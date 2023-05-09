using NovoWPF.Commands;
using NovoWPF.RegraDeNegocio;
using NovoWPF.View;
using System.Collections.ObjectModel;

namespace NovoWPF.ViewModel.Commands
{
    public class AbrirPessoaCommand : CommandBase
    {
        public ObservableCollection<Pessoa> Pessoas = new ObservableCollection<Pessoa>();
        public ObservableCollection<Pedido> Pedidos = new ObservableCollection<Pedido>();
        public ObservableCollection<Produto> Produtos = new ObservableCollection<Produto>();

        public int IdPessoaLista { get; set; }

        public AbrirPessoaCommand(ObservableCollection<Pessoa> pessoas, ObservableCollection<Pedido> pedidos, ObservableCollection<Produto> produtos, int idPessoaLista)
        {
            Pessoas = pessoas;
            Pedidos = pedidos;
            Produtos = produtos;
            IdPessoaLista = idPessoaLista;
        }
        public override void Execute(object parameter)
        {
            PessoaView pessoaView = new PessoaView();
            pessoaView.DataContext = new PessoaViewModel(pessoaView, Pessoas, Pedidos, Produtos, IdPessoaLista);
            pessoaView.Show();
        }
    }
}
