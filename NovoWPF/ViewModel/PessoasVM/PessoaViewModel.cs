using NovoWPF.View;
using NovoWPF.ViewModel.Commands;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace NovoWPF.ViewModel
{
    public class PessoaViewModel : ViewModelBase
    {
        public ObservableCollection<Pessoa> Pessoas { get; set; }
        public int IdPessoaLista { get; set; }
        public ICommand AbrirCadastroPessoa { get; }
        public ICommand AbrirEditarPessoa { get; }
        public ICommand DeletarPessoa { get; }
        public ICommand PesquisarPessoa { get; }
        public ICommand CancelarPesquisarPessoa { get; }

        public PessoaViewModel()
        {

        }

        public PessoaViewModel(PessoaView pessoaView)
        {
            Pessoas = new ObservableCollection<Pessoa>
            {
                new Pessoa(1, "Nome A", "11111111111", "Rua 1"),
                new Pessoa(2, "Nome B", "09634422950", "Rua 2"),
                new Pessoa(3, "Nome C", "12345678900", "Rua 3")
            };
            
            pessoaView.dataGridPessoa.ItemsSource = Pessoas;
            VerificaIdLista();
            AbrirEditarPessoa       = new AbrirEditarPessoaCommand(Pessoas, pessoaView);
            AbrirCadastroPessoa     = new AbrirCadastroPessoaCommand(Pessoas, this);
            DeletarPessoa           = new DeletarPessoaCommand(Pessoas, pessoaView);
            PesquisarPessoa         = new PesquisarPessoaCommand(Pessoas, pessoaView);
            CancelarPesquisarPessoa = new CancelarPesquisarPessoaCommand(Pessoas, pessoaView);
        }

        public void VerificaIdLista()
        {
            if (Pessoas.Count < 1)
                IdPessoaLista = 1;
            else
                IdPessoaLista = Pessoas.Count + 1;
        }
    }
}
