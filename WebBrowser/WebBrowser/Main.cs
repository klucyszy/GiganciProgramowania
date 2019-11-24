﻿using System;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Main : Form
    {
        private FavoritesFileManager _favoritesFileManager = new FavoritesFileManager();

        public string HomePageUrl { get; set; } = "www.google.com";
        private string _currentUrl = string.Empty;

        public Main()
        {
            InitializeComponent();
            NavigateToUrl();
            _favoritesFileManager.ReadFromFile();
            favoritesComboBox.DataSource = _favoritesFileManager.Favorites;
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
            string inputText = urlTextBox.Text;

            bool isValidUri = Uri.TryCreate(inputText, UriKind.Absolute, out Uri validUrl) && validUrl.Scheme == Uri.UriSchemeHttp;
            if (isValidUri)
            {
                browser.Navigate(validUrl);
                return;
            }

            //Mem browser
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

            _favoritesFileManager.AddToFavorites(currentUrl, title);

            //refresh the 'favoritesComboBox' combo box
            favoritesComboBox.DataSource = null;
            favoritesComboBox.DataSource = _favoritesFileManager.Favorites;

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
