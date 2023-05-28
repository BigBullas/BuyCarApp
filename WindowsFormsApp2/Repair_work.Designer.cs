namespace WindowsFormsApp2
{
    partial class Repair_work
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
            System.Windows.Forms.Label car_idLabel;
            System.Windows.Forms.Label mechanic_idLabel;
            System.Windows.Forms.Label start_dateLabel;
            System.Windows.Forms.Label end_dateLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Repair_work));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dataSetBuyCar = new WindowsFormsApp2.DataSetBuyCar();
            this.repair_workBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repair_workTableAdapter = new WindowsFormsApp2.DataSetBuyCarTableAdapters.repair_workTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.DataSetBuyCarTableAdapters.TableAdapterManager();
            this.carTableAdapter = new WindowsFormsApp2.DataSetBuyCarTableAdapters.carTableAdapter();
            this.mechanikTableAdapter = new WindowsFormsApp2.DataSetBuyCarTableAdapters.mechanikTableAdapter();
            this.repair_workDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repair_work_idTextBox = new System.Windows.Forms.TextBox();
            this.start_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.end_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.DeleteRepairWork = new System.Windows.Forms.Button();
            this.SaveRepairWork = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCar = new System.Windows.Forms.ComboBox();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxMechanic = new System.Windows.Forms.ComboBox();
            this.mechanikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            car_idLabel = new System.Windows.Forms.Label();
            mechanic_idLabel = new System.Windows.Forms.Label();
            start_dateLabel = new System.Windows.Forms.Label();
            end_dateLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBuyCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repair_workBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repair_workDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mechanikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // car_idLabel
            // 
            car_idLabel.AutoSize = true;
            car_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            car_idLabel.Location = new System.Drawing.Point(74, 71);
            car_idLabel.Name = "car_idLabel";
            car_idLabel.Size = new System.Drawing.Size(173, 20);
            car_idLabel.TabIndex = 4;
            car_idLabel.Text = "Номер транспорта:";
            // 
            // mechanic_idLabel
            // 
            mechanic_idLabel.AutoSize = true;
            mechanic_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            mechanic_idLabel.Location = new System.Drawing.Point(74, 134);
            mechanic_idLabel.Name = "mechanic_idLabel";
            mechanic_idLabel.Size = new System.Drawing.Size(138, 20);
            mechanic_idLabel.TabIndex = 6;
            mechanic_idLabel.Text = "ФИО механика:";
            // 
            // start_dateLabel
            // 
            start_dateLabel.AutoSize = true;
            start_dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            start_dateLabel.Location = new System.Drawing.Point(394, 71);
            start_dateLabel.Name = "start_dateLabel";
            start_dateLabel.Size = new System.Drawing.Size(199, 20);
            start_dateLabel.TabIndex = 8;
            start_dateLabel.Text = "Дата начала ремонта:";
            // 
            // end_dateLabel
            // 
            end_dateLabel.AutoSize = true;
            end_dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            end_dateLabel.Location = new System.Drawing.Point(394, 134);
            end_dateLabel.Name = "end_dateLabel";
            end_dateLabel.Size = new System.Drawing.Size(228, 20);
            end_dateLabel.TabIndex = 10;
            end_dateLabel.Text = "Дата окончания ремонта:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            descriptionLabel.Location = new System.Drawing.Point(74, 198);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(128, 20);
            descriptionLabel.TabIndex = 12;
            descriptionLabel.Text = "Подробности:";
            descriptionLabel.Click += new System.EventHandler(this.descriptionLabel_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.repair_workBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(915, 27);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // dataSetBuyCar
            // 
            this.dataSetBuyCar.DataSetName = "DataSetBuyCar";
            this.dataSetBuyCar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repair_workBindingSource
            // 
            this.repair_workBindingSource.DataMember = "repair_work";
            this.repair_workBindingSource.DataSource = this.dataSetBuyCar;
            // 
            // repair_workTableAdapter
            // 
            this.repair_workTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carTableAdapter = this.carTableAdapter;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.contractTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.mechanikTableAdapter = this.mechanikTableAdapter;
            this.tableAdapterManager.modelTableAdapter = null;
            this.tableAdapterManager.repair_workTableAdapter = this.repair_workTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.DataSetBuyCarTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // mechanikTableAdapter
            // 
            this.mechanikTableAdapter.ClearBeforeFill = true;
            // 
            // repair_workDataGridView
            // 
            this.repair_workDataGridView.AutoGenerateColumns = false;
            this.repair_workDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.repair_workDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.repair_workDataGridView.DataSource = this.repair_workBindingSource;
            this.repair_workDataGridView.Location = new System.Drawing.Point(34, 318);
            this.repair_workDataGridView.Name = "repair_workDataGridView";
            this.repair_workDataGridView.RowHeadersWidth = 51;
            this.repair_workDataGridView.RowTemplate.Height = 24;
            this.repair_workDataGridView.Size = new System.Drawing.Size(856, 242);
            this.repair_workDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "repair_work_id";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 35;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "car_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "№ транспорта";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "mechanic_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "№ механика";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 90;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "start_date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата начала";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "end_date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата окончания";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn6.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // repair_work_idTextBox
            // 
            this.repair_work_idTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.repair_work_idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.repair_work_idTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.repair_work_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.repair_workBindingSource, "repair_work_id", true));
            this.repair_work_idTextBox.Enabled = false;
            this.repair_work_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repair_work_idTextBox.Location = new System.Drawing.Point(444, 39);
            this.repair_work_idTextBox.Name = "repair_work_idTextBox";
            this.repair_work_idTextBox.Size = new System.Drawing.Size(200, 19);
            this.repair_work_idTextBox.TabIndex = 3;
            // 
            // start_dateDateTimePicker
            // 
            this.start_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.repair_workBindingSource, "start_date", true));
            this.start_dateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_dateDateTimePicker.Location = new System.Drawing.Point(398, 94);
            this.start_dateDateTimePicker.Name = "start_dateDateTimePicker";
            this.start_dateDateTimePicker.Size = new System.Drawing.Size(224, 26);
            this.start_dateDateTimePicker.TabIndex = 9;
            // 
            // end_dateDateTimePicker
            // 
            this.end_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.repair_workBindingSource, "end_date", true));
            this.end_dateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.end_dateDateTimePicker.Location = new System.Drawing.Point(398, 159);
            this.end_dateDateTimePicker.Name = "end_dateDateTimePicker";
            this.end_dateDateTimePicker.Size = new System.Drawing.Size(224, 26);
            this.end_dateDateTimePicker.TabIndex = 11;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.repair_workBindingSource, "description", true));
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTextBox.Location = new System.Drawing.Point(78, 221);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(544, 72);
            this.descriptionTextBox.TabIndex = 13;
            // 
            // DeleteRepairWork
            // 
            this.DeleteRepairWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteRepairWork.Location = new System.Drawing.Point(715, 134);
            this.DeleteRepairWork.Name = "DeleteRepairWork";
            this.DeleteRepairWork.Size = new System.Drawing.Size(130, 40);
            this.DeleteRepairWork.TabIndex = 21;
            this.DeleteRepairWork.Text = "Удалить";
            this.DeleteRepairWork.UseVisualStyleBackColor = true;
            this.DeleteRepairWork.Click += new System.EventHandler(this.DeleteRepairWork_Click);
            // 
            // SaveRepairWork
            // 
            this.SaveRepairWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveRepairWork.Location = new System.Drawing.Point(715, 71);
            this.SaveRepairWork.Name = "SaveRepairWork";
            this.SaveRepairWork.Size = new System.Drawing.Size(130, 40);
            this.SaveRepairWork.TabIndex = 20;
            this.SaveRepairWork.Text = "Сохранить";
            this.SaveRepairWork.UseVisualStyleBackColor = true;
            this.SaveRepairWork.Click += new System.EventHandler(this.SaveRepairWork_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(715, 194);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(130, 40);
            this.Back.TabIndex = 19;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(238, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ремонтная работа №";
            // 
            // comboBoxCar
            // 
            this.comboBoxCar.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.repair_workBindingSource, "car_id", true));
            this.comboBoxCar.DataSource = this.carBindingSource;
            this.comboBoxCar.DisplayMember = "state_number";
            this.comboBoxCar.DropDownHeight = 100;
            this.comboBoxCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCar.FormattingEnabled = true;
            this.comboBoxCar.IntegralHeight = false;
            this.comboBoxCar.Location = new System.Drawing.Point(78, 94);
            this.comboBoxCar.Name = "comboBoxCar";
            this.comboBoxCar.Size = new System.Drawing.Size(250, 28);
            this.comboBoxCar.TabIndex = 24;
            this.comboBoxCar.ValueMember = "car_id";
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "car";
            this.carBindingSource.DataSource = this.dataSetBuyCar;
            // 
            // comboBoxMechanic
            // 
            this.comboBoxMechanic.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.repair_workBindingSource, "mechanic_id", true));
            this.comboBoxMechanic.DataSource = this.mechanikBindingSource;
            this.comboBoxMechanic.DisplayMember = "name";
            this.comboBoxMechanic.DropDownHeight = 100;
            this.comboBoxMechanic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMechanic.FormattingEnabled = true;
            this.comboBoxMechanic.IntegralHeight = false;
            this.comboBoxMechanic.Location = new System.Drawing.Point(78, 157);
            this.comboBoxMechanic.Name = "comboBoxMechanic";
            this.comboBoxMechanic.Size = new System.Drawing.Size(250, 28);
            this.comboBoxMechanic.TabIndex = 25;
            this.comboBoxMechanic.ValueMember = "mechanic_id";
            // 
            // mechanikBindingSource
            // 
            this.mechanikBindingSource.DataMember = "mechanik";
            this.mechanikBindingSource.DataSource = this.dataSetBuyCar;
            // 
            // Repair_work
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 572);
            this.Controls.Add(this.comboBoxMechanic);
            this.Controls.Add(this.comboBoxCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteRepairWork);
            this.Controls.Add(this.SaveRepairWork);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.repair_work_idTextBox);
            this.Controls.Add(car_idLabel);
            this.Controls.Add(mechanic_idLabel);
            this.Controls.Add(start_dateLabel);
            this.Controls.Add(this.start_dateDateTimePicker);
            this.Controls.Add(end_dateLabel);
            this.Controls.Add(this.end_dateDateTimePicker);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.repair_workDataGridView);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "Repair_work";
            this.Text = "Repair_work";
            this.Load += new System.EventHandler(this.Repair_work_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBuyCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repair_workBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repair_workDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mechanikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private DataSetBuyCar dataSetBuyCar;
        private System.Windows.Forms.BindingSource repair_workBindingSource;
        private DataSetBuyCarTableAdapters.repair_workTableAdapter repair_workTableAdapter;
        private DataSetBuyCarTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView repair_workDataGridView;
        private System.Windows.Forms.TextBox repair_work_idTextBox;
        private System.Windows.Forms.DateTimePicker start_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker end_dateDateTimePicker;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button DeleteRepairWork;
        private System.Windows.Forms.Button SaveRepairWork;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCar;
        private DataSetBuyCarTableAdapters.carTableAdapter carTableAdapter;
        private System.Windows.Forms.BindingSource carBindingSource;
        private DataSetBuyCarTableAdapters.mechanikTableAdapter mechanikTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxMechanic;
        private System.Windows.Forms.BindingSource mechanikBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}