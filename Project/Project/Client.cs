using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Client : Form
    {
        private readonly int userId;
        private readonly First_Page first_Page;
        private readonly ClientServiceReference.WebClientSoapClient service;
        private readonly List<string> cinemaLocations;

        public Client(int userId, First_Page first_Page)
        {
            InitializeComponent();
            this.userId = userId;
            this.first_Page = first_Page;
            service = new ClientServiceReference.WebClientSoapClient();
            cinemaLocations = service.GetAllCinemas();

            initializeCinemaLocationsComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBoxLocations.SelectedItem != null)
            {
                var cinemaLocation = comboBoxLocations.SelectedItem.ToString();
                var cinemaId = service.GetCinemaByLocation(cinemaLocation);

                new Reservations(cinemaId, userId, this).Show();
                Hide();
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            first_Page.Show();
            Close();
        }

        private void initializeCinemaLocationsComboBox()
        {
            foreach(var location in cinemaLocations)
            {
                comboBoxLocations.Items.Add(location);
            }
        }
    }
}
