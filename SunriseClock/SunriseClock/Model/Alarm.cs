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
    public class Alarm
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

        [JsonIgnore]
        public bool Monday { get; set; }

        [JsonIgnore]
        public bool Tuesday { get; set; }

        [JsonIgnore]
        public bool Wednesday { get; set; }

        [JsonIgnore]
        public bool Thursday { get; set; }

        [JsonIgnore]
        public bool Friday { get; set; }

        [JsonIgnore]
        public bool Saturday { get; set; }

        [JsonIgnore]
        public bool Sunday { get; set; }

        //TODO: This should be a set
        // [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("weekDays")]
        public List<Weekday> WeekDays
        {
            get
            {
                var weekdays = new List<Weekday>();
                if (Monday) weekdays.Add(Weekday.Monday);
                if (Tuesday) weekdays.Add(Weekday.Tuesday);
                if (Wednesday) weekdays.Add(Weekday.Wednesday);
                if (Thursday) weekdays.Add(Weekday.Thursday);
                if (Friday) weekdays.Add(Weekday.Friday);
                if (Saturday) weekdays.Add(Weekday.Saturday);
                if (Sunday) weekdays.Add(Weekday.Sunday);
                return weekdays.Count == 0? null : weekdays;
            }
            set
            {
                foreach (var weekday in value)
                {
                    switch (weekday)
                    {
                        case Weekday.Monday:
                            Monday = true;
                            break;
                        case Weekday.Tuesday:
                            Tuesday = true;
                            break;
                        case Weekday.Wednesday:
                            Wednesday = true;
                            break;
                        case Weekday.Thursday:
                            Thursday = true;
                            break;
                        case Weekday.Friday:
                            Friday = true;
                            break;
                        case Weekday.Saturday:
                            Saturday = true;
                            break;
                        case Weekday.Sunday:
                            Sunday = true;
                            break;
                    }
                }
                
            }
        }
    }
}
