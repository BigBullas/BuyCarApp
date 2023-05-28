namespace WindowsFormsApp2
{
    partial class Model_car
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label model_nameLabel;
            System.Windows.Forms.Label car_nameLabel;
            System.Windows.Forms.Label equipmentLabel;
            System.Windows.Forms.Label transmissionLabel;
            System.Windows.Forms.Label trunk_capacityLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Model_car));
            this.modelBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetBuyCar = new WindowsFormsApp2.DataSetBuyCar();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.modelDataGridView = new System.Windows.Forms.DataGridView();
            this.model_idTextBox = new System.Windows.Forms.TextBox();
            this.model_nameTextBox = new System.Windows.Forms.TextBox();
            this.car_nameTextBox = new System.Windows.Forms.TextBox();
            this.equipmentTextBox = new System.Windows.Forms.TextBox();
            this.transmissionTextBox = new System.Windows.Forms.TextBox();
            this.trunk_capacityTextBox = new System.Windows.Forms.TextBox();
            this.DeleteModel = new System.Windows.Forms.Button();
            this.SaveModel = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.modelTableAdapter = new WindowsFormsApp2.DataSetBuyCarTableAdapters.modelTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.DataSetBuyCarTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            model_nameLabel = new System.Windows.Forms.Label();
            car_nameLabel = new System.Windows.Forms.Label();
            equipmentLabel = new System.Windows.Forms.Label();
            transmissionLabel = new System.Windows.Forms.Label();
            trunk_capacityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingNavigator)).BeginInit();
            this.modelBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBuyCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // model_nameLabel
            // 
            model_nameLabel.AutoSize = true;
            model_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            model_nameLabel.Location = new System.Drawing.Point(882, 43);
            model_nameLabel.Name = "model_nameLabel";
            model_nameLabel.Size = new System.Drawing.Size(174, 20);
            model_nameLabel.TabIndex = 4;
            model_nameLabel.Text = "Марка автомобиля:";
            // 
            // car_nameLabel
            // 
            car_nameLabel.AutoSize = true;
            car_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            car_nameLabel.Location = new System.Drawing.Point(882, 107);
            car_nameLabel.Name = "car_nameLabel";
            car_nameLabel.Size = new System.Drawing.Size(203, 20);
            car_nameLabel.TabIndex = 6;
            car_nameLabel.Text = "Название автомобиля:";
            // 
            // equipmentLabel
            // 
            equipmentLabel.AutoSize = true;
            equipmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            equipmentLabel.Location = new System.Drawing.Point(882, 173);
            equipmentLabel.Name = "equipmentLabel";
            equipmentLabel.Size = new System.Drawing.Size(136, 20);
            equipmentLabel.TabIndex = 8;
            equipmentLabel.Text = "Комплектация:";
            // 
            // transmissionLabel
            // 
            transmissionLabel.AutoSize = true;
            transmissionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            transmissionLabel.Location = new System.Drawing.Point(882, 238);
            transmissionLabel.Name = "transmissionLabel";
            transmissionLabel.Size = new System.Drawing.Size(161, 20);
            transmissionLabel.TabIndex = 10;
            transmissionLabel.Text = "Коробка передач:";
            // 
            // trunk_capacityLabel
            // 
            trunk_capacityLabel.AutoSize = true;
            trunk_capacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            trunk_capacityLabel.Location = new System.Drawing.Point(882, 301);
            trunk_capacityLabel.Name = "trunk_capacityLabel";
            trunk_capacityLabel.Size = new System.Drawing.Size(260, 20);
            trunk_capacityLabel.TabIndex = 12;
            trunk_capacityLabel.Text = "Вместительность багажника:";
            // 
            // modelBindingNavigator
            // 
            this.modelBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.modelBindingNavigator.BindingSource = this.modelBindingSource;
            this.modelBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.modelBindingNavigator.DeleteItem = null;
            this.modelBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.modelBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.modelBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.modelBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.modelBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.modelBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.modelBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.modelBindingNavigator.Name = "modelBindingNavigator";
            this.modelBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.modelBindingNavigator.Size = new System.Drawing.Size(1191, 27);
            this.modelBindingNavigator.TabIndex = 0;
            this.modelBindingNavigator.Text = "bindingNavigator1";
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
            // modelBindingSource
            // 
            this.modelBindingSource.DataMember = "model";
            this.modelBindingSource.DataSource = this.dataSetBuyCar;
            this.modelBindingSource.CurrentChanged += new System.EventHandler(this.modelBindingSource_CurrentChanged);
            // 
            // dataSetBuyCar
            // 
            this.dataSetBuyCar.DataSetName = "DataSetBuyCar";
            this.dataSetBuyCar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // modelDataGridView
            // 
            this.modelDataGridView.AutoGenerateColumns = false;
            this.modelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.modelDataGridView.DataSource = this.modelBindingSource;
            this.modelDataGridView.Location = new System.Drawing.Point(32, 96);
            this.modelDataGridView.Name = "modelDataGridView";
            this.modelDataGridView.RowHeadersWidth = 51;
            this.modelDataGridView.RowTemplate.Height = 24;
            this.modelDataGridView.Size = new System.Drawing.Size(796, 337);
            this.modelDataGridView.TabIndex = 1;
            // 
            // model_idTextBox
            // 
            this.model_idTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.model_idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.model_idTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.model_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "model_id", true));
            this.model_idTextBox.Enabled = false;
            this.model_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.model_idTextBox.Location = new System.Drawing.Point(746, 57);
            this.model_idTextBox.Name = "model_idTextBox";
            this.model_idTextBox.Size = new System.Drawing.Size(100, 2);
            this.model_idTextBox.TabIndex = 3;
            // 
            // model_nameTextBox
            // 
            this.model_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "model_name", true));
            this.model_nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.model_nameTextBox.Location = new System.Drawing.Point(886, 66);
            this.model_nameTextBox.Multiline = true;
            this.model_nameTextBox.Name = "model_nameTextBox";
            this.model_nameTextBox.Size = new System.Drawing.Size(249, 28);
            this.model_nameTextBox.TabIndex = 5;
            // 
            // car_nameTextBox
            // 
            this.car_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "car_name", true));
            this.car_nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.car_nameTextBox.Location = new System.Drawing.Point(886, 130);
            this.car_nameTextBox.Multiline = true;
            this.car_nameTextBox.Name = "car_nameTextBox";
            this.car_nameTextBox.Size = new System.Drawing.Size(249, 28);
            this.car_nameTextBox.TabIndex = 7;
            // 
            // equipmentTextBox
            // 
            this.equipmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "equipment", true));
            this.equipmentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equipmentTextBox.Location = new System.Drawing.Point(886, 196);
            this.equipmentTextBox.Multiline = true;
            this.equipmentTextBox.Name = "equipmentTextBox";
            this.equipmentTextBox.Size = new System.Drawing.Size(249, 28);
            this.equipmentTextBox.TabIndex = 9;
            // 
            // transmissionTextBox
            // 
            this.transmissionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "transmission", true));
            this.transmissionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transmissionTextBox.Location = new System.Drawing.Point(886, 261);
            this.transmissionTextBox.Multiline = true;
            this.transmissionTextBox.Name = "transmissionTextBox";
            this.transmissionTextBox.Size = new System.Drawing.Size(249, 28);
            this.transmissionTextBox.TabIndex = 11;
            // 
            // trunk_capacityTextBox
            // 
            this.trunk_capacityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "trunk_capacity", true));
            this.trunk_capacityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trunk_capacityTextBox.Location = new System.Drawing.Point(886, 324);
            this.trunk_capacityTextBox.Multiline = true;
            this.trunk_capacityTextBox.Name = "trunk_capacityTextBox";
            this.trunk_capacityTextBox.Size = new System.Drawing.Size(249, 28);
            this.trunk_capacityTextBox.TabIndex = 13;
            // 
            // DeleteModel
            // 
            this.DeleteModel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeleteModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteModel.Location = new System.Drawing.Point(1015, 369);
            this.DeleteModel.Name = "DeleteModel";
            this.DeleteModel.Size = new System.Drawing.Size(120, 40);
            this.DeleteModel.TabIndex = 14;
            this.DeleteModel.Text = "Удалить";
            this.DeleteModel.UseVisualStyleBackColor = true;
            this.DeleteModel.Click += new System.EventHandler(this.DeleteModel_Click);
            // 
            // SaveModel
            // 
            this.SaveModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveModel.Location = new System.Drawing.Point(886, 369);
            this.SaveModel.Name = "SaveModel";
            this.SaveModel.Size = new System.Drawing.Size(120, 40);
            this.SaveModel.TabIndex = 15;
            this.SaveModel.Text = "Сохранить";
            this.SaveModel.UseVisualStyleBackColor = true;
            this.SaveModel.Click += new System.EventHandler(this.SaveModel_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(32, 43);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(130, 40);
            this.Back.TabIndex = 16;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.contractTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.mechanikTableAdapter = null;
            this.tableAdapterManager.modelTableAdapter = this.modelTableAdapter;
            this.tableAdapterManager.repair_workTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.DataSetBuyCarTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "model_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 35;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "model_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Марка";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "car_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Название авто";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "equipment";
            this.dataGridViewTextBoxColumn4.HeaderText = "Комплектация";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "transmission";
            this.dataGridViewTextBoxColumn5.HeaderText = "Коробка передач";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "trunk_capacity";
            this.dataGridViewTextBoxColumn6.HeaderText = "Вместительность багажника";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Model_car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 506);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.SaveModel);
            this.Controls.Add(this.DeleteModel);
            this.Controls.Add(this.model_idTextBox);
            this.Controls.Add(model_nameLabel);
            this.Controls.Add(this.model_nameTextBox);
            this.Controls.Add(car_nameLabel);
            this.Controls.Add(this.car_nameTextBox);
            this.Controls.Add(equipmentLabel);
            this.Controls.Add(this.equipmentTextBox);
            this.Controls.Add(transmissionLabel);
            this.Controls.Add(this.transmissionTextBox);
            this.Controls.Add(trunk_capacityLabel);
            this.Controls.Add(this.trunk_capacityTextBox);
            this.Controls.Add(this.modelDataGridView);
            this.Controls.Add(this.modelBindingNavigator);
            this.Name = "Model_car";
            this.Text = "Модель автомобиля";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingNavigator)).EndInit();
            this.modelBindingNavigator.ResumeLayout(false);
            this.modelBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBuyCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetBuyCar dataSetBuyCar;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private DataSetBuyCarTableAdapters.modelTableAdapter modelTableAdapter;
        private DataSetBuyCarTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator modelBindingNavigator;
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
        private System.Windows.Forms.DataGridView modelDataGridView;
        private System.Windows.Forms.TextBox model_idTextBox;
        private System.Windows.Forms.TextBox model_nameTextBox;
        private System.Windows.Forms.TextBox car_nameTextBox;
        private System.Windows.Forms.TextBox equipmentTextBox;
        private System.Windows.Forms.TextBox transmissionTextBox;
        private System.Windows.Forms.TextBox trunk_capacityTextBox;
        private System.Windows.Forms.Button DeleteModel;
        private System.Windows.Forms.Button SaveModel;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

