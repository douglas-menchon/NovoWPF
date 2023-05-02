using NovoWPF.Commands;
using NovoWPF.View;
using System.Collections.ObjectModel;

namespace NovoWPF.ViewModel.Commands
{
    public class AbrirCadastroPessoaCommand : CommandBase
    {
        CadastroPessoaView cadastroPessoaView = new CadastroPessoaView();
        public override void Execute(object parameter)
        {
            cadastroPessoaView.Show();
        }
    }
}
