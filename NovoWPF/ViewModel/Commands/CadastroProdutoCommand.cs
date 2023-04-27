using NovoWPF.Commands;
using NovoWPF.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoWPF.ViewModel.Commands
{
    public class CadastroProdutoCommand : CommandBase
    {
        public override void Execute(object parameter)
        {
            CadastroProdutoView cadastroProdutoView = new CadastroProdutoView();
            cadastroProdutoView.DataContext = new CadastroProdutoViewModel();
            cadastroProdutoView.ShowDialog();
        }
    }
}
