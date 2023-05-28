namespace WindowsFormsApp2
{
    partial class Repair
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
            this.label1 = new System.Windows.Forms.Label();
            this.Repair_work = new System.Windows.Forms.Button();
            this.Mechanic = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(105, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ремонт автомобилей";
            // 
            // Repair_work
            // 
            this.Repair_work.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Repair_work.Location = new System.Drawing.Point(151, 121);
            this.Repair_work.Name = "Repair_work";
            this.Repair_work.Size = new System.Drawing.Size(248, 45);
            this.Repair_work.TabIndex = 1;
            this.Repair_work.Text = "Ремонтные работы";
            this.Repair_work.UseVisualStyleBackColor = true;
            this.Repair_work.Click += new System.EventHandler(this.Repair_work_Click);
            // 
            // Mechanic
            // 
            this.Mechanic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mechanic.Location = new System.Drawing.Point(151, 201);
            this.Mechanic.Name = "Mechanic";
            this.Mechanic.Size = new System.Drawing.Size(248, 45);
            this.Mechanic.TabIndex = 2;
            this.Mechanic.Text = "Механики";
            this.Mechanic.UseVisualStyleBackColor = true;
            this.Mechanic.Click += new System.EventHandler(this.Mechanic_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(151, 283);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(248, 45);
            this.Back.TabIndex = 3;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Repair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 441);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Mechanic);
            this.Controls.Add(this.Repair_work);
            this.Controls.Add(this.label1);
            this.Name = "Repair";
            this.Text = "Repair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Repair_work;
        private System.Windows.Forms.Button Mechanic;
        private System.Windows.Forms.Button Back;
    }
}