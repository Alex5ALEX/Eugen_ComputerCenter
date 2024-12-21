namespace ComputerCenterClient.View.ManufactureView
{
    partial class ManufactureEdit
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
            labelName = new Label();
            labelDescription = new Label();
            textBoxName = new TextBox();
            label = new Label();
            buttonDelete = new Button();
            buttonBack = new Button();
            buttonEdit = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(labelName);
            groupBox1.Controls.Add(labelDescription);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(buttonDelete);
            groupBox1.Controls.Add(buttonBack);
            groupBox1.Controls.Add(buttonEdit);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(340, 615);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 12F);
            richTextBox1.Location = new Point(22, 148);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(291, 268);
            richTextBox1.TabIndex = 50;
            richTextBox1.Text = "";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F);
            labelName.Location = new Point(22, 68);
            labelName.Name = "labelName";
            labelName.Size = new Size(80, 21);
            labelName.TabIndex = 43;
            labelName.Text = "Company:";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 12F);
            labelDescription.Location = new Point(22, 124);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(92, 21);
            labelDescription.TabIndex = 45;
            labelDescription.Text = "Description:";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 12F);
            textBoxName.Location = new Point(22, 92);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(291, 29);
            textBoxName.TabIndex = 49;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 20F);
            label.Location = new Point(6, 12);
            label.Name = "label";
            label.Size = new Size(219, 37);
            label.TabIndex = 39;
            label.Text = "Edit Manufacture";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Red;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 12F);
            buttonDelete.ForeColor = SystemColors.ControlText;
            buttonDelete.Location = new Point(120, 552);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(100, 50);
            buttonDelete.TabIndex = 42;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonBack
            // 
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 12F);
            buttonBack.ForeColor = SystemColors.ControlText;
            buttonBack.Location = new Point(3, 552);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(100, 50);
            buttonBack.TabIndex = 41;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.Aqua;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Segoe UI", 12F);
            buttonEdit.ForeColor = SystemColors.ControlText;
            buttonEdit.Location = new Point(237, 552);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(100, 50);
            buttonEdit.TabIndex = 40;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // ManufactureEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "ManufactureEdit";
            Size = new Size(340, 615);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelName;
        private Label labelDescription;
        private TextBox textBoxName;
        private Label label;
        private Button buttonDelete;
        private Button buttonBack;
        private Button buttonEdit;
        private RichTextBox richTextBox1;
    }
}
