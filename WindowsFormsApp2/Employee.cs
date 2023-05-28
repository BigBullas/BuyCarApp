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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetBuyCar);

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetBuyCar.employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.dataSetBuyCar.employee);

        }

        private void ContractByIDEmployee_Click(object sender, EventArgs e)
        {
            Hide();
            ContractById contract = new ContractById("employee", employee_idTextBox.Text);
            contract.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            Admin admin = new Admin();
            admin.Show();
        }

        private void employment_dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void employeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            if (textBoxFind.Text == "")
            {
                employeeBindingSource.RemoveFilter();
            }
            else
            {
                employeeBindingSource.Filter = "name like'%" + textBoxFind.Text + "%'";
            }
        }

        private void SaveEmployee_Click(object sender, EventArgs e)
        {
            int employee_id = int.Parse(employee_idTextBox.Text);

            if (IsEmployeeExists(employee_id))
            {
                NpgsqlConnection conn = Connection.GetConnection();
                try
                {                   
                    conn.Open();
                    string sql = "UPDATE employee SET employee_id = @employee_id, name = @name," +
                        " position = @position, employment_date = @emp_date," +
                        " phone = @phone WHERE employee_id = @employee_id;";

                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.Add("@employee_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = int.Parse(employee_idTextBox.Text);
                    cmd.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = nameTextBox.Text;
                    cmd.Parameters.Add("@position", NpgsqlTypes.NpgsqlDbType.Varchar).Value = positionTextBox.Text;
                    cmd.Parameters.Add("@emp_date", NpgsqlTypes.NpgsqlDbType.Date).Value = employment_dateDateTimePicker.Value;
                    cmd.Parameters.Add("@phone", NpgsqlTypes.NpgsqlDbType.Varchar).Value = phoneTextBox.Text;

                    if (cmd.ExecuteNonQuery() == 1)
                        MessageBox.Show("Изменение прошло успешно");
                    else
                        MessageBox.Show("Произошла ошибка. Повторите позже");

                    conn.Close();

                    Hide();
                    this.employeeTableAdapter.Update(this.dataSetBuyCar.employee);

                    Employee ifrm = new Employee();
                    ifrm.Show();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {               
                DataRow newRow;
                newRow = this.dataSetBuyCar.employee.NewRow();
                newRow["employee_id"] = employee_idTextBox.Text;
                newRow["name"] = nameTextBox.Text;
                newRow["position"] = positionTextBox.Text;
                newRow["employment_date"] = employment_dateDateTimePicker.Value;
                newRow["phone"] = phoneTextBox.Text;

                this.dataSetBuyCar.employee.Rows.Add(newRow);

                this.employeeTableAdapter.Update(this.dataSetBuyCar.employee);
                Hide();
                Employee ifrm = new Employee();
                ifrm.Show();
            }
        }

        private void DeleteEmployee_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = Connection.GetConnection();

            try
            {
                conn.Open();

                string sqlCommand = "DELETE FROM employee WHERE employee_id = @id;";
                NpgsqlCommand cmd = new NpgsqlCommand(sqlCommand, conn);
                cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = int.Parse(employee_idTextBox.Text);

                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Удаление прошло успешно");
                else
                    MessageBox.Show("Произошла ошибка. Повторите позже");

                conn.Close();

                Hide();
                this.employeeTableAdapter.Update(this.dataSetBuyCar.employee);

                Employee ifrm = new Employee();
                ifrm.Show();

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public Boolean IsEmployeeExists(int employee_id)
        {
            NpgsqlConnection conn = Connection.GetConnection();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM employee WHERE employee_id = @id", conn);
            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = employee_id;

            conn.Open();

            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                conn.Close();

                return true;
            }

            reader.Close();
            conn.Close();

            return false;
        }
    }
}
