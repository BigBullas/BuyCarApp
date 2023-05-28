namespace WindowsFormsApp2
{
    partial class User
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
            this.Exit = new System.Windows.Forms.Button();
            this.Model_car = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Car = new System.Windows.Forms.Button();
            this.Contract = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.Control;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(455, 230);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(215, 46);
            this.Exit.TabIndex = 18;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Model_car
            // 
            this.Model_car.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Model_car.Location = new System.Drawing.Point(111, 230);
            this.Model_car.Name = "Model_car";
            this.Model_car.Size = new System.Drawing.Size(215, 46);
            this.Model_car.TabIndex = 16;
            this.Model_car.Text = "Модели автомобилей";
            this.Model_car.UseVisualStyleBackColor = true;
            this.Model_car.Click += new System.EventHandler(this.Model_car_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(105, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "Добро пожаловать, пользователь!";
            // 
            // Car
            // 
            this.Car.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Car.Location = new System.Drawing.Point(455, 151);
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
            this.Contract.Location = new System.Drawing.Point(111, 151);
            this.Contract.Name = "Contract";
            this.Contract.Size = new System.Drawing.Size(215, 46);
            this.Contract.TabIndex = 12;
            this.Contract.Text = "Договоры";
            this.Contract.UseVisualStyleBackColor = true;
            this.Contract.Click += new System.EventHandler(this.Contract_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 378);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Model_car);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.Contract);
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Model_car;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Car;
        private System.Windows.Forms.Button Contract;
    }
}