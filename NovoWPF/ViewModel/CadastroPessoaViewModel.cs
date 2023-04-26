using NovoWPF.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NovoWPF.ViewModel
{
    public class CadastroPessoaViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand SalvarPessoa { get; }
        public ICommand CancelarPessoa { get; }

        public CadastroPessoaViewModel()
        {

        }
    }
}
