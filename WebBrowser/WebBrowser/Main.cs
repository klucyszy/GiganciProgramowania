using System;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Main : Form
    {        
        public string HomePageUrl { get; set; } = "www.google.com";
        
        private FavoritesFileRepository _repository = new FavoritesFileRepository();

        public Main()
        {
            InitializeComponent();
            browser.Navigate(HomePageUrl);
            favoritesComboBox.DataSource = _repository.Get();
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
            //1. obsługa prawidłowych adresow np. http://google.com
            string inputText = urlTextBox.Text;
            bool isValidUri = Uri.TryCreate(inputText, UriKind.Absolute, out Uri validUrl) && (validUrl.Scheme == Uri.UriSchemeHttp || validUrl.Scheme == Uri.UriSchemeHttps);
            if (isValidUri)
            {
                browser.Navigate(validUrl);
                return;
            }

            
            //2. Obsluga wpisywania dowolnego tekstu w pasku url
            string googleSearchUrlQuery = "www.google.com/search?q={0}";
            string formattedUrl = string.Empty;
            if (browseMemCheckbox.Checked)
            {
                formattedUrl = string.Format(googleSearchUrlQuery, inputText + " meme");
                browser.Navigate(formattedUrl);
            }
            else
            {
                formattedUrl = string.Format(googleSearchUrlQuery, inputText);
                browser.Navigate(formattedUrl);
            }
        }

        private void addToFavButton_Click(object sender, System.EventArgs e)
        {
            string currentUrl = urlTextBox.Text;
            string title = browser.Document.Title;

            _repository.Add(new Favorite(title, currentUrl));

            //refresh the 'favoritesComboBox' combo box
            favoritesComboBox.DataSource = null;
            favoritesComboBox.DataSource = _repository.Get();

        }

        private void browser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            stopButton.Enabled = false;
            reloadButton.Enabled = true;

            urlTextBox.Text = browser.Url.ToString();

            backButton.Enabled = browser.CanGoBack;
            goForwardButton.Enabled = browser.CanGoForward;

        }

        private void browser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            stopButton.Enabled = true;
            reloadButton.Enabled = false;
        }
    }
}
