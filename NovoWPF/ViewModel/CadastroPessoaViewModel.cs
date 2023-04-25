using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NovoWPF.ViewModel
{
    public class CadastroPessoaViewModel
    {
        public ICommand SalvarPessoa { get; }
        public ICommand CancelarPessoa { get; }

    }
}
