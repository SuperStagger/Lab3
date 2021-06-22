using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_3
{
    public partial class AddRoomForm : Form
    {
        private bool saved;
        private bool wantToSave;
        internal Room room;
        internal int index;
        public AddRoomForm()
        {
            InitializeComponent();

            FormClosing += AddRoomForm_FormClosing;

            Array values = Enum.GetValues(typeof(TypeOfRoom));
            foreach (var value in values)
            {
                typeOfRoomComboBox.Items.Add(value);
            }
        }

        private void AddRoomForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved && ValidateChildren())
            {
                DialogResult dr = MessageBox.Show("Are you want to save result?",
                          "Savet", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        wantToSave = true;
                        Save();

                        break;
                    case DialogResult.No:
                        wantToSave = false;
                        break;
                }
                if (!saved && wantToSave)
                    e.Cancel = true;
                else
                    e.Cancel = false;
                if (saved && wantToSave)
                    e.Cancel = false;
            }
        }

        private void typeOfRoomComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (!Enum.GetNames(typeof(TypeOfRoom)).Contains(typeOfRoomComboBox.Text))
            {

                e.Cancel = true;
                typeOfRoomComboBox.Focus();
                errorProvider.SetError(typeOfRoomComboBox, "File is missing in list");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(typeOfRoomComboBox, null);
            }
        }

        private void sizeTextBox_Validating(object sender, CancelEventArgs e)
        {
            var regex = new Regex("^[0-9]+$");
            if (!regex.IsMatch(sizeTextBox.Text))
            {
                e.Cancel = true;
                sizeTextBox.Focus();
                errorProvider.SetError(sizeTextBox, "Name should not be left blank!");

            }
            else if (string.IsNullOrWhiteSpace(sizeTextBox.Text))
            {
                e.Cancel = true;
                sizeTextBox.Focus();
                errorProvider.SetError(sizeTextBox, "TextBox must contains only numbers");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(sizeTextBox, null);
            }
        }

        private void priceTextBox_Validating(object sender, CancelEventArgs e)
        {
            var regex = new Regex("^[0-9]+$");
            if (!regex.IsMatch(priceTextBox.Text))
            {
                e.Cancel = true;
                priceTextBox.Focus();
                errorProvider.SetError(priceTextBox, "Name should not be left blank!");

            }
            else if (string.IsNullOrWhiteSpace(priceTextBox.Text))
            {
                e.Cancel = true;
                priceTextBox.Focus();
                errorProvider.SetError(priceTextBox, "TextBox must contains only numbers");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(priceTextBox, null);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                Close();
            }
        }
        private bool Save()
        {
            if (!ValidateChildren()) return saved;
            var size = int.Parse(sizeTextBox.Text);
            var priceOfCleaning = int.Parse(priceTextBox.Text);
            room = new Room(((TypeOfRoom)typeOfRoomComboBox.SelectedIndex), index, size, priceOfCleaning);
            saved = true;
            return saved;
        }
    }
}
