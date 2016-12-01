using SunriseClock.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunriseClock.Service
{
    class HostConfiguratorService
    {
        public static Host GetHost()
        {
            var host = new Host
            {
                Name = Properties.Settings.Default.Host,
                Port = Properties.Settings.Default.Port
            };

            // ReSharper disable once SuspiciousTypeConversion.Global
            ((INotifyPropertyChanged) host).PropertyChanged += (hostObject, args) =>
            {
                Properties.Settings.Default.Host = (hostObject as Host)?.Name;
                Properties.Settings.Default.Port = (hostObject as Host)?.Port ?? 80;
                Properties.Settings.Default.Save();
            };
            return host;
        }
    }
}
