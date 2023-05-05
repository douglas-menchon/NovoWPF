using NovoWPF.Commands;
using NovoWPF.RegraDeNegocio;
using NovoWPF.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NovoWPF.ViewModel.Commands.CommandProdutos.PesquisaProduto
{
    public class CancelarPesquisaProdutoCommand : CommandBase
    {
        public ObservableCollection<Produto> Produtos { get; set; }
        public ProdutoView ProdutoView { get; set; }

        public CancelarPesquisaProdutoCommand(ObservableCollection<Produto> produtos, ProdutoView produtoView)
        {
            Produtos = produtos;
            ProdutoView = produtoView;
        }

        public override void Execute(object parameter)
        {
            ProdutoView.dataGridProduto.ItemsSource = Produtos;
        }
    }
}
