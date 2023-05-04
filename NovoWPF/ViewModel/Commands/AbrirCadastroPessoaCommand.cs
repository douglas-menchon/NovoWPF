using NovoWPF.Commands;
using NovoWPF.View;
using System.Collections.ObjectModel;
using System.Windows;

namespace NovoWPF.ViewModel.Commands
{
    public class AbrirCadastroPessoaCommand : CommandBase
    {
        public ObservableCollection<Pessoa> Pessoas { get; set; }
        public int IdPessoaLista { get; set; }

        public AbrirCadastroPessoaCommand(ObservableCollection<Pessoa> pessoas, int idPessoaLista)
        {
            Pessoas = pessoas;
            IdPessoaLista = idPessoaLista;
        }
        public override void Execute(object parameter) 
        {
            CadastroPessoaView cadastroPessoaView = new CadastroPessoaView();
            cadastroPessoaView.DataContext = new CadastroPessoaViewModel(Pessoas, cadastroPessoaView);
            cadastroPessoaView.idPessoaBox.Text = IdPessoaLista.ToString();
            cadastroPessoaView.btnSalvarNovaPessoa.Visibility = Visibility.Visible;
            cadastroPessoaView.btnEditarNovaPessoa.Visibility = Visibility.Collapsed;
            cadastroPessoaView.Show();
        }
    }
}
 