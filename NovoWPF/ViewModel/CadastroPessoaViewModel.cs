using NovoWPF.ViewModel.Commands;
using System.Windows.Input;

namespace NovoWPF.ViewModel
{
    public class CadastroPessoaViewModel : CloseWindow
    {
        public ICommand SalvarPessoa { get; }

        public CadastroPessoaViewModel()
        {
            SalvarPessoa = new SalvaPessoaCommand();
        }
    }
}