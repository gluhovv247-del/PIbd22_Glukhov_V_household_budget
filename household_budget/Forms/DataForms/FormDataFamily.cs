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

namespace household_budget.Forms.DataForms
{
    public partial class FormDataFamily : Form
    {
        private readonly IUnityContainer _container;
        private readonly IFamilyRepository _familyRepository;
        public FormDataFamily(
            IUnityContainer container,
            IFamilyRepository familyRepository
            )
        {
            InitializeComponent();
            _container = container ??
                throw new ArgumentNullException(nameof(container));
            _familyRepository = familyRepository ??
                throw new ArgumentNullException(nameof(familyRepository));
        }

        private void DataFamilyForm_Load(object sender, EventArgs e)
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
                _container.Resolve<FormCreateFamily>().ShowDialog();
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при добавлении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!TryGetIdentifierFromSelectedRow(out var findId))
            {
                return;
            }
            try
            {
                var form = _container.Resolve<FormCreateFamily>();
                form.Id = findId;
                form.ShowDialog();
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при изменении",
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
                _familyRepository.DeleteFamily(findId);
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при удалении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadList() => dataGridView.DataSource =
            _familyRepository.ReadFamilies();

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
