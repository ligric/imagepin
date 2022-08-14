using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media.Imaging;

namespace ImagePin.Wpf
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        #endregion

        private bool _isProportionalResizing = false;

        public bool IsProportionalResizing
        {
            get { return _isProportionalResizing; }
            set
            {
                _isProportionalResizing = value;
                OnPropertyChanged(nameof(IsProportionalResizing));
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void OnWindowActivated(object sender, EventArgs e)
            => resizeModeControl.Visibility = Visibility.Visible;

        private void OnWindowDeactivated(object sender, EventArgs e)
            => resizeModeControl.Visibility = Visibility.Collapsed;

        private void OnCloseClicked(object sender, RoutedEventArgs e)
            => Environment.Exit(0);

        private void ChangeImageClicked(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                image.Source = new BitmapImage(new Uri(openFileDialog.FileName));
        }


    }
}
