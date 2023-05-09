using NovoWPF.RegraDeNegocio;
using NovoWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace NovoWPF.Comuns
{
    public class ControleXML
    {
        public ObservableCollection<Produto> Produtos { get; set; }
        public ObservableCollection<Pessoa> Pessoas { get; set; }
        public int IdProdutoLista { get; set; }
        public int IdPessoaLista { get; set; }

        public ControleXML()
        {
        }

        public void ExportarXmlProduto(ObservableCollection<Produto> Produtos, int idProdutoLista)
        {

            string fileName = "C:\\Produtos.xml";
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
            xml.Save(fileName);
        }
        public void ExportarXmlPessoa(ObservableCollection<Pessoa> Pessoas, int idPessoaLista)
        {
            string fileName = "C:\\Pessoas.xml";
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
            xml.Save(fileName);
        }

        /*public void ExportarXmlProduto()
        {
            var arquivoXml = @"C:\\Pedidos.xml";
            using (var stream = new StreamWriter(arquivoXml))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(ObservableCollection<Pedido>));
                serializador.Serialize(stream, Produtos);
            }
        }*/

        public void LerXmlProduto(int idProdutoLista, ObservableCollection<Produto> produtos)
        {
            Produtos = produtos;
            IdProdutoLista = idProdutoLista;

            string fileName = "C:\\Produtos.xml";

            try
            {
                var xml = XElement.Load(fileName);

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

            string fileName = "C:\\Pessoas.xml";

            try
            {
                var xml = XElement.Load(fileName);

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

    }
}
