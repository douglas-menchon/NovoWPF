using NovoWPF.RegraDeNegocio;
using NovoWPF.View;
using NovoWPF.ViewModel.Commands;
using NovoWPF.ViewModel.Commands.CommandProdutos.AbrirTelasProduto;
using NovoWPF.ViewModel.Commands.CommandProdutos.DeletarProduto;
using NovoWPF.ViewModel.Commands.CommandProdutos.PesquisaProduto;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace NovoWPF.ViewModel
{
    public class ProdutoViewModel : ViewModelBase
    {
        public ObservableCollection<Produto> Produtos { get; set; }
        public ICommand AbrirCadastroProduto{ get; }
        public ICommand AbrirEditarProduto { get; }
        public ICommand DeletarProduto { get; }
        public ICommand PesquisarProduto { get; }
        public ICommand CancelarPesquisarProduto { get; }

        public int IdProdutoLista { get; set; }

        public ProdutoViewModel()
        {
        }

        public ProdutoViewModel(ProdutoView produtoView, ObservableCollection<Produto> produtos, int idProdutoLista)
        {
            IdProdutoLista = idProdutoLista;
            produtoView.dataGridProduto.ItemsSource = produtos;
            VerificarProdutoId(produtos);
            AbrirEditarProduto = new AbrirEditarProdutoCommand(produtos, produtoView, this);
            AbrirCadastroProduto = new AbrirCadastroProdutoCommand(produtos, this, IdProdutoLista);
            DeletarProduto = new DeletarProdutoCommand(produtos, produtoView);
            PesquisarProduto = new PesquisaProdutoCommand(produtos, produtoView);
            CancelarPesquisarProduto = new CancelarPesquisaProdutoCommand(produtos, produtoView);

            if (produtoView.minimoTB.Text == "" || produtoView.maximoTB.Text == "")
            {
                produtoView.minimoTB.Text = "0";
                produtoView.maximoTB.Text = "9999999";
            }
        }

        public void VerificarProdutoId(ObservableCollection<Produto> produtos)
        {
            if (produtos.Count < 1)
            {
                IdProdutoLista = 1;
            }
            else
            {
                IdProdutoLista = produtos.Count + 1;
            }
        }
    }
}