using System;
using System.Windows.Forms;

namespace Project
{
    public partial class Client_Register : Form
    {
        private readonly First_Page first_Page;
        private readonly AuthenticationServiceReference.WebAuthenticationSoapClient service;
        private int confirmFlag;

        public Client_Register(First_Page first_Page)
        {
            InitializeComponent();
            service = new AuthenticationServiceReference.WebAuthenticationSoapClient();
            this.first_Page = first_Page;
            confirmFlag = -1;
        }

        public void SetConfirmFlag(int state)
        {
            confirmFlag = state;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            first_Page.Show();
            base.OnFormClosing(e);
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

            if (username == "" || name == "" || surname == "" || email == "" || phone == "" || birthDate == "")
            {
                MessageBox.Show("All fields must be completed.", "Error!");
            }
            else if (password.Length < 5)
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
                var del = new ConfirmActionDelegate(executeAfterConfirmation);

                var confirmAction = new ConfirmAction(this, null, null, del);
                confirmAction.Show();
                Hide();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void executeAfterConfirmation()
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
                    MessageBox.Show("Failed to create account. Possible causes:\n  - Username might be taken\n  - Invalid input format for date of birth", "Error!");
                }

                confirmFlag = -1;
            }

            if (confirmFlag == 0)
            {
                MessageBox.Show("Operation cancelled.", "Success!");

                confirmFlag = -1;
            }

            textBoxUserName.Text = "";
            textBoxName.Text = "";
            textBoxSurname.Text = "";
            textBoxEmail.Text = "";
            textBoxPhone.Text = "";
            textBoxBirthDate.Text = "";
            textBoxPassword.Text = "";
            textBoxConfirmPassword.Text = "";
        }
    }
}
