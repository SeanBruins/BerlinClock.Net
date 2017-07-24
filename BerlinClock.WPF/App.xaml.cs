using System.Windows;
using BerlinClock.WPF.ViewModels;
using BerlinClock.WPF.Views;

namespace BerlinClock.WPF
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_Startup(object sender, StartupEventArgs e)
        {
            var clockView = new BerlinClockView();
            var clockViewModel = new BerlinClockViewModel();

            clockView.DataContext = clockViewModel;
            clockView.Show();
        }
    }
}