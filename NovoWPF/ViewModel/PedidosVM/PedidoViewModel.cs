using NovoWPF.View;
using NovoWPF.ViewModel.Commands.CommandPedidos.AbrirPedido;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace NovoWPF.ViewModel
{
    public class PedidoViewModel : ViewModelBase
    {
        public ObservableCollection<Pedido> Pedidos { get; set; }

        public ICommand AbrirCadastroPedido { get; }

        public PedidoViewModel()
        {

        }
        public PedidoViewModel(PedidoView pedidoView)
        {
            Pedidos = new ObservableCollection<Pedido>();


            AbrirCadastroPedido = new AbrirCadastroPedidoCommand();
        }
    }
}
