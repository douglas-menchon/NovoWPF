using NovoWPF.Commands;
using NovoWPF.View;
using NovoWPF.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using NovoWPF.Comuns;
using static NovoWPF.ViewModel.Commands.CommandMap;
using System.Collections.ObjectModel;
using System.Windows;

namespace NovoWPF.ViewModel
{
    public class CadastroPessoaViewModel : ICloseWindows
    {
        private DelegateCommand _closeCommand;
        public DelegateCommand CloseCommand =>
            _closeCommand ?? (_closeCommand = new DelegateCommand(CloseWindow));
        void CloseWindow(object parameter)
        {
            Close?.Invoke();
        }

        public Action Close { get; set; }

        public bool CanClose()
        {
            return true;
        }
    }

    interface ICloseWindows
    {
        Action Close { get; set; }
        bool CanClose();
    }

   
}
