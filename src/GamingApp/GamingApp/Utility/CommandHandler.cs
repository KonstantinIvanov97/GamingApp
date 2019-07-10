using System;
using System.Windows.Input;

namespace GamingApp.Utility
{
    public class CommandHandler<T> : ICommand
    {
        private Action<T> execute;
        private Predicate<T> canExecute;

        public CommandHandler(Action action)
            : this(action, (obj) => true)
        {
        }

        public CommandHandler(Action<T> action)
            : this(action, (obj) => true)
        {
        }

        public CommandHandler(Action<T> action, Func<bool> canExecute)
            : this(action, (obj) => canExecute.Invoke())
        {
        }

        public CommandHandler(Action action, Func<bool> canExecute)
            : this(action, (obj) => canExecute.Invoke())
        {
        }

        public CommandHandler(Action<T> action, Predicate<T> canExecute)
        {
            this.execute = action;
            this.canExecute = canExecute;
        }

        public CommandHandler(Action action, Predicate<T> canExecute)
        {
            this.execute = (obj) => action.Invoke();
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object parameter)
        {
            bool result = canExecute((T)parameter);
            return result;
        }

        public void Execute(object parameter)
        {
            execute((T)parameter);
        }

        //public void OnCanExecuteChanged()
        //{
        //    CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        //}
    }

    public class CommandHandler : CommandHandler<object>
    {
        public CommandHandler(Action action)
            : base(action)
        {
        }

        public CommandHandler(Action action, Func<bool> canExecute)
            : base(action, canExecute)
        {
        }

        public CommandHandler(Action action, Predicate<object> canExecute)
            : base(action, canExecute)
        {
        }
    }
}
