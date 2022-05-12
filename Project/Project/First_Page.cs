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
    public partial class First_Page : Form
    {
        public First_Page()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabelCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Client_Register secondForm = new Client_Register();
            //this.Hide();
            secondForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
