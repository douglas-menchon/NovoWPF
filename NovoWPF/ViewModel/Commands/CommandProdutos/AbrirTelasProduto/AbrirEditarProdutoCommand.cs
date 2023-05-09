using NovoWPF.Commands;
using NovoWPF.RegraDeNegocio;
using NovoWPF.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NovoWPF.ViewModel.Commands.CommandProdutos.AbrirTelasProduto
{
    public class AbrirEditarProdutoCommand: CommandBase
    {
        public ObservableCollection<Produto> Produtos { get; set; }
        public ProdutoView ProdutoView { get; set; }
        public ProdutoViewModel ProdutoViewModel { get; set; }
        public AbrirEditarProdutoCommand(ObservableCollection<Produto> produtos, ProdutoView produtoView, ProdutoViewModel produtoViewModel)
        {
            Produtos = produtos;
            ProdutoView = produtoView;
            ProdutoViewModel = produtoViewModel;
        }

        public override void Execute(object parameter)
        {
            CadastroProdutoView cadastroProdutoView = new CadastroProdutoView();
            cadastroProdutoView.DataContext = new CadastroProdutoViewModel(Produtos, cadastroProdutoView, ProdutoViewModel);

            if(Produtos.Count > 0)
            {
                dynamic data = ProdutoView.dataGridProduto.SelectedItem;

                if(data != null)
                {
                    int indexData = data.IdProduto;
                    int indexList = Produtos.IndexOf(Produtos.Where(p => p.IdProduto == indexData).FirstOrDefault());

                    if(indexList != -1)
                    {
                        cadastroProdutoView.idProdutoBox.Text = Convert.ToString(Produtos[indexList].IdProduto);
                        cadastroProdutoView.nomeProdutoBox.Text = Produtos[indexList].NomeProduto;
                        cadastroProdutoView.codigoProdutoBox.Text = Produtos[indexList].Codigo;
                        cadastroProdutoView.valorProdutoBox.Text = Convert.ToString(Produtos[indexList].Valor);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao carregar os dados");
                        return;
                    }

                    cadastroProdutoView.btnSalvarProdutoEdit.Visibility = Visibility.Collapsed;
                    cadastroProdutoView.btnEditarNovoProduto.Visibility = Visibility.Visible;
                    cadastroProdutoView.Show();
                }
                else
                {
                    MessageBox.Show("Favor escolher um produto antes");
                }
            }
            else
            {
                MessageBox.Show("Favor cadastrar um produto antes");
            }
        }
    }
}
