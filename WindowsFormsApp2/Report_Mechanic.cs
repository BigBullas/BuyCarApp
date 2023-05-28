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
    public partial class Report_Mechanic : Form
    {
        public Report_Mechanic()
        {
            InitializeComponent();
        }

        private void mechanikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mechanikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetBuyCar);

        }

        private void Report_Mechanic_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetBuyCar.mechanik". При необходимости она может быть перемещена или удалена.
            this.mechanikTableAdapter.Fill(this.dataSetBuyCar.mechanik);

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            Report report = new Report();
            report.Show();
        }
    }
}
