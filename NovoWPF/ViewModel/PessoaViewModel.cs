using NovoWPF.ViewModel.Commands;
using System.Windows.Input;

namespace NovoWPF.ViewModel
{
    public class PessoaViewModel : ViewModelBase
    {
        public ICommand AbrirCadastroPessoa { get; }

        public PessoaViewModel()
        {
            AbrirCadastroPessoa = new AbrirCadastroPessoaCommand();
        }
    }
}
