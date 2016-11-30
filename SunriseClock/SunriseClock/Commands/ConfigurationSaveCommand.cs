using SunriseClock.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SunriseClock.Commands
{
    class ConfigurationSaveCommand : ICommand
    {
        public ConfigurationViewModel ConfigurationViewModel { get; set;}

        public ConfigurationSaveCommand(ConfigurationViewModel configurationViewModel)
        {
            ConfigurationViewModel = configurationViewModel;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return ConfigurationViewModel.CanSave;
        }

        public void Execute(object parameter)
        {
            ConfigurationViewModel.SaveChanges();
        }
    }
}
