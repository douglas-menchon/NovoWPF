﻿using NovoWPF.Commands;
using NovoWPF.Comuns;
using NovoWPF.RegraDeNegocio;
using NovoWPF.View;
using System.Collections.ObjectModel;
using System.Windows;

namespace NovoWPF.ViewModel.Commands
{
    public class SalvaPessoaCommand : CommandBase
    {
        public ObservableCollection<Pessoa> Pessoas { get; set; }
        private CadastroPessoaView CadastroPessoaView { get; set; }
        public PessoaViewModel PessoaViewModel { get;  set; }

        public SalvaPessoaCommand(ObservableCollection<Pessoa> pessoas, CadastroPessoaView cadastroPessoaView, PessoaViewModel pessoaViewModel)
        {
            Pessoas = pessoas;
            CadastroPessoaView = cadastroPessoaView;
            PessoaViewModel = pessoaViewModel;
        }
        public override void Execute(object parameter)
        {
            ControleXML controleXML = new ControleXML(Pessoas);
            if (CadastroPessoaView.CPFBox.Text != "" && CadastroPessoaView.nomePessoaBox.Text != "")
            {
                if (Pessoa.ValidaCpf(CadastroPessoaView.CPFBox.Text))
                {
                    Pessoas.Add(new Pessoa(int.Parse(CadastroPessoaView.idPessoaBox.Text)
                                                   , CadastroPessoaView.nomePessoaBox.Text.ToUpper()
                                                   , CadastroPessoaView.CPFBox.Text
                                                   , CadastroPessoaView.EnderecoBox.Text.ToUpper()
                                                   , PessoaViewModel.IdPessoaLista));

                    MessageBox.Show($"Cliente {CadastroPessoaView.nomePessoaBox.Text} cadastrado com sucesso");
                    PessoaViewModel.IdPessoaLista++;
                    CadastroPessoaView.Visibility = Visibility.Collapsed;
                    controleXML.ExportarXmlPessoa(Pessoas, PessoaViewModel.IdPessoaLista);
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