using NovoWPF.Commands;
using NovoWPF.View;
using NovoWPF.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using NovoWPF.Comuns;

namespace NovoWPF.ViewModel
{
    public class CadastroPessoaViewModel : VariaveisUniversais
    {
        public ICommand SalvarPessoa { get; }
        public Action CloseAction { get; set; }

        public CadastroPessoaViewModel()
        {
            GerarComandos();
        }

        private void GerarComandos()
        {
            Comandos = new CommandMap();
            Comandos.AdicionarComando(Fechar);
        }

        public void Close()
        {
            CloseAction?.Invoke();
        }

        private void Fechar()
        {
            Close();
        }
    }
}
