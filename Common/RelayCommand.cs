using System;
using System.Diagnostics;
using System.Windows.Input;

namespace Common
{
    /// <summary>
    /// RelayCommand is the custom class which is implemented in the ICommand interface. 
    /// RelayCommands are used to separate the semantics and the object that invokes a command from the logic 
    /// that executes the command i.e. it separates UI component from the logic that needs to be executed 
    /// on command invocation. So, that we can test business logic separately using test cases and also 
    /// our UI code is loosely coupled to business logic.
    /// </summary>
    public class RelayCommand1: ICommand
    {
        Action _TargetExecuteMethod;
        Func<bool> _TargetCanExecuteMethod;
        public RelayCommand1(Action executeMethod, bool _def = false, bool _can = false)
        {
            _TargetExecuteMethod = executeMethod;
        }

        public RelayCommand1(Action executeMethod, Func<bool> canExecuteMethod, bool _def = false, bool _can = false)
        {
            _TargetExecuteMethod = executeMethod;
            _TargetCanExecuteMethod = canExecuteMethod;
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }

        #region ICommand Members

        bool ICommand.CanExecute(object parameter)
        {

            if (_TargetCanExecuteMethod != null)
            {
                return _TargetCanExecuteMethod();
            }

            if (_TargetExecuteMethod != null)
            {
                return true;
            }

            return false;
        }

        public event EventHandler CanExecuteChanged = delegate { };

        void ICommand.Execute(object parameter)
        {
            if (_TargetExecuteMethod != null)
            {
                {
                    _TargetExecuteMethod();
                }
            }
        }

        #endregion
    }

    public class RelayCommand<T> : ICommand
    {

        Action<T> _TargetExecuteMethod;
        Func<T, bool> _TargetCanExecuteMethod;
        public RelayCommand(Action<T> executeMethod, bool _ShowProgress = true)
        {
            _TargetExecuteMethod = executeMethod;
        }

        public RelayCommand(Action<T> executeMethod, Func<T, bool> canExecuteMethod)
        {
            _TargetExecuteMethod = executeMethod;
            _TargetCanExecuteMethod = canExecuteMethod;
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }

        #region ICommand Members

        bool ICommand.CanExecute(object parameter)
        {

            if (_TargetCanExecuteMethod != null)
            {
                T tparm = (T)parameter;
                return _TargetCanExecuteMethod(tparm);
            }

            if (_TargetExecuteMethod != null)
            {
                return true;
            }

            return false;
        }



        public event EventHandler CanExecuteChanged = delegate { };

        public void Execute(object parameter)
        {
            if (_TargetExecuteMethod != null)
            {
                _TargetExecuteMethod((T)parameter);


            }
        }

        #endregion
    }

    public class RelayCommand : ICommand
    {
        #region Fields 
        readonly Action<object> _execute;
        readonly Predicate<object> _canExecute;
        private Func<Action<object>> fnCreate;
        #endregion // Fields 
        #region Constructors 

        public RelayCommand(Action<object> execute) : this(execute, null) { }
        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException("execute"); _canExecute = canExecute;
        }

        public RelayCommand(Func<Action<object>> fnCreate)
        {
            this.fnCreate = fnCreate;
        }
        #endregion // Constructors 
        #region ICommand Members 
        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute((object)parameter);
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public void Execute(object parameter) { _execute(parameter); }
        #endregion // ICommand Members 
    }
}
