using NovoWPF.Commands;
using NovoWPF.RegraDeNegocio;
using NovoWPF.View;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace NovoWPF.ViewModel.Commands
{
    public class AbrirCadastroProdutoCommand : CommandBase
    {
        public ObservableCollection<Produto> Produtos { get; set; }
        public ProdutoViewModel ProdutoViewModel { get; set; }
        public int IdProdutoLista { get; set; }

        public AbrirCadastroProdutoCommand(ObservableCollection<Produto> produtos, ProdutoViewModel produtoViewModel, int idProdutoLista)
        {
            Produtos = produtos;
            ProdutoViewModel = produtoViewModel;
            IdProdutoLista = idProdutoLista;
        }

        public override void Execute(object parameter)
        {
            CadastroProdutoView cadastroProdutoView = new CadastroProdutoView();
            cadastroProdutoView.DataContext = new CadastroProdutoViewModel(Produtos, cadastroProdutoView, ProdutoViewModel);
            cadastroProdutoView.idProdutoBox.Text = ProdutoViewModel.IdProdutoLista.ToString();
            cadastroProdutoView.btnEditarNovoProduto.Visibility = Visibility.Collapsed;
            cadastroProdutoView.btnSalvarProdutoEdit.Visibility = Visibility.Visible;
            cadastroProdutoView.Show();
        }
    }
}