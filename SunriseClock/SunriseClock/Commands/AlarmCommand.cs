using SunriseClock.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SunriseClock.Commands
{
    class AlarmCommand : ICommand
    {
        private AlarmViewModel AlarmViewModel;
        public AlarmCommand(AlarmViewModel alarmViewModel)
        {
            this.AlarmViewModel = alarmViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
