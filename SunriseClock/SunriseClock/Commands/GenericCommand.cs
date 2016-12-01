using System;
using System.Windows.Input;

namespace SunriseClock.Commands
{
    class GenericCommand : ICommand
    {
        public Action<object> Action { get; }
        public Func<bool> ValidCheck { get;  }

        public GenericCommand(Action<object> action, Func<bool> validCheck)
        {
            Action = action;
            ValidCheck = validCheck;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return ValidCheck();
        }

        public void Execute(object parameter)
        {
            Action(parameter);
        }
    }
}
