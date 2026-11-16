namespace household_budget.Forms.CreateForms
{
    partial class FormCreateOperation
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
            checkedListBoxImportance = new CheckedListBox();
            label1 = new Label();
            comboBoxCategoryOperation = new ComboBox();
            label2 = new Label();
            comboBoxFamilyMember = new ComboBox();
            label3 = new Label();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // checkedListBoxImportance
            // 
            checkedListBoxImportance.FormattingEnabled = true;
            checkedListBoxImportance.Location = new Point(230, 27);
            checkedListBoxImportance.Name = "checkedListBoxImportance";
            checkedListBoxImportance.Size = new Size(246, 114);
            checkedListBoxImportance.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 43);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 1;
            label1.Text = "Важность операции";
            // 
            // comboBoxCategoryOperation
            // 
            comboBoxCategoryOperation.FormattingEnabled = true;
            comboBoxCategoryOperation.Location = new Point(229, 173);
            comboBoxCategoryOperation.Name = "comboBoxCategoryOperation";
            comboBoxCategoryOperation.Size = new Size(246, 28);
            comboBoxCategoryOperation.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 173);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 3;
            label2.Text = "Категория";
            // 
            // comboBoxFamilyMember
            // 
            comboBoxFamilyMember.FormattingEnabled = true;
            comboBoxFamilyMember.Location = new Point(229, 248);
            comboBoxFamilyMember.Name = "comboBoxFamilyMember";
            comboBoxFamilyMember.Size = new Size(246, 28);
            comboBoxFamilyMember.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 251);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 5;
            label3.Text = "Член семьи";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(118, 327);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(301, 327);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormCreateOperation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 453);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(label3);
            Controls.Add(comboBoxFamilyMember);
            Controls.Add(label2);
            Controls.Add(comboBoxCategoryOperation);
            Controls.Add(label1);
            Controls.Add(checkedListBoxImportance);
            Name = "FormCreateOperation";
            Text = "Операция";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBoxImportance;
        private Label label1;
        private ComboBox comboBoxCategoryOperation;
        private Label label2;
        private ComboBox comboBoxFamilyMember;
        private Label label3;
        private Button buttonSave;
        private Button buttonCancel;
    }
}