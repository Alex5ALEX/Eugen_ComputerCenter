﻿namespace ComputerCenterClient.View.ProductView
{
    partial class ProductRow
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
            labelName = new Label();
            labelNameText = new Label();
            labelPrice = new Label();
            labelPriceText = new Label();
            groupBox1 = new GroupBox();
            labelType = new Label();
            labelTypeText = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F);
            labelName.Location = new Point(18, 28);
            labelName.Name = "labelName";
            labelName.Size = new Size(55, 21);
            labelName.TabIndex = 2;
            labelName.Text = "Name:";
            // 
            // labelNameText
            // 
            labelNameText.AutoSize = true;
            labelNameText.Font = new Font("Segoe UI", 12F);
            labelNameText.Location = new Point(79, 28);
            labelNameText.Name = "labelNameText";
            labelNameText.Size = new Size(94, 21);
            labelNameText.TabIndex = 4;
            labelNameText.Text = "TEXT_NAME";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 12F);
            labelPrice.Location = new Point(18, 59);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(47, 21);
            labelPrice.TabIndex = 13;
            labelPrice.Text = "Price:";
            // 
            // labelPriceText
            // 
            labelPriceText.AutoSize = true;
            labelPriceText.Font = new Font("Segoe UI", 12F);
            labelPriceText.Location = new Point(71, 59);
            labelPriceText.Name = "labelPriceText";
            labelPriceText.Size = new Size(94, 21);
            labelPriceText.TabIndex = 14;
            labelPriceText.Text = "TEXT_EMAIL";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(labelTypeText);
            groupBox1.Controls.Add(labelType);
            groupBox1.Controls.Add(labelNameText);
            groupBox1.Controls.Add(labelPriceText);
            groupBox1.Controls.Add(labelName);
            groupBox1.Controls.Add(labelPrice);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(536, 270);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Segoe UI", 12F);
            labelType.Location = new Point(317, 28);
            labelType.Name = "labelType";
            labelType.Size = new Size(45, 21);
            labelType.TabIndex = 15;
            labelType.Text = "Type:";
            // 
            // labelTypeText
            // 
            labelTypeText.AutoSize = true;
            labelTypeText.Font = new Font("Segoe UI", 12F);
            labelTypeText.Location = new Point(368, 28);
            labelTypeText.Name = "labelTypeText";
            labelTypeText.Size = new Size(43, 21);
            labelTypeText.TabIndex = 16;
            labelTypeText.Text = "label";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(18, 99);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(271, 165);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Provider";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Font = new Font("Segoe UI", 12F);
            groupBox3.Location = new Point(295, 99);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(235, 165);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Manufacture";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 0;
            label1.Text = "Company:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 36);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 66);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 66);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 2;
            label4.Text = "Contact:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 98);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 5;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 98);
            label6.Name = "label6";
            label6.Size = new Size(57, 21);
            label6.TabIndex = 4;
            label6.Text = "Phone:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(64, 129);
            label7.Name = "label7";
            label7.Size = new Size(52, 21);
            label7.TabIndex = 7;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 129);
            label8.Name = "label8";
            label8.Size = new Size(51, 21);
            label8.TabIndex = 6;
            label8.Text = "Email:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 66);
            label9.Name = "label9";
            label9.Size = new Size(52, 21);
            label9.TabIndex = 3;
            label9.Text = "label9";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 36);
            label10.Name = "label10";
            label10.Size = new Size(80, 21);
            label10.TabIndex = 2;
            label10.Text = "Company:";
            // 
            // ProductRow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(groupBox1);
            Name = "ProductRow";
            Size = new Size(536, 270);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label labelName;
        private Label labelNameText;
        private Label labelPrice;
        private Label labelPriceText;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label labelTypeText;
        private Label labelType;
        private GroupBox groupBox3;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label9;
        private Label label10;
    }
}
