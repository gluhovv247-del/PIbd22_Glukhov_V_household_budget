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

        private IBudgetRepository _budgetRepository;

        private IOperationCategoryRepository _operationCategoryRepository;

        private IFamilyMemberRepository _familyMemberRepository;

        private int? _budgetItemId;

        [Browsable(false)]
        [DesignerSerializationVisibility(
            DesignerSerializationVisibility.Hidden)]
        public int Id
        {
            set
            {
                try
                {
                    var budgetItem =
                    _budgetItemRepository.ReadBudgetItemById(value);
                    if (budgetItem == null)
                    {
                        throw new
                            InvalidDataException(nameof(budgetItem));
                    }
                    textBoxAmount.Text = budgetItem.PlannedAmount.ToString();
                    comboBoxBudget.SelectedValue = budgetItem.BudgetId;
                    comboBoxCategoryOperation.SelectedValue = budgetItem.OperationCategoryId;
                    comboBoxFamilyMember.SelectedValue = budgetItem.FamilyMemberId;
                    _budgetItemId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        public FormCreateBudgetItem(
            IBudgetItemRepository budgetItemRepository,
            IBudgetRepository budgetRepository,
            IOperationCategoryRepository operationCategoryRepository,
            IFamilyMemberRepository familyMemberRepository
            )
        {
            InitializeComponent();
            _budgetItemRepository = budgetItemRepository ?? throw new ArgumentNullException(nameof(budgetItemRepository));
            _budgetRepository = budgetRepository ?? throw new ArgumentNullException(nameof(budgetRepository));
            _operationCategoryRepository = operationCategoryRepository ?? throw new ArgumentNullException(nameof(operationCategoryRepository));
            _familyMemberRepository = familyMemberRepository ?? throw new ArgumentNullException(nameof(familyMemberRepository));

            comboBoxBudget.DataSource =
                budgetRepository.ReadBudgets(null, null, null, null);
            comboBoxBudget.DisplayMember = "Id";
            comboBoxBudget.ValueMember = "Id";

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
                    || comboBoxBudget.SelectedIndex < 0
                    || comboBoxCategoryOperation.SelectedIndex < 0
                    || comboBoxFamilyMember.SelectedIndex < 0)
                {
                    throw new Exception("Имеются незаполненные поля");
                }
                if (_budgetItemId.HasValue)
                {
                    _budgetItemRepository.UpdateBudgetItem(CreateBudgetItem(_budgetItemId.Value));
                }
                else
                {
                    _budgetItemRepository.CreateBudgetItem(CreateBudgetItem(0));
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private BudgetItem CreateBudgetItem(int id) => BudgetItem.CreateBudgetItem(id,
            Convert.ToDecimal(textBoxAmount.Text),
            (int)comboBoxBudget.SelectedValue!,
            (int)comboBoxCategoryOperation.SelectedValue!,
            (int)comboBoxFamilyMember.SelectedValue!);

        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }
}
