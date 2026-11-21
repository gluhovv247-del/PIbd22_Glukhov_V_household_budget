namespace household_budget.Forms.CreateForms
{
    partial class FormCreateBudgetReport
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
            comboBoxBudget = new ComboBox();
            labelBudget = new Label();
            buttonCancel = new Button();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // comboBoxBudget
            // 
            comboBoxBudget.FormattingEnabled = true;
            comboBoxBudget.Location = new Point(227, 53);
            comboBoxBudget.Name = "comboBoxBudget";
            comboBoxBudget.Size = new Size(221, 28);
            comboBoxBudget.TabIndex = 0;
            // 
            // labelBudget
            // 
            labelBudget.AutoSize = true;
            labelBudget.Location = new Point(64, 61);
            labelBudget.Name = "labelBudget";
            labelBudget.Size = new Size(63, 20);
            labelBudget.TabIndex = 1;
            labelBudget.Text = "Бюджет";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(305, 251);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(88, 251);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormCreateBudgetReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 453);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(labelBudget);
            Controls.Add(comboBoxBudget);
            Name = "FormCreateBudgetReport";
            Text = "Отчет по бюджету";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxBudget;
        private Label labelBudget;
        private Button buttonCancel;
        private Button buttonSave;
    }
}