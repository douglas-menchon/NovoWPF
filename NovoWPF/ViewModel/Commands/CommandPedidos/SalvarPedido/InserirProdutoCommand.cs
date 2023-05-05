using NovoWPF.Commands;
using NovoWPF.RegraDeNegocio;
using NovoWPF.View.Pedido;
using NovoWPF.ViewModel.PedidosVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NovoWPF.ViewModel.Commands.CommandPedidos.SalvarPedido
{
    public class InserirProdutoCommand : CommandBase
    {
        public ProdutoViewModel ProdutoViewModel { get; set; }
        public InserirPedidoView InserirPedidoView { get; set; }
        public InserirPedidoViewModel InserirPedidoViewModel { get; set; }
        public InserirProdutoCommand(ProdutoViewModel produtoViewModel, InserirPedidoView inserirPedidoView, InserirPedidoViewModel inserirPedidoViewModel)
        {
            ProdutoViewModel = produtoViewModel;
            InserirPedidoView = inserirPedidoView;
            InserirPedidoViewModel = inserirPedidoViewModel;
        }
        public override void Execute(object parameter)
        {
            var dadoProduto = ProdutoViewModel.Produtos.IndexOf(ProdutoViewModel.Produtos.Where(p => p.NomeProduto == InserirPedidoView.PedProdutosBox.Text).FirstOrDefault());


            if (dadoProduto != -1 && InserirPedidoView.PedProdutosBox.Text != "" && InserirPedidoView.qntdProdPedBox.Text != "" && int.Parse(InserirPedidoView.qntdProdPedBox.Text) >= 1)
            {
                InserirPedidoView.produtosListBox.Items.Add($"{InserirPedidoView.PedProdutosBox.Text}  Qntd: {InserirPedidoView.qntdProdPedBox.Text}   R$ {ProdutoViewModel.Produtos[dadoProduto].Valor}");

                InserirPedidoViewModel.ProdutosPedido.Add(new Produto(ProdutoViewModel.Produtos[dadoProduto].IdProduto, InserirPedidoView.PedProdutosBox.Text, ProdutoViewModel.Produtos[dadoProduto].Valor, int.Parse(InserirPedidoView.qntdProdPedBox.Text)));
            }
            else
            {
                MessageBox.Show("Campos necessarios não preenchidos corretamente");
            }
        }
    }
}
