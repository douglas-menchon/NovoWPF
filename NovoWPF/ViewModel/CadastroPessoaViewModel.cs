using System.ComponentModel;
using System.Windows.Input;

namespace NovoWPF.ViewModel
{
    public class CadastroPessoaViewModel : ViewModelBase
    {
        public ICommand SalvarPessoa { get; }
        public ICommand CancelarPessoa { get; }

        public CadastroPessoaViewModel()
        {

        }
    }
}
