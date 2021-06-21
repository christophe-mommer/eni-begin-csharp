using System;
using System.Windows;

namespace DesktopWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            label1.Text = "Dernière fois que le bouton a été cliqué : " + DateTime.Now;
            MessageBox.Show("Vous avez cliqué sur le bouton");
        }
    }
}
