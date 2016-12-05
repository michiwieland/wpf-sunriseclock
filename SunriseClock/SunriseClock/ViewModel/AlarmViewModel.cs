using System;
using System.Collections.Generic;
using SunriseClock.Commands;
using SunriseClock.Model;
using SunriseClock.Service;
using System.Linq;
using System.Windows.Input;

namespace SunriseClock.ViewModel
{
    public class AlarmViewModel
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
            AlarmSaveCommand = new GenericCommand(SaveChanges, CanSaveOrDelete);
            AlarmDeleteCommand = new GenericCommand(DeleteAlarm, CanSaveOrDelete);

            Host = HostConfiguratorService.GetHost();

            Api = new ClockApi(new Uri("http://" + Host.Name + ":" + Host.Port + "/api/v2/"));
            Configuration = Api.GetConfiguration();
        }

        public void AddAlarm(object parameter)
        {
            var newAlarm = new Alarm
            {
                Name = "[Neuer Alarm]",
                AlarmTime = new DateTime() + new TimeSpan(7, 30, 0)
            };
            Configuration.Alarms.Add(newAlarm);
        }

        public void DeleteAlarm(object parameter)
        {
            Alarm alarm = (Alarm)parameter;
            Configuration.Alarms.Remove(alarm);
        }

        public bool CanSaveOrDelete()
        {
            return Configuration?.Alarms != null && Configuration.Alarms.All(
                a => !string.IsNullOrWhiteSpace(a.Name) &&
                a.AlarmTime.Hour >= 0 &&
                a.AlarmTime.Minute >= 0 &&
                a.EnlightDuration > 0 &&
                a.LightDuration > 0);
        }

        public void SaveChanges(object parameter)
        {
            Api.SetConfiguration(Configuration);
        }
    }   
}
