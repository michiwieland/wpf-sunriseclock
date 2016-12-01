using System;
using System.Windows.Input;
using SunriseClock.ViewModel;

namespace SunriseClock.Commands
{
    class AlarmSaveCommand : ICommand
    {
        public AlarmViewModel AlarmViewModel { get; set;}

        public AlarmSaveCommand(AlarmViewModel alarmViewModel)
        {
            AlarmViewModel = alarmViewModel;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return AlarmViewModel.CanSave;
        }

        public void Execute(object parameter)
        {
            AlarmViewModel.SaveChanges();
        }
    }
}
