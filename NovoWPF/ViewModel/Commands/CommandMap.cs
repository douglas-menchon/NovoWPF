﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NovoWPF.ViewModel.Commands
{
    public class CommandMap
    {
        public ICommand AdicionarComando(Action metodo)
        {
            var nomeComando = metodo.Method.Name;
            Comandos[nomeComando] = new DelegateCommand(x => { metodo.Invoke(); });
            return Comandos[nomeComando];
        }

        protected Dictionary<string, ICommand> Comandos
        {
            get
            {
                if (null == comandos)
                    comandos = new Dictionary<string, ICommand>();

                return comandos;
            }
        }

        private Dictionary<string, ICommand> comandos;

        public class DelegateCommand : ICommand
        {

            private readonly Action<object> _execute;
            private readonly Predicate<object> _canExecute;

            public DelegateCommand(Action<object> execute) : this(execute, null)
            {
            }


            public DelegateCommand(Action<object> execute, Predicate<object> canExecute)
            {
                if (execute == null)
                    throw new ArgumentNullException("execute");
                _execute = execute;
                _canExecute = canExecute;
            }


            public bool CanExecute(object parameter)
            {
                return _canExecute == null ? true : _canExecute(parameter);
            }

            public event EventHandler CanExecuteChanged
            {
                add { CommandManager.RequerySuggested += value; }
                remove { CommandManager.RequerySuggested -= value; }
            }

            public void Execute(object parameter)
            {
                _execute(parameter);
            }
        }
        public class RelayCommand : ICommand
        {
            readonly Action<object> _execute;
            readonly Predicate<object> _canExecute;

            public RelayCommand(Action<object> execute) : this(execute, null)
            {

            }

            public RelayCommand(Action<object> execute, Predicate<object> canExecute)
            {
                if (execute == null)
                    throw new ArgumentNullException("execute");
                _execute = execute; _canExecute = canExecute;
            }

            public bool CanExecute(object parameter)
            {
                return _canExecute == null ? true : _canExecute(parameter);
            }

            public event EventHandler CanExecuteChanged
            {
                add { CommandManager.RequerySuggested += value; }
                remove { CommandManager.RequerySuggested -= value; }
            }

            public void Execute(object parameter) { _execute(parameter); }
        }

    }
}
