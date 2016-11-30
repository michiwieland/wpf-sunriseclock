using SunriseClock.Commands;
using SunriseClock.Model;
using SunriseClock.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SunriseClock.ViewModel
{
    class ConfigurationViewModel
    {
        public Configuration Configuration { get; set; }
        public ICommand ConfigurationSaveCommand { get; set;  }
        public ClockApi Api { get; set; }

        public ConfigurationViewModel()
        {
 
            ConfigurationSaveCommand = new ConfigurationSaveCommand(this);
            Api = new ClockApi();
            Configuration = Api.GetConfiguration();
        }


        public bool CanSave
        {
            get
            {
                if (Configuration == null || Configuration.Alarms == null)
                {
                    return false;
                }
                return Configuration.Alarms.All(a => !string.IsNullOrWhiteSpace(a.Name));
             }
        }

        public void SaveChanges()
        {
            Api.SetConfiguration(Configuration);
        }
    }   
}
