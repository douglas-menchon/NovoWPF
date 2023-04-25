using NovoWPF.Commands;
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
    public class TelaProjetoViewModel : ViewModelBase
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand AbrirTelaProduto { get; }
        public ICommand AbrirTelaPessoa { get; }

        public TelaProjetoViewModel()
        {
            AbrirTelaProduto = new AbrirProdutoCommand();
            AbrirTelaPessoa = new AbrirPessoaCommand();
        }
        
    }
}
