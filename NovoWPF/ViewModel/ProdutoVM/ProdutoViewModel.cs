using NovoWPF.View;
using NovoWPF.ViewModel.Commands;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace NovoWPF.ViewModel
{
    public class ProdutoViewModel : ViewModelBase
    {
        public ObservableCollection<Produto> Produtos { get; set; }
        public ICommand AbrirCadastroProduto{ get; }

        public ProdutoViewModel()
        {

        }

        public ProdutoViewModel(ProdutoView produtoView)
        {
            Produtos = new ObservableCollection<Produto>();
            produtoView.dataGridProduto.ItemsSource = Produtos;

            AbrirCadastroProduto = new AbrirCadastroProdutoCommand(Produtos);
        }
    }
}