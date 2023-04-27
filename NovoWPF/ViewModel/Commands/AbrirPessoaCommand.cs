﻿using NovoWPF.Commands;
using NovoWPF.View;

namespace NovoWPF.ViewModel.Commands
{
    public class AbrirPessoaCommand : CommandBase
    {
        public override void Execute(object parameter)
        {
            PessoaView pessoaView = new PessoaView();
            pessoaView.DataContext = new PessoaViewModel();
            pessoaView.Show();
        }
    }
}