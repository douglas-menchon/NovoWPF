using NovoWPF.Commands;
using NovoWPF.Comuns;
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
        public ControleXML controleXML = new ControleXML();

        public int IdPessoaLista { get; set; }
        public int IdProdutoLista { get; set; }
        public ICommand AbrirTelaProduto { get; }
        public ICommand AbrirTelaPessoa { get; }

        public TelaProjetoViewModel()
        {
            controleXML.LerXmlPessoa(IdPessoaLista, Pessoas);
            controleXML.LerXmlProduto(IdProdutoLista, Produtos);
            AbrirTelaPessoa = new AbrirPessoaCommand(Pessoas, Pedidos, Produtos, IdPessoaLista);
            AbrirTelaProduto = new AbrirProdutoCommand(Produtos, IdProdutoLista);
        }
        
    }
}