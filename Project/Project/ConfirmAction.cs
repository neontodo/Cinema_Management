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
    public delegate void ConfirmActionDelegate();

    public partial class ConfirmAction : Form
    {
        private Client_Register client_Register;
        private MoviesWorkSchedule moviesWorkSchedule;
        private Reservations reservations;
        private ConfirmActionDelegate del;

        public ConfirmAction(Client_Register client_Register, MoviesWorkSchedule moviesWorkSchedule, Reservations reservations, ConfirmActionDelegate del)
        {
            InitializeComponent();
            this.client_Register = client_Register;
            this.moviesWorkSchedule = moviesWorkSchedule;
            this.reservations = reservations;
            this.del = del;
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
                moviesWorkSchedule.SetConfirmFlag(0);
                moviesWorkSchedule.Show();
                Close();
            }

            if (reservations != null)
            {
                reservations.SetConfirmFlag(0);
                reservations.Show();
                Close();
            }

            del();
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
                moviesWorkSchedule.SetConfirmFlag(1);
                moviesWorkSchedule.Show();
                Close();
            }

            if(reservations != null)
            {
                reservations.SetConfirmFlag(1);
                reservations.Show();
                Close();
            }

            del();
        }
    }
}
