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
        }

    }
}
