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

namespace NovoWPF.ViewModel.Commands.CommandPedidos.AbrirPedido
{
    public class AbrirIncluirPedidoCommand : CommandBase
    {
        public ObservableCollection<Pedido> Pedidos { get; set; }
        public ObservableCollection<Pessoa> Pessoas { get; set; }
        public PessoaView PessoaView { get; set; }
        public PessoaViewModel PessoaViewModel { get; set; }
        public int IdPedidoLista { get; set; }
        public AbrirIncluirPedidoCommand(ObservableCollection<Pessoa> pessoas, PessoaView pessoaView, ObservableCollection<Pedido> pedidos, PessoaViewModel pessoaViewModel)
        {
            Pessoas = pessoas;
            PessoaView = pessoaView;
            Pedidos = pedidos;
            PessoaViewModel = pessoaViewModel;
        }

        public override void Execute(object parameter)
        {
            InserirPedidoView inserirPedidoView = new InserirPedidoView();
            inserirPedidoView.DataContext = new InserirPedidoViewModel(inserirPedidoView, Pedidos);

            dynamic data = PessoaView.dataGridPessoa.SelectedItem;
            string indexData = data.NomePessoa;
        
            inserirPedidoView.idPedidoBox.Text = $"{PessoaViewModel.IdPedidoLista}";

            inserirPedidoView.nomePedidoPessoaBox.Text = indexData;
            inserirPedidoView.DataPedidoBox.Text = DateTime.Now.ToString("dd-MM-yyyy");

            inserirPedidoView.Show();
        }
    }
}
