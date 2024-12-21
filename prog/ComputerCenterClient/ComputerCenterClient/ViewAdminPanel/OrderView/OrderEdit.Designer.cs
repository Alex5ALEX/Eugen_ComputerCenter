﻿namespace ComputerCenterClient.View.OrderView
{
    partial class OrderEdit
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
            groupBox1 = new GroupBox();
            buttonDelete = new Button();
            buttonBack = new Button();
            buttonEdit = new Button();
            dateTimePicker1 = new DateTimePicker();
            groupBox2 = new GroupBox();
            label9 = new Label();
            label10 = new Label();
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabControl = new TabControl();
            PageProduct = new TabPage();
            flowLayoutPanelProduct = new FlowLayoutPanel();
            tabPageServices = new TabPage();
            flowLayoutPanelServices = new FlowLayoutPanel();
            tabPageCustomers = new TabPage();
            flowLayoutPanelCustomers = new FlowLayoutPanel();
            label = new Label();
            labelDate = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControl.SuspendLayout();
            PageProduct.SuspendLayout();
            tabPageServices.SuspendLayout();
            tabPageCustomers.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(buttonDelete);
            groupBox1.Controls.Add(buttonBack);
            groupBox1.Controls.Add(buttonEdit);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(tabControl);
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(labelDate);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(680, 615);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Red;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 12F);
            buttonDelete.ForeColor = SystemColors.ControlText;
            buttonDelete.Location = new Point(106, 558);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(90, 50);
            buttonDelete.TabIndex = 66;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonBack
            // 
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 12F);
            buttonBack.ForeColor = SystemColors.ControlText;
            buttonBack.Location = new Point(10, 558);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(90, 50);
            buttonBack.TabIndex = 65;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.Aqua;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Segoe UI", 12F);
            buttonEdit.ForeColor = SystemColors.ControlText;
            buttonEdit.Location = new Point(202, 558);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(90, 50);
            buttonEdit.TabIndex = 64;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F);
            dateTimePicker1.Location = new Point(16, 91);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(290, 29);
            dateTimePicker1.TabIndex = 63;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(16, 126);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(290, 232);
            groupBox2.TabIndex = 61;
            groupBox2.TabStop = false;
            groupBox2.Text = "Customer";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 194);
            label9.Name = "label9";
            label9.Size = new Size(69, 21);
            label9.TabIndex = 9;
            label9.Text = "Address:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(90, 194);
            label10.Name = "label10";
            label10.Size = new Size(0, 21);
            label10.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 153);
            label7.Name = "label7";
            label7.Size = new Size(51, 21);
            label7.TabIndex = 7;
            label7.Text = "Email:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(96, 153);
            label8.Name = "label8";
            label8.Size = new Size(0, 21);
            label8.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 111);
            label5.Name = "label5";
            label5.Size = new Size(57, 21);
            label5.TabIndex = 5;
            label5.Text = "Phone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(96, 111);
            label6.Name = "label6";
            label6.Size = new Size(0, 21);
            label6.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 73);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 3;
            label3.Text = "Surmane:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 73);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 39);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 39);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(PageProduct);
            tabControl.Controls.Add(tabPageServices);
            tabControl.Controls.Add(tabPageCustomers);
            tabControl.Font = new Font("Segoe UI", 12F);
            tabControl.Location = new Point(312, 19);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(362, 593);
            tabControl.TabIndex = 24;
            // 
            // PageProduct
            // 
            PageProduct.Controls.Add(flowLayoutPanelProduct);
            PageProduct.Location = new Point(4, 30);
            PageProduct.Name = "PageProduct";
            PageProduct.Padding = new Padding(3);
            PageProduct.Size = new Size(354, 559);
            PageProduct.TabIndex = 0;
            PageProduct.Text = "Product";
            PageProduct.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelProduct
            // 
            flowLayoutPanelProduct.AutoScroll = true;
            flowLayoutPanelProduct.Location = new Point(0, 0);
            flowLayoutPanelProduct.Name = "flowLayoutPanelProduct";
            flowLayoutPanelProduct.Size = new Size(354, 560);
            flowLayoutPanelProduct.TabIndex = 0;
            // 
            // tabPageServices
            // 
            tabPageServices.Controls.Add(flowLayoutPanelServices);
            tabPageServices.Location = new Point(4, 30);
            tabPageServices.Name = "tabPageServices";
            tabPageServices.Padding = new Padding(3);
            tabPageServices.Size = new Size(354, 559);
            tabPageServices.TabIndex = 1;
            tabPageServices.Text = "Services";
            tabPageServices.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelServices
            // 
            flowLayoutPanelServices.AutoScroll = true;
            flowLayoutPanelServices.Location = new Point(0, 0);
            flowLayoutPanelServices.Name = "flowLayoutPanelServices";
            flowLayoutPanelServices.Size = new Size(354, 559);
            flowLayoutPanelServices.TabIndex = 0;
            // 
            // tabPageCustomers
            // 
            tabPageCustomers.Controls.Add(flowLayoutPanelCustomers);
            tabPageCustomers.Location = new Point(4, 30);
            tabPageCustomers.Name = "tabPageCustomers";
            tabPageCustomers.Padding = new Padding(3);
            tabPageCustomers.Size = new Size(354, 559);
            tabPageCustomers.TabIndex = 2;
            tabPageCustomers.Text = "Customer";
            tabPageCustomers.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelCustomers
            // 
            flowLayoutPanelCustomers.AutoScroll = true;
            flowLayoutPanelCustomers.Location = new Point(0, 0);
            flowLayoutPanelCustomers.Name = "flowLayoutPanelCustomers";
            flowLayoutPanelCustomers.Size = new Size(354, 560);
            flowLayoutPanelCustomers.TabIndex = 0;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 20F);
            label.Location = new Point(6, 19);
            label.Name = "label";
            label.Size = new Size(138, 37);
            label.TabIndex = 0;
            label.Text = "Edit Order";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 12F);
            labelDate.Location = new Point(18, 67);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(45, 21);
            labelDate.TabIndex = 1;
            labelDate.Text = "Date:";
            // 
            // OrderEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "OrderEdit";
            Size = new Size(680, 615);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabControl.ResumeLayout(false);
            PageProduct.ResumeLayout(false);
            tabPageServices.ResumeLayout(false);
            tabPageCustomers.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox2;
        private Label label9;
        private Label label10;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private TabControl tabControl;
        private TabPage PageProduct;
        private FlowLayoutPanel flowLayoutPanelProduct;
        private TabPage tabPageServices;
        private FlowLayoutPanel flowLayoutPanelServices;
        private TabPage tabPageCustomers;
        private FlowLayoutPanel flowLayoutPanelCustomers;
        private Label label;
        private Label labelDate;
        private Button buttonDelete;
        private Button buttonBack;
        private Button buttonEdit;
    }
}
