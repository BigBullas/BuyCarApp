using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            Admin admin = new Admin();
            admin.Show();
        }

        private void Contract_Click(object sender, EventArgs e)
        {
            Hide();
            ContractById contractById = new ContractById("", "");
            contractById.Show();
        }

        private void RepairWork_Click(object sender, EventArgs e)
        {
            Hide();
            Repair_workById repair_WorkById = new Repair_workById("", "");
            repair_WorkById.Show();
        }

        private void Client_Click(object sender, EventArgs e)
        {
            Hide();
            Report_Client reportClient = new Report_Client();
            reportClient.Show();
        }

        private void Employee_Click(object sender, EventArgs e)
        {
            Hide();
            Report_Employee report_Employee = new Report_Employee();
            report_Employee.Show();
        }

        private void Mechanic_Click(object sender, EventArgs e)
        {
            Hide();
            Report_Mechanic report_Mechanic = new Report_Mechanic();
            report_Mechanic.Show();
        }

        private void Car_Click(object sender, EventArgs e)
        {
            Hide();
            Report_car report_Car = new Report_car();
            report_Car.Show();
        }

        private void Model_car_Click(object sender, EventArgs e)
        {
            Hide();
            Report_Model_car report_Model_car = new Report_Model_car();
            report_Model_car.Show();
        }
    }
}
