using NovoWPF.Comuns;
using NovoWPF.RegraDeNegocio;
using NovoWPF.ViewModel.Commands;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace NovoWPF.ViewModel
{
    public class TelaProjetoViewModel : ViewModelBase
    {
        public ObservableCollection<Pessoa> Pessoas = new ObservableCollection<Pessoa>();
        public ObservableCollection<Pedido> Pedidos = new ObservableCollection<Pedido>();
        public ObservableCollection<Produto> Produtos = new ObservableCollection<Produto>();

        public int IdPessoaLista { get; set; }
        public int IdProdutoLista { get; set; }
        public ICommand AbrirTelaProduto { get; }
        public ICommand AbrirTelaPessoa { get; }

        public TelaProjetoViewModel()
        {
            LerXmlPessoa(IdPessoaLista, Pessoas);
            LerXmlProduto(IdProdutoLista, Produtos);
            Pedidos = LerXmlPedido(Pedidos);
            AbrirTelaPessoa = new AbrirPessoaCommand(Pessoas, Pedidos, Produtos, IdPessoaLista);
            AbrirTelaProduto = new AbrirProdutoCommand(Produtos, IdProdutoLista);
        }

        public void AceitarApenasNumeros(TextBox textBox)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Digite apenas números");
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
            }
        }
        public void ExportarXmlProduto(ObservableCollection<Produto> Produtos, int idProdutoLista)
        {
            IdProdutoLista = idProdutoLista;
            var xml = new XElement("Produtos",
                new XElement("IdProdutoLista", idProdutoLista),
                from p in Produtos
                select new XElement("Produto",
                    new XElement("IdProduto", p.IdProduto),
                    new XElement("NomeProduto", p.NomeProduto),
                    new XElement("Codigo", p.Codigo),
                    new XElement("Valor", p.Valor)
                )
            );
            xml.Save("C:\\Produtos.xml");
        }
        public void ExportarXmlPessoa(ObservableCollection<Pessoa> Pessoas, int idPessoaLista)
        {
            var xml = new XElement("Pessoas",
                new XElement("IdPessoaLista", idPessoaLista),
                from p in Pessoas
                select new XElement("Pessoa",
                    new XElement("IdPessoa", p.IdPessoa),
                    new XElement("NomePessoa", p.NomePessoa),
                    new XElement("CPF", p.CPF),
                    new XElement("Endereco", p.Endereco)
                )
            );
            xml.Save("C:\\Pessoas.xml");
        }

        public void ExportarXmlPedido(ObservableCollection<Pedido> pedidos)
        {
            Pedidos = pedidos;
            using (var stream = new StreamWriter("C:\\Pedidos.xml"))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(ObservableCollection<Pedido>));
                serializador.Serialize(stream, Pedidos);
            }
        }

        public void LerXmlProduto(int idProdutoLista, ObservableCollection<Produto> produtos)
        {
            Produtos = produtos;
            IdProdutoLista = idProdutoLista;
            try
            {
                var xml = XElement.Load("C:\\Produtos.xml");
                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

                IdProdutoLista = int.Parse(xml.Element("IdProdutoLista").Value);

                foreach (var element in xml.Elements("Produto"))
                {
                    var produtoLerXml = new Produto
                    {
                        IdProduto = int.Parse(element.Element("IdProduto").Value),
                        NomeProduto = element.Element("NomeProduto").Value,
                        Codigo = element.Element("Codigo").Value,
                        Valor = double.Parse(element.Element("Valor").Value),
                    };
                    Produtos.Add(produtoLerXml);
                }
            }
            catch
            {
                return;
            }
        }

        public void LerXmlPessoa(int idPessoaLista, ObservableCollection<Pessoa> pessoas)
        {
            Pessoas = pessoas;
            IdPessoaLista = idPessoaLista;
            try
            {
                var xml = XElement.Load("C:\\Pessoas.xml");

                IdPessoaLista = int.Parse(xml.Element("IdPessoaLista").Value);

                foreach (var element in xml.Elements("Pessoa"))
                {
                    var pessoa = new Pessoa
                    {
                        IdPessoa = int.Parse(element.Element("IdPessoa").Value),
                        NomePessoa = element.Element("NomePessoa").Value,
                        CPF = element.Element("CPF").Value,
                        Endereco = element.Element("Endereco").Value,
                    };
                    Pessoas.Add(pessoa);
                }
            }
            catch
            {
                return;
            }
        }

        public ObservableCollection<Pedido> LerXmlPedido(ObservableCollection<Pedido> pedidos)
        {
            ObservableCollection<Pedido> lista = pedidos;

            try
            {
                using (StreamReader stream = new StreamReader("C:\\Pedidos.xml"))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(ObservableCollection<Pedido>));
                    lista = (ObservableCollection<Pedido>)serializador.Deserialize(stream);
                }
                return lista;
            }
            catch
            {
                return lista;
            }
        }
    }
}
