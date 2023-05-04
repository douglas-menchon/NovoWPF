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
    public class AbrirEditarPessoaCommand : CommandBase
    {
        public ObservableCollection<Pessoa> Pessoas { get; set; }
        public PessoaView PessoaView { get; set; }

        public AbrirEditarPessoaCommand(ObservableCollection<Pessoa> pessoas, PessoaView pessoaView)
        {
            Pessoas = pessoas;
            PessoaView = pessoaView;
        }

        public override void Execute(object parameter)
        {
            CadastroPessoaView cadastroPessoaView = new CadastroPessoaView();
            cadastroPessoaView.DataContext = new CadastroPessoaViewModel(Pessoas, cadastroPessoaView);

            dynamic data = PessoaView.dataGridPessoa.SelectedItem;
            int indexData = data.IdPessoa;
            int indexList = Pessoas.IndexOf(Pessoas.Where(p => p.IdPessoa == indexData).FirstOrDefault());

            if (indexList != -1)
            {
               
                cadastroPessoaView.idPessoaBox.Text = Convert.ToString(Pessoas[indexList].IdPessoa);
                cadastroPessoaView.nomePessoaBox.Text = Pessoas[indexList].NomePessoa;
                cadastroPessoaView.CPFBox.Text = Pessoas[indexList].CPF;
                cadastroPessoaView.EnderecoBox.Text = Pessoas[indexList].Endereco;
            }
            else
            {
                MessageBox.Show("Erro ao carregar os dados");
                return;
            }


            cadastroPessoaView.btnSalvarNovaPessoa.Visibility = Visibility.Collapsed;
            cadastroPessoaView.btnEditarNovaPessoa.Visibility = Visibility.Visible;
            cadastroPessoaView.Show();

        }
    }
}
