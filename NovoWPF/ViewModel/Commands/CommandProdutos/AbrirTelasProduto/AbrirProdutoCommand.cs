using NovoWPF.Commands;
using NovoWPF.RegraDeNegocio;
using NovoWPF.View;
using System.Collections.ObjectModel;

namespace NovoWPF.ViewModel.Commands
{

    public class AbrirProdutoCommand : CommandBase
    {
        public ObservableCollection<Produto> Produtos { get; set; }

        public AbrirProdutoCommand(ObservableCollection<Produto> produtos)
        {
            Produtos = produtos;
        }
        public override void Execute(object parameter)
        {
            ProdutoView produtoView = new ProdutoView();
            produtoView.DataContext = new ProdutoViewModel(produtoView, Produtos);
            produtoView.Show();
        }
    } 
}
