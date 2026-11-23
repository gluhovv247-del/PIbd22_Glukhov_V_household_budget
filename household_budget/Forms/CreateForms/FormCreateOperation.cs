using household_budget.Entities;
using household_budget.Entities.Enums;
using household_budget.Repositories;
using household_budget.Repositories.Implementations;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace household_budget.Forms.CreateForms
{
    public partial class FormCreateOperation : Form
    {
        private IOperationRepository _operationRepository;

        private IOperationCategoryRepository _operationCategoryRepository;

        private IFamilyMemberRepository _familyMemberRepository;

        public FormCreateOperation(
            IOperationRepository operationRepository,
            IOperationCategoryRepository operationCategoryRepository,
            IFamilyMemberRepository familyMemberRepository
            )
        {
            InitializeComponent();
            _operationRepository = operationRepository ?? throw new ArgumentNullException(nameof(operationRepository));
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

            foreach (var elem in Enum.GetValues(typeof(OperationImportance)))
            {
                checkedListBoxImportance.Items.Add(elem);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxFamilyMember.SelectedIndex < 0
                    || comboBoxCategoryOperation.SelectedIndex < 0)
                {
                    throw new Exception("Имеются незаполненные поля");
                }
                _operationRepository.CreateOperation(CreateOperation(0));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Operation CreateOperation(int id)
        {
            OperationImportance importance = OperationImportance.None;
            foreach (var elem in checkedListBoxImportance.CheckedItems)
            {
                importance |= (OperationImportance)elem;
            }
            return Operation.CreateOperation(
                id,
                DateTime.Now,
                (int)comboBoxCategoryOperation.SelectedIndex,
                importance,
                (int)comboBoxFamilyMember.SelectedIndex
            );
        }

    }
}

    
