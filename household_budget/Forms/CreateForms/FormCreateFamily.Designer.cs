namespace household_budget.Forms
{
    partial class FormCreateFamily
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
            Button buttonCancel;
            labelSurname = new Label();
            textBoxSurname = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(286, 311);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(48, 123);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(73, 20);
            labelSurname.TabIndex = 0;
            labelSurname.Text = "Фамилия";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(136, 120);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(253, 27);
            textBoxSurname.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(98, 311);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // FormCreateFamily
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 453);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxSurname);
            Controls.Add(labelSurname);
            Name = "FormCreateFamily";
            Text = "Семья";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSurname;
        private TextBox textBoxSurname;
        private Button buttonSave;
    }
}