﻿namespace ComputerCenterClient.View.OrderView.Rows
{
    partial class ServicesShortRow
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 12F);
            numericUpDown1.Location = new Point(204, 48);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 29);
            numericUpDown1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(68, 19);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(6, 50);
            label5.Name = "label5";
            label5.Size = new Size(47, 21);
            label5.TabIndex = 5;
            label5.Text = "Price:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(68, 50);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 6;
            label6.Text = "label6";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 90);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // ServicesShortRow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "ServicesShortRow";
            Size = new Size(330, 90);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
    }
}