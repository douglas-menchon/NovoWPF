using NovoWPF.RegraDeNegocio;
using NovoWPF.View;
using NovoWPF.ViewModel.Commands.CommandPedidos.AlterarStatus;
using NovoWPF.ViewModel.Commands.CommandPedidos.ExpandirPedido;
using NovoWPF.ViewModel.Commands.CommandPedidos.PesquisaStatus;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace NovoWPF.ViewModel.PedidosVM
{
    public class DetalhePedidoViewModel : ViewModelBase
    {
        public ICommand ExpandirPedido { get; set; }
        public ICommand MarcarEnviado { get; set; }
        public ICommand MarcarRecebido { get; set; }
        public ICommand MarcarPago { get; set; }
        public ICommand PesquisarTodos { get; set; }
        public ICommand PesquisarPendente { get; set; }
        public ICommand PesquisarPago { get; set; }
        public ICommand PesquisarEntregue { get; set; }



        public DetalhePedidoViewModel(string nomePessoaSelecionada, ObservableCollection<Pedido> pedidos, PedidoView pedidoView)
        {
            ExpandirPedido = new ExpandirPedidoCommand(pedidoView, pedidos);
            MarcarEnviado = new MarcarEnviadoCommand(pedidos, pedidoView);
            MarcarRecebido = new MarcarRecebidoCommand(pedidos, pedidoView);
            MarcarPago = new MarcarPagoCommand(pedidos, pedidoView);
            PesquisarTodos = new PesquisarTodosCommand(pedidos, pedidoView);
            PesquisarPendente = new PesquisarPendenteCommand(pedidos, pedidoView);
            PesquisarPago = new PesquisarPagoCommand(pedidos, pedidoView);
            PesquisarEntregue = new PesquisarEntregueCommand(pedidos, pedidoView);
        }
    }
}
