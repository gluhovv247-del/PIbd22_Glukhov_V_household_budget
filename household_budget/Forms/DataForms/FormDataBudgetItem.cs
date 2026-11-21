using household_budget.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Unity;
using household_budget.Forms.CreateForms;

namespace household_budget.Forms.DataForms
{
    public partial class FormDataBudgetItem : Form
    {
        private readonly IUnityContainer _container;
        private readonly IBudgetItemRepository _budgetItemRepository;
        public FormDataBudgetItem(
            IUnityContainer container,
            IBudgetItemRepository budgetItemRepository
            )
        {
            InitializeComponent();
            _container = container ??
                throw new ArgumentNullException(nameof(container));
            _budgetItemRepository = budgetItemRepository ??
                throw new ArgumentNullException(nameof(budgetItemRepository));
        }

        private void DataBudgetItemForm_Load(object sender, EventArgs e)
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

        private void LoadList() => dataGridView.DataSource =
            _budgetItemRepository.ReadBudgetItems();
    }
}
