using System;
using System.Windows.Forms;

namespace Samples.Biblioteka
{
    public partial class LoginForm : Form
    {
        private string _login = "user";
        private string _password = "user1234";

        public LoginForm()
        {
            InitializeComponent();
            wrongUserLabel.Visible = false;
            passwordTextBox.PasswordChar = '*';
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool isUsernameValid = loginTextBox.Text.Equals(_login);
            bool isPasswordValid = passwordTextBox.Text.Equals(_password);

            if (isUsernameValid && isPasswordValid)
            {
                var mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                wrongUserLabel.Visible = true;
                loginTextBox.Text = string.Empty;
                passwordTextBox.Text = string.Empty;
            }
        }
    }
}
