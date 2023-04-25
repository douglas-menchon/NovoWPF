using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NovoWPF.ViewModel
{
    class CadastroProdutoViewModel : ViewModelBase
    {
        public ICommand SalvarProduto { get; }
        public ICommand CancelarProduto { get; }
    }
}
