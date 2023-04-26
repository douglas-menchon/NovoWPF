using NovoWPF.Commands;
using NovoWPF.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoWPF.ViewModel.Commands
{
    public class AbrirCadastroProdutoCommand : CommandBase
    {
        public override void Execute(object parameter)
        {
            CadastroProdutoView produtoView = new CadastroProdutoView();
            produtoView.DataContext = new CadastroProdutoViewModel();
            produtoView.Show();
        }
    }
}
