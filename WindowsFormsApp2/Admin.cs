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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Contract_Click(object sender, EventArgs e)
        {
            Hide();
            Contract contract = new Contract();
            contract.Show();

        }

        private void Client_Click(object sender, EventArgs e)
        {
            Hide();
            Client client = new Client();
            client.Show();
        }

        private void Employee_Click(object sender, EventArgs e)
        {
            Hide();
            Employee employee = new Employee();
            employee.Show();
        }

        private void Car_Click(object sender, EventArgs e)
        {
            Hide();
            Car car = new Car();
            car.ShowDialog();
        }

        private void Repair_Click(object sender, EventArgs e)
        {
            Hide();
            Repair repair = new Repair();
            repair.Show();
        }

        private void Model_car_Click(object sender, EventArgs e)
        {
            Hide();
            Model_car model = new Model_car();
            model.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Hide();
            Auth ifr = new Auth();
            ifr.Show();
        }

        private void Report_Click(object sender, EventArgs e)
        {
            Hide();
            Report report = new Report();
            report.Show();
        }
    }
}
