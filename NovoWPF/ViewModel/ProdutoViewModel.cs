using NovoWPF.ViewModel.Commands;
using System.Windows.Input;

namespace NovoWPF.ViewModel
{
    public class ProdutoViewModel : ViewModelBase
    {
        public ICommand AbrirCadastroProduto{ get; }

        public ProdutoViewModel()
        {            
            AbrirCadastroProduto = new AbrirCadastroProdutoCommand();
        }
    }
}