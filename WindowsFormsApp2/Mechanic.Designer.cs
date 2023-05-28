namespace WindowsFormsApp2
{
    partial class Mechanic
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label work_experienceLabel;
            System.Windows.Forms.Label employment_dateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mechanic));
            this.mechanikDataGridView = new System.Windows.Forms.DataGridView();
            this.mechanic_idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.work_experienceTextBox = new System.Windows.Forms.TextBox();
            this.employment_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FindBtn = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.RepairWorkByIdMechanic = new System.Windows.Forms.Button();
            this.DeleteMechanic = new System.Windows.Forms.Button();
            this.SaveMechanic = new System.Windows.Forms.Button();
            this.clientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mechanikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetBuyCar = new WindowsFormsApp2.DataSetBuyCar();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mechanikTableAdapter = new WindowsFormsApp2.DataSetBuyCarTableAdapters.mechanikTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.DataSetBuyCarTableAdapters.TableAdapterManager();
            nameLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            work_experienceLabel = new System.Windows.Forms.Label();
            employment_dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mechanikDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingNavigator)).BeginInit();
            this.clientBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mechanikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBuyCar)).BeginInit();
            this.SuspendLayout();
            // 
            // mechanikDataGridView
            // 
            this.mechanikDataGridView.AutoGenerateColumns = false;
            this.mechanikDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mechanikDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.mechanikDataGridView.DataSource = this.mechanikBindingSource;
            this.mechanikDataGridView.Location = new System.Drawing.Point(29, 115);
            this.mechanikDataGridView.Name = "mechanikDataGridView";
            this.mechanikDataGridView.RowHeadersWidth = 51;
            this.mechanikDataGridView.RowTemplate.Height = 24;
            this.mechanikDataGridView.Size = new System.Drawing.Size(898, 360);
            this.mechanikDataGridView.TabIndex = 1;
            // 
            // mechanic_idTextBox
            // 
            this.mechanic_idTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.mechanic_idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mechanic_idTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.mechanic_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mechanikBindingSource, "mechanic_id", true));
            this.mechanic_idTextBox.Enabled = false;
            this.mechanic_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mechanic_idTextBox.Location = new System.Drawing.Point(928, 48);
            this.mechanic_idTextBox.Name = "mechanic_idTextBox";
            this.mechanic_idTextBox.Size = new System.Drawing.Size(200, 2);
            this.mechanic_idTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(980, 115);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(138, 20);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "ФИО механика:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mechanikBindingSource, "name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(984, 141);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(277, 28);
            this.nameTextBox.TabIndex = 5;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            categoryLabel.Location = new System.Drawing.Point(980, 172);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(160, 20);
            categoryLabel.TabIndex = 6;
            categoryLabel.Text = "Разряд механика:";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mechanikBindingSource, "category", true));
            this.categoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryTextBox.Location = new System.Drawing.Point(984, 195);
            this.categoryTextBox.Multiline = true;
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(277, 28);
            this.categoryTextBox.TabIndex = 7;
            // 
            // work_experienceLabel
            // 
            work_experienceLabel.AutoSize = true;
            work_experienceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            work_experienceLabel.Location = new System.Drawing.Point(980, 229);
            work_experienceLabel.Name = "work_experienceLabel";
            work_experienceLabel.Size = new System.Drawing.Size(125, 20);
            work_experienceLabel.TabIndex = 8;
            work_experienceLabel.Text = "Стаж работы:";
            // 
            // work_experienceTextBox
            // 
            this.work_experienceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mechanikBindingSource, "work_experience", true));
            this.work_experienceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.work_experienceTextBox.Location = new System.Drawing.Point(984, 252);
            this.work_experienceTextBox.Multiline = true;
            this.work_experienceTextBox.Name = "work_experienceTextBox";
            this.work_experienceTextBox.Size = new System.Drawing.Size(277, 28);
            this.work_experienceTextBox.TabIndex = 9;
            // 
            // employment_dateLabel
            // 
            employment_dateLabel.AutoSize = true;
            employment_dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            employment_dateLabel.Location = new System.Drawing.Point(980, 290);
            employment_dateLabel.Name = "employment_dateLabel";
            employment_dateLabel.Size = new System.Drawing.Size(158, 20);
            employment_dateLabel.TabIndex = 10;
            employment_dateLabel.Text = "Дата устройства:";
            // 
            // employment_dateDateTimePicker
            // 
            this.employment_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mechanikBindingSource, "employment_date", true));
            this.employment_dateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employment_dateDateTimePicker.Location = new System.Drawing.Point(984, 313);
            this.employment_dateDateTimePicker.Name = "employment_dateDateTimePicker";
            this.employment_dateDateTimePicker.Size = new System.Drawing.Size(277, 26);
            this.employment_dateDateTimePicker.TabIndex = 11;
            // 
            // FindBtn
            // 
            this.FindBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindBtn.Location = new System.Drawing.Point(713, 48);
            this.FindBtn.Margin = new System.Windows.Forms.Padding(4);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(130, 40);
            this.FindBtn.TabIndex = 31;
            this.FindBtn.Text = "Найти";
            this.FindBtn.UseVisualStyleBackColor = true;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(404, 58);
            this.textBoxFind.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFind.Multiline = true;
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(193, 28);
            this.textBoxFind.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(252, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Поиск механика";
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(29, 48);
            this.Back.Margin = new System.Windows.Forms.Padding(4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(130, 40);
            this.Back.TabIndex = 28;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // RepairWorkByIdMechanic
            // 
            this.RepairWorkByIdMechanic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepairWorkByIdMechanic.Location = new System.Drawing.Point(984, 417);
            this.RepairWorkByIdMechanic.Margin = new System.Windows.Forms.Padding(4);
            this.RepairWorkByIdMechanic.Name = "RepairWorkByIdMechanic";
            this.RepairWorkByIdMechanic.Size = new System.Drawing.Size(277, 58);
            this.RepairWorkByIdMechanic.TabIndex = 34;
            this.RepairWorkByIdMechanic.Text = "Ремонтные работы механика";
            this.RepairWorkByIdMechanic.UseVisualStyleBackColor = true;
            this.RepairWorkByIdMechanic.Click += new System.EventHandler(this.RepairWorkByIdMechanic_Click);
            // 
            // DeleteMechanic
            // 
            this.DeleteMechanic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteMechanic.Location = new System.Drawing.Point(1131, 369);
            this.DeleteMechanic.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteMechanic.Name = "DeleteMechanic";
            this.DeleteMechanic.Size = new System.Drawing.Size(130, 40);
            this.DeleteMechanic.TabIndex = 33;
            this.DeleteMechanic.Text = "Удалить";
            this.DeleteMechanic.UseVisualStyleBackColor = true;
            this.DeleteMechanic.Click += new System.EventHandler(this.DeleteMechanic_Click);
            // 
            // SaveMechanic
            // 
            this.SaveMechanic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveMechanic.Location = new System.Drawing.Point(984, 369);
            this.SaveMechanic.Margin = new System.Windows.Forms.Padding(4);
            this.SaveMechanic.Name = "SaveMechanic";
            this.SaveMechanic.Size = new System.Drawing.Size(130, 40);
            this.SaveMechanic.TabIndex = 32;
            this.SaveMechanic.Text = "Сохранить";
            this.SaveMechanic.UseVisualStyleBackColor = true;
            this.SaveMechanic.Click += new System.EventHandler(this.SaveMechanic_Click);
            // 
            // clientBindingNavigator
            // 
            this.clientBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clientBindingNavigator.BindingSource = this.mechanikBindingSource;
            this.clientBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientBindingNavigator.DeleteItem = null;
            this.clientBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.clientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.toolStripSeparator1});
            this.clientBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clientBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientBindingNavigator.Name = "clientBindingNavigator";
            this.clientBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientBindingNavigator.Size = new System.Drawing.Size(1306, 31);
            this.clientBindingNavigator.TabIndex = 35;
            this.clientBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // mechanikBindingSource
            // 
            this.mechanikBindingSource.DataMember = "mechanik";
            this.mechanikBindingSource.DataSource = this.dataSetBuyCar;
            // 
            // dataSetBuyCar
            // 
            this.dataSetBuyCar.DataSetName = "DataSetBuyCar";
            this.dataSetBuyCar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "mechanic_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 35;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО механика";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "category";
            this.dataGridViewTextBoxColumn3.HeaderText = "Разряд механика";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "work_experience";
            this.dataGridViewTextBoxColumn4.HeaderText = "Стаж работы";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "employment_date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата устройства";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // mechanikTableAdapter
            // 
            this.mechanikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.contractTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.mechanikTableAdapter = this.mechanikTableAdapter;
            this.tableAdapterManager.modelTableAdapter = null;
            this.tableAdapterManager.repair_workTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.DataSetBuyCarTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Mechanic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 558);
            this.Controls.Add(this.clientBindingNavigator);
            this.Controls.Add(this.RepairWorkByIdMechanic);
            this.Controls.Add(this.DeleteMechanic);
            this.Controls.Add(this.SaveMechanic);
            this.Controls.Add(this.FindBtn);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.mechanic_idTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(work_experienceLabel);
            this.Controls.Add(this.work_experienceTextBox);
            this.Controls.Add(employment_dateLabel);
            this.Controls.Add(this.employment_dateDateTimePicker);
            this.Controls.Add(this.mechanikDataGridView);
            this.Name = "Mechanic";
            this.Text = "Mechanic";
            this.Load += new System.EventHandler(this.Mechanic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mechanikDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingNavigator)).EndInit();
            this.clientBindingNavigator.ResumeLayout(false);
            this.clientBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mechanikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBuyCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSetBuyCar dataSetBuyCar;
        private System.Windows.Forms.BindingSource mechanikBindingSource;
        private DataSetBuyCarTableAdapters.mechanikTableAdapter mechanikTableAdapter;
        private DataSetBuyCarTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView mechanikDataGridView;
        private System.Windows.Forms.TextBox mechanic_idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox work_experienceTextBox;
        private System.Windows.Forms.DateTimePicker employment_dateDateTimePicker;
        private System.Windows.Forms.Button FindBtn;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button RepairWorkByIdMechanic;
        private System.Windows.Forms.Button DeleteMechanic;
        private System.Windows.Forms.Button SaveMechanic;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingNavigator clientBindingNavigator;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}