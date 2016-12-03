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
        public ClockApi Api { get; set; }

        public ICommand AlarmAddCommand { get; set; }
        public ICommand AlarmSaveCommand { get; set; }
        public ICommand AlarmDeleteCommand { get; set; }

        public AlarmViewModel()
        {
            AlarmAddCommand = new GenericCommand(AddAlarm, () => true ); 
            AlarmSaveCommand = new GenericCommand(SaveChanges, CanSave);
            AlarmDeleteCommand = new GenericCommand(DeleteAlarm, () => true );
            
            Api = new ClockApi();
            Configuration = Api.GetConfiguration();

            // TODO replace with HostService call
            Host = HostConfiguratorService.GetHost();
        }

        public void AddAlarm(object parameter)
        {
            Configuration.Alarms.Add(new Alarm());
        }

        public void DeleteAlarm(object parameter)
        {
            Alarm alarm = (Alarm)parameter;
            Configuration.Alarms.Remove(alarm);
        }

        public bool CanSave()
        {
            return Configuration?.Alarms != null && Configuration.Alarms.All(a => !string.IsNullOrWhiteSpace(a.Name));
        }

        public void SaveChanges(object parameter)
        {
            Api.SetConfiguration(Configuration);
        }
    }   
}
