using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace SunriseClock.Model
{
    // TODO: Serialization as string names
    enum Weekday
    {
        [JsonProperty("monday")]
        Monday = 1,
        [JsonProperty("tuesday")]
        Tuesday = 2,
        [JsonProperty("wednesday")]
        Wednesday = 3,
        [JsonProperty("thursday")]
        Thursday = 4,
        [JsonProperty("friday")]
        Friday = 5,
        [JsonProperty("saturday")]
        Saturday = 6,
        [JsonProperty("sunday")]
        Sunday = 7
    }
}
