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
    public partial class FormDataForecasts : Form
    {
        private readonly IUnityContainer _container;
        private readonly IBudgetForecastRepository _budgetForecastRepository;
        public FormDataForecasts(
            IUnityContainer container,
            IBudgetForecastRepository budgetForecastRepository
            )
        {
            InitializeComponent();
            _container = container ??
                throw new ArgumentNullException(nameof(container));
            _budgetForecastRepository = budgetForecastRepository ??
                throw new ArgumentNullException(nameof(budgetForecastRepository));
        }

        private void DataForecastsForm_Load(object sender, EventArgs e)
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

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormCreateForecastcs>().ShowDialog();
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при добавлении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadList() => dataGridView.DataSource =
            _budgetForecastRepository.ReadBudgetForecasts(null, null, null, null);

        private bool TryGetIdentifierFromSelectedRow(out int id)
        {
            id = 0;
            if (dataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Нет выбранной записи", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            id =
            Convert.ToInt32(dataGridView.SelectedRows[0].Cells["Id"].Value);
            return true;

        }
    }
}
