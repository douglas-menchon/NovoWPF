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

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand SalvarProduto { get; }
        public ICommand CancelarProduto { get; }

        public CadastroProdutoViewModel()
        {

        }
    }
}
