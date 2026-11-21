using household_budget.Forms.DataForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Unity;

namespace household_budget.Forms
{
    public partial class FormHouseholdBudget : Form
    {
        private readonly IUnityContainer _container;

        public FormHouseholdBudget(IUnityContainer container)
        {
            InitializeComponent();
            _container = container ??
                throw new ArgumentNullException(nameof(container));
        }

        private void familiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormDataFamily>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void familyMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormDataFamilyMember>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void categoryOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormDataCategoryOperation>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormDataOperation>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void budgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormDataBudget>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void budgetItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormDataBudgetItem>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void budgetReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormDataBudgetReport>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void forecastsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormDataForecasts>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
