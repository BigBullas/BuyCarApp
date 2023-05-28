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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetBuyCar);

        }

        private void Client_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetBuyCar.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.dataSetBuyCar.client);

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            Admin admin = new Admin();
            admin.Show();
        }

        private void SaveClient_Click(object sender, EventArgs e)
        {
            int client_id = int.Parse(client_idTextBox.Text);

            if (IsClientExists(client_id))
            {
                NpgsqlConnection conn = Connection.GetConnection();
                try
                {
                    conn.Open();
                    string sql = "UPDATE client SET client_id = @client_id, name = @name," +
                        " birth_date = @birth_date, passport_data = @passport_data," +
                        " phone = @phone WHERE client_id = @client_id;";

                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.Add("@client_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = int.Parse(client_idTextBox.Text);
                    cmd.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = nameTextBox.Text;
                    cmd.Parameters.Add("@birth_date", NpgsqlTypes.NpgsqlDbType.Date).Value = birth_dateDateTimePicker.Value;
                    cmd.Parameters.Add("@passport_data", NpgsqlTypes.NpgsqlDbType.Varchar).Value = passport_dataTextBox.Text;
                    cmd.Parameters.Add("@phone", NpgsqlTypes.NpgsqlDbType.Varchar).Value = phoneTextBox.Text;

                    if (cmd.ExecuteNonQuery() == 1)
                        MessageBox.Show("Изменение прошло успешно");
                    else
                        MessageBox.Show("Произошла ошибка. Повторите позже");

                    conn.Close();

                    Hide();
                    this.clientTableAdapter.Update(this.dataSetBuyCar.client);

                    Client ifrm = new Client();
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
                newRow = this.dataSetBuyCar.client.NewRow();
                newRow["client_id"] = client_idTextBox.Text;
                newRow["name"] = nameTextBox.Text;
                newRow["birth_date"] = birth_dateDateTimePicker.Value;
                newRow["passport_data"] = passport_dataTextBox.Text;
                newRow["phone"] = phoneTextBox.Text;

                this.dataSetBuyCar.client.Rows.Add(newRow);

                this.clientTableAdapter.Update(this.dataSetBuyCar.client);
                Hide();
                Client ifrm = new Client();
                ifrm.Show();
            }
        }

        private void DeleteClient_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = Connection.GetConnection();

            try
            {
                conn.Open();

                string sqlCommand = "DELETE FROM client WHERE client_id = @id;";
                NpgsqlCommand cmd = new NpgsqlCommand(sqlCommand, conn);
                cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = int.Parse(client_idTextBox.Text);

                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Удаление прошло успешно");
                else
                    MessageBox.Show("Произошла ошибка. Повторите позже");

                conn.Close();

                Hide();
                this.clientTableAdapter.Update(this.dataSetBuyCar.client);

                Client ifrm = new Client();
                ifrm.Show();

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            if (textBoxFind.Text == "")
            {
                clientBindingSource.RemoveFilter();
            }
            else
            {
                clientBindingSource.Filter = "name like'%" + textBoxFind.Text + "%'";
            }
        }

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ContractByIdClient_Click(object sender, EventArgs e)
        {
            Hide();
            ContractById contract = new ContractById("client", client_idTextBox.Text);
            contract.Show();
        }

        public Boolean IsClientExists(int client_id)
        {
            NpgsqlConnection conn = Connection.GetConnection();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM client WHERE client_id = @id", conn);
            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = client_id;

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

        private void clientBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
