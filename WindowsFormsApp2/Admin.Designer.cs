namespace WindowsFormsApp2
{
    partial class Admin
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
            this.Client = new System.Windows.Forms.Button();
            this.Employee = new System.Windows.Forms.Button();
            this.Contract = new System.Windows.Forms.Button();
            this.Car = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Repair = new System.Windows.Forms.Button();
            this.Model_car = new System.Windows.Forms.Button();
            this.Report = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Client
            // 
            this.Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Client.Location = new System.Drawing.Point(46, 198);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(215, 46);
            this.Client.TabIndex = 0;
            this.Client.Text = "Клиенты";
            this.Client.UseVisualStyleBackColor = false;
            this.Client.Click += new System.EventHandler(this.Client_Click);
            // 
            // Employee
            // 
            this.Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employee.Location = new System.Drawing.Point(46, 263);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(215, 46);
            this.Employee.TabIndex = 1;
            this.Employee.Text = "Сотрудники";
            this.Employee.UseVisualStyleBackColor = true;
            this.Employee.Click += new System.EventHandler(this.Employee_Click);
            // 
            // Contract
            // 
            this.Contract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Contract.Location = new System.Drawing.Point(46, 136);
            this.Contract.Name = "Contract";
            this.Contract.Size = new System.Drawing.Size(215, 46);
            this.Contract.TabIndex = 2;
            this.Contract.Text = "Договоры";
            this.Contract.UseVisualStyleBackColor = true;
            this.Contract.Click += new System.EventHandler(this.Contract_Click);
            // 
            // Car
            // 
            this.Car.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Car.Location = new System.Drawing.Point(390, 136);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(215, 46);
            this.Car.TabIndex = 3;
            this.Car.Text = "Автомобили";
            this.Car.UseVisualStyleBackColor = true;
            this.Car.Click += new System.EventHandler(this.Car_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Добро пожаловать, администратор!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Repair
            // 
            this.Repair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Repair.Location = new System.Drawing.Point(46, 327);
            this.Repair.Name = "Repair";
            this.Repair.Size = new System.Drawing.Size(215, 46);
            this.Repair.TabIndex = 6;
            this.Repair.Text = "Ремонт";
            this.Repair.UseVisualStyleBackColor = true;
            this.Repair.Click += new System.EventHandler(this.Repair_Click);
            // 
            // Model_car
            // 
            this.Model_car.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Model_car.Location = new System.Drawing.Point(390, 201);
            this.Model_car.Name = "Model_car";
            this.Model_car.Size = new System.Drawing.Size(215, 46);
            this.Model_car.TabIndex = 7;
            this.Model_car.Text = "Модели автомобилей";
            this.Model_car.UseVisualStyleBackColor = true;
            this.Model_car.Click += new System.EventHandler(this.Model_car_Click);
            // 
            // Report
            // 
            this.Report.BackColor = System.Drawing.SystemColors.Control;
            this.Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Report.Location = new System.Drawing.Point(390, 263);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(215, 46);
            this.Report.TabIndex = 8;
            this.Report.Text = "Отчёты";
            this.Report.UseVisualStyleBackColor = false;
            this.Report.Click += new System.EventHandler(this.Report_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.Control;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(390, 327);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(215, 46);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 444);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.Model_car);
            this.Controls.Add(this.Repair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.Contract);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.Client);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Client;
        private System.Windows.Forms.Button Employee;
        private System.Windows.Forms.Button Contract;
        private System.Windows.Forms.Button Car;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Repair;
        private System.Windows.Forms.Button Model_car;
        private System.Windows.Forms.Button Report;
        private System.Windows.Forms.Button Exit;
    }
}