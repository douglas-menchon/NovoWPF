using NovoWPF.RegraDeNegocio;
using NovoWPF.View;
using NovoWPF.View.Pedido;
using NovoWPF.ViewModel.Commands.CommandPedidos.SalvarPedido;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NovoWPF.ViewModel.PedidosVM
{
    public class InserirPedidoViewModel : CloseWindow
    {
        public List<Produto> ProdutosPedido { get; set; }
        public ICommand InserirProduto { get; }
        public ICommand SalvarPedido { get; }
        public InserirPedidoViewModel(InserirPedidoView inserirPedidoView, ObservableCollection<Pedido> pedidos, ObservableCollection<Produto> produtos, PessoaViewModel pessoaViewModel)
        {
            ProdutosPedido = new List<Produto>();
            InserirProduto = new InserirProdutoCommand(inserirPedidoView, this, produtos);
            SalvarPedido = new SalvarPedidoCommand(inserirPedidoView, this, pessoaViewModel, pedidos);
        }
    }
}
