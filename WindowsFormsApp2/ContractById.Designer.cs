namespace WindowsFormsApp2
{
    partial class ContractById
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
            this.Back = new System.Windows.Forms.Button();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contract_detailedBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetBuyCar = new WindowsFormsApp2.DataSetBuyCar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contract_detailedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractTableAdapter = new WindowsFormsApp2.DataSetBuyCarTableAdapters.contractTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.DataSetBuyCarTableAdapters.TableAdapterManager();
            this.contract_detailedBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new WindowsFormsApp2.DataSetBuyCarTableAdapters.carTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contract_detailedBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBuyCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contract_detailedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contract_detailedBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(65, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(123, 45);
            this.Back.TabIndex = 2;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "car";
            this.carBindingSource.DataSource = this.contract_detailedBindingSource2;
            // 
            // contract_detailedBindingSource2
            // 
            this.contract_detailedBindingSource2.DataSource = this.dataSetBuyCar;
            this.contract_detailedBindingSource2.Position = 0;
            // 
            // dataSetBuyCar
            // 
            this.dataSetBuyCar.DataSetName = "DataSetBuyCar";
            this.dataSetBuyCar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1524, 529);
            this.dataGridView1.TabIndex = 3;
            // 
            // contractBindingSource
            // 
            this.contractBindingSource.DataMember = "contract";
            this.contractBindingSource.DataSource = this.dataSetBuyCar;
            // 
            // contract_detailedBindingSource
            // 
            this.contract_detailedBindingSource.DataSource = this.dataSetBuyCar;
            this.contract_detailedBindingSource.Position = 0;
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
            // contract_detailedBindingSource1
            // 
            this.contract_detailedBindingSource1.DataSource = this.dataSetBuyCar;
            this.contract_detailedBindingSource1.Position = 0;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // ContractById
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 663);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Back);
            this.Name = "ContractById";
            this.Text = "ContractById";
            this.Load += new System.EventHandler(this.ContractByIdEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contract_detailedBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBuyCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contract_detailedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contract_detailedBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSetBuyCar dataSetBuyCar;
        private System.Windows.Forms.BindingSource contractBindingSource;
        private DataSetBuyCarTableAdapters.contractTableAdapter contractTableAdapter;
        private DataSetBuyCarTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.BindingSource contract_detailedBindingSource;
        private System.Windows.Forms.BindingSource contract_detailedBindingSource1;
        private System.Windows.Forms.BindingSource contract_detailedBindingSource2;
        private System.Windows.Forms.BindingSource carBindingSource;
        private DataSetBuyCarTableAdapters.carTableAdapter carTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}