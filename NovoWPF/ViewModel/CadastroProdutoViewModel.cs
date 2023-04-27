using NovoWPF.View;
using NovoWPF.ViewModel.Commands;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace NovoWPF.ViewModel
{
    public class CadastroProdutoViewModel : ViewModelBase
    {

        public ObservableCollection<Produto> Produtos { get; set; }

        public ICommand SalvarProduto { get; }
        public ICommand CancelarProduto { get; }

        public CadastroProdutoViewModel()
        {
            SalvarProduto = new SalvarProdutoCommand();
        }

    }
}
