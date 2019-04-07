using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Samples.WebBrowser
{
    public enum AddToFavoritesResult
    {
        Add,
        Cancel
    }

    public sealed partial class AddToFavorites : ContentDialog
    {
        public AddToFavoritesResult Result { get; set; }
        public string SiteName { get; set; }
        public string SiteUrl { get; set; }

        public AddToFavorites(string siteUrl)
        {
            InitializeComponent();
            _siteUrlTextBox.Text = siteUrl;
        }

        private void ContentDialog_AddClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            Result = AddToFavoritesResult.Add;

            SiteName = _siteNameTextBox.Text;
            SiteUrl = _siteUrlTextBox.Text;
        }

        private void ContentDialog_CancelClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            Result = AddToFavoritesResult.Cancel;
        }
    }
}
