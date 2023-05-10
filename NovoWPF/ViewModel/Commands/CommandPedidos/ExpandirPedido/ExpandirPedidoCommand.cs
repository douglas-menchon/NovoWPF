using NovoWPF.Commands;
using NovoWPF.RegraDeNegocio;
using NovoWPF.View;
using NovoWPF.View.Pedido;
using NovoWPF.ViewModel.PedidosVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NovoWPF.ViewModel.Commands.CommandPedidos.ExpandirPedido
{
    public class ExpandirPedidoCommand : CommandBase
    {
        public PedidoView PedidoView { get; set; }
        public ObservableCollection<Pedido> Pedidos { get; set; }
        public ExpandirPedidoCommand(PedidoView pedidoView, ObservableCollection<Pedido> pedidos)
        {
            PedidoView = pedidoView;
            Pedidos = pedidos;
        }

        public override void Execute(object parameter)
        {
            PedidoExpandidoView pedidoExpandidoView = new PedidoExpandidoView();
            dynamic data = PedidoView.dataGridPedidos.SelectedItem;
            if(data != null)
            {
                pedidoExpandidoView.DataContext = new PedidoExpandidoViewModel(data, Pedidos, pedidoExpandidoView);
                pedidoExpandidoView.Show();
            }
            else
            {
                MessageBox.Show("Favor selecionar um pedido!");
            }
        }
    }
}
