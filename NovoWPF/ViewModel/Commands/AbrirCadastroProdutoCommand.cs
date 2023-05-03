using NovoWPF.Commands;
using NovoWPF.View;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace NovoWPF.ViewModel.Commands
{
    public class AbrirCadastroProdutoCommand : CommandBase
    {
        public override void Execute(object parameter)
        {
            CadastroProdutoView cadastroProdutoView = new CadastroProdutoView();
            cadastroProdutoView.Show();
        }

    
    }
}
