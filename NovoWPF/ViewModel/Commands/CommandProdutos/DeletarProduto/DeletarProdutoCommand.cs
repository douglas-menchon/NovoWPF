using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using NovoWPF.Commands;
using NovoWPF.Comuns;
using NovoWPF.RegraDeNegocio;
using NovoWPF.View;

namespace NovoWPF.ViewModel.Commands.CommandProdutos.DeletarProduto
{
    public class DeletarProdutoCommand : CommandBase
    {
        private ObservableCollection<Produto> Produtos { get; set; }
        private ProdutoView ProdutoView { get; set; }
        public ProdutoViewModel ProdutoViewModel { get; set; }

        public DeletarProdutoCommand(ObservableCollection<Produto> produtos, ProdutoView cadastro, ProdutoViewModel produtoViewModel)
        {
            Produtos = produtos;
            ProdutoView = cadastro;
            ProdutoViewModel = produtoViewModel;
        }

        public override void Execute(object parameter)
        {
            TelaProjetoViewModel telaProjetoViewModel = new TelaProjetoViewModel();
            dynamic data = ProdutoView.dataGridProduto.SelectedItem;
            if(data!= null)
            {
                Produtos.Remove(data);
                MessageBox.Show("Produto deletado com sucesso!");
                telaProjetoViewModel.ExportarXmlProduto(Produtos, ProdutoViewModel.IdProdutoLista);
            }
            else
            {
                MessageBox.Show("Favor escolher um produto");
            }
        }
    }
}
