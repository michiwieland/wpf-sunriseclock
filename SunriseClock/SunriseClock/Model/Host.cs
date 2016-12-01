using PropertyChanged;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SunriseClock.Model
{
    [ImplementPropertyChanged]
    class Host
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("port")]
        public int Port { get; set; }
    }
}
