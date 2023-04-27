using NovoWPF.View;
using NovoWPF.ViewModel;
using System.Collections.ObjectModel;

namespace NovoWPF.Commands
{

    public class AbrirProdutoCommand : CommandBase
    {
        public ObservableCollection<Produto> Produtos { get; set; } = new ObservableCollection<Produto>();
        public override void Execute(object parameter)
        {
            ProdutoView produtoView = new ProdutoView(Produtos);
            produtoView.DataContext = new ProdutoViewModel();
            produtoView.Show();
        }
    }
}
