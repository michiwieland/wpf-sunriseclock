using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SunriseClock.Model
{

    [ImplementPropertyChanged]
    class Configuration
    {
        [JsonProperty("alarms")]
        public ObservableCollection<Alarm> Alarms { get; set; }
    }
}
