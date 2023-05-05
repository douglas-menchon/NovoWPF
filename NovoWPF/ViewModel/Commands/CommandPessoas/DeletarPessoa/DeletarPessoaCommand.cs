using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using NovoWPF.Commands;
using NovoWPF.RegraDeNegocio;
using NovoWPF.View;

namespace NovoWPF.ViewModel
{
    internal class DeletarPessoaCommand : CommandBase
    {
        private ObservableCollection<Pessoa> Pessoas { get; set; }
        private PessoaView PessoaView { get; set; }

        public DeletarPessoaCommand(ObservableCollection<Pessoa> pessoas, PessoaView cadastro)
        {
            Pessoas = pessoas;
            PessoaView = cadastro;
        }

        public override void Execute(object parameter)
        {
            dynamic data = PessoaView.dataGridPessoa.SelectedItem;

            if(data != null)
                Pessoas.Remove(data);
            else
            {
                MessageBox.Show("Selecione uma pessoa para deletar!");
                return;
            }
        }
    }
}