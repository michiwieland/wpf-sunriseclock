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
        public Weekday? Monday { get; set; }

        [JsonIgnore]
        public Weekday? Tuesday { get; set; }

        [JsonIgnore]
        public Weekday? Wednesday { get; set; }

        [JsonIgnore]
        public Weekday? Thursday { get; set; }

        [JsonIgnore]
        public Weekday? Friday { get; set; }

        [JsonIgnore]
        public Weekday? Saturday { get; set; }

        [JsonIgnore]
        public Weekday? Sunday { get; set; }

        //TODO: This should be a set
        // [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("weekDays")]
        public List<Weekday> WeekDays
        {
            get
            {
                List<Weekday> weekdays = new List<Weekday>();
                if (Monday != null) weekdays.Add(Weekday.Monday);
                if (Tuesday != null) weekdays.Add(Weekday.Tuesday);
                if (Wednesday != null) weekdays.Add(Weekday.Wednesday);
                if (Thursday != null) weekdays.Add(Weekday.Thursday);
                if (Friday != null) weekdays.Add(Weekday.Friday);
                if (Saturday != null) weekdays.Add(Weekday.Saturday);
                if (Sunday != null) weekdays.Add(Weekday.Sunday);
                return weekdays;
            }
            set
            {
                WeekDays = value;
                foreach (var weekday in value)
                {
                    switch (weekday)
                    {
                        case Weekday.Monday:
                            Monday = Weekday.Monday;
                            break;
                        case Weekday.Tuesday:
                            Tuesday = Weekday.Tuesday;
                            break;
                        case Weekday.Wednesday:
                            Wednesday = Weekday.Wednesday;
                            break;
                        case Weekday.Thursday:
                            Thursday = Weekday.Thursday;
                            break;
                        case Weekday.Friday:
                            Friday = Weekday.Friday;
                            break;
                        case Weekday.Saturday:
                            Saturday = Weekday.Saturday;
                            break;
                        case Weekday.Sunday:
                            Sunday = Weekday.Sunday;
                            break;
                    }
                }
                
            }
        }
    }
}
