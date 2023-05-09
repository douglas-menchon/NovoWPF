using NovoWPF.RegraDeNegocio;
using NovoWPF.View.Pedido;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoWPF.ViewModel.PedidosVM
{
    public class PedidoExpandidoViewModel : ViewModelBase
    {
        public PedidoExpandidoViewModel(dynamic data, ObservableCollection<Pedido> pedidos, PedidoExpandidoView pedidoExpandidoView)
        {
            string indexNome = data.NomePessoa;
            int indexPed = data.IdPedido;
            var indexList = pedidos.Where(p => p.NomePessoa == indexNome && p.IdPedido == indexPed).ToList();

            foreach (var item in indexList)
            {
                pedidoExpandidoView.dataGridPedidoExpandido.ItemsSource = item.Produtos.ToList();
            }
        }
    }
}
