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
    public partial class Report_Model_car : Form
    {
        public Report_Model_car()
        {
            InitializeComponent();
        }

        private void modelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.modelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetBuyCar);

        }

        private void Report_Model_car_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetBuyCar.model". При необходимости она может быть перемещена или удалена.
            this.modelTableAdapter.Fill(this.dataSetBuyCar.model);

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            Hide();
            string user = MyUser.GetLogin();
            if (user == "user")
            {
                User ifr = new User();
                ifr.Show();
            }
            else
            {
                Report report = new Report();
                report.Show();
            }
        }
    }
}
