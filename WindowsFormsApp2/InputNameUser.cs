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
    public partial class InputNameUser : Form
    {
        public InputNameUser()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            User user = new User();
            user.Show();
        }

        private void Mechanic_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = Connection.GetConnection();
            conn.Close();
            conn.Open();

            string sql = "SELECT client_id FROM client where name = @name;";
            var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Text).Value = textBox1.Text;
            string tmp;
            try
            {
                tmp = cmd.ExecuteScalar().ToString();
                MessageBox.Show(tmp);
                conn.Close();
                Hide();
                ContractByUser ifr = new ContractByUser("client_id", tmp);
                ifr.Show();                
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void WithoutUser_Click(object sender, EventArgs e)
        {
            Hide();
            ContractByUser ifr = new ContractByUser("client_id", "");
            ifr.Show();
        }
    }
}
