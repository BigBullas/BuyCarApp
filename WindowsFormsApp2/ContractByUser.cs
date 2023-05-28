using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class ContractByUser : Form
    {
        private string filter_id;
        private string filter_type;
        public ContractByUser(string type, string filter_id)
        {
            InitializeComponent();
            this.filter_id = filter_id;
            this.filter_type = type;
        }

        private void contractBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contractBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetBuyCar);

        }

        private void ContractByUser_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetBuyCar1.car". При необходимости она может быть перемещена или удалена.
            this.carTableAdapter.Fill(this.dataSetBuyCar1.car);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetBuyCar.employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.dataSetBuyCar.employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetBuyCar.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.dataSetBuyCar.client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetBuyCar.contract". При необходимости она может быть перемещена или удалена.
            this.contractTableAdapter.Fill(this.dataSetBuyCar.contract);

            NpgsqlConnection conn = Connection.GetConnection();
            try
            {
                if (this.filter_id.Length > 0)
                {
                    conn.Open();
                    string sql = "SELECT contract_id as \"№\", client_id, client_name as \"ФИО клиента\", " +
                        "car_id, state_number as \"Номер авто\", price as \"Стоимость\", " +
                        "start_date as \"Дата начала аренды\", end_date as \"Дата окончания аренды\", " +
                        "employee_id, employee_name as \"ФИО сотрдуника\"," +
                        " conclusion_date as \"Дата заключения\"" +
                        " FROM contract_detailed;";

                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    conn.Close();
                    dataGridView1.DataSource = dt;

                    // Создание источника данных BindingSource
                    BindingSource bindingSource = new BindingSource();

                    // Привязка таблицы dt к BindingSource
                    bindingSource.DataSource = dt;

                    //Стукалов Иван Дмитриевич 'Стукалов Иван Дмитриевич'

                    //this.filter_type = "\'ФИО клиента\'";



                    bindingSource.Filter = this.filter_type + " = " + this.filter_id;
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            User user = new User();
            user.Show();
        }

        private void SaveContract_Click(object sender, EventArgs e)
        {
            string client_name = TextBoxName.Text;
            NpgsqlConnection conn = Connection.GetConnection();

            conn.Open();
            

            if (IsClientExists(client_name))
            {
                try
                {
                    conn.Open();
                    string sql = "UPDATE client SET name = @name," +
                        " birth_date = @birth_date, passport_data = @passport_data," +
                        " phone = @phone WHERE name = @client_name;";

                    NpgsqlCommand cmd2 = new NpgsqlCommand(sql, conn);
                    cmd2.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = TextBoxName.Text;
                    cmd2.Parameters.Add("@birth_date", NpgsqlTypes.NpgsqlDbType.Date).Value = dateTimePickerBirth.Value;
                    cmd2.Parameters.Add("@passport_data", NpgsqlTypes.NpgsqlDbType.Varchar).Value = TextBoxPassport.Text;
                    cmd2.Parameters.Add("@phone", NpgsqlTypes.NpgsqlDbType.Varchar).Value = TextBoxPhone.Text;

                    //if (cmd2.ExecuteNonQuery() == 1)
                    //    MessageBox.Show("Изменение прошло успешно");
                    //else
                    //    MessageBox.Show("Произошла ошибка. Повторите позже");

                    conn.Close();

                    //Hide();
                    this.clientTableAdapter.Update(this.dataSetBuyCar.client);

                    //Client ifrm = new Client();
                    //ifrm.Show();
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
                newRow = this.dataSetBuyCar.client.NewRow();
                newRow["name"] = TextBoxName.Text;
                newRow["birth_date"] = dateTimePickerBirth.Value;
                newRow["passport_data"] = TextBoxPassport.Text;
                newRow["phone"] = TextBoxPhone.Text;

                this.dataSetBuyCar.client.Rows.Add(newRow);

                this.clientTableAdapter.Update(this.dataSetBuyCar.client);
                //Hide();
                //Client ifrm = new Client();
                //ifrm.Show();
            }

            conn.Close();
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT client_id FROM client WHERE name = @name", conn);
            cmd.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = client_name;
            NpgsqlDataReader rd = cmd.ExecuteReader();
            int client_id = 1;
            rd.Read();
            client_id = (int)rd[0];

            conn.Close();
            //int contract_id = int.Parse(contract_idTextBox.Text);          

            try
            {
                DataRow newRow;
                newRow = this.dataSetBuyCar.contract.NewRow();
                newRow["car_id"] = comboBoxCar.SelectedValue;
                newRow["client_id"] = client_id;
                newRow["employee_id"] = comboBoxEmployee.SelectedValue;
                newRow["price"] = TextBoxPrice.Text;
                newRow["start_date"] = dateTimePickerStart.Value;
                newRow["end_date"] = dateTimePickerEnd.Value;
                newRow["conclusion_date"] = dateTimePickerConclusion.Value;

                this.dataSetBuyCar.contract.Rows.Add(newRow);

                this.contractTableAdapter.Update(this.dataSetBuyCar.contract);

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);
            }

            Hide();
            ContractByUser ifrm = new ContractByUser("client_id", client_id.ToString());
            ifrm.Show();

        }

        public Boolean IsClientExists(string client_name)
        {
            NpgsqlConnection conn = Connection.GetConnection();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM client WHERE name = @name", conn);
            cmd.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = client_name;
            conn.Close() ;
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
    }
}
