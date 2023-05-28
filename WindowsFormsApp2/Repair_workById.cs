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
    public partial class Repair_workById : Form
    {
        private string filter_id;
        private string filter_type;
        public Repair_workById(string type, string filter_id)
        {
            InitializeComponent();
            this.filter_id = filter_id;
            this.filter_type = type;
        }

        private void repair_workBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.repair_workBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetBuyCar);

        }

        private void Repair_workById_Load(object sender, EventArgs e)
        {

            NpgsqlConnection conn = Connection.GetConnection();
            try
            {
                conn.Open();

                string sql = "SELECT repair_work_id as \"№\", car_id, state_number as \"Номер авто\", " +
                    "mechanic_id, name as \"ФИО механика\", start_date as \"Дата начала ремонта\", " +
                    "end_date as \"Дата окончания ремонта\", description as \"Подробности\"" +
                    " FROM repair_work_detailed;";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dataGridView1.DataSource = dt;

                // Создание источника данных BindingSource
                BindingSource bindingSource = new BindingSource();

                // Привязка таблицы dt к BindingSource
                bindingSource.DataSource = dt;

                if (this.filter_id.Length > 0)

                    bindingSource.Filter = this.filter_type + "_id=" + this.filter_id;
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
            switch (this.filter_type)
            {
                case "mechanic":
                    Mechanic mechanic = new Mechanic();
                    mechanic.Show();
                    break;
                case "car":
                    Car car = new Car();
                    car.Show();
                    break;
                case "":
                    Report report = new Report();
                    report.Show();
                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
