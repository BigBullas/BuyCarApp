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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowsFormsApp1;

namespace WindowsFormsApp2
{
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }

        private void carBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetBuyCar);

        }

        private void Car_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetBuyCar.model". При необходимости она может быть перемещена или удалена.
            this.modelTableAdapter.Fill(this.dataSetBuyCar.model);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetBuyCar.car". При необходимости она может быть перемещена или удалена.
            this.carTableAdapter.Fill(this.dataSetBuyCar.car);
            modelBindingSource.Filter = "model_id =" + comboBox1.SelectedValue;

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            Admin admin = new Admin();
            admin.ShowDialog();
        }

        private void SaveCar_Click(object sender, EventArgs e)
        {
            int car_id = int.Parse(car_idTextBox.Text);

            if (IsCarExists(car_id))
            {
                NpgsqlConnection conn = Connection.GetConnection();
                try
                {
                    conn.Open();
                    string sql = "UPDATE car SET car_id = @car_id, model_id = @model_id," +
                        " state_number = @st_nmbr, min_rental_period = @m_r_prd," +
                        " rental_price = @rnt_pr, deposit = @dpt, damage = @dmg " +
                        "WHERE car_id = @car_id;";

                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.Add("@car_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = int.Parse(car_idTextBox.Text);
                    cmd.Parameters.Add("@model_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = comboBox1.SelectedValue;
                    cmd.Parameters.Add("@st_nmbr", NpgsqlTypes.NpgsqlDbType.Varchar).Value = state_numberTextBox.Text;
                    cmd.Parameters.Add("@m_r_prd", NpgsqlTypes.NpgsqlDbType.Varchar).Value = min_rental_periodTextBox.Text;
                    cmd.Parameters.Add("@rnt_pr", NpgsqlTypes.NpgsqlDbType.Money).Value = decimal.Parse(rental_priceTextBox.Text);
                    cmd.Parameters.Add("@dpt", NpgsqlTypes.NpgsqlDbType.Money).Value = decimal.Parse(depositTextBox.Text);
                    cmd.Parameters.Add("@dmg", NpgsqlTypes.NpgsqlDbType.Varchar).Value = damageTextBox.Text;

                    if (cmd.ExecuteNonQuery() == 1)
                        MessageBox.Show("Изменение прошло успешно");
                    else
                        MessageBox.Show("Произошла ошибка. Повторите позже");

                    conn.Close();

                    Hide();
                    this.carTableAdapter.Update(this.dataSetBuyCar.car);

                    Car ifrm = new Car();
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
                newRow = this.dataSetBuyCar.car.NewRow();
                newRow["car_id"] = car_idTextBox.Text;
                newRow["model_id"] = comboBox1.SelectedValue;
                newRow["state_number"] = state_numberTextBox.Text;
                newRow["min_rental_period"] = min_rental_periodTextBox.Text;
                newRow["rental_price"] = rental_priceTextBox.Text;
                newRow["deposit"] = depositTextBox.Text;
                newRow["damage"] = damageTextBox.Text;

                this.dataSetBuyCar.car.Rows.Add(newRow);

                this.carTableAdapter.Update(this.dataSetBuyCar.car);
                Hide();
                Car ifrm = new Car();
                ifrm.Show();
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void DeleteCar_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = Connection.GetConnection();

            try
            {
                conn.Open();

                string sqlCommand = "DELETE FROM car WHERE car_id = @id;";
                NpgsqlCommand cmd = new NpgsqlCommand(sqlCommand, conn);
                cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = int.Parse(car_idTextBox.Text);

                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Удаление прошло успешно");
                else
                    MessageBox.Show("Произошла ошибка. Повторите позже");

                conn.Close();

                Hide();
                this.carTableAdapter.Update(this.dataSetBuyCar.car);

                Car ifrm = new Car();
                ifrm.Show();

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public Boolean IsCarExists(int car_id)
        {
            NpgsqlConnection conn = Connection.GetConnection();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM car WHERE car_id = @id", conn);
            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = car_id;

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

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            modelBindingSource.Filter = "model_id =" + comboBox1.SelectedValue;
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            modelBindingSource.Filter = "model_id =" + comboBox1.SelectedValue;
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            modelBindingSource.Filter = "model_id =" + comboBox1.SelectedValue;
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            modelBindingSource.Filter = "model_id =" + comboBox1.SelectedValue;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void depositLabel_Click(object sender, EventArgs e)
        {

        }

        private void min_rental_periodTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnContractById_Click(object sender, EventArgs e)
        {
            Hide();
            ContractById contract = new ContractById("car", car_idTextBox.Text);
            contract.Show();
        }
    }
}
