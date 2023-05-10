using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using NovoWPF.Commands;
using NovoWPF.Comuns;
using NovoWPF.RegraDeNegocio;
using NovoWPF.View;

namespace NovoWPF.ViewModel
{
    internal class DeletarPessoaCommand : CommandBase
    {
        private ObservableCollection<Pessoa> Pessoas { get; set; }
        private PessoaView PessoaView { get; set; }
        public PessoaViewModel PessoaViewModel { get; set; }

        public DeletarPessoaCommand(ObservableCollection<Pessoa> pessoas, PessoaView cadastro, PessoaViewModel pessoaViewModel)
        {
            Pessoas = pessoas;
            PessoaView = cadastro;
            PessoaViewModel = pessoaViewModel;
        }

        public override void Execute(object parameter)
        {
            TelaProjetoViewModel telaProjetoViewModel = new TelaProjetoViewModel();
            dynamic data = PessoaView.dataGridPessoa.SelectedItem;

            if(data != null)
            {
                Pessoas.Remove(data);

                telaProjetoViewModel.ExportarXmlPessoa(Pessoas, PessoaViewModel.IdPessoaLista);
            }
            else
            {
                MessageBox.Show("Selecione uma pessoa para deletar!");
            }
        }
    }
}