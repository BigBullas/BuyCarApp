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
    public partial class Mechanic : Form
    {
        public Mechanic()
        {
            InitializeComponent();
        }

        private void Mechanic_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetBuyCar.mechanik". При необходимости она может быть перемещена или удалена.
            this.mechanikTableAdapter.Fill(this.dataSetBuyCar.mechanik);

        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            if (textBoxFind.Text == "")
            {
                mechanikBindingSource.RemoveFilter();
            }
            else
            {
                mechanikBindingSource.Filter = "name like'%" + textBoxFind.Text + "%'";
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            Repair repair = new Repair();
            repair.Show();
        }

        public Boolean IsMechanicExists(int mechanic_id)
        {
            NpgsqlConnection conn = Connection.GetConnection();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM mechanic WHERE mechanic_id = @id", conn);
            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = mechanic_id;

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

        private void DeleteMechanic_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = Connection.GetConnection();

            try
            {
                conn.Open();

                string sqlCommand = "DELETE FROM mechanic WHERE mechanic_id = @id;";
                NpgsqlCommand cmd = new NpgsqlCommand(sqlCommand, conn);
                cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = int.Parse(mechanic_idTextBox.Text);

                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Удаление прошло успешно");
                else
                    MessageBox.Show("Произошла ошибка. Повторите позже");

                conn.Close();

                Hide();
                this.mechanikTableAdapter.Update(this.dataSetBuyCar.mechanik);

                Mechanic ifrm = new Mechanic();
                ifrm.Show();

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SaveMechanic_Click(object sender, EventArgs e)
        {
            int mechanic_id = int.Parse(mechanic_idTextBox.Text);

            if (IsMechanicExists(mechanic_id))
            {
                NpgsqlConnection conn = Connection.GetConnection();
                try
                {
                    conn.Open();
                    string sql = "UPDATE mechanic SET mechanic_id = @mechanic_id, name = @name," +
                        " category = @category, work_experience = @work_experience," +
                        " employment_date = @employment_date WHERE mechanic_id = @mechanic_id;";
                 
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.Add("@mechanic_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = int.Parse(mechanic_idTextBox.Text);
                    cmd.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = nameTextBox.Text;
                    cmd.Parameters.Add("@category", NpgsqlTypes.NpgsqlDbType.Varchar).Value = categoryTextBox.Text;
                    cmd.Parameters.Add("@work_experience", NpgsqlTypes.NpgsqlDbType.Integer).Value = int.Parse(work_experienceTextBox.Text);
                    cmd.Parameters.Add("@employment_date", NpgsqlTypes.NpgsqlDbType.Date).Value = employment_dateDateTimePicker.Value;

                    if (cmd.ExecuteNonQuery() == 1)
                        MessageBox.Show("Изменение прошло успешно");
                    else
                        MessageBox.Show("Произошла ошибка. Повторите позже");

                    conn.Close();

                    Hide();
                    this.mechanikTableAdapter.Update(this.dataSetBuyCar.mechanik);

                    Mechanic ifrm = new Mechanic();
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
                newRow = this.dataSetBuyCar.mechanik.NewRow();
                newRow["mechanic_id"] = mechanic_idTextBox.Text;
                newRow["name"] = nameTextBox.Text;
                newRow["category"] = categoryTextBox.Text;
                newRow["work_experience"] = work_experienceTextBox.Text;
                newRow["employment_date"] = employment_dateDateTimePicker.Value;

                this.dataSetBuyCar.mechanik.Rows.Add(newRow);
                this.mechanikTableAdapter.Update(this.dataSetBuyCar.mechanik);

                Hide();
                Mechanic ifrm = new Mechanic();
                ifrm.Show();
            }
        }

        private void RepairWorkByIdMechanic_Click(object sender, EventArgs e)
        {
            Hide();
            Repair_workById contract = new Repair_workById("mechanic", mechanic_idTextBox.Text);
            contract.Show();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
