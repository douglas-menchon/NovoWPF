using NovoWPF.ViewModel.Commands;
using System.Windows.Input;

namespace NovoWPF.ViewModel
{
    public class PedidoViewModel : ViewModelBase
    {
        public ICommand AbrirCadastroProduto { get; }

        public PedidoViewModel()
        {
            AbrirCadastroProduto = new AbrirCadastroProdutoCommand();
        }
    }
}
