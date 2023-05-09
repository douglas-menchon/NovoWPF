using NovoWPF.Commands;
using NovoWPF.RegraDeNegocio;
using NovoWPF.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NovoWPF.ViewModel.Commands.CommandPedidos.PesquisaStatus
{
    public class PesquisarEntregueCommand : CommandBase
    {
        public ObservableCollection<Pedido> Pedidos { get; set; }
        public PedidoView PedidoView { get; set; }
        public PesquisarEntregueCommand(ObservableCollection<Pedido> pedidos, PedidoView pedidoView)
        {
            Pedidos = pedidos;
            PedidoView = pedidoView;
        }
        public override void Execute(object parameter)
        {
            var dado = Pedidos.Where(p => p.Status == (Status)3 && p.NomePessoa == PedidoView.txtNomePedido.Text).ToList();

            if (dado.Count > 0)
                PedidoView.dataGridPedidos.ItemsSource = dado;
            else
            {
                MessageBox.Show("Pedidos não encontrados!");
                var indexList = Pedidos.Where(p => p.NomePessoa == PedidoView.txtNomePedido.Text).ToList();
                PedidoView.dataGridPedidos.ItemsSource = indexList;
            }
        }
    }
}
