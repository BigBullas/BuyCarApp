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
    public partial class Report_car : Form
    {
        public Report_car()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetBuyCar);

        }

        private void Report_car_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetBuyCar.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.dataSetBuyCar.client);

            NpgsqlConnection conn = Connection.GetConnection();
            try
            {
                conn.Open();

                string sql = "SELECT car_id as \"№\", model_id, car_name as \"Название автомобиля\", " +
                    "state_number as \"Номер авто\", min_rental_period as \"Минимальный период аренды\", " +
                    "rental_price as \"Цена аренды\", deposit as \"Залог\", damage as \"Имеющиеся повреждения\"" +
                    " FROM car_detailed;";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dataGridView1.DataSource = dt;

                // Создание источника данных BindingSource
                BindingSource bindingSource = new BindingSource();

                // Привязка таблицы dt к BindingSource
                bindingSource.DataSource = dt;
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
            string user = MyUser.GetLogin();
            if (user == "user") {
                User ifr = new User();
                ifr.Show();
            } else
            {
                Report report = new Report();
                report.Show();
            }
            
        }
    }
}
