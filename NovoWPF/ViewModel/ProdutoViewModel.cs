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
            Produtos = new ObservableCollection<Produto>
            {
                new Produto(1, "Produto A", "123", 10.50),
                new Produto(2, "Produto B", "456", 20.00),
                new Produto(3, "Produto C", "789", 5.00)
            };

            produtoView.dataGridProduto.ItemsSource = Produtos;

            AbrirCadastroProduto = new AbrirCadastroProdutoCommand(Produtos);
        }
    }
}