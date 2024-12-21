namespace ComputerCenterClient.View.ManufactureView
{
    partial class ManufactureAdd
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
            richTextBox1 = new RichTextBox();
            label = new Label();
            labelName = new Label();
            buttonBack = new Button();
            labelDescription = new Label();
            buttonAdd = new Button();
            textBoxName = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(labelName);
            groupBox1.Controls.Add(buttonBack);
            groupBox1.Controls.Add(labelDescription);
            groupBox1.Controls.Add(buttonAdd);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(340, 615);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 12F);
            richTextBox1.Location = new Point(18, 129);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(291, 268);
            richTextBox1.TabIndex = 56;
            richTextBox1.Text = "";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 20F);
            label.Location = new Point(6, 12);
            label.Name = "label";
            label.Size = new Size(222, 37);
            label.TabIndex = 13;
            label.Text = "Add Manufacture";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F);
            labelName.Location = new Point(18, 49);
            labelName.Name = "labelName";
            labelName.Size = new Size(80, 21);
            labelName.TabIndex = 51;
            labelName.Text = "Company:";
            // 
            // buttonBack
            // 
            buttonBack.BackColor = SystemColors.ControlLightLight;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 12F);
            buttonBack.Location = new Point(6, 552);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(100, 50);
            buttonBack.TabIndex = 25;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 12F);
            labelDescription.Location = new Point(18, 105);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(92, 21);
            labelDescription.TabIndex = 53;
            labelDescription.Text = "Description:";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.SpringGreen;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 12F);
            buttonAdd.Location = new Point(234, 552);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(100, 50);
            buttonAdd.TabIndex = 24;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 12F);
            textBoxName.Location = new Point(18, 73);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(291, 29);
            textBoxName.TabIndex = 55;
            // 
            // ManufactureAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "ManufactureAdd";
            Size = new Size(340, 615);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label;
        private Button buttonBack;
        private Button buttonAdd;
        private RichTextBox richTextBox1;
        private Label labelName;
        private Label labelDescription;
        private TextBox textBoxName;
    }
}
