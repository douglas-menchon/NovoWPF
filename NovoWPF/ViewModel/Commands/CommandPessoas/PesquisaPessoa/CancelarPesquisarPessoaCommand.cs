using NovoWPF.Commands;
using NovoWPF.RegraDeNegocio;
using NovoWPF.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoWPF.ViewModel.Commands
{
    public class CancelarPesquisarPessoaCommand : CommandBase
    {
        public ObservableCollection<Pessoa> Pessoas { get; set; }
        public PessoaView PessoaView { get; set; }

        public CancelarPesquisarPessoaCommand(ObservableCollection<Pessoa> pessoas, PessoaView pessoaView)
        {
            Pessoas = pessoas;
            PessoaView = pessoaView;
        }

        public override void Execute(object parameter)
        {
            PessoaView.dataGridPessoa.ItemsSource = Pessoas;
        }
    }
}
