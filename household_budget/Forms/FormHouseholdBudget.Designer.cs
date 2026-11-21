namespace household_budget.Forms
{
    partial class FormHouseholdBudget
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
            pictureBoxBackground = new PictureBox();
            menuStrip1 = new MenuStrip();
            directoriesToolStripMenuItem = new ToolStripMenuItem();
            familiesToolStripMenuItem = new ToolStripMenuItem();
            familyMembersToolStripMenuItem = new ToolStripMenuItem();
            categoryOperationsToolStripMenuItem = new ToolStripMenuItem();
            operationsToolStripMenuItem = new ToolStripMenuItem();
            transactionsToolStripMenuItem = new ToolStripMenuItem();
            budgetToolStripMenuItem = new ToolStripMenuItem();
            budgetItemsToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            budgetReportsToolStripMenuItem = new ToolStripMenuItem();
            forecastsToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackground).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxBackground
            // 
            pictureBoxBackground.Dock = DockStyle.Fill;
            pictureBoxBackground.Image = Properties.Resources.background;
            pictureBoxBackground.Location = new Point(0, 28);
            pictureBoxBackground.Name = "pictureBoxBackground";
            pictureBoxBackground.Size = new Size(800, 422);
            pictureBoxBackground.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBackground.TabIndex = 0;
            pictureBoxBackground.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { directoriesToolStripMenuItem, operationsToolStripMenuItem, reportsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // directoriesToolStripMenuItem
            // 
            directoriesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { familiesToolStripMenuItem, familyMembersToolStripMenuItem, categoryOperationsToolStripMenuItem });
            directoriesToolStripMenuItem.Name = "directoriesToolStripMenuItem";
            directoriesToolStripMenuItem.Size = new Size(117, 24);
            directoriesToolStripMenuItem.Text = "Справочники";
            // 
            // familiesToolStripMenuItem
            // 
            familiesToolStripMenuItem.Name = "familiesToolStripMenuItem";
            familiesToolStripMenuItem.Size = new Size(239, 26);
            familiesToolStripMenuItem.Text = "Семьи";
            familiesToolStripMenuItem.Click += familiesToolStripMenuItem_Click;
            // 
            // familyMembersToolStripMenuItem
            // 
            familyMembersToolStripMenuItem.Name = "familyMembersToolStripMenuItem";
            familyMembersToolStripMenuItem.Size = new Size(239, 26);
            familyMembersToolStripMenuItem.Text = "Участники семей";
            familyMembersToolStripMenuItem.Click += familyMembersToolStripMenuItem_Click;
            // 
            // categoryOperationsToolStripMenuItem
            // 
            categoryOperationsToolStripMenuItem.Name = "categoryOperationsToolStripMenuItem";
            categoryOperationsToolStripMenuItem.Size = new Size(239, 26);
            categoryOperationsToolStripMenuItem.Text = "Категории операций";
            categoryOperationsToolStripMenuItem.Click += categoryOperationsToolStripMenuItem_Click;
            // 
            // operationsToolStripMenuItem
            // 
            operationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { transactionsToolStripMenuItem, budgetToolStripMenuItem, budgetItemsToolStripMenuItem });
            operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            operationsToolStripMenuItem.Size = new Size(95, 24);
            operationsToolStripMenuItem.Text = "Операции";
            // 
            // transactionsToolStripMenuItem
            // 
            transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            transactionsToolStripMenuItem.Size = new Size(242, 26);
            transactionsToolStripMenuItem.Text = "Денежные Операции";
            transactionsToolStripMenuItem.Click += transactionsToolStripMenuItem_Click;
            // 
            // budgetToolStripMenuItem
            // 
            budgetToolStripMenuItem.Name = "budgetToolStripMenuItem";
            budgetToolStripMenuItem.Size = new Size(242, 26);
            budgetToolStripMenuItem.Text = "Бюджет";
            budgetToolStripMenuItem.Click += budgetToolStripMenuItem_Click;
            // 
            // budgetItemsToolStripMenuItem
            // 
            budgetItemsToolStripMenuItem.Name = "budgetItemsToolStripMenuItem";
            budgetItemsToolStripMenuItem.Size = new Size(242, 26);
            budgetItemsToolStripMenuItem.Text = "Бюджет по статьям";
            budgetItemsToolStripMenuItem.Click += budgetItemsToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { budgetReportsToolStripMenuItem, forecastsToolStripMenuItem });
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(73, 24);
            reportsToolStripMenuItem.Text = "Отчеты";
            // 
            // budgetReportsToolStripMenuItem
            // 
            budgetReportsToolStripMenuItem.Name = "budgetReportsToolStripMenuItem";
            budgetReportsToolStripMenuItem.Size = new Size(247, 26);
            budgetReportsToolStripMenuItem.Text = "Выполнение Бюджета";
            budgetReportsToolStripMenuItem.Click += budgetReportsToolStripMenuItem_Click;
            // 
            // forecastsToolStripMenuItem
            // 
            forecastsToolStripMenuItem.Name = "forecastsToolStripMenuItem";
            forecastsToolStripMenuItem.Size = new Size(247, 26);
            forecastsToolStripMenuItem.Text = "Прогнозы";
            forecastsToolStripMenuItem.Click += forecastsToolStripMenuItem_Click;
            // 
            // FormHouseholdBudget
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxBackground);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormHouseholdBudget";
            Text = "Бюджет";
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackground).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxBackground;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem directoriesToolStripMenuItem;
        private ToolStripMenuItem operationsToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem budgetReportsToolStripMenuItem;
        private ToolStripMenuItem forecastsToolStripMenuItem;
        private ToolStripMenuItem familiesToolStripMenuItem;
        private ToolStripMenuItem familyMembersToolStripMenuItem;
        private ToolStripMenuItem categoryOperationsToolStripMenuItem;
        private ToolStripMenuItem transactionsToolStripMenuItem;
        private ToolStripMenuItem budgetToolStripMenuItem;
        private ToolStripMenuItem budgetItemsToolStripMenuItem;
    }
}