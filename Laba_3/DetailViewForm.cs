using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_3
{
    public partial class DetailViewForm : Form
    {
        public DetailViewForm()
        {
            InitializeComponent();
        }

        internal DetailViewForm(Accounting accounting)
        {
            InitializeComponent();
            nameLabel.Text = accounting.animal.name;
            priceLabel.Text = $"{accounting.price}";
            dateOfArrivalLabel.Text = accounting.dateOfArrival.ToString();
            countryLabel.Text = accounting.animal.country;
            speciesLabel.Text = accounting.animal.species;
            dateOfBirthLabel.Text = accounting.animal.dateOfBirth.ToString();
        }
    }
}
