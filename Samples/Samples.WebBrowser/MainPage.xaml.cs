using Samples.WebBrowser.Logic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Samples.WebBrowser
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public FavoritesRepository Favorites { get; set; }

        public MainPage()
        {
            InitializeComponent();
            InitializeFavorites();
            InitializeMainPage();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (_webView.CanGoBack)
            {
                _webView.GoBack();
            }           
        }

        private void Forward_Click(object sender, RoutedEventArgs e)
        {
            if (_webView.CanGoForward)
            {
                _webView.GoForward();
            }
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            _webView.Stop();
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            _webView.Refresh();
        }

        private async void Favorite_Click(object sender, RoutedEventArgs e)
        {
            var currentSiteUrl = _webView.Source.ToString();
            var addToFavoritesDialog = new AddToFavorites(currentSiteUrl);
            await addToFavoritesDialog.ShowAsync();

            if(addToFavoritesDialog.Result == AddToFavoritesResult.Add)
            {
                Favorites.Add(addToFavoritesDialog.SiteName, addToFavoritesDialog.SiteUrl);

                //_favoritesComboBox.ItemsSource = Favorites.Get();
            }
        }

        private void _webView_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            //Set the loaded site to _urlTextBox
            _urlTextBox.Text = sender.Source.ToString();

            _backButton.IsEnabled = sender.CanGoBack;
            _forwardButton.IsEnabled = sender.CanGoForward;
        }

        private void _favoritesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = _favoritesComboBox.SelectedItem as Favorite;
            _urlTextBox.Text = selectedItem.SiteUrl.ToString();
            _webView.Navigate(selectedItem.SiteUrl);
        }

        private void InitializeFavorites()
        {
            Favorites = new FavoritesRepository();
            _favoritesComboBox.ItemsSource = Favorites.Get();
        }

        private void InitializeMainPage()
        {
            var appView = ApplicationView.GetForCurrentView();
            appView.Title = "Moja przeglądarka!";
            var homePage = new Uri("https://google.com");
            _webView.Navigate(homePage);
        }
    }
}
