using household_budget.Entities;
using household_budget.Entities.Enums;
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
    public partial class FormCreateFamilyMember : Form
    {
        private IFamilyMemberRepository _familyMemberRepository;

        private IFamilyRepository _familyRepository;

        private int? _familyMemberId;

        [Browsable(false)]
        [DesignerSerializationVisibility(
            DesignerSerializationVisibility.Hidden)]
        public int Id
        {
            set
            {
                try
                {
                    var familyMember =
                    _familyMemberRepository.ReadFamilyMemberById(value);
                    if (familyMember == null)
                    {
                        throw new
                            InvalidDataException(nameof(familyMember));
                    }
                    textBoxFirstName.Text = familyMember.FirstName;
                    comboBoxFamily.SelectedValue = familyMember.FamilyId;
                    dateTimePickerBirthDate.Value = familyMember.BirthDate;
                    comboBoxRole.SelectedItem = familyMember.Role;
                    _familyMemberId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        public FormCreateFamilyMember(
            IFamilyMemberRepository familyMemberRepository,
            IFamilyRepository familyRepository
            )
        {
            InitializeComponent();
            _familyMemberRepository = familyMemberRepository ?? throw new ArgumentNullException(nameof(familyMemberRepository));
            _familyRepository = familyRepository ?? throw new ArgumentNullException(nameof(familyRepository));

            comboBoxFamily.DataSource =
                familyRepository.ReadFamilies();
            comboBoxFamily.DisplayMember = "Surname";
            comboBoxFamily.ValueMember = "Id";

            comboBoxRole.DataSource = Enum.GetValues(typeof(FamilyRole));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxFirstName.Text)
                    || comboBoxFamily.SelectedIndex < 0
                    || comboBoxRole.SelectedIndex < 0)
                {
                    throw new Exception("Имеются незаполненные поля");
                }
                if (_familyMemberId.HasValue)
                {
                    _familyMemberRepository.UpdateFamilyMember(CreateFamilyMember(_familyMemberId.Value));
                }
                else
                {
                    _familyMemberRepository.CreateFamilyMember(CreateFamilyMember(0));
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private FamilyMember CreateFamilyMember(int id) => FamilyMember.CreateFamilyMember(id,
            textBoxFirstName.Text,
            (int)comboBoxFamily.SelectedValue!,
            DateTime.SpecifyKind(dateTimePickerBirthDate.Value, DateTimeKind.Utc),
            (FamilyRole)comboBoxRole.SelectedItem!);

        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }
}
