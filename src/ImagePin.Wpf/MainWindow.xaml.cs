using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace ImagePin.Wpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnWindowActivated(object sender, System.EventArgs e)
        {
            resizeModeControl.Visibility = Visibility.Visible;
        }

        private void OnWindowDeactivated(object sender, System.EventArgs e)
        {
            resizeModeControl.Visibility = Visibility.Collapsed;
        }

        private void ChangeImageClicked(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                image.Source = new BitmapImage(new Uri(openFileDialog.FileName));
        }
    }
}
