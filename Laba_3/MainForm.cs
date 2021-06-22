using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Laba_3
{
    public partial class MainForm : Form
    {
        List<Room> rooms;
        AddAccountForm addAccountForm;
        AddRoomForm addRoomForm;
        DetailViewForm detailView;
        EditAccountingForm editAccountingForm;
        int currentRoom;
        public MainForm()
        {
            InitializeComponent();

            roomsListBox.SelectedValueChanged += RoomsListBox_SelectedValueChanged;
            rooms = new List<Room>();
            currentRoom = 0;
            ValidateChildren();


        }

        private void RoomsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (roomsListBox.SelectedItem != null)
            {
                contentListBox.Items.Clear();
                foreach (var item in ((Room)roomsListBox.SelectedItem).accounting)
                {
                    contentListBox.Items.Add(item);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Add_Animal_Click(object sender, EventArgs e)
        {
            if (roomsListBox.SelectedItem != null)
            {
                addAccountForm = new AddAccountForm();
                addAccountForm.FormClosed += addAccountForm_FormClosed;
                addAccountForm.ShowDialog();
            }
        }

        private void addAccountForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(roomsListBox.SelectedItem != null)
            {
                ((Room)roomsListBox.SelectedItem).accounting.Add(addAccountForm.accounting);
            }
        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            addRoomForm = new AddRoomForm();
            addRoomForm.index = rooms.Count + 1;
            addRoomForm.FormClosed += AddRoomForm_FormClosed;
            addRoomForm.ShowDialog();
        }

        private void AddRoomForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            rooms.Add(addRoomForm.room);
            roomsListBox.Items.Clear();
            foreach (var item in rooms)
            {
                roomsListBox.Items.Add(item);
            }
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void saveRoomsButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog openFileDialog = new SaveFileDialog())
            {
                openFileDialog.AddExtension = true;
                openFileDialog.DefaultExt = ".rfe";
                openFileDialog.Filter = "(*.rfe)|*.rfe";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveTo(rooms, openFileDialog.FileName);
                }
            }
        }
        private void SaveTo(List<Room> rooms, string filePath)
        {
            var serializer = new DataContractSerializer(typeof(List<Room>));
            using (var writer = XmlWriter.Create(filePath))
            {
                serializer.WriteObject(writer, rooms);
            }
        }
        private List<Room> OpenFrom(string filePath)
        {
            if (File.Exists(filePath))
            {
                var serializer = new DataContractSerializer(typeof(List<Room>));
                using (var reader = XmlReader.Create(filePath))
                {
                    var rooms = (List<Room>)serializer.ReadObject(reader);
                    return rooms;
                }
            }
            else
            {
                throw new Exception("File does not exists");
            }
        }

        private void openRoomsButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = false;
                openFileDialog.Filter = "(*.rfe)|*.rfe";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        rooms = OpenFrom(openFileDialog.FileName);
                        roomsListBox.Items.Clear();
                        foreach (var item in rooms)
                        {
                            roomsListBox.Items.Add(item);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Corrupted data");
                    }

                }
            }
        }

        private void detailViewButton_Click(object sender, EventArgs e)
        {
            if (contentListBox.SelectedItem != null)
            {
                detailView = new DetailViewForm(contentListBox.SelectedItem as Accounting);
                detailView.ShowDialog();
            }
            
        }

        private void editListButton_Click(object sender, EventArgs e)
        {
            if (contentListBox.SelectedItem != null)
            {
                editAccountingForm = new EditAccountingForm(contentListBox.SelectedItem as Accounting);
                editAccountingForm.FormClosed += EditAccountingForm_FormClosed;
                editAccountingForm.ShowDialog();
            }
        }

        private void EditAccountingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            rooms[roomsListBox.SelectedIndex].accounting[contentListBox.SelectedIndex] = editAccountingForm.accounting;
            contentListBox.Items.Clear();
            foreach (var item in ((Room)roomsListBox.SelectedItem).accounting)
            {
                contentListBox.Items.Add(item);
            }
        }
    }
}
