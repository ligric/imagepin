using System.Windows;

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
    }
}
