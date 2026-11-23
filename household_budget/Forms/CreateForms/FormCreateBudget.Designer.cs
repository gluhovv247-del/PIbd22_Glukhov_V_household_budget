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
            dataGridViewBudgetItem = new DataGridView();
            dateTimePickerStartDate = new DateTimePicker();
            labelStartDate = new Label();
            dateTimePickerEndDate = new DateTimePicker();
            labelEndDate = new Label();
            buttonSave = new Button();
            buttonCancel = new Button();
            comboBoxFamily = new ComboBox();
            labelFamily = new Label();
            labelBudgetItems = new Label();
            buttonCreate = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBudgetItem).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewBudgetItem
            // 
            dataGridViewBudgetItem.AllowUserToAddRows = false;
            dataGridViewBudgetItem.AllowUserToDeleteRows = false;
            dataGridViewBudgetItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBudgetItem.Location = new Point(175, 218);
            dataGridViewBudgetItem.Name = "dataGridViewBudgetItem";
            dataGridViewBudgetItem.RowHeadersVisible = false;
            dataGridViewBudgetItem.RowHeadersWidth = 51;
            dataGridViewBudgetItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBudgetItem.Size = new Size(230, 158);
            dataGridViewBudgetItem.TabIndex = 8;
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
            buttonSave.Location = new Point(112, 395);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(311, 395);
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
            // labelBudgetItems
            // 
            labelBudgetItems.AutoSize = true;
            labelBudgetItems.Location = new Point(50, 259);
            labelBudgetItems.Name = "labelBudgetItems";
            labelBudgetItems.Size = new Size(121, 20);
            labelBudgetItems.TabIndex = 9;
            labelBudgetItems.Text = "Статьи бюджета";
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(426, 235);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(94, 29);
            buttonCreate.TabIndex = 10;
            buttonCreate.Text = "Создать";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(426, 297);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 11;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // FormCreateBudget
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 453);
            Controls.Add(buttonDelete);
            Controls.Add(buttonCreate);
            Controls.Add(labelBudgetItems);
            Controls.Add(dataGridViewBudgetItem);
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
            Load += FormCreateBudget_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBudgetItem).EndInit();
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
        private DataGridView dataGridViewBudgetItem;
        private Label labelBudgetItems;
        private Button buttonCreate;
        private Button buttonDelete;
    }
}