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
    public partial class ContractById : Form
    {
        private string filter_id;
        private string filter_type;
        public ContractById(string type, string filter_id)
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

        private void ContractByIdEmployee_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetBuyCar.contract_detailed". При необходимости она может быть перемещена или удалена.
            this.contract_detailedTableAdapter.Fill(this.dataSetBuyCar.contract_detailed);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetBuyCar.contract_detailed". При необходимости она может быть перемещена или удалена.
            this.contract_detailedTableAdapter.Fill(this.dataSetBuyCar.contract_detailed);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetBuyCar.car". При необходимости она может быть перемещена или удалена.
            this.carTableAdapter.Fill(this.dataSetBuyCar.car);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetBuyCar.contract". При необходимости она может быть перемещена или удалена.
            this.contractTableAdapter.Fill(this.dataSetBuyCar.contract);

            NpgsqlConnection conn = Connection.GetConnection();
            try
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
                case "employee":
                    Employee employee = new Employee();
                    employee.Show();
                    break;
                case "car":
                    Car car = new Car();
                    car.Show();
                    break;
                case "client":
                    Client client = new Client();
                    client.Show();
                    break;
                case "":
                    Report report = new Report();
                    report.Show();
                    break;
            }
           
        }
    }
}
