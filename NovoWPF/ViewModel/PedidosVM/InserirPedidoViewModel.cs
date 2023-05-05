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
        public InserirPedidoViewModel(InserirPedidoView inserirPedidoView, ObservableCollection<Pedido> pedidos)
        {
            ProdutosPedido = new List<Produto>();
            ProdutoViewModel ProdutoViewModel = new ProdutoViewModel();
            PessoaViewModel PessoaViewModel = new PessoaViewModel();
            InserirProduto = new InserirProdutoCommand(ProdutoViewModel, inserirPedidoView, this);
            SalvarPedido = new SalvarPedidoCommand(inserirPedidoView, this, PessoaViewModel);
        }


    }
}
