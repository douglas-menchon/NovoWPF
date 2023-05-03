using NovoWPF.View;
using NovoWPF.ViewModel.Commands;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace NovoWPF.ViewModel
{
    public class CadastroProdutoViewModel : CloseWindow
    {
        public CadastroProdutoView CadastroProdutoView { get; set; }

        public Produto Produto { get; set; }

        public ObservableCollection<Produto> Produtos { get; set; }

        public int IdProdutoLista { get; set; }

        public ICommand SalvarProduto { get; }


        public CadastroProdutoViewModel(ObservableCollection<Produto> produtos , CadastroProdutoView cadastro)
        {
            Produtos = produtos;
            CadastroProdutoView = cadastro;
            VerificarProdutoId();
            SalvarProduto = new SalvarProdutoCommand(Produtos, CadastroProdutoView);
        }

        public CadastroProdutoViewModel()
        {
        }

        public void VerificarProdutoId()
        {
            if (Produtos.Count < 1)
            {
                IdProdutoLista = 1;
            }
             CadastroProdutoView.idProdutoBox.Text = $"{IdProdutoLista}";
        }

        public void IncrementarId()
        {
            IdProdutoLista++;
        }
    }
}
