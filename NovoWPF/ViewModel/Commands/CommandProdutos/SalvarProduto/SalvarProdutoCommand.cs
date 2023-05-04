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
        public CadastroProdutoViewModel CadastroProdutoViewModel { get; set; }
        public int IdListaProduto { get; set; }
        public ProdutoViewModel ProdutoViewModel { get; set; }
        public SalvarProdutoCommand(ObservableCollection<Produto> produtos, CadastroProdutoView cadastroProdutoView, ProdutoViewModel produtoViewModel)
        {
            Produtos = produtos;
            CadastroProdutoView = cadastroProdutoView;
            ProdutoViewModel = produtoViewModel;
        }

        public override void Execute(object parameter)
        {

            CadastroProdutoViewModel cadastroPessoaViewModel = new CadastroProdutoViewModel();

            if(CadastroProdutoView.nomeProdutoBox.Text != ""  && CadastroProdutoView.codigoProdutoBox.Text != "" 
                && CadastroProdutoView.valorProdutoBox.Text != "")
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

                ProdutoViewModel.IncrementarId();
                CadastroProdutoView.Visibility = Visibility.Collapsed;
            }
            else
            {
                MessageBox.Show("Favor preencher itens obrigatórios");
            }
        }
    }
}
