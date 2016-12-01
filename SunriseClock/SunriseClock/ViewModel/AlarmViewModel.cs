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
    internal class AlarmViewModel
    {
        public Host Host { get; set; }
        public Configuration Configuration { get; set; }
        public ICommand AlarmSaveCommand { get; set;  }
        public ClockApi Api { get; set; }

        public AlarmViewModel()
        {
            AlarmSaveCommand = new AlarmSaveCommand(this);
            Api = new ClockApi();
            Configuration = Api.GetConfiguration();

            // TODO replace with HostService call
            Host = new Host();
            Host.Name = "clock.fh2.ch";
            Host.Port = 80;
        }

        public bool CanSave
        {
            get
            {
                return Configuration?.Alarms != null && Configuration.Alarms.All(a => !string.IsNullOrWhiteSpace(a.Name));
            }
        }

        public void SaveChanges()
        {
            Api.SetConfiguration(Configuration);
        }
    }   
}
