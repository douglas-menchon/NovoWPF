using NovoWPF.Commands;
using NovoWPF.View;
using System.Collections.ObjectModel;
using System.Windows;

namespace NovoWPF.ViewModel.Commands
{
    public class SalvarProdutoCommand : CommandBase
    {
        public ObservableCollection<Produto> Produtos { get; set; }
        public CadastroProdutoView CadastroProdutoView { get; set; }

        public SalvarProdutoCommand(ObservableCollection<Produto> produtos, CadastroProdutoView cadastroProdutoView)
        {
            Produtos = produtos;
            CadastroProdutoView = cadastroProdutoView;
        }

        public override void Execute(object parameter)
        {
            double valor = 0;

             if (!string.IsNullOrEmpty(CadastroProdutoView.valorProdutoBox.Text))
            {
                valor = double.Parse(CadastroProdutoView.valorProdutoBox.Text);
            }

            Produtos.Add(new Produto(int.Parse(CadastroProdutoView.idProdutoBox.Text)
                                            , CadastroProdutoView.nomeProdutoBox.Text
                                            , CadastroProdutoView.codigoProdutoBox.Text
                                            , valor));
            MessageBox.Show($"o ID é: {CadastroProdutoView.idProdutoBox.Text}");
        }
    }
}
