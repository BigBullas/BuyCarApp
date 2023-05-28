namespace WindowsFormsApp2
{
    partial class Report
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
            this.Back = new System.Windows.Forms.Button();
            this.Mechanic = new System.Windows.Forms.Button();
            this.Model_car = new System.Windows.Forms.Button();
            this.RepairWork = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Car = new System.Windows.Forms.Button();
            this.Contract = new System.Windows.Forms.Button();
            this.Employee = new System.Windows.Forms.Button();
            this.Client = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.Control;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(466, 327);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(215, 46);
            this.Back.TabIndex = 18;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Mechanic
            // 
            this.Mechanic.BackColor = System.Drawing.SystemColors.Control;
            this.Mechanic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mechanic.Location = new System.Drawing.Point(466, 263);
            this.Mechanic.Name = "Mechanic";
            this.Mechanic.Size = new System.Drawing.Size(215, 46);
            this.Mechanic.TabIndex = 17;
            this.Mechanic.Text = "Механики";
            this.Mechanic.UseVisualStyleBackColor = false;
            this.Mechanic.Click += new System.EventHandler(this.Mechanic_Click);
            // 
            // Model_car
            // 
            this.Model_car.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Model_car.Location = new System.Drawing.Point(466, 201);
            this.Model_car.Name = "Model_car";
            this.Model_car.Size = new System.Drawing.Size(215, 46);
            this.Model_car.TabIndex = 16;
            this.Model_car.Text = "Модели автомобилей";
            this.Model_car.UseVisualStyleBackColor = true;
            this.Model_car.Click += new System.EventHandler(this.Model_car_Click);
            // 
            // RepairWork
            // 
            this.RepairWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepairWork.Location = new System.Drawing.Point(122, 327);
            this.RepairWork.Name = "RepairWork";
            this.RepairWork.Size = new System.Drawing.Size(215, 46);
            this.RepairWork.TabIndex = 15;
            this.RepairWork.Text = "Ремонтные работы";
            this.RepairWork.UseVisualStyleBackColor = true;
            this.RepairWork.Click += new System.EventHandler(this.RepairWork_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(333, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "Отчёты";
            // 
            // Car
            // 
            this.Car.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Car.Location = new System.Drawing.Point(466, 136);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(215, 46);
            this.Car.TabIndex = 13;
            this.Car.Text = "Автомобили";
            this.Car.UseVisualStyleBackColor = true;
            this.Car.Click += new System.EventHandler(this.Car_Click);
            // 
            // Contract
            // 
            this.Contract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Contract.Location = new System.Drawing.Point(122, 136);
            this.Contract.Name = "Contract";
            this.Contract.Size = new System.Drawing.Size(215, 46);
            this.Contract.TabIndex = 12;
            this.Contract.Text = "Договоры";
            this.Contract.UseVisualStyleBackColor = true;
            this.Contract.Click += new System.EventHandler(this.Contract_Click);
            // 
            // Employee
            // 
            this.Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employee.Location = new System.Drawing.Point(122, 263);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(215, 46);
            this.Employee.TabIndex = 11;
            this.Employee.Text = "Сотрудники";
            this.Employee.UseVisualStyleBackColor = true;
            this.Employee.Click += new System.EventHandler(this.Employee_Click);
            // 
            // Client
            // 
            this.Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Client.Location = new System.Drawing.Point(122, 198);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(215, 46);
            this.Client.TabIndex = 10;
            this.Client.Text = "Клиенты";
            this.Client.UseVisualStyleBackColor = false;
            this.Client.Click += new System.EventHandler(this.Client_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Mechanic);
            this.Controls.Add(this.Model_car);
            this.Controls.Add(this.RepairWork);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.Contract);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.Client);
            this.Name = "Report";
            this.Text = "Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Mechanic;
        private System.Windows.Forms.Button Model_car;
        private System.Windows.Forms.Button RepairWork;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Car;
        private System.Windows.Forms.Button Contract;
        private System.Windows.Forms.Button Employee;
        private System.Windows.Forms.Button Client;
    }
}