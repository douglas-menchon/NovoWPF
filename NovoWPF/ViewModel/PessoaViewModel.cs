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
    public class PessoaViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand AbrirTelaPessoa { get; }

        public PessoaViewModel()
        {
            AbrirTelaPessoa = new AbrirPessoaCommand();
        }
    }
}
