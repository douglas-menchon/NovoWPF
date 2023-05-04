using NovoWPF.Commands;
using NovoWPF.View;
using System.Collections.ObjectModel;

namespace NovoWPF.ViewModel.Commands
{

    public class AbrirProdutoCommand : CommandBase
    {
        public override void Execute(object parameter)
        {
            ProdutoView produtoView = new ProdutoView();
            produtoView.DataContext = new ProdutoViewModel(produtoView);
            produtoView.Show();
        }
    } 
}
