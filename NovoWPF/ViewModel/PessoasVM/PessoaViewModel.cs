using NovoWPF.RegraDeNegocio;
using NovoWPF.View;
using NovoWPF.ViewModel.Commands;
using NovoWPF.ViewModel.Commands.CommandPedidos.AbrirPedido;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace NovoWPF.ViewModel
{
    public class PessoaViewModel : ViewModelBase
    {
        public int IdPessoaLista { get; set; }
        public int IdPedidoLista { get; set; }
        public ICommand AbrirCadastroPessoa { get; }
        public ICommand AbrirIncluirPedido { get; }
        public ICommand AbrirDetalhePedido { get; }
        public ICommand AbrirEditarPessoa { get; }
        public ICommand DeletarPessoa { get; }
        public ICommand PesquisarPessoa { get; }
        public ICommand CancelarPesquisarPessoa { get; }

        public PessoaViewModel()
        {

        }

        public PessoaViewModel(PessoaView pessoaView, ObservableCollection<Pessoa> pessoas, ObservableCollection<Pedido> pedidos, ObservableCollection<Produto> produtos)
        {
            pessoaView.dataGridPessoa.ItemsSource = pessoas;
            VerificaIdListaPessoa(pessoas);
            AbrirEditarPessoa = new AbrirEditarPessoaCommand(pessoas, pessoaView);
            AbrirCadastroPessoa = new AbrirCadastroPessoaCommand(pessoas, this);
            DeletarPessoa = new DeletarPessoaCommand(pessoas, pessoaView);
            PesquisarPessoa = new PesquisarPessoaCommand(pessoas, pessoaView);
            CancelarPesquisarPessoa = new CancelarPesquisarPessoaCommand(pessoas, pessoaView);
            AbrirIncluirPedido = new AbrirIncluirPedidoCommand(pessoas, pessoaView, pedidos, this, produtos);
            AbrirDetalhePedido = new AbrirDetalhePedidoCommand(pessoaView, pedidos);
        }

        public void VerificaIdListaPessoa(ObservableCollection<Pessoa> pessoas)
        {
            if (pessoas.Count < 1)
                IdPessoaLista = 1;
            else
                IdPessoaLista = pessoas.Count + 1;
        }

        public void VerificaIdListaPessoa(ObservableCollection<Pedido> pedidos)
        {
            if (pedidos.Count < 1)
                IdPedidoLista = 1;
            else
                IdPedidoLista = pedidos.Count + 1;
        }
    }
}