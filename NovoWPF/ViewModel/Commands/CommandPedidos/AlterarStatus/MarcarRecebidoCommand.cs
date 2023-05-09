using NovoWPF.Commands;
using NovoWPF.RegraDeNegocio;
using NovoWPF.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoWPF.ViewModel.Commands.CommandPedidos.AlterarStatus
{
    public class MarcarRecebidoCommand : CommandBase
    {
        public ObservableCollection<Pedido> Pedidos { get; set; }
        public PedidoView PedidoView { get; set; }
        public MarcarRecebidoCommand(ObservableCollection<Pedido> pedidos, PedidoView pedidoView)
        {
            Pedidos = pedidos;
            PedidoView = pedidoView;
        }
        public override void Execute(object parameter)
        {
            dynamic data = PedidoView.dataGridPedidos.SelectedItem;
            int indexPed = data.IdPedido;
            var indexList = Pedidos.Where(p => p.IdPedido == indexPed).FirstOrDefault();

            indexList.Status = (Status)3;
            PedidoView.dataGridPedidos.Items.Refresh();
        }
    }
}
