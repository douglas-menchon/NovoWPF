using NovoWPF.RegraDeNegocio;
using NovoWPF.View;
using NovoWPF.ViewModel.Commands;
using NovoWPF.ViewModel.Commands.CommandProdutos.AbrirTelasProduto;
using NovoWPF.ViewModel.Commands.CommandProdutos.DeletarProduto;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace NovoWPF.ViewModel
{
    public class ProdutoViewModel : ViewModelBase
    {
        public ObservableCollection<Produto> Produtos { get; set; }
        public ICommand AbrirCadastroProduto{ get; }
        public ICommand AbrirEditarProduto { get; }
        public ICommand DeletarProduto { get; }
        public int IdProdutoLista { get; set; }

        public ProdutoViewModel()
        {
        }

        public ProdutoViewModel(ProdutoView produtoView)
        {
            Produtos = new ObservableCollection<Produto>();

            produtoView.dataGridProduto.ItemsSource = Produtos;
            VerificarProdutoId();
            AbrirEditarProduto = new AbrirEditarProdutoCommand(Produtos, produtoView);
            AbrirCadastroProduto = new AbrirCadastroProdutoCommand(Produtos, this);
            DeletarProduto = new DeletarProdutoCommand(Produtos, produtoView);

        }

        public void VerificarProdutoId()
        {
            if (Produtos.Count < 1)
            {
                IdProdutoLista = 1;
            }
            else
            {
                IdProdutoLista = Produtos.Count + 1;
            }
        }
    }
}