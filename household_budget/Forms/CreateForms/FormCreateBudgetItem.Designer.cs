namespace household_budget.Forms.CreateForms
{
    partial class FormCreateBudgetItem
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
            labelAmount = new Label();
            textBoxAmount = new TextBox();
            comboBoxBudget = new ComboBox();
            labelBudget = new Label();
            labelCategory = new Label();
            labelFamilyMember = new Label();
            comboBoxCategoryOperation = new ComboBox();
            comboBoxFamilyMember = new ComboBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Location = new Point(85, 72);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(128, 20);
            labelAmount.TabIndex = 0;
            labelAmount.Text = "Денежная сумма";
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(269, 72);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(198, 27);
            textBoxAmount.TabIndex = 1;
            // 
            // comboBoxBudget
            // 
            comboBoxBudget.FormattingEnabled = true;
            comboBoxBudget.Location = new Point(269, 134);
            comboBoxBudget.Name = "comboBoxBudget";
            comboBoxBudget.Size = new Size(198, 28);
            comboBoxBudget.TabIndex = 2;
            // 
            // labelBudget
            // 
            labelBudget.AutoSize = true;
            labelBudget.Location = new Point(85, 142);
            labelBudget.Name = "labelBudget";
            labelBudget.Size = new Size(63, 20);
            labelBudget.TabIndex = 3;
            labelBudget.Text = "Бюджет";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(85, 202);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(81, 20);
            labelCategory.TabIndex = 4;
            labelCategory.Text = "Категория";
            // 
            // labelFamilyMember
            // 
            labelFamilyMember.AutoSize = true;
            labelFamilyMember.Location = new Point(85, 258);
            labelFamilyMember.Name = "labelFamilyMember";
            labelFamilyMember.Size = new Size(91, 20);
            labelFamilyMember.TabIndex = 5;
            labelFamilyMember.Text = "Член семьи";
            // 
            // comboBoxCategoryOperation
            // 
            comboBoxCategoryOperation.FormattingEnabled = true;
            comboBoxCategoryOperation.Location = new Point(269, 202);
            comboBoxCategoryOperation.Name = "comboBoxCategoryOperation";
            comboBoxCategoryOperation.Size = new Size(198, 28);
            comboBoxCategoryOperation.TabIndex = 6;
            // 
            // comboBoxFamilyMember
            // 
            comboBoxFamilyMember.FormattingEnabled = true;
            comboBoxFamilyMember.Location = new Point(269, 258);
            comboBoxFamilyMember.Name = "comboBoxFamilyMember";
            comboBoxFamilyMember.Size = new Size(198, 28);
            comboBoxFamilyMember.TabIndex = 7;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(105, 334);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(269, 334);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormCreateBudgetItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 453);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxFamilyMember);
            Controls.Add(comboBoxCategoryOperation);
            Controls.Add(labelFamilyMember);
            Controls.Add(labelCategory);
            Controls.Add(labelBudget);
            Controls.Add(comboBoxBudget);
            Controls.Add(textBoxAmount);
            Controls.Add(labelAmount);
            Name = "FormCreateBudgetItem";
            Text = "Статья бюджета";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAmount;
        private TextBox textBoxAmount;
        private ComboBox comboBoxBudget;
        private Label labelBudget;
        private Label labelCategory;
        private Label labelFamilyMember;
        private ComboBox comboBoxCategoryOperation;
        private ComboBox comboBoxFamilyMember;
        private Button buttonSave;
        private Button buttonCancel;
    }
}
