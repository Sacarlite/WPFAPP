using System.Configuration;
using System.Data;
using System.Windows;

namespace WPFAPP
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        
        private Bootstrapper? _bootstrapper;

        protected override void OnStartup(StartupEventArgs e)
        {
            // Запуск приложения
            _bootstrapper = new Bootstrapper();
            MainWindow = _bootstrapper.Run();
            MainWindow.Show();

            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
        }

    }

}
