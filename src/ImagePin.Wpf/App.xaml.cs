using System.Windows;

namespace ImagePin.Wpf
{
    public partial class App : Application
    {
        private void OnApplicationStartup(object sender, StartupEventArgs e)
        {
            MainWindow = new MainWindow();
            MainWindow.Show();
        }
    }
}
