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
    class Configuration
    {
        public Configuration() { }
        [DeserializeAs(Name = "alarms")]
        [SerializeAs(Name = "alarms")]
        public List<Alarm> Alarms { get; set; }
    }
}
