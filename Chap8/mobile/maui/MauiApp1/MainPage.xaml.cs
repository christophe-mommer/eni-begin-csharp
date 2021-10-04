using Microsoft.Maui.Controls;
using System;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            label1.Text = "Dernière fois que le bouton a été cliqué : " + DateTime.Now;
            await DisplayAlert("Information", "Vous avez cliqué sur le bouton", "OK");
        }
    }
}
