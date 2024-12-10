namespace ComputerCenterClient.View.ManufactureView
{
    partial class ManufactureRow
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
            labelDescriptionText = new Label();
            labelDescription = new Label();
            labelNameText = new Label();
            labelName = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelDescriptionText);
            groupBox1.Controls.Add(labelDescription);
            groupBox1.Controls.Add(labelNameText);
            groupBox1.Controls.Add(labelName);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(873, 85);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // labelDescriptionText
            // 
            labelDescriptionText.AutoSize = true;
            labelDescriptionText.Font = new Font("Segoe UI", 12F);
            labelDescriptionText.Location = new Point(88, 49);
            labelDescriptionText.Name = "labelDescriptionText";
            labelDescriptionText.Size = new Size(129, 21);
            labelDescriptionText.TabIndex = 5;
            labelDescriptionText.Text = "TEXT_Description";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 12F);
            labelDescription.Location = new Point(6, 49);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(85, 21);
            labelDescription.TabIndex = 3;
            labelDescription.Text = "Decription:";
            // 
            // labelNameText
            // 
            labelNameText.AutoSize = true;
            labelNameText.Font = new Font("Segoe UI", 12F);
            labelNameText.Location = new Point(88, 19);
            labelNameText.Name = "labelNameText";
            labelNameText.Size = new Size(94, 21);
            labelNameText.TabIndex = 4;
            labelNameText.Text = "TEXT_NAME";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F);
            labelName.Location = new Point(6, 19);
            labelName.Name = "labelName";
            labelName.Size = new Size(80, 21);
            labelName.TabIndex = 2;
            labelName.Text = "Company:";
            // 
            // ManufactureRow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(groupBox1);
            Name = "ManufactureRow";
            Size = new Size(873, 85);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelAddresText;
        private Label labelAddres;
        private Label labelDescriptionText;
        private Label labelEmailText;
        private Label labelDescription;
        private Label labelNameText;
        private Label labelEmail;
        private Label labelName;
    }
}
