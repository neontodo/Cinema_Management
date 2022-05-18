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
    public partial class ConfirmAction : Form
    {
        Client_Register client_Register;
        MoviesWorkSchedule moviesWorkSchedule;
        Reservations reservations;

        public ConfirmAction(Client_Register client_Register, MoviesWorkSchedule moviesWorkSchedule, Reservations reservations)
        {
            InitializeComponent();
            this.client_Register = client_Register;
            this.moviesWorkSchedule = moviesWorkSchedule;
            this.reservations = reservations;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (client_Register != null)
            {
                client_Register.SetConfirmFlag(0);
                client_Register.Show();
                Close();
            }

            if (moviesWorkSchedule != null)
            {
                throw new NotImplementedException();
            }

            if (reservations != null)
            {
                throw new NotImplementedException();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(client_Register != null)
            {
                client_Register.SetConfirmFlag(1);
                client_Register.Show();
                Close();
            }

            if(moviesWorkSchedule != null)
            {
                throw new NotImplementedException();
            }

            if(reservations != null)
            {
                throw new NotImplementedException();
            }
        }
    }
}
