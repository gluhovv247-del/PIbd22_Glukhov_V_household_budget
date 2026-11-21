namespace household_budget.Forms
{
    partial class FormCreateBudget
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
            dateTimePickerStartDate = new DateTimePicker();
            labelStartDate = new Label();
            dateTimePickerEndDate = new DateTimePicker();
            labelEndDate = new Label();
            buttonSave = new Button();
            buttonCancel = new Button();
            comboBoxFamily = new ComboBox();
            labelFamily = new Label();
            SuspendLayout();
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.Location = new Point(200, 56);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(250, 27);
            dateTimePickerStartDate.TabIndex = 0;
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Location = new Point(74, 61);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(94, 20);
            labelStartDate.TabIndex = 1;
            labelStartDate.Text = "Дата начала";
            // 
            // dateTimePickerEndDate
            // 
            dateTimePickerEndDate.Location = new Point(203, 123);
            dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            dateTimePickerEndDate.Size = new Size(250, 27);
            dateTimePickerEndDate.TabIndex = 2;
            // 
            // labelEndDate
            // 
            labelEndDate.AutoSize = true;
            labelEndDate.Location = new Point(84, 128);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(87, 20);
            labelEndDate.TabIndex = 3;
            labelEndDate.Text = "Дата конца";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(115, 302);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(302, 302);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // comboBoxFamily
            // 
            comboBoxFamily.FormattingEnabled = true;
            comboBoxFamily.Location = new Point(200, 184);
            comboBoxFamily.Name = "comboBoxFamily";
            comboBoxFamily.Size = new Size(253, 28);
            comboBoxFamily.TabIndex = 6;
            // 
            // labelFamily
            // 
            labelFamily.AutoSize = true;
            labelFamily.Location = new Point(101, 184);
            labelFamily.Name = "labelFamily";
            labelFamily.Size = new Size(53, 20);
            labelFamily.TabIndex = 7;
            labelFamily.Text = "Семья";
            // 
            // FormCreateBudget
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 453);
            Controls.Add(labelFamily);
            Controls.Add(comboBoxFamily);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(labelEndDate);
            Controls.Add(dateTimePickerEndDate);
            Controls.Add(labelStartDate);
            Controls.Add(dateTimePickerStartDate);
            Name = "FormCreateBudget";
            Text = "Бюджет";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerStartDate;
        private Label labelStartDate;
        private DateTimePicker dateTimePickerEndDate;
        private Label labelEndDate;
        private Button buttonSave;
        private Button buttonCancel;
        private ComboBox comboBoxFamily;
        private Label labelFamily;
    }
}