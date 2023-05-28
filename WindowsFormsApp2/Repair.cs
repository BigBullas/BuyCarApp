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
    public partial class Repair : Form
    {
        public Repair()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            Admin admin = new Admin();
            admin.Show();
        }

        private void Repair_work_Click(object sender, EventArgs e)
        {
            Hide();
            Repair_work repair_work = new Repair_work();
            repair_work.Show();
        }

        private void Mechanic_Click(object sender, EventArgs e)
        {
            Hide();
            Mechanic mechanic = new Mechanic();
            mechanic.Show();
        }
    }
}
