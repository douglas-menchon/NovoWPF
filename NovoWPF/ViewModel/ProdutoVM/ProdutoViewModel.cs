using NovoWPF.RegraDeNegocio;
using NovoWPF.View;
using NovoWPF.ViewModel.Commands;
using NovoWPF.ViewModel.Commands.CommandProdutos.AbrirTelasProduto;
using NovoWPF.ViewModel.Commands.CommandProdutos.DeletarProduto;
using NovoWPF.ViewModel.Commands.CommandProdutos.PesquisaProduto;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
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

        public ProdutoViewModel(ProdutoView produtoView, ObservableCollection<Produto> produtos)
        {
            produtoView.dataGridProduto.ItemsSource = Produtos;
            VerificarProdutoId();
            AbrirEditarProduto = new AbrirEditarProdutoCommand(Produtos, produtoView);
            AbrirCadastroProduto = new AbrirCadastroProdutoCommand(Produtos, this);
            DeletarProduto = new DeletarProdutoCommand(Produtos, produtoView);
            PesquisarProduto = new PesquisaProdutoCommand(Produtos, produtoView);
            CancelarPesquisarProduto = new CancelarPesquisaProdutoCommand(Produtos, produtoView);

            if (produtoView.minimoTB.Text == "" || produtoView.maximoTB.Text == "")
            {
                produtoView.minimoTB.Text = "0";
                produtoView.maximoTB.Text = "9999999";
            }
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