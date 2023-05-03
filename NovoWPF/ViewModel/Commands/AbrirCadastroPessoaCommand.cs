using NovoWPF.Commands;
using NovoWPF.View;
using System.Collections.ObjectModel;
using System.Windows;

namespace NovoWPF.ViewModel.Commands
{
    public class AbrirCadastroPessoaCommand : CommandBase
    {
        public ObservableCollection<Pessoa> Pessoas { get; set; }

        public AbrirCadastroPessoaCommand(ObservableCollection<Pessoa> pessoas)
        {
            Pessoas = pessoas;
        }
        public override void Execute(object parameter) 
        {
            CadastroPessoaView cadastroPessoaView = new CadastroPessoaView();
            cadastroPessoaView.DataContext = new CadastroPessoaViewModel(Pessoas, cadastroPessoaView);
            cadastroPessoaView.btnSalvarNovaPessoa.Visibility = Visibility.Visible;
            cadastroPessoaView.btnEditarNovaPessoa.Visibility = Visibility.Collapsed;
            cadastroPessoaView.Show();
        }
    }
}
 