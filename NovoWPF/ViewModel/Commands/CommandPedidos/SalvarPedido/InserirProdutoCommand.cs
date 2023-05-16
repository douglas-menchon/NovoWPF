using NovoWPF.Commands;
using NovoWPF.RegraDeNegocio;
using NovoWPF.View.Pedido;
using NovoWPF.ViewModel.PedidosVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NovoWPF.ViewModel.Commands.CommandPedidos.SalvarPedido
{
    public class InserirProdutoCommand : CommandBase
    {
        public ObservableCollection<Produto> Produtos { get; set; }
        public InserirPedidoView InserirPedidoView { get; set; }
        public InserirPedidoViewModel InserirPedidoViewModel { get; set; }
        public InserirProdutoCommand(InserirPedidoView inserirPedidoView, InserirPedidoViewModel inserirPedidoViewModel, ObservableCollection<Produto> produtos)
        {
            InserirPedidoView = inserirPedidoView;
            InserirPedidoViewModel = inserirPedidoViewModel;
            Produtos = produtos;
        }
        public override void Execute(object parameter)
        {
            var dadoProduto = Produtos.IndexOf(Produtos.Where(p => p.NomeProduto == InserirPedidoView.PedProdutosBox.Text.Trim()).FirstOrDefault());


            if (dadoProduto != -1 && InserirPedidoView.PedProdutosBox.Text != "" && InserirPedidoView.qntdProdPedBox.Text != "" && int.Parse(InserirPedidoView.qntdProdPedBox.Text) >= 1)
            {
                InserirPedidoView.produtosListBox.Items.Add($"{InserirPedidoView.PedProdutosBox.Text.Trim()}  Qntd: {InserirPedidoView.qntdProdPedBox.Text.Trim()}   R$ {Produtos[dadoProduto].Valor}");

                InserirPedidoViewModel.ProdutosPedido.Add(new Produto(Produtos[dadoProduto].IdProduto, InserirPedidoView.PedProdutosBox.Text.Trim(), Produtos[dadoProduto].Valor, int.Parse(InserirPedidoView.qntdProdPedBox.Text.Trim())));
                InserirPedidoView.PedProdutosBox.Text = "";
                InserirPedidoView.qntdProdPedBox.Text = "";
            }
            else
            {
                MessageBox.Show("Campos necessarios não preenchidos corretamente");
            }
        }
    }
}
