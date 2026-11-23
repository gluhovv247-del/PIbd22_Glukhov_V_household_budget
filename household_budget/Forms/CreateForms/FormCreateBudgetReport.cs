using household_budget.Entities;
using household_budget.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace household_budget.Forms.CreateForms
{
    public partial class FormCreateBudgetReport : Form
    {
        private IBudgetReportRepository _budgetReportRepository;

        private IBudgetRepository _budgetRepository;

        public FormCreateBudgetReport(
            IBudgetReportRepository budgetReportRepository,
            IBudgetRepository budgetRepository
            )
        {
            InitializeComponent();
            _budgetReportRepository = budgetReportRepository ?? throw new ArgumentNullException(nameof(budgetReportRepository));
            _budgetRepository = budgetRepository ?? throw new ArgumentNullException(nameof(budgetRepository));
            comboBoxBudget.DataSource =
                budgetRepository.ReadBudgets(null, null, null, null);
            comboBoxBudget.DisplayMember = "Id";
            comboBoxBudget.ValueMember = "Id";
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxBudget.SelectedIndex < 0)
                {
                    throw new Exception("Имеются незаполненные поля");
                }
                _budgetReportRepository.CreateBudgetReport(BudgetReport.CreateBudgetReport(
                0,
                0,
                0,
                0,
                0,
                DateTime.UtcNow,
                (int)comboBoxBudget.SelectedValue!));
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
