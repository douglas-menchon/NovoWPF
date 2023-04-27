using NovoWPF.Commands;
using NovoWPF.View;

namespace NovoWPF.ViewModel.Commands
{
    public class AbrirCadastroPessoaCommand : CommandBase
    {
        public override void Execute(object parameter)
        {
            CadastroPessoaView cadastroPessoaView = new CadastroPessoaView();
            cadastroPessoaView.Show();
        }
    }
}
