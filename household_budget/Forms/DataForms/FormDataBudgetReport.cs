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
    public partial class FormDataBudgetReport : Form
    {
        private readonly IUnityContainer _container;
        private readonly IBudgetReportRepository _budgetReportRepository;
        public FormDataBudgetReport(
            IUnityContainer container,
            IBudgetReportRepository budgetReportRepository
            )
        {
            InitializeComponent();
            _container = container ??
                throw new ArgumentNullException(nameof(container));
            _budgetReportRepository = budgetReportRepository ??
                throw new ArgumentNullException(nameof(budgetReportRepository));
        }

        private void DataBudgetReportForm_Load(object sender, EventArgs e)
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
                _container.Resolve<FormCreateBudgetReport>().ShowDialog();
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при добавлении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadList() => dataGridView.DataSource =
            _budgetReportRepository.ReadBudgetReports(null, null);

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
