using NovoWPF.Commands;
using NovoWPF.RegraDeNegocio;
using NovoWPF.View;
using NovoWPF.ViewModel.PedidosVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NovoWPF.ViewModel.Commands.CommandPedidos.AbrirPedido
{
    public class AbrirDetalhePedidoCommand : CommandBase
    {
        public ObservableCollection<Pedido> Pedidos { get; set; }
        public PessoaView PessoaView { get; set; }
 
        public AbrirDetalhePedidoCommand(PessoaView pessoaView, ObservableCollection<Pedido> pedidos)
        {
            Pedidos = pedidos;
            PessoaView = pessoaView;
        }
        public override void Execute(object parameter)
        {
            PedidoView pedidoView = new PedidoView();

            dynamic data = PessoaView.dataGridPessoa.SelectedItem;
            string indexData = data.NomePessoa;
            var indexList = Pedidos.Where(p => p.NomePessoa == indexData).ToList();

            if (indexList.Count > 0)
            {
                pedidoView.txtNomePedido.Text = indexData;
                pedidoView.dataGridPedidos.ItemsSource = indexList;
                pedidoView.DataContext = new DetalhePedidoViewModel(indexData, Pedidos, pedidoView);
                pedidoView.Show();
            }
            else
            {
                MessageBox.Show("Nenhum Pedido Encontrado");
                return;
            }
        }
    }
}
