using NovoWPF.View;
using NovoWPF.ViewModel.Commands;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace NovoWPF.ViewModel
{
    public class ProdutoViewModel : ViewModelBase
    {
        public ObservableCollection<Produto> Produtos { get; set; }
        public ICommand AbrirCadastroProduto{ get; }
        public int IdProdutoLista { get; set; }

        public ProdutoViewModel()
        {
        }

        public ProdutoViewModel(ProdutoView produtoView)
        {
            Produtos = new ObservableCollection<Produto>();
            VerificarProdutoId();
            produtoView.dataGridProduto.ItemsSource = Produtos;
            AbrirCadastroProduto = new AbrirCadastroProdutoCommand(Produtos, this);
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

        public void IncrementarId()
        {
            IdProdutoLista++;
        }
    }
}