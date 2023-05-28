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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void Repair_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Click(object sender, EventArgs e)
        {

        }

        private void Client_Click(object sender, EventArgs e)
        {

        }

        private void Report_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Hide();
            Auth ifr = new Auth();
            ifr.Show();
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

        private void Contract_Click(object sender, EventArgs e)
        {
            Hide();
            InputNameUser ifr = new InputNameUser();
            ifr.Show();
        }
    }
}
