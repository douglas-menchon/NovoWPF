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
        public ObservableCollection<Produto> Produtos { get; set; }
        public PessoaView PessoaView { get; set; }
        public PessoaViewModel PessoaViewModel { get; set; }
        public int IdPedidoLista { get; set; }
        public AbrirIncluirPedidoCommand(ObservableCollection<Pessoa> pessoas, PessoaView pessoaView, ObservableCollection<Pedido> pedidos, PessoaViewModel pessoaViewModel, ObservableCollection<Produto> produtos)
        {
            Pessoas = pessoas;
            PessoaView = pessoaView;
            Pedidos = pedidos;
            PessoaViewModel = pessoaViewModel;
            Produtos = produtos;
        }

        public override void Execute(object parameter)
        {
            InserirPedidoView inserirPedidoView = new InserirPedidoView();
            inserirPedidoView.DataContext = new InserirPedidoViewModel(inserirPedidoView, Pedidos, Produtos, PessoaViewModel);

            dynamic data = PessoaView.dataGridPessoa.SelectedItem;
            if (data != null)
            {
                string indexData = data.NomePessoa;
        
                inserirPedidoView.idPedidoBox.Text = (Pedidos.Count + 1).ToString();

                inserirPedidoView.produtosPedListBox.ItemsSource = Produtos;
                inserirPedidoView.nomePedidoPessoaBox.Text = indexData;
                inserirPedidoView.DataPedidoBox.Text = DateTime.Now.ToString("dd-MM-yyyy");

                inserirPedidoView.Show();
            }
            else
            {
                MessageBox.Show("Favor selecionar uma pessoa");
            }
        }
    }
}
