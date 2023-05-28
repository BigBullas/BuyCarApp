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
    public partial class Repair_work : Form
    {
        public Repair_work()
        {
            InitializeComponent();
        }

        private void Repair_work_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetBuyCar.mechanik". При необходимости она может быть перемещена или удалена.
            this.mechanikTableAdapter.Fill(this.dataSetBuyCar.mechanik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetBuyCar.car". При необходимости она может быть перемещена или удалена.
            this.carTableAdapter.Fill(this.dataSetBuyCar.car);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetBuyCar.repair_work". При необходимости она может быть перемещена или удалена.
            this.repair_workTableAdapter.Fill(this.dataSetBuyCar.repair_work);

        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            Repair repair = new Repair();
            repair.Show();
        }

        private void DeleteRepairWork_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = Connection.GetConnection();

            try
            {
                conn.Open();

                string sqlCommand = "DELETE FROM repair_work WHERE repair_work_id = @id;";
                NpgsqlCommand cmd = new NpgsqlCommand(sqlCommand, conn);
                cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = int.Parse(repair_work_idTextBox.Text);

                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Удаление прошло успешно");
                else
                    MessageBox.Show("Произошла ошибка. Повторите позже");

                conn.Close();

                Hide();
                this.repair_workTableAdapter.Update(this.dataSetBuyCar.repair_work);

                Repair_work ifrm = new Repair_work();
                ifrm.Show();

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SaveRepairWork_Click(object sender, EventArgs e)
        {
            int repair_work_id = int.Parse(repair_work_idTextBox.Text);

            if (IsRepairWorkExists(repair_work_id))
            {
                NpgsqlConnection conn = Connection.GetConnection();
                try
                {
                    conn.Open();
                    string sql = "UPDATE repair_work SET repair_work_id = @rw_id, car_id = @car_id," +
                        " mechanic_id = @mechanic_id, start_date = @start_date," +
                        " end_date = @end_date, description = @dpt " +
                        "WHERE repair_work_id = @rw_id;";
                    
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.Add("@rw_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = int.Parse(repair_work_idTextBox.Text);
                    cmd.Parameters.Add("@car_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = comboBoxCar.SelectedValue;
                    cmd.Parameters.Add("@mechanic_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = comboBoxMechanic.SelectedValue;
                    cmd.Parameters.Add("@start_date", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = start_dateDateTimePicker.Value;
                    cmd.Parameters.Add("@end_date", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = end_dateDateTimePicker.Value;
                    cmd.Parameters.Add("@dpt", NpgsqlTypes.NpgsqlDbType.Varchar).Value = descriptionTextBox.Text;

                    if (cmd.ExecuteNonQuery() == 1)
                        MessageBox.Show("Изменение прошло успешно");
                    else
                        MessageBox.Show("Произошла ошибка. Повторите позже");

                    conn.Close();

                    Hide();
                    this.repair_workTableAdapter.Update(this.dataSetBuyCar.repair_work);

                    Repair_work ifrm = new Repair_work();
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
                newRow = this.dataSetBuyCar.repair_work.NewRow();

                newRow["repair_work_id"] = repair_work_idTextBox.Text;
                newRow["car_id"] = comboBoxCar.SelectedValue;
                newRow["mechanic_id"] = comboBoxMechanic.SelectedValue;
                newRow["start_date"] = start_dateDateTimePicker.Value;
                newRow["end_date"] = end_dateDateTimePicker.Value;
                newRow["description"] = descriptionTextBox.Text;

                this.dataSetBuyCar.repair_work.Rows.Add(newRow);

                this.repair_workTableAdapter.Update(this.dataSetBuyCar.repair_work);
                Hide();
                Repair_work ifrm = new Repair_work();
                ifrm.Show();
            }
        }

        public Boolean IsRepairWorkExists(int repair_work_id)
        {
            NpgsqlConnection conn = Connection.GetConnection();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM repair_work WHERE repair_work_id = @id", conn);
            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = repair_work_id;

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
