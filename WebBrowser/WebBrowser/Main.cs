using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Main : Form
    {
        public string HomePageUrl { get; set; } = "www.google.com";
        private string _currentUrl = string.Empty;

        public Main()
        {
            InitializeComponent();
            NavigateToUrl();
        }

        private void backButton_Click(object sender, System.EventArgs e)
        {
            browser.GoBack();
        }

        private void goForwardButton_Click(object sender, System.EventArgs e)
        {
            browser.GoForward();
        }

        private void stopButton_Click(object sender, System.EventArgs e)
        {
            browser.Stop();
        }

        private void homeButton_Click(object sender, System.EventArgs e)
        {
            browser.Navigate(HomePageUrl);
        }

        private void reloadButton_Click(object sender, System.EventArgs e)
        {
            browser.Refresh();
        }

        private void searchButton_Click(object sender, System.EventArgs e)
        {
            string url = urlTextBox.Text;
            browser.Navigate(url);
        }

        private void addToFavButton_Click(object sender, System.EventArgs e)
        {
            //TODO: Next lesson
        }

        private void browser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            stopButton.Enabled = false;
            reloadButton.Enabled = true;

            urlTextBox.Text = browser.Url.ToString();

            if (browser.CanGoBack)
            {
                backButton.Enabled = true;
            }
            else
            {
                backButton.Enabled = false;
            }

            if (browser.CanGoForward)
            {
                goForwardButton.Enabled = true;
            }
            else
            {
                goForwardButton.Enabled = false;
            }
        }

        private void browser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            stopButton.Enabled = true;
            reloadButton.Enabled = false;
        }

        // Własne metody
        private void NavigateToUrl()
        {
            _currentUrl = urlTextBox.Text;
            if (string.IsNullOrEmpty(_currentUrl))
            {
                _currentUrl = HomePageUrl;
                browser.Navigate(HomePageUrl);
            }
            else
            {
                browser.Navigate(_currentUrl);
            }

            //obsługa przycisków back i goForward
            //TODO: Wydzielic obsluge przyciskow do oddzielnych metod
            if (browser.CanGoBack)
            {
                backButton.Enabled = true;
            }
            else
            {
                backButton.Enabled = false;
            }

            if (browser.CanGoForward)
            {
                goForwardButton.Enabled = true;
            }
            else
            {
                goForwardButton.Enabled = false;
            }
        }
    }
}
