namespace Commands
{
    using System;
    using System.Windows;
    using System.Windows.Input;

    public class ShowInputCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return parameter is string && !string.IsNullOrEmpty((string)parameter);
        }

        public void Execute(object parameter)
        {
            if (!CanExecute(parameter))
            {
                return;
            }

            MessageBox.Show((string)parameter);
        }
    }
}
