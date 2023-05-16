using NovoWPF.Commands;
using NovoWPF.RegraDeNegocio;
using NovoWPF.View;
using System.Collections.ObjectModel;
using System.Windows;

namespace NovoWPF.ViewModel.Commands
{
    public class AbrirCadastroPessoaCommand : CommandBase
    {
        public ObservableCollection<Pessoa> Pessoas { get; set; }
        public PessoaViewModel PessoaViewModel { get; set; }

        public AbrirCadastroPessoaCommand(ObservableCollection<Pessoa> pessoas, PessoaViewModel pessoaViewModel)
        {
            Pessoas = pessoas;
            PessoaViewModel = pessoaViewModel;
        }
        public override void Execute(object parameter) 
        {
            CadastroPessoaView cadastroPessoaView = new CadastroPessoaView();
            cadastroPessoaView.DataContext = new CadastroPessoaViewModel(Pessoas, cadastroPessoaView, PessoaViewModel);
            cadastroPessoaView.idPessoaBox.Text = PessoaViewModel.IdPessoaLista.ToString();
            cadastroPessoaView.btnSalvarNovaPessoa.Visibility = Visibility.Visible;
            cadastroPessoaView.btnEditarNovaPessoa.Visibility = Visibility.Collapsed;
            cadastroPessoaView.CPFBox.IsReadOnly = false;
            cadastroPessoaView.Show();
        }
    }
}
 