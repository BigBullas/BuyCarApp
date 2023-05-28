using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Contract : Form
    {
        public Contract()
        {
            InitializeComponent();
        }

        private void contractBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contractBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetBuyCar);

        }

        private void Contract_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetBuyCar.employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.dataSetBuyCar.employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetBuyCar.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.dataSetBuyCar.client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetBuyCar.car". При необходимости она может быть перемещена или удалена.
            this.carTableAdapter.Fill(this.dataSetBuyCar.car);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetBuyCar.contract". При необходимости она может быть перемещена или удалена.
            this.contractTableAdapter.Fill(this.dataSetBuyCar.contract);

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            Admin admin = new Admin();
            admin.Show();
        }

        private void DeleteContract_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = Connection.GetConnection();

            try
            {
                conn.Open();

                string sqlCommand = "DELETE FROM contract WHERE contract_id = @id;";
                NpgsqlCommand cmd = new NpgsqlCommand(sqlCommand, conn);
                cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = int.Parse(contract_idTextBox.Text);

                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Удаление прошло успешно");
                else
                    MessageBox.Show("Произошла ошибка. Повторите позже");

                conn.Close();

                Hide();
                this.contractTableAdapter.Update(this.dataSetBuyCar.contract);

                Contract contract = new Contract();
                contract.Show();

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SaveContract_Click(object sender, EventArgs e)
        {
            int contract_id = int.Parse(contract_idTextBox.Text);

            if (IsContractExists(contract_id))
            {
                NpgsqlConnection conn = Connection.GetConnection();
                try
                {                  
                    conn.Open();
                    string sql = "UPDATE contract SET contract_id = @contract_id, car_id = @car_id," +
                        " client_id = @client_id, employee_id = @employee_id," +
                        " price = @price, start_date = @st_date, end_date = @en_date, " +
                        "conclusion_date = @cnl_date " +
                        "WHERE contract_id = @contract_id;";

                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.Add("@contract_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = int.Parse(contract_idTextBox.Text);
                    cmd.Parameters.Add("@car_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = comboBoxCar.SelectedValue;
                    cmd.Parameters.Add("@client_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = comboBoxClient.SelectedValue;
                    cmd.Parameters.Add("@employee_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = comboBoxEmployee.SelectedValue;
                    cmd.Parameters.Add("@price", NpgsqlTypes.NpgsqlDbType.Money).Value = decimal.Parse(priceTextBox.Text);
                    cmd.Parameters.Add("@st_date", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = start_dateDateTimePicker.Value;
                    cmd.Parameters.Add("@en_date", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = end_dateDateTimePicker.Value;
                    cmd.Parameters.Add("@cnl_date", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = conclusion_dateDateTimePicker.Value;

                    if (cmd.ExecuteNonQuery() == 1)
                        MessageBox.Show("Изменение прошло успешно");
                    else
                        MessageBox.Show("Произошла ошибка. Повторите позже");

                    conn.Close();

                    Hide();
                    this.contractTableAdapter.Update(this.dataSetBuyCar.contract);

                    Contract ifrm = new Contract();
                    ifrm.Show();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {                
                DataRow newRow;
                newRow = this.dataSetBuyCar.contract.NewRow();
                newRow["contract_id"] = contract_idTextBox.Text;
                newRow["car_id"] = comboBoxCar.SelectedValue;
                newRow["client_id"] = comboBoxClient.SelectedValue;
                newRow["employee_id"] = comboBoxEmployee.SelectedValue;
                newRow["price"] = priceTextBox.Text;
                newRow["start_date"] = start_dateDateTimePicker.Value;
                newRow["end_date"] = end_dateDateTimePicker.Value;
                newRow["conclusion_date"] = conclusion_dateDateTimePicker.Value;

                this.dataSetBuyCar.contract.Rows.Add(newRow);

                this.contractTableAdapter.Update(this.dataSetBuyCar.contract);
                Hide();
                Contract ifrm = new Contract();
                ifrm.Show();
            }
        }

        //private void support_specialistBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    string conn_param = "Host=127.0.0.1;Port=5432;Username=postgres;Password=postgres;Database=telephone_company;";
        //    var connStr = new NpgsqlConnectionStringBuilder(conn_param);
        //    string sql = "UPDATE subscription SET caller_id = " + caller_idTextBox1.Text + ", plan_id = " + plan_idTextBox1.Text +
        //        ", start_date = :startTime" + ", end_date = :endTime " +
        //        "WHERE subscription_id = " + subscription_idTextBox.Text + ";";
        //    NpgsqlConnection conn = new NpgsqlConnection(connStr.ToString());
        //    conn.Open();


        //    var uploadEndTimeParam = new NpgsqlParameter("endTime", NpgsqlDbType.Timestamp);
        //    uploadEndTimeParam.Value = end_dateDateTimePicker.Value;
        //    var uploadStartTimeParam = new NpgsqlParameter("startTime", NpgsqlDbType.Timestamp);
        //    uploadStartTimeParam.Value = start_dateDateTimePicker.Value;
        //    var updateCommand = new NpgsqlCommand(sql, conn);
        //    updateCommand.Parameters.Add(uploadStartTimeParam);
        //    updateCommand.Parameters.Add(uploadEndTimeParam);
        //    try
        //    {
        //        updateCommand.ExecuteScalar();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex);
        //    }


        //    this.subscriptionTableAdapter.Update(this.telephone_companyDataSet);

        //    Subscription ifrm = new Subscription();
        //    ifrm.Show();
        //    this.Hide();
        //}

        public Boolean IsContractExists(int contract_id)
        {
            NpgsqlConnection conn = Connection.GetConnection();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM contract WHERE contract_id = @id", conn);
            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = contract_id;

            conn.Open();

            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                conn.Close();

                return true;
            }

            reader.Close();
            conn.Close();

            return false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void end_dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
