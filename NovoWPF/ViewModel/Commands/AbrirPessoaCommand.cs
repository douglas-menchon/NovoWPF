using NovoWPF.Commands;
using NovoWPF.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoWPF.ViewModel.Commands
{
    class AbrirPessoaCommand : CommandBase
    {
        public override void Execute(object parameter)
        {
            PessoaView pessoaView = new PessoaView();
            pessoaView.DataContext = new PessoaViewModel();
            pessoaView.Show();
        }
    }
}
