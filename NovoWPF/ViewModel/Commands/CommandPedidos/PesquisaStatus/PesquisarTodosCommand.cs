using NovoWPF.Commands;
using NovoWPF.RegraDeNegocio;
using NovoWPF.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoWPF.ViewModel.Commands.CommandPedidos.PesquisaStatus
{
    public class PesquisarTodosCommand : CommandBase
    {
        public ObservableCollection<Pedido> Pedidos { get; set; }
        public PedidoView PedidoView { get; set; }
        public PesquisarTodosCommand(ObservableCollection<Pedido> pedidos, PedidoView pedidoView)
        {
            Pedidos = pedidos;
            PedidoView = pedidoView;
        }
        public override void Execute(object parameter)
        {
            var indexList = Pedidos.Where(p => p.NomePessoa == PedidoView.txtNomePedido.Text).ToList();

            PedidoView.dataGridPedidos.ItemsSource = indexList;
        }
    }
}
