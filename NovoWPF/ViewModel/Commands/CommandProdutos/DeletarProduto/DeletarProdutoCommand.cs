using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using NovoWPF.Commands;
using NovoWPF.RegraDeNegocio;
using NovoWPF.View;

namespace NovoWPF.ViewModel.Commands.CommandProdutos.DeletarProduto
{
    public class DeletarProdutoCommand : CommandBase
    {
        private ObservableCollection<Produto> Produtos { get; set; }
        private ProdutoView ProdutoView { get; set; }

        public DeletarProdutoCommand(ObservableCollection<Produto> produtos, ProdutoView cadastro)
        {
            Produtos = produtos;
            ProdutoView = cadastro;
        }

        public override void Execute(object parameter)
        {
            dynamic data = ProdutoView.dataGridProduto.SelectedItem;
            if(data!= null)
            {
                Produtos.Remove(data);
                MessageBox.Show("Produto deletado com sucesso!");
            }
            else
            {
                MessageBox.Show("Favor escolher um produto");
            }
        }
    }
}
