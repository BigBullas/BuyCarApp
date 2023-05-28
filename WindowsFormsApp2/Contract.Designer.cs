namespace WindowsFormsApp2
{
    partial class Contract
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
            System.Windows.Forms.Label contract_idLabel;
            System.Windows.Forms.Label car_idLabel;
            System.Windows.Forms.Label client_idLabel;
            System.Windows.Forms.Label employee_idLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label start_dateLabel;
            System.Windows.Forms.Label end_dateLabel;
            System.Windows.Forms.Label conclusion_dateLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contract));
            this.dataSetBuyCar = new WindowsFormsApp2.DataSetBuyCar();
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractTableAdapter = new WindowsFormsApp2.DataSetBuyCarTableAdapters.contractTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.DataSetBuyCarTableAdapters.TableAdapterManager();
            this.contractBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.contract_idTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.start_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.end_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.conclusion_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DeleteContract = new System.Windows.Forms.Button();
            this.SaveContract = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.comboBoxCar = new System.Windows.Forms.ComboBox();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new WindowsFormsApp2.DataSetBuyCarTableAdapters.carTableAdapter();
            this.clientTableAdapter = new WindowsFormsApp2.DataSetBuyCarTableAdapters.clientTableAdapter();
            this.employeeTableAdapter = new WindowsFormsApp2.DataSetBuyCarTableAdapters.employeeTableAdapter();
            contract_idLabel = new System.Windows.Forms.Label();
            car_idLabel = new System.Windows.Forms.Label();
            client_idLabel = new System.Windows.Forms.Label();
            employee_idLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            start_dateLabel = new System.Windows.Forms.Label();
            end_dateLabel = new System.Windows.Forms.Label();
            conclusion_dateLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBuyCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingNavigator)).BeginInit();
            this.contractBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // contract_idLabel
            // 
            contract_idLabel.AutoSize = true;
            contract_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            contract_idLabel.Location = new System.Drawing.Point(232, 52);
            contract_idLabel.Name = "contract_idLabel";
            contract_idLabel.Size = new System.Drawing.Size(101, 20);
            contract_idLabel.TabIndex = 2;
            contract_idLabel.Text = "Договор №";
            // 
            // car_idLabel
            // 
            car_idLabel.AutoSize = true;
            car_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            car_idLabel.Location = new System.Drawing.Point(66, 161);
            car_idLabel.Name = "car_idLabel";
            car_idLabel.Size = new System.Drawing.Size(173, 20);
            car_idLabel.TabIndex = 4;
            car_idLabel.Text = "Номер транспорта:";
            // 
            // client_idLabel
            // 
            client_idLabel.AutoSize = true;
            client_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            client_idLabel.Location = new System.Drawing.Point(66, 88);
            client_idLabel.Name = "client_idLabel";
            client_idLabel.Size = new System.Drawing.Size(128, 20);
            client_idLabel.TabIndex = 6;
            client_idLabel.Text = "ФИО клиента:";
            // 
            // employee_idLabel
            // 
            employee_idLabel.AutoSize = true;
            employee_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            employee_idLabel.Location = new System.Drawing.Point(66, 403);
            employee_idLabel.Name = "employee_idLabel";
            employee_idLabel.Size = new System.Drawing.Size(307, 20);
            employee_idLabel.TabIndex = 8;
            employee_idLabel.Text = "Сотрудник, заключающий договор:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            priceLabel.Location = new System.Drawing.Point(66, 235);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(107, 20);
            priceLabel.TabIndex = 10;
            priceLabel.Text = "Стоимость:";
            // 
            // start_dateLabel
            // 
            start_dateLabel.AutoSize = true;
            start_dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            start_dateLabel.Location = new System.Drawing.Point(66, 305);
            start_dateLabel.Name = "start_dateLabel";
            start_dateLabel.Size = new System.Drawing.Size(124, 20);
            start_dateLabel.TabIndex = 12;
            start_dateLabel.Text = "Срок аренды:";
            // 
            // end_dateLabel
            // 
            end_dateLabel.AutoSize = true;
            end_dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            end_dateLabel.Location = new System.Drawing.Point(304, 332);
            end_dateLabel.Name = "end_dateLabel";
            end_dateLabel.Size = new System.Drawing.Size(29, 20);
            end_dateLabel.TabIndex = 14;
            end_dateLabel.Text = "по";
            // 
            // conclusion_dateLabel
            // 
            conclusion_dateLabel.AutoSize = true;
            conclusion_dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            conclusion_dateLabel.Location = new System.Drawing.Point(391, 403);
            conclusion_dateLabel.Name = "conclusion_dateLabel";
            conclusion_dateLabel.Size = new System.Drawing.Size(248, 20);
            conclusion_dateLabel.TabIndex = 16;
            conclusion_dateLabel.Text = "Дата заключения договора:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(66, 333);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(26, 20);
            label1.TabIndex = 25;
            label1.Text = "С ";
            label1.Click += new System.EventHandler(this.label1_Click);
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
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.contractTableAdapter = this.contractTableAdapter;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.mechanikTableAdapter = null;
            this.tableAdapterManager.modelTableAdapter = null;
            this.tableAdapterManager.repair_workTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.DataSetBuyCarTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // contractBindingNavigator
            // 
            this.contractBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contractBindingNavigator.BindingSource = this.contractBindingSource;
            this.contractBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contractBindingNavigator.DeleteItem = null;
            this.contractBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contractBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem});
            this.contractBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contractBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contractBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contractBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contractBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contractBindingNavigator.Name = "contractBindingNavigator";
            this.contractBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contractBindingNavigator.Size = new System.Drawing.Size(681, 27);
            this.contractBindingNavigator.TabIndex = 0;
            this.contractBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // contract_idTextBox
            // 
            this.contract_idTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.contract_idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contract_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "contract_id", true));
            this.contract_idTextBox.Enabled = false;
            this.contract_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contract_idTextBox.Location = new System.Drawing.Point(339, 53);
            this.contract_idTextBox.Name = "contract_idTextBox";
            this.contract_idTextBox.Size = new System.Drawing.Size(200, 19);
            this.contract_idTextBox.TabIndex = 3;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "price", true));
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTextBox.Location = new System.Drawing.Point(70, 258);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(290, 26);
            this.priceTextBox.TabIndex = 11;
            // 
            // start_dateDateTimePicker
            // 
            this.start_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractBindingSource, "start_date", true));
            this.start_dateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_dateDateTimePicker.Location = new System.Drawing.Point(98, 328);
            this.start_dateDateTimePicker.Name = "start_dateDateTimePicker";
            this.start_dateDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.start_dateDateTimePicker.TabIndex = 13;
            // 
            // end_dateDateTimePicker
            // 
            this.end_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractBindingSource, "end_date", true));
            this.end_dateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.end_dateDateTimePicker.Location = new System.Drawing.Point(339, 328);
            this.end_dateDateTimePicker.Name = "end_dateDateTimePicker";
            this.end_dateDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.end_dateDateTimePicker.TabIndex = 15;
            this.end_dateDateTimePicker.ValueChanged += new System.EventHandler(this.end_dateDateTimePicker_ValueChanged);
            // 
            // conclusion_dateDateTimePicker
            // 
            this.conclusion_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractBindingSource, "conclusion_date", true));
            this.conclusion_dateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.conclusion_dateDateTimePicker.Location = new System.Drawing.Point(395, 426);
            this.conclusion_dateDateTimePicker.Name = "conclusion_dateDateTimePicker";
            this.conclusion_dateDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.conclusion_dateDateTimePicker.TabIndex = 17;
            // 
            // DeleteContract
            // 
            this.DeleteContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteContract.Location = new System.Drawing.Point(498, 161);
            this.DeleteContract.Name = "DeleteContract";
            this.DeleteContract.Size = new System.Drawing.Size(120, 44);
            this.DeleteContract.TabIndex = 21;
            this.DeleteContract.Text = "Удалить";
            this.DeleteContract.UseVisualStyleBackColor = true;
            this.DeleteContract.Click += new System.EventHandler(this.DeleteContract_Click);
            // 
            // SaveContract
            // 
            this.SaveContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveContract.Location = new System.Drawing.Point(498, 88);
            this.SaveContract.Name = "SaveContract";
            this.SaveContract.Size = new System.Drawing.Size(120, 44);
            this.SaveContract.TabIndex = 20;
            this.SaveContract.Text = "Сохранить";
            this.SaveContract.UseVisualStyleBackColor = true;
            this.SaveContract.Click += new System.EventHandler(this.SaveContract_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(498, 247);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(120, 44);
            this.Back.TabIndex = 19;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // comboBoxCar
            // 
            this.comboBoxCar.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contractBindingSource, "car_id", true));
            this.comboBoxCar.DataSource = this.carBindingSource;
            this.comboBoxCar.DisplayMember = "state_number";
            this.comboBoxCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCar.FormattingEnabled = true;
            this.comboBoxCar.Location = new System.Drawing.Point(70, 184);
            this.comboBoxCar.Name = "comboBoxCar";
            this.comboBoxCar.Size = new System.Drawing.Size(290, 28);
            this.comboBoxCar.TabIndex = 22;
            this.comboBoxCar.ValueMember = "car_id";
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "car";
            this.carBindingSource.DataSource = this.dataSetBuyCar;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contractBindingSource, "client_id", true));
            this.comboBoxClient.DataSource = this.clientBindingSource;
            this.comboBoxClient.DisplayMember = "name";
            this.comboBoxClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(70, 111);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(290, 28);
            this.comboBoxClient.TabIndex = 23;
            this.comboBoxClient.ValueMember = "client_id";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.dataSetBuyCar;
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contractBindingSource, "employee_id", true));
            this.comboBoxEmployee.DataSource = this.employeeBindingSource;
            this.comboBoxEmployee.DisplayMember = "name";
            this.comboBoxEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(70, 428);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(290, 28);
            this.comboBoxEmployee.TabIndex = 24;
            this.comboBoxEmployee.ValueMember = "employee_id";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.dataSetBuyCar;
            // 
            // contractBindingSource1
            // 
            this.contractBindingSource1.DataMember = "contract";
            this.contractBindingSource1.DataSource = this.dataSetBuyCar;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // Contract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 502);
            this.Controls.Add(label1);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.comboBoxCar);
            this.Controls.Add(this.DeleteContract);
            this.Controls.Add(this.SaveContract);
            this.Controls.Add(this.Back);
            this.Controls.Add(contract_idLabel);
            this.Controls.Add(this.contract_idTextBox);
            this.Controls.Add(car_idLabel);
            this.Controls.Add(client_idLabel);
            this.Controls.Add(employee_idLabel);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(start_dateLabel);
            this.Controls.Add(this.start_dateDateTimePicker);
            this.Controls.Add(end_dateLabel);
            this.Controls.Add(this.end_dateDateTimePicker);
            this.Controls.Add(conclusion_dateLabel);
            this.Controls.Add(this.conclusion_dateDateTimePicker);
            this.Controls.Add(this.contractBindingNavigator);
            this.Name = "Contract";
            this.Text = "Contract";
            this.Load += new System.EventHandler(this.Contract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBuyCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingNavigator)).EndInit();
            this.contractBindingNavigator.ResumeLayout(false);
            this.contractBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetBuyCar dataSetBuyCar;
        private System.Windows.Forms.BindingSource contractBindingSource;
        private DataSetBuyCarTableAdapters.contractTableAdapter contractTableAdapter;
        private DataSetBuyCarTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator contractBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox contract_idTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.DateTimePicker start_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker end_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker conclusion_dateDateTimePicker;
        private System.Windows.Forms.Button DeleteContract;
        private System.Windows.Forms.Button SaveContract;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.ComboBox comboBoxCar;
        private System.Windows.Forms.BindingSource contractBindingSource1;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.BindingSource carBindingSource;
        private DataSetBuyCarTableAdapters.carTableAdapter carTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DataSetBuyCarTableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DataSetBuyCarTableAdapters.employeeTableAdapter employeeTableAdapter;
    }
}