using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ForkliftManager.Core
{
    class RelayCommand : ICommand
    {

        private Action<object> _execute;
        private Predicate<object> _canExecute;

        //constructor for a command
        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        //can a command be executed
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        //what should happen with the command
        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
