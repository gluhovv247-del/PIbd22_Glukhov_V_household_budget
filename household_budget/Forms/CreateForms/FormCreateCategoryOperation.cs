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
    public partial class FormCreateCategoryOperation : Form
    {
        private IOperationCategoryRepository _operationCategoryRepository;

        private int? _operationCategoryId;

        [Browsable(false)]
        [DesignerSerializationVisibility(
            DesignerSerializationVisibility.Hidden)]
        public int Id
        {
            set
            {
                try
                {
                    var operationCategory =
                    _operationCategoryRepository.ReadOperationCategoryById(value);
                    if (operationCategory == null)
                    {
                        throw new
                            InvalidDataException(nameof(operationCategory));
                    }
                    textBoxName.Text = operationCategory.Name;
                    textBoxType.Text = operationCategory.Type;
                    textBoxDescription.Text = operationCategory.Description;
                    _operationCategoryId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        public FormCreateCategoryOperation(IOperationCategoryRepository operationCategoryRepository)
        {
            InitializeComponent();
            _operationCategoryRepository = operationCategoryRepository ?? throw new ArgumentNullException(nameof(operationCategoryRepository));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxName.Text)
                    || string.IsNullOrWhiteSpace(textBoxType.Text))
                {
                    throw new Exception("Имеются незаполненные поля");
                }
                if (_operationCategoryId.HasValue)
                {
                    _operationCategoryRepository.UpdateOperationCategory(CreateOperationCategory(_operationCategoryId.Value));
                }
                else
                {
                    _operationCategoryRepository.CreateOperationCategory(CreateOperationCategory(0));
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private OperationCategory CreateOperationCategory(int id) => OperationCategory.CreateOperationCategory(id,
            textBoxName.Text,
            textBoxType.Text,
            string.IsNullOrWhiteSpace(textBoxDescription.Text) ? null : textBoxDescription.Text);

        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }
}
