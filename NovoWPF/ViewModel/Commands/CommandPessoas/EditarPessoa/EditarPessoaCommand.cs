using NovoWPF.Commands;
using NovoWPF.Comuns;
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
    public class EditarPessoaCommand : CommandBase
    {
        public ObservableCollection<Pessoa> Pessoas { get; set; }
        private CadastroPessoaView CadastroPessoaView { get; set; }
        public PessoaViewModel PessoaViewModel { get; set; }

        public EditarPessoaCommand(ObservableCollection<Pessoa> pessoas, CadastroPessoaView cadastroPessoaView, PessoaViewModel pessoaViewModel)
        {
            Pessoas = pessoas;
            CadastroPessoaView = cadastroPessoaView;
            PessoaViewModel = pessoaViewModel;
        }
        public override void Execute(object parameter)
        {
            TelaProjetoViewModel telaProjetoViewModel = new TelaProjetoViewModel();
            if (!string.IsNullOrWhiteSpace(CadastroPessoaView.CPFBox.Text) && !string.IsNullOrWhiteSpace(CadastroPessoaView.nomePessoaBox.Text))
            {
                if (Pessoa.ValidaCpf(CadastroPessoaView.CPFBox.Text))
                {
                    int idText = Convert.ToInt32(CadastroPessoaView.idPessoaBox.Text);
                    int indexList = Pessoas.IndexOf(Pessoas.Where(p => p.IdPessoa == idText).FirstOrDefault());

                    Pessoas[indexList].NomePessoa = CadastroPessoaView.nomePessoaBox.Text.ToUpper();
                    Pessoas[indexList].CPF = CadastroPessoaView.CPFBox.Text;
                    Pessoas[indexList].Endereco = CadastroPessoaView.EnderecoBox.Text.ToUpper();

                    MessageBox.Show($"Pessoa: {CadastroPessoaView.nomePessoaBox.Text} editada com sucesso");

                    CadastroPessoaView.Visibility = Visibility.Collapsed;
                    telaProjetoViewModel.ExportarXmlPessoa(Pessoas, PessoaViewModel.IdPessoaLista);
                }
                else
                {
                    MessageBox.Show("CPF Inválido!");
                }
            }
            else
            {
                MessageBox.Show("Campos obrigatórios não preenchidos!!");
            }
        }
    }   
}
