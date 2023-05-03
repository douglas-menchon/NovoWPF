using NovoWPF.Commands;
using NovoWPF.View;
using System.Collections.ObjectModel;

namespace NovoWPF.ViewModel.Commands
{
    public class AbrirPessoaCommand : CommandBase
    {

        public override void Execute(object parameter)
        {
            PessoaView pessoaView = new PessoaView();
            pessoaView.DataContext = new PessoaViewModel(pessoaView);
            pessoaView.Show();
        }
    }
}
