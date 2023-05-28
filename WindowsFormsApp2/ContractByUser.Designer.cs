namespace WindowsFormsApp2
{
    partial class ContractByUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label13;
            this.dataSetBuyCar = new WindowsFormsApp2.DataSetBuyCar();
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractTableAdapter = new WindowsFormsApp2.DataSetBuyCarTableAdapters.contractTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.DataSetBuyCarTableAdapters.TableAdapterManager();
            this.clientTableAdapter = new WindowsFormsApp2.DataSetBuyCarTableAdapters.clientTableAdapter();
            this.contract_idTextBox = new System.Windows.Forms.TextBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client_idTextBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SaveContract = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.comboBoxCar = new System.Windows.Forms.ComboBox();
            this.TextBoxPrice = new System.Windows.Forms.TextBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerConclusion = new System.Windows.Forms.DateTimePicker();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.TextBoxPassport = new System.Windows.Forms.TextBox();
            this.TextBoxPhone = new System.Windows.Forms.TextBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new WindowsFormsApp2.DataSetBuyCarTableAdapters.employeeTableAdapter();
            this.dataSetBuyCar1 = new WindowsFormsApp2.DataSetBuyCar();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new WindowsFormsApp2.DataSetBuyCarTableAdapters.carTableAdapter();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBuyCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBuyCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(38, 536);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(26, 20);
            label1.TabIndex = 49;
            label1.Text = "С ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(656, 374);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(173, 20);
            label3.TabIndex = 32;
            label3.Text = "Номер транспорта:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label5.Location = new System.Drawing.Point(975, 374);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(307, 20);
            label5.TabIndex = 34;
            label5.Text = "Сотрудник, заключающий договор:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label6.Location = new System.Drawing.Point(656, 448);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(107, 20);
            label6.TabIndex = 35;
            label6.Text = "Стоимость:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label7.Location = new System.Drawing.Point(38, 508);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(124, 20);
            label7.TabIndex = 37;
            label7.Text = "Срок аренды:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label8.Location = new System.Drawing.Point(276, 535);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(29, 20);
            label8.TabIndex = 39;
            label8.Text = "по";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label9.Location = new System.Drawing.Point(975, 448);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(248, 20);
            label9.TabIndex = 41;
            label9.Text = "Дата заключения договора:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label10.Location = new System.Drawing.Point(38, 374);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(128, 20);
            label10.TabIndex = 50;
            label10.Text = "ФИО клиента:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label11.Location = new System.Drawing.Point(38, 442);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(146, 20);
            label11.TabIndex = 52;
            label11.Text = "Дата рождения:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label12.Location = new System.Drawing.Point(342, 374);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(207, 20);
            label12.TabIndex = 54;
            label12.Text = "Серия/номер паспорта:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label13.Location = new System.Drawing.Point(342, 442);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(160, 20);
            label13.TabIndex = 56;
            label13.Text = "Номер телефона:";
            // 
            // dataSetBuyCar
            // 
            this.dataSetBuyCar.DataSetName = "DataSetBuyCar";
            this.dataSetBuyCar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contractBindingSource
            // 
            this.contractBindingSource.DataMember = "contract";
            this.contractBindingSource.DataSource = this.dataSetBuyCar;
            // 
            // contractTableAdapter
            // 
            this.contractTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.contractTableAdapter = this.contractTableAdapter;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.mechanikTableAdapter = null;
            this.tableAdapterManager.modelTableAdapter = null;
            this.tableAdapterManager.repair_workTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.DataSetBuyCarTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // contract_idTextBox
            // 
            this.contract_idTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.contract_idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contract_idTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.contract_idTextBox.Enabled = false;
            this.contract_idTextBox.Location = new System.Drawing.Point(681, 594);
            this.contract_idTextBox.Name = "contract_idTextBox";
            this.contract_idTextBox.Size = new System.Drawing.Size(200, 15);
            this.contract_idTextBox.TabIndex = 3;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.dataSetBuyCar;
            // 
            // client_idTextBox1
            // 
            this.client_idTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.client_idTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.client_idTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.client_idTextBox1.Enabled = false;
            this.client_idTextBox1.Location = new System.Drawing.Point(926, 594);
            this.client_idTextBox1.Name = "client_idTextBox1";
            this.client_idTextBox1.Size = new System.Drawing.Size(200, 15);
            this.client_idTextBox1.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1539, 285);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Мои договоры";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1524, 246);
            this.dataGridView1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SaveContract);
            this.groupBox2.Controls.Add(this.Back);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1539, 255);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Создать новый договор";
            // 
            // SaveContract
            // 
            this.SaveContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveContract.Location = new System.Drawing.Point(1386, 48);
            this.SaveContract.Name = "SaveContract";
            this.SaveContract.Size = new System.Drawing.Size(120, 44);
            this.SaveContract.TabIndex = 22;
            this.SaveContract.Text = "Сохранить";
            this.SaveContract.UseVisualStyleBackColor = true;
            this.SaveContract.Click += new System.EventHandler(this.SaveContract_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(1386, 116);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(120, 44);
            this.Back.TabIndex = 21;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contractBindingSource, "employee_id", true));
            this.comboBoxEmployee.DataSource = this.employeeBindingSource;
            this.comboBoxEmployee.DisplayMember = "name";
            this.comboBoxEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(979, 399);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(290, 28);
            this.comboBoxEmployee.TabIndex = 48;
            this.comboBoxEmployee.ValueMember = "employee_id";
            // 
            // comboBoxCar
            // 
            this.comboBoxCar.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contractBindingSource, "car_id", true));
            this.comboBoxCar.DataSource = this.carBindingSource;
            this.comboBoxCar.DisplayMember = "state_number";
            this.comboBoxCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCar.FormattingEnabled = true;
            this.comboBoxCar.Location = new System.Drawing.Point(660, 397);
            this.comboBoxCar.Name = "comboBoxCar";
            this.comboBoxCar.Size = new System.Drawing.Size(290, 28);
            this.comboBoxCar.TabIndex = 46;
            this.comboBoxCar.ValueMember = "car_id";
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPrice.Location = new System.Drawing.Point(660, 471);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(290, 26);
            this.TextBoxPrice.TabIndex = 36;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerStart.Location = new System.Drawing.Point(70, 531);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerStart.TabIndex = 38;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerEnd.Location = new System.Drawing.Point(311, 531);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerEnd.TabIndex = 40;
            // 
            // dateTimePickerConclusion
            // 
            this.dateTimePickerConclusion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerConclusion.Location = new System.Drawing.Point(979, 471);
            this.dateTimePickerConclusion.Name = "dateTimePickerConclusion";
            this.dateTimePickerConclusion.Size = new System.Drawing.Size(290, 26);
            this.dateTimePickerConclusion.TabIndex = 42;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxName.Location = new System.Drawing.Point(42, 397);
            this.TextBoxName.Multiline = true;
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(255, 28);
            this.TextBoxName.TabIndex = 51;
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerBirth.Location = new System.Drawing.Point(42, 465);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(255, 26);
            this.dateTimePickerBirth.TabIndex = 53;
            // 
            // TextBoxPassport
            // 
            this.TextBoxPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPassport.Location = new System.Drawing.Point(346, 397);
            this.TextBoxPassport.Multiline = true;
            this.TextBoxPassport.Name = "TextBoxPassport";
            this.TextBoxPassport.Size = new System.Drawing.Size(255, 28);
            this.TextBoxPassport.TabIndex = 55;
            // 
            // TextBoxPhone
            // 
            this.TextBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPhone.Location = new System.Drawing.Point(346, 465);
            this.TextBoxPhone.Multiline = true;
            this.TextBoxPhone.Name = "TextBoxPhone";
            this.TextBoxPhone.Size = new System.Drawing.Size(255, 28);
            this.TextBoxPhone.TabIndex = 57;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.dataSetBuyCar;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetBuyCar1
            // 
            this.dataSetBuyCar1.DataSetName = "DataSetBuyCar";
            this.dataSetBuyCar1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "car";
            this.carBindingSource.DataSource = this.dataSetBuyCar1;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // ContractByUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 628);
            this.Controls.Add(label10);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.client_idTextBox1);
            this.Controls.Add(this.contract_idTextBox);
            this.Controls.Add(label11);
            this.Controls.Add(this.dateTimePickerBirth);
            this.Controls.Add(label12);
            this.Controls.Add(this.TextBoxPassport);
            this.Controls.Add(label13);
            this.Controls.Add(this.TextBoxPhone);
            this.Controls.Add(label1);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.comboBoxCar);
            this.Controls.Add(label3);
            this.Controls.Add(label5);
            this.Controls.Add(label6);
            this.Controls.Add(this.TextBoxPrice);
            this.Controls.Add(label7);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(label8);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(label9);
            this.Controls.Add(this.dateTimePickerConclusion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ContractByUser";
            this.Text = "ContractByUser";
            this.Load += new System.EventHandler(this.ContractByUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBuyCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBuyCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetBuyCar dataSetBuyCar;
        private System.Windows.Forms.BindingSource contractBindingSource;
        private DataSetBuyCarTableAdapters.contractTableAdapter contractTableAdapter;
        private DataSetBuyCarTableAdapters.TableAdapterManager tableAdapterManager;
        private DataSetBuyCarTableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.TextBox contract_idTextBox;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.TextBox client_idTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SaveContract;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.ComboBox comboBoxCar;
        private System.Windows.Forms.TextBox TextBoxPrice;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerConclusion;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.TextBox TextBoxPassport;
        private System.Windows.Forms.TextBox TextBoxPhone;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DataSetBuyCarTableAdapters.employeeTableAdapter employeeTableAdapter;
        private DataSetBuyCar dataSetBuyCar1;
        private System.Windows.Forms.BindingSource carBindingSource;
        private DataSetBuyCarTableAdapters.carTableAdapter carTableAdapter;
    }
}