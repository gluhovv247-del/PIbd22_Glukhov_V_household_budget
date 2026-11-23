namespace household_budget.Forms.CreateForms
{
    partial class FormCreateForecastcs
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
            dateTimePickerEndDate = new DateTimePicker();
            labelStartDate = new Label();
            labelEndDate = new Label();
            buttonSave = new Button();
            buttonCancel = new Button();
            comboBoxFamily = new ComboBox();
            labelFamily = new Label();
            SuspendLayout();
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.Location = new Point(235, 49);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(250, 27);
            dateTimePickerStartDate.TabIndex = 0;
            // 
            // dateTimePickerEndDate
            // 
            dateTimePickerEndDate.Location = new Point(235, 117);
            dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            dateTimePickerEndDate.Size = new Size(250, 27);
            dateTimePickerEndDate.TabIndex = 1;
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Location = new Point(77, 56);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(61, 20);
            labelStartDate.TabIndex = 2;
            labelStartDate.Text = "Начало";
            // 
            // labelEndDate
            // 
            labelEndDate.AutoSize = true;
            labelEndDate.Location = new Point(77, 124);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(53, 20);
            labelEndDate.TabIndex = 3;
            labelEndDate.Text = "Конец";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(93, 306);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(299, 306);
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
            comboBoxFamily.Location = new Point(235, 187);
            comboBoxFamily.Name = "comboBoxFamily";
            comboBoxFamily.Size = new Size(250, 28);
            comboBoxFamily.TabIndex = 6;
            // 
            // labelFamily
            // 
            labelFamily.AutoSize = true;
            labelFamily.Location = new Point(77, 195);
            labelFamily.Name = "labelFamily";
            labelFamily.Size = new Size(53, 20);
            labelFamily.TabIndex = 7;
            labelFamily.Text = "Семья";
            // 
            // FormCreateForecastcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 453);
            Controls.Add(labelFamily);
            Controls.Add(comboBoxFamily);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(labelEndDate);
            Controls.Add(labelStartDate);
            Controls.Add(dateTimePickerEndDate);
            Controls.Add(dateTimePickerStartDate);
            Name = "FormCreateForecastcs";
            Text = "Прогноз";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerStartDate;
        private DateTimePicker dateTimePickerEndDate;
        private Label labelStartDate;
        private Label labelEndDate;
        private Button buttonSave;
        private Button buttonCancel;
        private ComboBox comboBoxFamily;
        private Label labelFamily;
    }
}