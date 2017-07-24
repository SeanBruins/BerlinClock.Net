using BerlinClock.Lib;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Threading;

namespace BerlinClock.WPF.ViewModels
{
    internal sealed class BerlinClockViewModel : INotifyPropertyChanged
    {
        private readonly BerlinClockGenerator _clock;
        private readonly DispatcherTimer _timer;
        private long _counter;
        public string TheTime => _clock.Generate(DateTime.Now);

        public BerlinClockViewModel()
        {
            _clock = new BerlinClockGenerator();

            _timer = new DispatcherTimer {Interval = new TimeSpan(0, 0, 0, 0, 5)};
            _timer.Tick += TimerTick;
            _timer.Start();
        }

        private long Counter
        {
            get => _counter;
            set
            {
                _counter = value;
                OnPropertyChanged("Counter");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void TimerTick(object sender, EventArgs e)
        {
            Counter++;
            OnPropertyChanged("TheTime");
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}