using NovoWPF.Commands;
using NovoWPF.View;
using System.Collections.ObjectModel;

namespace NovoWPF.ViewModel.Commands
{
    public class AbrirPessoaCommand : CommandBase
    {
        public ObservableCollection<Pessoa> Pessoas { get; set; } = new ObservableCollection<Pessoa>();

        public override void Execute(object parameter)
        {
            PessoaView pessoaView = new PessoaView(Pessoas);
            pessoaView.DataContext = new PessoaViewModel();
            pessoaView.Show();
        }
    }
}
