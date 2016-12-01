using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SunriseClock.Model
{
    [ImplementPropertyChanged]
    class Alarm
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("time")]
        public DateTime AlarmTime { get; set; }

        [JsonProperty("lightDuration")]
        public int LightDuration { get; set; }

        [JsonProperty("enlightDuration")]
        public int EnlightDuration { get; set; }

        [JsonProperty("selected")]
        public bool Enabled { get; set; }

        //TODO: This should be a set
        // [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("weekDays")]
        public List<Weekday> WeekDays { get; set; }
    }
}
