using NovoWPF.RegraDeNegocio;
using NovoWPF.View;
using NovoWPF.ViewModel.Commands;
using NovoWPF.ViewModel.Commands.CommandProdutos.EditarProduto;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace NovoWPF.ViewModel
{
    public class CadastroProdutoViewModel : CloseWindow
    {

        public ICommand SalvarProduto { get; }
        public ICommand EditarProduto { get; }


        public CadastroProdutoViewModel(ObservableCollection<Produto> produtos , CadastroProdutoView cadastro, ProdutoViewModel produtoViewModel)
        {
            SalvarProduto = new SalvarProdutoCommand(produtos, cadastro, produtoViewModel);
            EditarProduto = new EditarProdutoCommand(produtos, cadastro, produtoViewModel);
        }

        public CadastroProdutoViewModel()
        {
        }
      
    }
}