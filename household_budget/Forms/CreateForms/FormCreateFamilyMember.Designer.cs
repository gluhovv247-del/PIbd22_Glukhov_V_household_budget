namespace household_budget.Forms.CreateForms
{
    partial class FormCreateFamilyMember
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
            textBoxFirstName = new TextBox();
            labelFirstName = new Label();
            labelFamily = new Label();
            comboBoxFamily = new ComboBox();
            dateTimePickerBirthDate = new DateTimePicker();
            labelBirthDate = new Label();
            comboBoxRole = new ComboBox();
            labelRole = new Label();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(215, 62);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(230, 27);
            textBoxFirstName.TabIndex = 0;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(80, 62);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(39, 20);
            labelFirstName.TabIndex = 1;
            labelFirstName.Text = "Имя";
            // 
            // labelFamily
            // 
            labelFamily.AutoSize = true;
            labelFamily.Location = new Point(80, 122);
            labelFamily.Name = "labelFamily";
            labelFamily.Size = new Size(53, 20);
            labelFamily.TabIndex = 2;
            labelFamily.Text = "Семья";
            // 
            // comboBoxFamily
            // 
            comboBoxFamily.FormattingEnabled = true;
            comboBoxFamily.Location = new Point(215, 122);
            comboBoxFamily.Name = "comboBoxFamily";
            comboBoxFamily.Size = new Size(230, 28);
            comboBoxFamily.TabIndex = 3;
            // 
            // dateTimePickerBirthDate
            // 
            dateTimePickerBirthDate.Location = new Point(215, 185);
            dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            dateTimePickerBirthDate.Size = new Size(230, 27);
            dateTimePickerBirthDate.TabIndex = 4;
            // 
            // labelBirthDate
            // 
            labelBirthDate.AutoSize = true;
            labelBirthDate.Location = new Point(80, 185);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(116, 20);
            labelBirthDate.TabIndex = 5;
            labelBirthDate.Text = "Дата рождения";
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(215, 243);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(230, 28);
            comboBoxRole.TabIndex = 6;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Location = new Point(80, 243);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(42, 20);
            labelRole.TabIndex = 7;
            labelRole.Text = "Роль";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(102, 321);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(286, 321);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormCreateFamilyMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 453);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(labelRole);
            Controls.Add(comboBoxRole);
            Controls.Add(labelBirthDate);
            Controls.Add(dateTimePickerBirthDate);
            Controls.Add(comboBoxFamily);
            Controls.Add(labelFamily);
            Controls.Add(labelFirstName);
            Controls.Add(textBoxFirstName);
            Name = "FormCreateFamilyMember";
            Text = "Член семьи";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFirstName;
        private Label labelFirstName;
        private Label labelFamily;
        private ComboBox comboBoxFamily;
        private DateTimePicker dateTimePickerBirthDate;
        private Label labelBirthDate;
        private ComboBox comboBoxRole;
        private Label labelRole;
        private Button buttonSave;
        private Button buttonCancel;
    }
}