using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunriseClock.Model
{
    [ImplementPropertyChanged]
    class Alarm
    {
        public string Name { get; set; }
        public DateTime AlarmTime { get; set; }
        public int LightDuration { get; set; }
        public int EnlightDuration { get; set; }
        public bool Enabled { get; set; }
    }
}
