using NovoWPF.Commands;
using NovoWPF.View;
using System.Collections.ObjectModel;

namespace NovoWPF.ViewModel.Commands
{
    public class AbrirCadastroPessoaCommand : CommandBase
    {
        public override void Execute(object parameter)
        {
            CadastroPessoaView cadastroPessoaView = new CadastroPessoaView();
            cadastroPessoaView.DataContext = new CadastroPessoaViewModel();
            cadastroPessoaView.Show();
        }
    }
}
