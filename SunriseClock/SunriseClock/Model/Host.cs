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
    class Host
    {
        public string Name { get; set; }
        public int Port { get; set; }
    }
}
