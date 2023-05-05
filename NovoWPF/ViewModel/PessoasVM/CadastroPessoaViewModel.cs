﻿using NovoWPF.View;
using NovoWPF.ViewModel.Commands;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace NovoWPF.ViewModel
{
    public class CadastroPessoaViewModel : CloseWindow
    {

        public ICommand SalvarPessoa { get; }
        public ICommand EditarPessoa { get; }

        public CadastroPessoaViewModel(ObservableCollection<Pessoa> pessoas, CadastroPessoaView cadastro, PessoaViewModel pessoaViewModel)
        {
            SalvarPessoa = new SalvaPessoaCommand(pessoas, cadastro, pessoaViewModel);
        }     

        public CadastroPessoaViewModel(ObservableCollection<Pessoa> pessoas, CadastroPessoaView cadastro)
        {
            EditarPessoa = new EditarPessoaCommand(pessoas, cadastro);
        }

        public CadastroPessoaViewModel()
        {

        }
    }
}