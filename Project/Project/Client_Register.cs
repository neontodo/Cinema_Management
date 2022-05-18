using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Client_Register : Form
    {
        private readonly First_Page first_Page;
        private readonly AuthenticationServiceReference.WebAuthenticationSoapClient service;
        private int confirmFlag;
        private System.Timers.Timer secondTimer;
        private System.Timers.Timer limitTimer;

        public Client_Register(First_Page first_Page)
        {
            InitializeComponent();
            service = new AuthenticationServiceReference.WebAuthenticationSoapClient();
            this.first_Page = first_Page;
            confirmFlag = -1;
            secondTimer = new System.Timers.Timer(1000);
            limitTimer = new System.Timers.Timer(5 * 1000);
        }

        public void SetConfirmFlag(int state)
        {
            confirmFlag = state;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            var username = textBoxUserName.Text;
            var name = textBoxName.Text;
            var surname = textBoxSurname.Text;
            var email = textBoxEmail.Text;
            var phone = textBoxPhone.Text;
            var birthDate = textBoxBirthDate.Text;
            var password = textBoxPassword.Text;
            var confirmPassword = textBoxConfirmPassword.Text;

            if(username == "" || name == "" || surname == "" || email == "" || phone == "" || birthDate == "")
            {
                MessageBox.Show("All fields must be completed.", "Error!");
            }
            else if(password.Length < 5)
            {
                MessageBox.Show("The password must have at least 5 characters.", "Error!");
                textBoxPassword.Text = "";
                textBoxConfirmPassword.Text = "";
            }
            else if (!password.Equals(confirmPassword))
            {
                MessageBox.Show("The confirmation password is different from password.", "Error!");
                textBoxPassword.Text = "";
                textBoxConfirmPassword.Text = "";
            }
            else
            {
                var confirmAction = new ConfirmAction(this, null, null);
                confirmAction.Show();
                Hide();

                secondTimer.Elapsed += new System.Timers.ElapsedEventHandler(executeAtOneSecond);
                limitTimer.Elapsed += limitTimer_Elapsed;

                limitTimer.Start();
                secondTimer.Start();

                //for (int i = 0; i < 5; i++)
                //{
                //    Thread.Sleep(1000);

                //    if (confirmFlag == 1)
                //    {
                //        var details = new AuthenticationServiceReference.ArrayOfString
                //        {
                //            textBoxUserName.Text,
                //            textBoxPassword.Text,
                //            textBoxName.Text,
                //            textBoxSurname.Text,
                //            textBoxPhone.Text,
                //            textBoxEmail.Text,
                //            textBoxBirthDate.Text
                //        };

                //        if (service.CreateAccount(details))
                //        {
                //            MessageBox.Show("Account created successfully.", "Success!");
                //        }
                //        else
                //        {
                //            MessageBox.Show("Failed to create account (username might be taken).", "Error!");
                //        }

                //        break;
                //    }

                //    if (confirmFlag == 0)
                //    {
                //        MessageBox.Show("Operation cancelled.", "Success!");
                //        break;
                //    }
                //}

                //if (confirmFlag == -1)
                //{
                //    confirmAction.Close();
                //    Show();
                //    MessageBox.Show("Connection timed out, please try again.", "Error!");
                //}

                //textBoxUserName.Text = "";
                //textBoxName.Text = "";
                //textBoxSurname.Text = "";
                //textBoxEmail.Text = "";
                //textBoxPhone.Text = "";
                //textBoxBirthDate.Text = "";
                //textBoxPassword.Text = "";
                //textBoxConfirmPassword.Text = "";
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            first_Page.Show();
            Close();
        }

        private void executeAtOneSecond(object sender, EventArgs e)
        {
                if (confirmFlag == 1)
                {
                    var details = new AuthenticationServiceReference.ArrayOfString
                    {
                        textBoxUserName.Text,
                        textBoxPassword.Text,
                        textBoxName.Text,
                        textBoxSurname.Text,
                        textBoxPhone.Text,
                        textBoxEmail.Text,
                        textBoxBirthDate.Text
                    };

                    if (service.CreateAccount(details))
                    {
                        MessageBox.Show("Account created successfully.", "Success!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to create account (username might be taken).", "Error!");
                    }
                }

                if (confirmFlag == 0)
                {
                    MessageBox.Show("Operation cancelled.", "Success!");
                }
        }

        private void limitTimer_Elapsed(object sender, EventArgs e)
        {
            if (confirmFlag == -1)
            {
                //confirmAction.Close();
                Show();
                MessageBox.Show("Connection timed out, please try again.", "Error!");
            }

            textBoxUserName.Text = "";
            textBoxName.Text = "";
            textBoxSurname.Text = "";
            textBoxEmail.Text = "";
            textBoxPhone.Text = "";
            textBoxBirthDate.Text = "";
            textBoxPassword.Text = "";
            textBoxConfirmPassword.Text = "";

            secondTimer.Stop();
            limitTimer.Stop();
        }
    }
}
