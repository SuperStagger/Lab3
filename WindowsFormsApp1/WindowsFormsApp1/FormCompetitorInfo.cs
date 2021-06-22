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
    public partial class FormCompetitorInfo : Form
    {
        private Form1 mainForm;
        List<Compititor> newOrgs;

        public FormCompetitorInfo(Form1 MainForm)
        {
            mainForm = MainForm;
            InitializeComponent();
            newOrgs = new List<Compititor>(mainForm.Orgs);
            orgList.Items.AddRange(newOrgs.ToArray());
            
        }

        private void addOrg_Click(object sender, EventArgs e)
        {
            Compititor newOrg = new Compititor(orgName.Text, orgSurname.Text, dateTimePicker1.Value);
            newOrgs.Add(newOrg);

            orgList.Items.Add(newOrg);
            orgName.Text = "";
        }

        private void save_Click(object sender, EventArgs e)
        {
            mainForm.Orgs = new List<Compititor>(newOrgs);
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void delOrg_Click(object sender, EventArgs e)
        {
            Compititor delOrg = (Compititor)orgList.SelectedItem;
            newOrgs.Remove(delOrg);
            orgList.Items.Remove(delOrg);

        }

        private void editOrg_Click(object sender, EventArgs e)
        {
            Compititor edtOrg = (Compititor)orgList.SelectedItem;
            newOrgs[newOrgs.FindIndex(c => c == edtOrg)] = new Compititor(orgName.Text, orgSurname.Text, dateTimePicker1.Value);

            orgList.Items.Clear();
            orgList.Items.AddRange(newOrgs.ToArray());
        }

        private void FormCompetitorInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
