using PropertyChanged;
using RestSharp.Deserializers;
using RestSharp.Serializers;
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

        [DeserializeAs(Name = "name")]
        [SerializeAs(Name = "name")]
        public string Name { get; set; }

        [DeserializeAs(Name = "time")]
        [SerializeAs(Name = "time")]
        public DateTime AlarmTime { get; set; }

        [DeserializeAs(Name = "lightDuration")]
        [SerializeAs(Name = "lightDuration")]
        public int LightDuration { get; set; }

        [DeserializeAs(Name = "enlightDuration")]
        [SerializeAs(Name = "enlightDuration")]
        public int EnlightDuration { get; set; }

        [DeserializeAs(Name = "selected")]
        [SerializeAs(Name = "selected")]
        public bool Enabled { get; set; }
        
        //TODO: This should be a set
        [DeserializeAs(Name = "weekDays")]
        [SerializeAs(Name = "weekDays")]
        public List<Weekday> WeekDays { get; set; }
    }
}
