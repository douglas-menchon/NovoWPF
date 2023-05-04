using NovoWPF.Commands;
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

        public AbrirCadastroProdutoCommand(ObservableCollection<Produto> produtos, ProdutoViewModel produtoViewModel)
        {
            Produtos = produtos;
            ProdutoViewModel = produtoViewModel;
        }

        public override void Execute(object parameter)
        {
            CadastroProdutoView cadastroProdutoView = new CadastroProdutoView();
            cadastroProdutoView.DataContext = new CadastroProdutoViewModel(Produtos, cadastroProdutoView, ProdutoViewModel);
            cadastroProdutoView.idProdutoBox.Text = ProdutoViewModel.IdProdutoLista.ToString();
            cadastroProdutoView.Show();
        }
    }
}