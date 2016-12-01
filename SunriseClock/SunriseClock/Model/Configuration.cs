using PropertyChanged;
using System;
using System.Collections.Generic;
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
        public List<Alarm> Alarms { get; set; }
    }
}
