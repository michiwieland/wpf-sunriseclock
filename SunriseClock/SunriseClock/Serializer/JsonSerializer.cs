using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp.Serializers;
using RestSharp.Deserializers;

namespace SunriseClock.Serializer
{
    internal class JsonSerializer : ISerializer, IDeserializer
    {
        private readonly Newtonsoft.Json.JsonSerializer serializer;

        public JsonSerializer(Newtonsoft.Json.JsonSerializer serializer)
        {
            this.serializer = serializer;
        }

        public string ContentType
        {
            get { return "application/json"; }
            set {  } // per Interface.
        }
        public string DateFormat { get; set; }
        public string Namespace { get; set; }
        public string RootElement { get; set; }

        public string Serialize(object obj)
        {
            using (var stringWriter = new StringWriter())
            {
                using (var jsonTextWriter = new JsonTextWriter(stringWriter))
                {
                    serializer.Serialize(jsonTextWriter, obj);

                    return stringWriter.ToString();
                }
            }
        }

        public T Deserialize<T>(RestSharp.IRestResponse response)
        {
            var content = response.Content;
            
            using (var stringReader = new StringReader(content))
            {
                using (var jsonTextReader = new JsonTextReader(stringReader))
                {
                    return serializer.Deserialize<T>(jsonTextReader);
                }
            }
        }

        public static JsonSerializer Default => new JsonSerializer(new Newtonsoft.Json.JsonSerializer()
        {
            NullValueHandling = NullValueHandling.Ignore,
        });
    }
}
