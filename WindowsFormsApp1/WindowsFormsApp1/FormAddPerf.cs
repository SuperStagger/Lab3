using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormAddPerf : Form
    {
        private Random rnd = new Random();

        private Form1 mainForm;

        public FormAddPerf(Form1 MainForm)
        {
            mainForm = MainForm;
            InitializeComponent();

            orgExc.Items.AddRange(mainForm.Orgs.ToArray());
        }

        private void addExc_Click(object sender, EventArgs e)
        {
            mainForm.lastChangeEx = new Perfomance((Compititor)orgExc.SelectedItem, Perfomance.formsExc[formExc.SelectedItem.ToString()], rnd.Next(1, 100));
            mainForm.d();
            Close();
        }

        private void cancel_Click(object sender, EventArgs e) => Close();

        private void FormAddExc_Load(object sender, EventArgs e)
        {

        }
    }
}
