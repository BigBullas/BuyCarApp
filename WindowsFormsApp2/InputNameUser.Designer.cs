namespace WindowsFormsApp2
{
    partial class InputNameUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.WithoutUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(421, 233);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(150, 40);
            this.Back.TabIndex = 7;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Mechanic
            // 
            this.Mechanic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mechanic.Location = new System.Drawing.Point(247, 233);
            this.Mechanic.Name = "Mechanic";
            this.Mechanic.Size = new System.Drawing.Size(150, 40);
            this.Mechanic.TabIndex = 6;
            this.Mechanic.Text = "Продолжить";
            this.Mechanic.UseVisualStyleBackColor = true;
            this.Mechanic.Click += new System.EventHandler(this.Mechanic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(261, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите ФИО:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(247, 153);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 40);
            this.textBox1.TabIndex = 8;
            // 
            // WithoutUser
            // 
            this.WithoutUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WithoutUser.Location = new System.Drawing.Point(247, 297);
            this.WithoutUser.Name = "WithoutUser";
            this.WithoutUser.Size = new System.Drawing.Size(323, 31);
            this.WithoutUser.TabIndex = 9;
            this.WithoutUser.Text = "У меня нет аккаунта";
            this.WithoutUser.UseVisualStyleBackColor = true;
            this.WithoutUser.Click += new System.EventHandler(this.WithoutUser_Click);
            // 
            // InputNameUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WithoutUser);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Mechanic);
            this.Controls.Add(this.label1);
            this.Name = "InputNameUser";
            this.Text = "InputNameUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Mechanic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button WithoutUser;
    }
}