using RVP.Task._4;
using System.Windows;

namespace RVP.Task._4
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            new MainWindow().Show();
        }
    }
}
