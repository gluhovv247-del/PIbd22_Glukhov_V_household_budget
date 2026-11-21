using household_budget.Entities;
using household_budget.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace household_budget.Forms
{
    public partial class FormCreateBudget : Form
    {
        private IBudgetRepository _budgetRepository;

        private IFamilyRepository _familyRepository;
        public FormCreateBudget(IBudgetRepository budgetRepository, IFamilyRepository familyRepository)
        {
            InitializeComponent();
            _budgetRepository = budgetRepository ?? throw new ArgumentNullException(nameof(budgetRepository));
            _familyRepository = familyRepository ?? throw new ArgumentNullException(nameof(familyRepository));
            comboBoxFamily.DataSource =
                familyRepository.ReadFamilies();
            comboBoxFamily.DisplayMember = "Family";
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
                _budgetRepository.CreateBudget(Budget.CreateBudget(
                0,
                dateTimePickerStartDate.Value,
                dateTimePickerEndDate.Value,
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

