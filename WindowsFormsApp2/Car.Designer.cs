namespace WindowsFormsApp2
{
    partial class Car
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
            System.Windows.Forms.Label model_idLabel;
            System.Windows.Forms.Label state_numberLabel;
            System.Windows.Forms.Label min_rental_periodLabel;
            System.Windows.Forms.Label rental_priceLabel;
            System.Windows.Forms.Label depositLabel;
            System.Windows.Forms.Label damageLabel;
            System.Windows.Forms.Label model_nameLabel;
            System.Windows.Forms.Label car_nameLabel;
            System.Windows.Forms.Label equipmentLabel;
            System.Windows.Forms.Label transmissionLabel;
            System.Windows.Forms.Label trunk_capacityLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Car));
            this.dataSetBuyCar = new WindowsFormsApp2.DataSetBuyCar();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new WindowsFormsApp2.DataSetBuyCarTableAdapters.carTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.DataSetBuyCarTableAdapters.TableAdapterManager();
            this.carBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.car_idTextBox = new System.Windows.Forms.TextBox();
            this.state_numberTextBox = new System.Windows.Forms.TextBox();
            this.min_rental_periodTextBox = new System.Windows.Forms.TextBox();
            this.rental_priceTextBox = new System.Windows.Forms.TextBox();
            this.depositTextBox = new System.Windows.Forms.TextBox();
            this.damageTextBox = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.SaveCar = new System.Windows.Forms.Button();
            this.DeleteCar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.modelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelTableAdapter = new WindowsFormsApp2.DataSetBuyCarTableAdapters.modelTableAdapter();
            this.model_idTextBox = new System.Windows.Forms.TextBox();
            this.model_nameTextBox = new System.Windows.Forms.TextBox();
            this.car_nameTextBox = new System.Windows.Forms.TextBox();
            this.equipmentTextBox = new System.Windows.Forms.TextBox();
            this.transmissionTextBox = new System.Windows.Forms.TextBox();
            this.trunk_capacityTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnContractById = new System.Windows.Forms.Button();
            model_idLabel = new System.Windows.Forms.Label();
            state_numberLabel = new System.Windows.Forms.Label();
            min_rental_periodLabel = new System.Windows.Forms.Label();
            rental_priceLabel = new System.Windows.Forms.Label();
            depositLabel = new System.Windows.Forms.Label();
            damageLabel = new System.Windows.Forms.Label();
            model_nameLabel = new System.Windows.Forms.Label();
            car_nameLabel = new System.Windows.Forms.Label();
            equipmentLabel = new System.Windows.Forms.Label();
            transmissionLabel = new System.Windows.Forms.Label();
            trunk_capacityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBuyCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingNavigator)).BeginInit();
            this.carBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // model_idLabel
            // 
            model_idLabel.AutoSize = true;
            model_idLabel.Location = new System.Drawing.Point(12, 43);
            model_idLabel.Name = "model_idLabel";
            model_idLabel.Size = new System.Drawing.Size(203, 20);
            model_idLabel.TabIndex = 4;
            model_idLabel.Text = "Название автомобиля:";
            // 
            // state_numberLabel
            // 
            state_numberLabel.AutoSize = true;
            state_numberLabel.Location = new System.Drawing.Point(12, 109);
            state_numberLabel.Name = "state_numberLabel";
            state_numberLabel.Size = new System.Drawing.Size(104, 20);
            state_numberLabel.TabIndex = 6;
            state_numberLabel.Text = "Гос. номер:";
            // 
            // min_rental_periodLabel
            // 
            min_rental_periodLabel.AutoSize = true;
            min_rental_periodLabel.Location = new System.Drawing.Point(420, 89);
            min_rental_periodLabel.Name = "min_rental_periodLabel";
            min_rental_periodLabel.Size = new System.Drawing.Size(127, 40);
            min_rental_periodLabel.TabIndex = 8;
            min_rental_periodLabel.Text = "Минимальный\r\nсрок аренды:";
            // 
            // rental_priceLabel
            // 
            rental_priceLabel.AutoSize = true;
            rental_priceLabel.Location = new System.Drawing.Point(260, 43);
            rental_priceLabel.Name = "rental_priceLabel";
            rental_priceLabel.Size = new System.Drawing.Size(115, 20);
            rental_priceLabel.TabIndex = 10;
            rental_priceLabel.Text = "Цена за час:";
            // 
            // depositLabel
            // 
            depositLabel.AutoSize = true;
            depositLabel.Location = new System.Drawing.Point(260, 109);
            depositLabel.Name = "depositLabel";
            depositLabel.Size = new System.Drawing.Size(64, 20);
            depositLabel.TabIndex = 12;
            depositLabel.Text = "Залог:";
            depositLabel.Click += new System.EventHandler(this.depositLabel_Click);
            // 
            // damageLabel
            // 
            damageLabel.AutoSize = true;
            damageLabel.Location = new System.Drawing.Point(12, 180);
            damageLabel.Name = "damageLabel";
            damageLabel.Size = new System.Drawing.Size(232, 20);
            damageLabel.TabIndex = 14;
            damageLabel.Text = "Имеющиеся повреждения:";
            // 
            // model_nameLabel
            // 
            model_nameLabel.AutoSize = true;
            model_nameLabel.Location = new System.Drawing.Point(28, 40);
            model_nameLabel.Name = "model_nameLabel";
            model_nameLabel.Size = new System.Drawing.Size(67, 20);
            model_nameLabel.TabIndex = 21;
            model_nameLabel.Text = "Марка:";
            // 
            // car_nameLabel
            // 
            car_nameLabel.AutoSize = true;
            car_nameLabel.Location = new System.Drawing.Point(260, 40);
            car_nameLabel.Name = "car_nameLabel";
            car_nameLabel.Size = new System.Drawing.Size(96, 20);
            car_nameLabel.TabIndex = 23;
            car_nameLabel.Text = "Название:";
            // 
            // equipmentLabel
            // 
            equipmentLabel.AutoSize = true;
            equipmentLabel.Location = new System.Drawing.Point(28, 114);
            equipmentLabel.Name = "equipmentLabel";
            equipmentLabel.Size = new System.Drawing.Size(136, 20);
            equipmentLabel.TabIndex = 25;
            equipmentLabel.Text = "Комплектация:";
            // 
            // transmissionLabel
            // 
            transmissionLabel.AutoSize = true;
            transmissionLabel.Location = new System.Drawing.Point(260, 114);
            transmissionLabel.Name = "transmissionLabel";
            transmissionLabel.Size = new System.Drawing.Size(161, 20);
            transmissionLabel.TabIndex = 27;
            transmissionLabel.Text = "Коробка передач:";
            // 
            // trunk_capacityLabel
            // 
            trunk_capacityLabel.AutoSize = true;
            trunk_capacityLabel.Location = new System.Drawing.Point(523, 114);
            trunk_capacityLabel.Name = "trunk_capacityLabel";
            trunk_capacityLabel.Size = new System.Drawing.Size(255, 20);
            trunk_capacityLabel.TabIndex = 29;
            trunk_capacityLabel.Text = "Вместительность багажника";
            // 
            // dataSetBuyCar
            // 
            this.dataSetBuyCar.DataSetName = "DataSetBuyCar";
            this.dataSetBuyCar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "car";
            this.carBindingSource.DataSource = this.dataSetBuyCar;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carTableAdapter = this.carTableAdapter;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.contractTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.mechanikTableAdapter = null;
            this.tableAdapterManager.modelTableAdapter = null;
            this.tableAdapterManager.repair_workTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.DataSetBuyCarTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // carBindingNavigator
            // 
            this.carBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.carBindingNavigator.BindingSource = this.carBindingSource;
            this.carBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.carBindingNavigator.DeleteItem = null;
            this.carBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.carBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.carBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.carBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.carBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.carBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.carBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.carBindingNavigator.Name = "carBindingNavigator";
            this.carBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.carBindingNavigator.Size = new System.Drawing.Size(932, 27);
            this.carBindingNavigator.TabIndex = 0;
            this.carBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
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
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // car_idTextBox
            // 
            this.car_idTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.car_idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.car_idTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.car_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "car_id", true));
            this.car_idTextBox.Enabled = false;
            this.car_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.car_idTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.car_idTextBox.Location = new System.Drawing.Point(552, 25);
            this.car_idTextBox.Name = "car_idTextBox";
            this.car_idTextBox.ReadOnly = true;
            this.car_idTextBox.Size = new System.Drawing.Size(121, 2);
            this.car_idTextBox.TabIndex = 3;
            // 
            // state_numberTextBox
            // 
            this.state_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "state_number", true));
            this.state_numberTextBox.Location = new System.Drawing.Point(16, 132);
            this.state_numberTextBox.Multiline = true;
            this.state_numberTextBox.Name = "state_numberTextBox";
            this.state_numberTextBox.Size = new System.Drawing.Size(201, 28);
            this.state_numberTextBox.TabIndex = 7;
            // 
            // min_rental_periodTextBox
            // 
            this.min_rental_periodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "min_rental_period", true));
            this.min_rental_periodTextBox.Location = new System.Drawing.Point(424, 132);
            this.min_rental_periodTextBox.Name = "min_rental_periodTextBox";
            this.min_rental_periodTextBox.Size = new System.Drawing.Size(121, 26);
            this.min_rental_periodTextBox.TabIndex = 9;
            this.min_rental_periodTextBox.TextChanged += new System.EventHandler(this.min_rental_periodTextBox_TextChanged);
            // 
            // rental_priceTextBox
            // 
            this.rental_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "rental_price", true));
            this.rental_priceTextBox.Location = new System.Drawing.Point(264, 66);
            this.rental_priceTextBox.Multiline = true;
            this.rental_priceTextBox.Name = "rental_priceTextBox";
            this.rental_priceTextBox.Size = new System.Drawing.Size(121, 28);
            this.rental_priceTextBox.TabIndex = 11;
            // 
            // depositTextBox
            // 
            this.depositTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "deposit", true));
            this.depositTextBox.Location = new System.Drawing.Point(264, 132);
            this.depositTextBox.Multiline = true;
            this.depositTextBox.Name = "depositTextBox";
            this.depositTextBox.Size = new System.Drawing.Size(121, 28);
            this.depositTextBox.TabIndex = 13;
            // 
            // damageTextBox
            // 
            this.damageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "damage", true));
            this.damageTextBox.Location = new System.Drawing.Point(18, 213);
            this.damageTextBox.Multiline = true;
            this.damageTextBox.Name = "damageTextBox";
            this.damageTextBox.Size = new System.Drawing.Size(644, 92);
            this.damageTextBox.TabIndex = 15;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(696, 182);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(120, 44);
            this.Back.TabIndex = 16;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // SaveCar
            // 
            this.SaveCar.Location = new System.Drawing.Point(696, 57);
            this.SaveCar.Name = "SaveCar";
            this.SaveCar.Size = new System.Drawing.Size(120, 44);
            this.SaveCar.TabIndex = 17;
            this.SaveCar.Text = "Сохранить";
            this.SaveCar.UseVisualStyleBackColor = true;
            this.SaveCar.Click += new System.EventHandler(this.SaveCar_Click);
            // 
            // DeleteCar
            // 
            this.DeleteCar.Location = new System.Drawing.Point(696, 120);
            this.DeleteCar.Name = "DeleteCar";
            this.DeleteCar.Size = new System.Drawing.Size(120, 44);
            this.DeleteCar.TabIndex = 18;
            this.DeleteCar.Text = "Удалить";
            this.DeleteCar.UseVisualStyleBackColor = true;
            this.DeleteCar.Click += new System.EventHandler(this.DeleteCar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.carBindingSource, "model_id", true));
            this.comboBox1.DataSource = this.modelBindingSource1;
            this.comboBox1.DisplayMember = "car_name";
            this.comboBox1.DropDownHeight = 100;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(16, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 28);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.ValueMember = "model_id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // modelBindingSource1
            // 
            this.modelBindingSource1.DataMember = "model";
            this.modelBindingSource1.DataSource = this.dataSetBuyCar;
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataMember = "model";
            this.modelBindingSource.DataSource = this.dataSetBuyCar;
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // model_idTextBox
            // 
            this.model_idTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.model_idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.model_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "model_id", true));
            this.model_idTextBox.Enabled = false;
            this.model_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.model_idTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.model_idTextBox.Location = new System.Drawing.Point(578, 25);
            this.model_idTextBox.Name = "model_idTextBox";
            this.model_idTextBox.Size = new System.Drawing.Size(168, 2);
            this.model_idTextBox.TabIndex = 20;
            // 
            // model_nameTextBox
            // 
            this.model_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "model_name", true));
            this.model_nameTextBox.Enabled = false;
            this.model_nameTextBox.Location = new System.Drawing.Point(32, 63);
            this.model_nameTextBox.Name = "model_nameTextBox";
            this.model_nameTextBox.Size = new System.Drawing.Size(201, 26);
            this.model_nameTextBox.TabIndex = 22;
            // 
            // car_nameTextBox
            // 
            this.car_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "car_name", true));
            this.car_nameTextBox.Enabled = false;
            this.car_nameTextBox.Location = new System.Drawing.Point(264, 63);
            this.car_nameTextBox.Name = "car_nameTextBox";
            this.car_nameTextBox.Size = new System.Drawing.Size(201, 26);
            this.car_nameTextBox.TabIndex = 24;
            // 
            // equipmentTextBox
            // 
            this.equipmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "equipment", true));
            this.equipmentTextBox.Enabled = false;
            this.equipmentTextBox.Location = new System.Drawing.Point(32, 137);
            this.equipmentTextBox.Name = "equipmentTextBox";
            this.equipmentTextBox.Size = new System.Drawing.Size(201, 26);
            this.equipmentTextBox.TabIndex = 26;
            // 
            // transmissionTextBox
            // 
            this.transmissionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "transmission", true));
            this.transmissionTextBox.Enabled = false;
            this.transmissionTextBox.Location = new System.Drawing.Point(527, 137);
            this.transmissionTextBox.Name = "transmissionTextBox";
            this.transmissionTextBox.Size = new System.Drawing.Size(201, 26);
            this.transmissionTextBox.TabIndex = 28;
            // 
            // trunk_capacityTextBox
            // 
            this.trunk_capacityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "trunk_capacity", true));
            this.trunk_capacityTextBox.Enabled = false;
            this.trunk_capacityTextBox.Location = new System.Drawing.Point(264, 137);
            this.trunk_capacityTextBox.Name = "trunk_capacityTextBox";
            this.trunk_capacityTextBox.Size = new System.Drawing.Size(201, 26);
            this.trunk_capacityTextBox.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.DeleteCar);
            this.groupBox1.Controls.Add(this.SaveCar);
            this.groupBox1.Controls.Add(this.Back);
            this.groupBox1.Controls.Add(this.car_idTextBox);
            this.groupBox1.Controls.Add(model_idLabel);
            this.groupBox1.Controls.Add(state_numberLabel);
            this.groupBox1.Controls.Add(this.state_numberTextBox);
            this.groupBox1.Controls.Add(min_rental_periodLabel);
            this.groupBox1.Controls.Add(this.min_rental_periodTextBox);
            this.groupBox1.Controls.Add(rental_priceLabel);
            this.groupBox1.Controls.Add(this.rental_priceTextBox);
            this.groupBox1.Controls.Add(depositLabel);
            this.groupBox1.Controls.Add(this.depositTextBox);
            this.groupBox1.Controls.Add(damageLabel);
            this.groupBox1.Controls.Add(this.damageTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(38, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 325);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автомобиль";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.model_idTextBox);
            this.groupBox2.Controls.Add(model_nameLabel);
            this.groupBox2.Controls.Add(this.model_nameTextBox);
            this.groupBox2.Controls.Add(car_nameLabel);
            this.groupBox2.Controls.Add(this.car_nameTextBox);
            this.groupBox2.Controls.Add(equipmentLabel);
            this.groupBox2.Controls.Add(this.equipmentTextBox);
            this.groupBox2.Controls.Add(transmissionLabel);
            this.groupBox2.Controls.Add(this.transmissionTextBox);
            this.groupBox2.Controls.Add(trunk_capacityLabel);
            this.groupBox2.Controls.Add(this.trunk_capacityTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(38, 389);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(854, 206);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Технические характеристики автомобиля";
            // 
            // BtnContractById
            // 
            this.BtnContractById.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnContractById.Location = new System.Drawing.Point(38, 625);
            this.BtnContractById.Name = "BtnContractById";
            this.BtnContractById.Size = new System.Drawing.Size(275, 62);
            this.BtnContractById.TabIndex = 33;
            this.BtnContractById.Text = "Договоры с данным автомобилем";
            this.BtnContractById.UseVisualStyleBackColor = true;
            this.BtnContractById.Click += new System.EventHandler(this.BtnContractById_Click);
            // 
            // Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 717);
            this.Controls.Add(this.BtnContractById);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.carBindingNavigator);
            this.Name = "Car";
            this.Text = "Car";
            this.Load += new System.EventHandler(this.Car_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBuyCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingNavigator)).EndInit();
            this.carBindingNavigator.ResumeLayout(false);
            this.carBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetBuyCar dataSetBuyCar;
        private System.Windows.Forms.BindingSource carBindingSource;
        private DataSetBuyCarTableAdapters.carTableAdapter carTableAdapter;
        private DataSetBuyCarTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator carBindingNavigator;
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
        private System.Windows.Forms.TextBox car_idTextBox;
        private System.Windows.Forms.TextBox state_numberTextBox;
        private System.Windows.Forms.TextBox min_rental_periodTextBox;
        private System.Windows.Forms.TextBox rental_priceTextBox;
        private System.Windows.Forms.TextBox depositTextBox;
        private System.Windows.Forms.TextBox damageTextBox;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button SaveCar;
        private System.Windows.Forms.Button DeleteCar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private DataSetBuyCarTableAdapters.modelTableAdapter modelTableAdapter;
        private System.Windows.Forms.TextBox model_idTextBox;
        private System.Windows.Forms.TextBox model_nameTextBox;
        private System.Windows.Forms.TextBox car_nameTextBox;
        private System.Windows.Forms.TextBox equipmentTextBox;
        private System.Windows.Forms.TextBox transmissionTextBox;
        private System.Windows.Forms.TextBox trunk_capacityTextBox;
        private System.Windows.Forms.BindingSource modelBindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnContractById;
    }
}