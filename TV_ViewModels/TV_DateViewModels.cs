using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgreso3API_ThyaraVintimilla.TV_ViewModels
{
    public class TV_DateViewModel : INotifyPropertyChanged
    {
        DateTime _dateTime;
        Timer _timer;

        public event PropertyChangedEventHandler PropertyChanged;

        public DateTime DateTime
        {
            get => _dateTime; set
            {
                if (_dateTime != value)
                {
                    _dateTime = value;
                    OnPropertyChanged();

                }
            }
        }

        public TV_DateViewModel()
        {
            this.DateTime = DateTime.Now;
            _timer = new Timer(new TimerCallback((s) => this.DateTime = DateTime.Now), null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
        }

        ~TV_DateViewModel() => _timer.Dispose();

        public void OnPropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));




    }
}
