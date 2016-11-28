using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunriseClock.Model
{

    [ImplementPropertyChanged]
    class Configuration
    {
        public string Hostname { get; set; }
        public int Port { get; set; }
        public List<Alarm> Alarms { get; set; }
    }
}
