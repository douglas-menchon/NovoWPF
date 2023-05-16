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
    public class AbrirEditarPessoaCommand : CommandBase
    {
        public ObservableCollection<Pessoa> Pessoas { get; set; }
        public PessoaViewModel PessoaViewModel { get; set; }
        public PessoaView PessoaView { get; set; }
        public int IdPessoaLista { get; set; }

        public AbrirEditarPessoaCommand(ObservableCollection<Pessoa> pessoas, PessoaView pessoaView, PessoaViewModel pessoaViewModel)
        {
            Pessoas = pessoas;
            PessoaView = pessoaView;
            PessoaViewModel = pessoaViewModel;
        }

        public override void Execute(object parameter)
        {
            CadastroPessoaView cadastroPessoaView = new CadastroPessoaView();
            cadastroPessoaView.DataContext = new CadastroPessoaViewModel(Pessoas, cadastroPessoaView, PessoaViewModel);

            dynamic data = PessoaView.dataGridPessoa.SelectedItem;
            if (data != null)
            {
                int indexData = data.IdPessoa;
                int indexList = Pessoas.IndexOf(Pessoas.Where(p => p.IdPessoa == indexData).FirstOrDefault());

                if (indexList != -1)
                {

                    cadastroPessoaView.idPessoaBox.Text = Convert.ToString(Pessoas[indexList].IdPessoa);
                    cadastroPessoaView.nomePessoaBox.Text = Pessoas[indexList].NomePessoa;
                    cadastroPessoaView.CPFBox.Text = Pessoas[indexList].CPF;
                    cadastroPessoaView.EnderecoBox.Text = Pessoas[indexList].Endereco;
                    cadastroPessoaView.CPFBox.IsReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Erro ao carregar os dados");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Selecione uma pessoa para editar!");
                return;
            }

            cadastroPessoaView.btnSalvarNovaPessoa.Visibility = Visibility.Collapsed;
            cadastroPessoaView.btnEditarNovaPessoa.Visibility = Visibility.Visible;
            cadastroPessoaView.Show();

        }
    }
}
