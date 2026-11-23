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
    public partial class FormCreateBudgetItem : Form
    {
        private IBudgetItemRepository _budgetItemRepository;

        private IOperationCategoryRepository _operationCategoryRepository;

        private IFamilyMemberRepository _familyMemberRepository;

        public BudgetItem? CreatedBudgetItem { get; private set; }


        private int? _budgetItemId;

        public FormCreateBudgetItem(
            IBudgetItemRepository budgetItemRepository,
            IBudgetRepository budgetRepository,
            IOperationCategoryRepository operationCategoryRepository,
            IFamilyMemberRepository familyMemberRepository
            )
        {
            InitializeComponent();
            _budgetItemRepository = budgetItemRepository ?? throw new ArgumentNullException(nameof(budgetItemRepository));
            _operationCategoryRepository = operationCategoryRepository ?? throw new ArgumentNullException(nameof(operationCategoryRepository));
            _familyMemberRepository = familyMemberRepository ?? throw new ArgumentNullException(nameof(familyMemberRepository));

            comboBoxCategoryOperation.DataSource =
                operationCategoryRepository.ReadOperationCategories();
            comboBoxCategoryOperation.DisplayMember = "Name";
            comboBoxCategoryOperation.ValueMember = "Id";

            comboBoxFamilyMember.DataSource =
                familyMemberRepository.ReadFamilyMembers();
            comboBoxFamilyMember.DisplayMember = "FirstName";
            comboBoxFamilyMember.ValueMember = "Id";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxAmount.Text)
                    || comboBoxCategoryOperation.SelectedIndex < 0
                    || comboBoxFamilyMember.SelectedIndex < 0)
                {
                    throw new Exception("Имеются незаполненные поля");
                }
                if (!decimal.TryParse(textBoxAmount.Text, out decimal amount))
                {
                    throw new Exception("Некорректная сумма");
                }
                CreatedBudgetItem = BudgetItem.CreateBudgetItem(
                    _budgetItemId ?? 0,
                    amount,
                    0,
                    (int)comboBoxCategoryOperation.SelectedValue!,
                    (int)comboBoxFamilyMember.SelectedValue!
                );
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }
}