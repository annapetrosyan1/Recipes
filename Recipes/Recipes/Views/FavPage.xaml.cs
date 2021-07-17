using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Recipes.Views
{
    public partial class FavPage : ContentPage
    {
        public FavPage()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            // Launch the specified URL in the system browser.
            await Launcher.OpenAsync("https://aka.ms/xamarin-quickstart");
        }
    }
}