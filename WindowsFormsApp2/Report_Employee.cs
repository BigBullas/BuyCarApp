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
    public partial class Report_Employee : Form
    {
        public Report_Employee()
        {
            InitializeComponent();
        }

        private void Report_Employee_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetBuyCar.employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.dataSetBuyCar.employee);

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            Report report = new Report();
            report.Show();
        }
    }
}
