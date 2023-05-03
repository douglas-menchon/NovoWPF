using NovoWPF.Commands;
using NovoWPF.View;

namespace NovoWPF.ViewModel.Commands
{
    public class SalvaPessoaCommand : CommandBase
    {


        public override void Execute(object parameter)
        {
            CadastroPessoaView cadastroPessoaView = new CadastroPessoaView();
            Pessoa p = new Pessoa
            {
                IdPessoa = int.Parse(IdPessoaTextBox),
                NomePessoa = NomePessoaTextBox,
                CPF = CPFTextBox,
                Endereco = EnderecoTextBox
            };

            Pessoas.Add(p);

            PessoaView pessoaView = new PessoaView(Pessoas);
            pessoaView.dataGridPessoa.ItemsSource = Pessoas;

            pessoaView.Show();
        }
     
    }
}