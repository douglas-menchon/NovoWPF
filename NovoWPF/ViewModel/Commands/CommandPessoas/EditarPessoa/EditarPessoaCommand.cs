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
    public class EditarPessoaCommand : CommandBase
    {
        public ObservableCollection<Pessoa> Pessoas { get; set; }
        private CadastroPessoaView CadastroPessoaView { get; set; }

        public EditarPessoaCommand(ObservableCollection<Pessoa> pessoas, CadastroPessoaView cadastroPessoaView)
        {
            Pessoas = pessoas;
            CadastroPessoaView = cadastroPessoaView;
        }
        public override void Execute(object parameter)
        {
            if (CadastroPessoaView.nomePessoaBox.Text != "" && CadastroPessoaView.CPFBox.Text != "")
            {
                if (Pessoa.ValidaCpf(CadastroPessoaView.CPFBox.Text))
                {
                    int idText = Convert.ToInt32(CadastroPessoaView.idPessoaBox.Text);
                    int indexList = Pessoas.IndexOf(Pessoas.Where(p => p.IdPessoa == idText).FirstOrDefault());

                    Pessoas[indexList].NomePessoa = CadastroPessoaView.nomePessoaBox.Text.ToUpper();
                    Pessoas[indexList].CPF = CadastroPessoaView.CPFBox.Text;
                    Pessoas[indexList].Endereco = CadastroPessoaView.EnderecoBox.Text.ToUpper();

                    MessageBox.Show($"Pessoa: {CadastroPessoaView.nomePessoaBox.Text} editada com sucesso");

                    
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

            CadastroPessoaView.Visibility = Visibility.Collapsed;
        }
    }   
}
