using NovoWPF.Comuns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static NovoWPF.ViewModel.Commands.CommandMap;

namespace NovoWPF.ViewModel
{
    public class CloseWindow : ICloseWindows
    {
        private DelegateCommand _closeCommand;
        public DelegateCommand CloseCommand =>
            _closeCommand ?? (_closeCommand = new DelegateCommand(FecharWindow));
        void FecharWindow(object parameter)
        {
            Close?.Invoke();
        }

        public Action Close { get; set; }

        public bool CanClose()
        {
            return true;
        }      

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(dynamic nomeDaPropriedade)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nomeDaPropriedade));
        }
    }
}