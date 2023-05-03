using NovoWPF.Commands;
using NovoWPF.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NovoWPF.ViewModel.Commands
{
    public class SalvaPessoaCommand : CommandBase
    {
        public ObservableCollection<Pessoa> Pessoas { get; set; }

        public override void Execute(object parameter)
        {
            CadastroPessoaView cadastroPessoaView = new CadastroPessoaView();
            Pessoas = new ObservableCollection<Pessoa>();
            cadastroPessoaView.ShowDialog();

            Pessoas.Add(new Pessoa(int.Parse(cadastroPessoaView.idPessoaBox.Text),
                                             cadastroPessoaView.nomePessoaBox.Text,
                                             cadastroPessoaView.CPFBox.Text,
                                             cadastroPessoaView.EnderecoBox.Text));

            PessoaView pessoaView = new PessoaView(Pessoas);
            pessoaView.dataGridPessoa.ItemsSource = Pessoas;

            pessoaView.Show();
        }
     
    }
}