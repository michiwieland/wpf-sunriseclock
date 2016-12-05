using PropertyChanged;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace SunriseClock.Model
{

    [ImplementPropertyChanged]
    public class Configuration
    {
        [JsonProperty("alarms")]
        public ObservableCollection<Alarm> Alarms { get; set; }
    }
}
