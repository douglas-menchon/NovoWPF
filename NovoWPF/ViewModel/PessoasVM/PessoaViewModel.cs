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
        public ObservableCollection<Pessoa> Pessoas { get; set; }
        public ObservableCollection<Pedido> Pedidos { get; set; }
        public int IdPessoaLista { get; set; }
        public int IdPedidoLista { get; set; }
        public ICommand AbrirCadastroPessoa { get; }
        public ICommand AbrirIncluirPedido { get; }
        public ICommand AbrirEditarPessoa { get; }
        public ICommand DeletarPessoa { get; }
        public ICommand PesquisarPessoa { get; }
        public ICommand CancelarPesquisarPessoa { get; }

        public PessoaViewModel()
        {

        }

        public PessoaViewModel(ObservableCollection<Pessoa> pessoas, ObservableCollection<Pedido> pedidos)
        {
            Pessoas = pessoas;
            Pedidos = pedidos;
        }

        public PessoaViewModel(PessoaView pessoaView)
        {
            pessoaView.dataGridPessoa.ItemsSource = Pessoas;
            VerificaIdListaPessoa();
            VerificaIdListaPedido();
            AbrirEditarPessoa       = new AbrirEditarPessoaCommand(Pessoas, pessoaView);
            AbrirCadastroPessoa     = new AbrirCadastroPessoaCommand(Pessoas, this);
            DeletarPessoa           = new DeletarPessoaCommand(Pessoas, pessoaView);
            PesquisarPessoa         = new PesquisarPessoaCommand(Pessoas, pessoaView);
            CancelarPesquisarPessoa = new CancelarPesquisarPessoaCommand(Pessoas, pessoaView);
            AbrirIncluirPedido      = new AbrirIncluirPedidoCommand(Pessoas, pessoaView, Pedidos, this);
        }

        public void VerificaIdListaPessoa()
        {
            if (Pessoas.Count < 1)
                IdPessoaLista = 1;
            else
                IdPessoaLista = Pessoas.Count + 1;
        }
        public void VerificaIdListaPedido()
        {
            if (Pedidos.Count < 1)
                IdPedidoLista = 1;
            else
                IdPedidoLista = Pedidos.Count + 1;
        }
    }
}