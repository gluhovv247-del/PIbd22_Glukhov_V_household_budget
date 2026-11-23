using household_budget.Entities;
using household_budget.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace household_budget.Forms
{
    public partial class FormCreateFamily : Form
    {
        private IFamilyRepository _familyRepository;

        private int? _familyId;

        [Browsable(false)]
        [DesignerSerializationVisibility(
            DesignerSerializationVisibility.Hidden)]
        public int Id
        {
            set
            {
                try
                {
                    var family =
                    _familyRepository.ReadFamilyById(value);
                    if (family == null)
                    {
                        throw new
                            InvalidDataException(nameof(family));
                    }
                    textBoxSurname.Text = family.Surname;
                    _familyId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        public FormCreateFamily(IFamilyRepository familyRepository)
        {
            InitializeComponent();
            _familyRepository = familyRepository ?? throw new ArgumentNullException(nameof(familyRepository));
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxSurname.Text))
                {
                    throw new Exception("Имеются незаполненные поля");
                }
                if (_familyId.HasValue)
                {
                    _familyRepository.UpdateFamily(CreateFamily(_familyId.Value));
                }
                else
                {
                    _familyRepository.CreateFamily(CreateFamily(0));
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Family CreateFamily(int id) => Family.CreateFamily(id,
            textBoxSurname.Text);
           

        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }


}

