using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static private DataContractSerializerSettings settings = new DataContractSerializerSettings();
        private DataContractSerializer serializer = new DataContractSerializer(typeof(List<Compititor>), settings);

        private Random rnd = new Random();

        private List<Compitition> tours = new List<Compitition>();

        private List<Perfomance> per = new List<Perfomance>();

        private List<Compititor> com = new List<Compititor>();

        public List<Compititor> Orgs
        {
            get => com;
            set => com = value;
        }
        public void OrgsAdd(Compititor o) => com.Add(o);

        public List<Perfomance> Exc
        {
            get => per;
        }

        public Perfomance lastChangeEx;

        public delegate void dForm();
        public dForm d;

        public Form1()
        {
            InitializeComponent();

            /*settings.PreserveObjectReferences = true;
            List<Compititor> restored;
            using (var reader = XmlReader.Create("com.xml"))
            {
                restored = (List<Compititor>)serializer.ReadObject(reader);
            }
            com = restored;*/
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void addTour_Click(object sender, EventArgs e)
        {
            FormAddCompetition addFrom = new FormAddCompetition(this);
            addFrom.ShowDialog();
        }

        public void add_Tour(Compitition t)
        {
            tours.Add(t);
            listTour.Items.Add(t);

            per.Clear();
            listExc.Items.Clear();
        }

        private void addExc_Click(object sender, EventArgs e)
        {
            d = new dForm(AddExcursion);
            openAddExForm();
        }

        private void openAddExForm()
        {
            FormAddPerf addForm = new FormAddPerf(this);
            addForm.ShowDialog();
        }

        public void AddExcursion()
        {
            per.Add(lastChangeEx);
            listExc.Items.Add(lastChangeEx);
        }

        private void listExc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                infoText.Text = "Виступ:\n" + ((Perfomance)listExc.SelectedItem).Info;
            }
            catch { }
        }

        private void listTour_SelectedValueChanged(object sender, EventArgs e)
        {
            updateInfoBox();
        }
        private void updateInfoBox()
        {
            listInfo.Items.Clear();
            try
            {
                Compitition t = (Compitition)listTour.SelectedItem;
                infoText.Text = "Змагання: " + t.Info();
                listInfo.Items.Add("Змагання: " + t);
                foreach (Perfomance ex in t)
                {
                    listInfo.Items.Add(ex);
                }
            }
            catch { }
        }
        private void updateTourBox()
        {
            for (int i = 0; i < listTour.Items.Count; i++)
            {
                listTour.Items[i] = listTour.Items[i];
            }
        }
        private void addEx_Click(object sender, EventArgs e)
        {
            if (listExc.SelectedItem != null && listTour.SelectedItem != null)
            {
                Compitition t = (Compitition)listTour.SelectedItem;
                Perfomance ex = (Perfomance)listExc.SelectedItem;
                t.Add(ex);
                per.Remove(ex);
                listExc.Items.Remove(ex);
                updateInfoBox();
                updateTourBox();
            }
        }

        private void deleteEx_Click(object sender, EventArgs e)
        {
            if (listTour.SelectedItem != null && listInfo.SelectedItem != null)
            {
                try
                {
                    Compitition t = (Compitition)listTour.SelectedItem;
                    Perfomance ex = (Perfomance)listInfo.SelectedItem;
                    t.Remove(ex);
                    updateInfoBox();
                    updateTourBox();
                }
                catch { }
            }
        }

        private void redactEx_Click(object sender, EventArgs e)
        {
            d = new dForm(redEx);
            openAddExForm();
        }

        private void redEx()
        {
            Perfomance Ex = (Perfomance)listInfo.SelectedItem;
            Compitition compitation = (Compitition)listTour.SelectedItem;
            compitation.EXS[compitation.EXS.FindIndex(c => c == Ex)] = new Perfomance(lastChangeEx);
            updateTourBox();
            updateInfoBox();
        }

        private void orgInfo_Click(object sender, EventArgs e)
        {
            FormCompetitorInfo form = new FormCompetitorInfo(this);
            form.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            settings.PreserveObjectReferences = true;
            using (XmlWriter xmlWriter = XmlWriter.Create("com.xml"))
            {
                serializer.WriteObject(xmlWriter, com);
            }
        }
    }
}
