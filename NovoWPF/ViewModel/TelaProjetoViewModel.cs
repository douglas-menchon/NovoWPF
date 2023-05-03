using NovoWPF.Commands;
using NovoWPF.ViewModel.Commands;
using System.Windows.Input;

namespace NovoWPF.ViewModel
{
    public class TelaProjetoViewModel : ViewModelBase
    {
        public ICommand AbrirTelaProduto { get; }
        public ICommand AbrirTelaPessoa { get; }

        public TelaProjetoViewModel()
        {
            AbrirTelaPessoa = new AbrirPessoaCommand();
            AbrirTelaProduto = new AbrirProdutoCommand();
        }
        
    }
}