using NovoWPF.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NovoWPF.ViewModel
{
    public class TelaProjetoViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand AbrirTelaProduto { get; }

        public TelaProjetoViewModel()
        {
            AbrirTelaProduto = new AbrirProdutoCommand();
        }
    }
}
