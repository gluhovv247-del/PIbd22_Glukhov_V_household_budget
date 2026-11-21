namespace household_budget.Forms.CreateForms
{
    partial class FormCreateCategoryOperation
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
            textBoxName = new TextBox();
            textBoxDescription = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            labelName = new Label();
            labelType = new Label();
            labelDescription = new Label();
            textBoxType = new TextBox();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(230, 55);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(227, 27);
            textBoxName.TabIndex = 0;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(230, 197);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(227, 100);
            textBoxDescription.TabIndex = 2;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(91, 325);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(298, 325);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(61, 58);
            labelName.Name = "labelName";
            labelName.Size = new Size(77, 20);
            labelName.TabIndex = 5;
            labelName.Text = "Название";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(61, 135);
            labelType.Name = "labelType";
            labelType.RightToLeft = RightToLeft.Yes;
            labelType.Size = new Size(35, 20);
            labelType.TabIndex = 6;
            labelType.Text = "Тип";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(61, 204);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(79, 20);
            labelDescription.TabIndex = 7;
            labelDescription.Text = "Описание";
            // 
            // textBoxType
            // 
            textBoxType.Location = new Point(230, 128);
            textBoxType.Name = "textBoxType";
            textBoxType.Size = new Size(227, 27);
            textBoxType.TabIndex = 8;
            // 
            // FormCreateCategoryOperation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 453);
            Controls.Add(textBoxType);
            Controls.Add(labelDescription);
            Controls.Add(labelType);
            Controls.Add(labelName);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxName);
            Name = "FormCreateCategoryOperation";
            Text = "Категория Операции";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxDescription;
        private Button buttonSave;
        private Button buttonCancel;
        private Label labelName;
        private Label labelType;
        private Label labelDescription;
        private TextBox textBoxType;
    }
}