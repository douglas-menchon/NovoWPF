using NovoWPF.Commands;
using NovoWPF.RegraDeNegocio;
using NovoWPF.ViewModel.Commands;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace NovoWPF.ViewModel
{
    public class TelaProjetoViewModel : ViewModelBase
    {
        public ObservableCollection<Pessoa> Pessoas = new ObservableCollection<Pessoa>();
        public ObservableCollection<Pedido> Pedidos = new ObservableCollection<Pedido>();
        public ObservableCollection<Produto> Produtos = new ObservableCollection<Produto>();
        public int IdProdutoLista { get; set; }
        public ICommand AbrirTelaProduto { get; }
        public ICommand AbrirTelaPessoa { get; }

        public TelaProjetoViewModel()
        {
            AbrirTelaPessoa = new AbrirPessoaCommand(Pessoas, Pedidos, Produtos);
            AbrirTelaProduto = new AbrirProdutoCommand(Produtos, IdProdutoLista);
        }
        
    }
}