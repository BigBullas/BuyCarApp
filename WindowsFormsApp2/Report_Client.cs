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
    public partial class Report_Client : Form
    {
        public Report_Client()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetBuyCar);

        }

        private void Report_Client_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetBuyCar.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.dataSetBuyCar.client);

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            Report report = new Report();
            report.Show();
        }
    }
}
