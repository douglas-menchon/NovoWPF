using NovoWPF.Commands;
using NovoWPF.View;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace NovoWPF.ViewModel.Commands
{
    public class AbrirCadastroProdutoCommand : CommandBase
    {
        public ObservableCollection<Produto> Produtos { get; set; } = new ObservableCollection<Produto>();

        CadastroProdutoView cadastroProdutoView = new CadastroProdutoView();
        public override void Execute(object parameter)
        {
            cadastroProdutoView.ShowDialog();
            DadosProduto();
        }

        public void DadosProduto()
        {
            Produto produto = new Produto();
            produto.IdProduto = int.Parse(cadastroProdutoView.idProdutoBox.Text);
            produto.NomeProduto = cadastroProdutoView.nomeProdutoBox.Text;
            produto.Codigo = cadastroProdutoView.codigoProdutoBox.Text;

            if (!string.IsNullOrEmpty(cadastroProdutoView.valorProdutoBox.Text))
            {
                produto.Valor = double.Parse(cadastroProdutoView.valorProdutoBox.Text);
            }

            Produtos.Add(produto);

            ProdutoView view = new ProdutoView(Produtos);
            view.dataGridProduto.ItemsSource = Produtos; //aqui
            view.dataGridProduto.Items.Refresh();
            
        }
    }
}
