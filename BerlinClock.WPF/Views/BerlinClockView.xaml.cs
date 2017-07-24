using System;
using System.Windows;
using System.Windows.Threading;

namespace BerlinClock.WPF.Views
{
    /// <summary>
    ///     Interaction logic for BerlinClockView.xaml
    /// </summary>
    public partial class BerlinClockView : Window
    {
        public BerlinClockView()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer(new TimeSpan(0, 0, 0, 0, 5), DispatcherPriority.Normal, delegate
            {
                this.DateText.Text = DateTime.Now.ToString("HH:mm:ss");
            }, this.Dispatcher);
        }
    }
}