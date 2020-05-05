using System;
using System.Windows.Forms;

namespace Samples.Biblioteka
{
    public partial class LoginForm : Form
    {
        private string _login = "admin";
        private string _password = "admin";

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
