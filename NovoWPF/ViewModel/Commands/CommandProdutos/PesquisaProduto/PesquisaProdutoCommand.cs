using NovoWPF.Commands;
using NovoWPF.View;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;


namespace NovoWPF.ViewModel.Commands.CommandProdutos.PesquisaProduto
{
    public class PesquisaProdutoCommand : CommandBase
    {
        public ObservableCollection<Produto> Produtos { get; set; }
        public ProdutoView ProdutoView { get; set; }
        public PesquisaProdutoCommand(ObservableCollection<Produto> produtos, ProdutoView produtoView)
        {
            Produtos = produtos;
            ProdutoView = produtoView;
        }

        public override void Execute(object parameter)
        {
            var dadosGrid = Produtos.Where(p => p.NomeProduto.Contains(ProdutoView.txtBoxPesquisaProduto.Text)).ToList();

            if (dadosGrid.Count > 0 && ProdutoView.txtBoxPesquisaProduto.Text != "")
            {
                ProdutoView.dataGridProduto.ItemsSource = dadosGrid;
            }

            var dadosValor = Produtos.Where(p => p.Valor >= double.Parse(ProdutoView.minimoTB.Text) && p.Valor <= double.Parse(ProdutoView.maximoTB.Text)).ToList();

            if (dadosValor.Count > 0)
            {
                ProdutoView.dataGridProduto.ItemsSource = dadosValor;
            }
        }
    }
}
 