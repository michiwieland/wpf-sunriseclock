using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace SunriseClock.Model
{
    // TODO: Serialization as string names
    [JsonConverter(typeof(StringEnumConverter))]
    enum Weekday
    {
        [EnumMember(Value = "monday")]
        Monday = 1,
        [EnumMember(Value = "tuesday")]
        Tuesday = 2,
        [EnumMember(Value = "wednesday")]
        Wednesday = 3,
        [EnumMember(Value = "thursday")]
        Thursday = 4,
        [EnumMember(Value = "friday")]
        Friday = 5,
        [EnumMember(Value = "saturday")]
        Saturday = 6,
        [EnumMember(Value = "sunday")]
        Sunday = 7
    }
}
