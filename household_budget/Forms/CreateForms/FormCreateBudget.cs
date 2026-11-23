using household_budget.Entities;
using household_budget.Forms.CreateForms;
using household_budget.Repositories;
using System.ComponentModel;
using Unity;

namespace household_budget.Forms
{
    public partial class FormCreateBudget : Form
    {
        private IBudgetRepository _budgetRepository;

        private IBudgetItemRepository _budgetItemRepository;

        private readonly IUnityContainer _container;

        private IFamilyRepository _familyRepository;

        BindingList<BudgetItem> _budgetItems = new BindingList<BudgetItem>();

        public FormCreateBudget(IBudgetRepository budgetRepository, IFamilyRepository familyRepository, IBudgetItemRepository budgetItemRepository, IUnityContainer container)
        {
            InitializeComponent();
            _budgetRepository = budgetRepository ?? throw new ArgumentNullException(nameof(budgetRepository));
            _familyRepository = familyRepository ?? throw new ArgumentNullException(nameof(familyRepository));
            comboBoxFamily.DataSource =
                familyRepository.ReadFamilies();
            comboBoxFamily.DisplayMember = "Family";
            comboBoxFamily.ValueMember = "Id";
            _budgetItemRepository = budgetItemRepository;
            _container = container;
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
                var startDate = DateTime.SpecifyKind(dateTimePickerStartDate.Value, DateTimeKind.Utc);
                var endDate = DateTime.SpecifyKind(dateTimePickerEndDate.Value, DateTimeKind.Utc);

                if (startDate >= endDate)
                {
                    throw new Exception("Дата окончания должна быть позже даты начала");
                }
                _budgetRepository.CreateBudget(Budget.CreateBudget(
                0,
                startDate,
                endDate,
                (int)comboBoxFamily.SelectedValue!), _budgetItems.ToList());
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCreateBudget_Load(object sender, EventArgs e)
        {
            try
            {
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadList() => dataGridViewBudgetItem.DataSource =
            _budgetItems;

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                using var form = _container.Resolve<FormCreateBudgetItem>();
                form.ShowDialog();
                if (form.CreatedBudgetItem != null)
                {
                    _budgetItems.Add(form.CreatedBudgetItem);
                }
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при добавлении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!TryGetIdentifierFromSelectedRow(out var findId))
            {
                return;
            }
            if (MessageBox.Show("Удалить запись?", "Удаление",
            MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            try
            {
                var selectedItem = dataGridViewBudgetItem
                    .SelectedRows[0].DataBoundItem as BudgetItem;

                if (selectedItem == null)
                {
                    throw new Exception("Запись не найдена");
                }
                _budgetItems.Remove(selectedItem);

                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при удалении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool TryGetIdentifierFromSelectedRow(out int id)
        {
            id = 0;
            if (dataGridViewBudgetItem.SelectedRows.Count < 1)
            {
                MessageBox.Show("Нет выбранной записи", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            id =
            Convert.ToInt32(dataGridViewBudgetItem.SelectedRows[0].Cells["Id"].Value);
            return true;

        }
    }

}