using NovoWPF.Commands;
using NovoWPF.RegraDeNegocio;
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
    public class PesquisarPessoaCommand : CommandBase
    {
        public ObservableCollection<Pessoa> Pessoas { get; set; }
        public PessoaView PessoaView { get; set; }

        public PesquisarPessoaCommand(ObservableCollection<Pessoa> pessoas, PessoaView pessoaView)
        {
            Pessoas = pessoas;
            PessoaView = pessoaView;
        }

        public override void Execute(object parameter)
        {
            var dadosGrid = Pessoas.Where(g => g.NomePessoa.Contains(PessoaView.txtBoxPesquisaPessoa.Text) || g.CPF.Contains(PessoaView.txtBoxPesquisaPessoa.Text)).ToList();

            if (dadosGrid.Count > 0 && PessoaView.txtBoxPesquisaPessoa.Text != "")
                PessoaView.dataGridPessoa.ItemsSource = dadosGrid;
            else
                MessageBox.Show("Pessoa não encontrada!");

            PessoaView.txtBoxPesquisaPessoa.Text = "";
        }
    }
}
