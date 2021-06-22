using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormAddCompetition : Form
    {
        private Form1 mainForm;

        public FormAddCompetition(Form1 MainForm)
        {
            mainForm = MainForm;
            InitializeComponent();
        }

        private void addExc_Click(object sender, EventArgs e)
        {
            mainForm.add_Tour(new Compitition(dateTour.Value, new List<Perfomance>(mainForm.Exc)));
            Close();
        }

        private void cancel_Click(object sender, EventArgs e) => Close();

        private void FormAddCompetition_Load(object sender, EventArgs e)
        {

        }
    }
}
