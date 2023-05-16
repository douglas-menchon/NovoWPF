using NovoWPF.Commands;
using NovoWPF.Comuns;
using NovoWPF.RegraDeNegocio;
using NovoWPF.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NovoWPF.ViewModel.Commands.CommandPedidos.AlterarStatus
{
    public class MarcarEnviadoCommand : CommandBase
    {
        public ObservableCollection<Pedido> Pedidos { get; set; }
        public PedidoView PedidoView { get; set; }
        public MarcarEnviadoCommand(ObservableCollection<Pedido> pedidos, PedidoView pedidoView)
        {
            Pedidos = pedidos;
            PedidoView = pedidoView;
        }

        public override void Execute(object parameter)
        {
            TelaProjetoViewModel telaProjetoViewModel = new TelaProjetoViewModel();

            dynamic data = PedidoView.dataGridPedidos.SelectedItem;
            if (data != null)
            {
                int indexPed = data.IdPedido;
                var indexList = Pedidos.Where(p => p.IdPedido == indexPed).FirstOrDefault();

                indexList.Status = (Status)2;
                PedidoView.dataGridPedidos.Items.Refresh();
                telaProjetoViewModel.ExportarXmlPedido(Pedidos);
            }
            else
                MessageBox.Show("Favor selecionar uma pessoa");

        }
    }
}
