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

namespace WindowsFormsApp2
{
    public partial class Model_car : Form
    {
        public Model_car()
        {
            InitializeComponent();
        }

        private void modelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.modelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetBuyCar);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetBuyCar.model". При необходимости она может быть перемещена или удалена.
            this.modelTableAdapter.Fill(this.dataSetBuyCar.model);

        }

        private void DeleteModel_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = Connection.GetConnection();

            try
            {
                conn.Open();

                string sqlCommand = "DELETE FROM car_model WHERE model_id = @id;";
                NpgsqlCommand cmd = new NpgsqlCommand(sqlCommand, conn);
                cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = int.Parse(model_idTextBox.Text);

                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Удаление прошло успешно");
                else
                    MessageBox.Show("Произошла ошибка. Повторите позже");

                conn.Close();

                Hide();
                this.modelTableAdapter.Update(this.dataSetBuyCar.model);

                Model_car ifrm = new Model_car();
                ifrm.Show();

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void modelBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void SaveModel_Click(object sender, EventArgs e)
        {
            int model_id = int.Parse(model_idTextBox.Text);

            if (IsModelExists(model_id))
            {
                NpgsqlConnection conn = Connection.GetConnection();
                try
                {
                    conn.Open();
                    string sql = "UPDATE car_model SET model_id = @model_id, model_name = @m_name," +
                        " car_name = @c_name, equipment = @equipment," +
                        " transmission = @transmission, trunk_capacity = @trunk_capacity" +
                        " WHERE model_id = @model_id;";

                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.Add("@model_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = int.Parse(model_idTextBox.Text);
                    cmd.Parameters.Add("@m_name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = model_nameTextBox.Text;
                    cmd.Parameters.Add("@c_name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = car_nameTextBox.Text;
                    cmd.Parameters.Add("@equipment", NpgsqlTypes.NpgsqlDbType.Varchar).Value = equipmentTextBox.Text;
                    cmd.Parameters.Add("@transmission", NpgsqlTypes.NpgsqlDbType.Varchar).Value = transmissionTextBox.Text;
                    cmd.Parameters.Add("@trunk_capacity", NpgsqlTypes.NpgsqlDbType.Integer).Value = int.Parse(trunk_capacityTextBox.Text);

                    if (cmd.ExecuteNonQuery() == 1)
                        MessageBox.Show("Изменение прошло успешно");
                    else
                        MessageBox.Show("Произошла ошибка. Повторите позже");

                    conn.Close();

                    Hide();
                    this.modelTableAdapter.Update(this.dataSetBuyCar.model);

                    Model_car ifrm = new Model_car();
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
                newRow = this.dataSetBuyCar.model.NewRow();
                newRow["model_id"] = model_idTextBox.Text;
                newRow["model_name"] = model_nameTextBox.Text;
                newRow["car_name"] = car_nameTextBox.Text;
                newRow["equipment"] = equipmentTextBox.Text;
                newRow["transmission"] = transmissionTextBox.Text;
                newRow["trunk_capacity"] = trunk_capacityTextBox.Text;

                this.dataSetBuyCar.model.Rows.Add(newRow);
                this.modelTableAdapter.Update(this.dataSetBuyCar.model);

                Hide();
                Model_car ifrm = new Model_car();
                ifrm.Show();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            Admin ifr = new Admin(); 
            ifr.ShowDialog();
        }

        public Boolean IsModelExists(int model_id)
        {
            NpgsqlConnection conn = Connection.GetConnection();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM car_model WHERE model_id = @id", conn);
            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = model_id;

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
