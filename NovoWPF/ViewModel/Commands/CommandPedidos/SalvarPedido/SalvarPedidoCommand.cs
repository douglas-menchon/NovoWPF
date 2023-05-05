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
    public class SalvarPedidoCommand : CommandBase
    {
        public InserirPedidoView InserirPedidoView { get; set; }
        public InserirPedidoViewModel InserirPedidoViewModel { get; set; }
        public PessoaViewModel PessoaViewModel { get; set; }
        public SalvarPedidoCommand(InserirPedidoView inserirPedidoView, InserirPedidoViewModel inserirPedidoViewModel, PessoaViewModel pessoaViewModel)
        {
            InserirPedidoView = inserirPedidoView;
            InserirPedidoViewModel = inserirPedidoViewModel;
            PessoaViewModel = pessoaViewModel;
        }
        public override void Execute(object parameter)
        {
            double valorPedido = 0;


            if (InserirPedidoView.FormaPagPedidoBox.SelectedValue != null && InserirPedidoView.produtosListBox.HasItems)
            {

                foreach (var item in InserirPedidoViewModel.ProdutosPedido)
                {
                    var valorPorQntd = item.Valor * item.QntdProduto;

                    valorPedido += valorPorQntd;
                }

                PessoaViewModel.Pedidos.Add(new Pedido(PessoaViewModel.IdPedidoLista, InserirPedidoView.nomePedidoPessoaBox.Text.ToUpper(), InserirPedidoViewModel.ProdutosPedido, valorPedido, Convert.ToInt32(InserirPedidoView.FormaPagPedidoBox.SelectedValue), 0, PessoaViewModel.IdPedidoLista + 1));
                             
                MessageBox.Show("Cadastro efetuado com sucesso");

                PessoaViewModel.IdPedidoLista++;
                InserirPedidoViewModel.ProdutosPedido.Clear();

            }
            else
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!");

            }
        }
    }
}
