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
    public partial class FormCreateForecastcs : Form
    {
        private IBudgetForecastRepository _budgetForecastRepository;

        private IFamilyRepository _familyRepository;

        public FormCreateForecastcs(
            IBudgetForecastRepository budgetForecastRepository,
            IFamilyRepository familyRepository
            )
        {
            InitializeComponent();
            _budgetForecastRepository = budgetForecastRepository ?? throw new ArgumentNullException(nameof(budgetForecastRepository));
            _familyRepository = familyRepository ?? throw new ArgumentNullException(nameof(familyRepository));
            comboBoxFamily.DataSource =
                familyRepository.ReadFamilies();
            comboBoxFamily.DisplayMember = "Surname";
            comboBoxFamily.ValueMember = "Id";
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxFamily.SelectedIndex < 0)
                {
                    throw new Exception("Имеются незаполненные поля");
                }
                _budgetForecastRepository.CreateBudgetForecast(BudgetForecast.CreateBudget(
                0,
                 DateTime.SpecifyKind(dateTimePickerStartDate.Value, DateTimeKind.Utc),
                DateTime.SpecifyKind(dateTimePickerEndDate.Value, DateTimeKind.Utc),
                0,
                0,
                (int)comboBoxFamily.SelectedValue!));
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
