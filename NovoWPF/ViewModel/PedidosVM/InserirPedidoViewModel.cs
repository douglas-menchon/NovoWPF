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
    public class InserirPedidoViewModel : ViewModelBase
    {
        public List<Produto> ProdutosPedido { get; set; }
        public ICommand InserirProduto { get; }
        public ICommand SalvarPedido { get; }
        public InserirPedidoViewModel(InserirPedidoView inserirPedidoView, ObservableCollection<Pedido> pedidos, ObservableCollection<Produto> produtos)
        {
            ProdutosPedido = new List<Produto>();
            PessoaViewModel PessoaViewModel = new PessoaViewModel();
            InserirProduto = new InserirProdutoCommand(inserirPedidoView, this, produtos);
            SalvarPedido = new SalvarPedidoCommand(inserirPedidoView, this, PessoaViewModel, pedidos);
        }
    }
}
