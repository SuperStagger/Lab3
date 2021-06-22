using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Laba_3
{
    public partial class AddAccountForm : Form
    {
        private bool saved;
        private bool wantToSave;
        internal Accounting accounting;

        public AddAccountForm()
        {
            InitializeComponent();
            saved = false;
        }
        private void TextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Name should not be left blank!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, null);
            }
        }

        private void TextBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                e.Cancel = true;
                textBox2.Focus();
                errorProvider1.SetError(textBox2, "Name should not be left blank!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox2, null);
            }
        }

        private void TextBox3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                e.Cancel = true;
                textBox3.Focus();
                errorProvider1.SetError(textBox3, "Name should not be left blank!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox3, null);
            }
        }
        private void TextBox6_Validating(object sender, CancelEventArgs e)
        {
            var regex = new Regex("^[0-9]+$");
            if (!regex.IsMatch(textBox6.Text))
            {
                e.Cancel = true;
                textBox6.Focus();
                errorProvider1.SetError(textBox6, "Name should not be left blank!");

            }
            else if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                e.Cancel = true;
                textBox6.Focus();
                errorProvider1.SetError(textBox6, "TextBox must contains only numbers");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox6, null);
            }
        }

        private void AddAnimal_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                Close();
            }
        }
        private bool Save()
        {
            if (!ValidateChildren()) return saved;
            var species = textBox1.Text;
            var country = textBox2.Text;
            var name = textBox3.Text;
            var dateOfBirth = dateTimePicker1.Value;
            var dateOfArrival = dateTimePicker2.Value;
            var cost = textBox6.Text;
            accounting = new Accounting(new Animal(species, country, name, dateOfBirth), dateOfArrival, int.Parse(cost));
            saved = true;
            return saved;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
