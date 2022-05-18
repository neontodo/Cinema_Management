using System;
using System.Windows.Forms;

namespace Project
{
    public partial class First_Page : Form
    {
        private readonly AuthenticationServiceReference.WebAuthenticationSoapClient service;

        public First_Page()
        {
            InitializeComponent();
            service = new AuthenticationServiceReference.WebAuthenticationSoapClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabelCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Client_Register(this).Show();
            Hide();

            textBoxUserName.Text = "";
            textBoxPassword.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userId;
            var username = textBoxUserName.Text;
            var password = textBoxPassword.Text;

            if(username != "" && password != "")
            {
                userId = service.FindAccount(username, password);

                if (userId == -1)
                {
                    MessageBox.Show("User not found.", "Error!");
                }

                if (service.IsClient(userId))
                {
                    new Client(userId, this).Show();
                    Hide();
                }

                if (service.IsEmployee(userId))
                {
                    new MoviesWorkSchedule(userId, this).Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Username and password fields must not be empty.", "Error!");
            }

            textBoxUserName.Text = "";
            textBoxPassword.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
