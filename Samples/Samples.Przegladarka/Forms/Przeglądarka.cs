using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samples.Przegladarka
{
    public partial class Przeglądarka : Form
    {
        private UserControl _dodajUlubiony; // = null
        private string _homePage = "https://google.com";

        public Przeglądarka()
        {
            InitializeComponent();
            SetHomePage();
        }

        private void SetHomePage()
        {
            this.przegladarkaWebBrowser.Navigate(_homePage);
        }

        private void wsteczButton_Click(object sender, EventArgs e)
        {
            if (this.przegladarkaWebBrowser.CanGoBack)
            {
                this.przegladarkaWebBrowser.GoBack();
            }            
        }

        private void przodButton_Click(object sender, EventArgs e)
        {
            if (this.przegladarkaWebBrowser.CanGoForward)
            {
                this.przegladarkaWebBrowser.GoForward();
            }
        }
        private void zatrzymajButton_Click(object sender, EventArgs e)
        {
            this.przegladarkaWebBrowser.Stop();
        }
        private void odswiezButton_Click(object sender, EventArgs e)
        {
            this.przegladarkaWebBrowser.Refresh();
        }

        private void ulubioneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Dodaj do ulubionych
        private void dodajUlubionyButton_Click(object sender, EventArgs e)
        {
            // sprawdzic czy nie jest nullem (userControl)
            //jezeli nie jest nullem to go zamykamy
            if (_dodajUlubiony != null) _dodajUlubiony.Dispose();

            //tworzymy obiekt naszego userControla
            _dodajUlubiony = new DodajUlubiony(urlTextBox.Text);

            //nowa pozycja userControla
            var xLocation = this.Size.Width / 2 - _dodajUlubiony.Width / 2;
            var yLocation = this.Size.Height / 2 - _dodajUlubiony.Height / 2;
            //ustawiamy nowa pozycje
            _dodajUlubiony.Location = new Point(xLocation, yLocation);

            // do formy dodajemy usercontrol
            this.Controls.Add(_dodajUlubiony);
            _dodajUlubiony.BringToFront();
        }

        private void idzButton_Click(object sender, EventArgs e)
        {

        }

        private void urlTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            var urlText = this.urlTextBox.Text;
            if(e.KeyCode == Keys.Enter)
            {
                if (urlText != string.Empty)
                {
                    Uri result;
                    if(!Uri.TryCreate(urlText, UriKind.Absolute, out result))
                    {
                        MessageBox.Show("Błąd", "Błędny adres",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    this.przegladarkaWebBrowser.Navigate(this.urlTextBox.Text);
                }
            }
        }

        private void przegladarkaWebBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            urlTextBox.Text = przegladarkaWebBrowser.Url.ToString();

            wteczButton.Enabled = true;
            przodButton.Enabled = false;
        }
    }
}
