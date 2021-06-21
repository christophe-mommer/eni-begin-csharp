using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DesktopUWP
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                label1.Text = "Dernière fois que le bouton a été cliqué : " + DateTime.Now;
                ContentDialog dialog = new ContentDialog()
                {
                    Title = "Information",
                    Content = "Vous avez cliqué sur le bouton",
                    CloseButtonText = "Ok"
                };

                await dialog.ShowAsync();
            }
            catch { }
        }
    }
}
