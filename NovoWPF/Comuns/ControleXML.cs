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
        public ObservableCollection<Pessoa> Pessoas { get; set; }
        public ObservableCollection<Produto> Produtos { get; set; }
        public PessoaViewModel PessoaViewModel { get; set; }
        public ProdutoViewModel ProdutoViewModel { get; set; }

        public int IdProdutoLista { get; set; }

        public ControleXML(ObservableCollection<Produto> produtos)
        {
            Produtos = produtos;
        }

        public ControleXML(ObservableCollection<Pessoa> pessoas)
        {
            Pessoas = pessoas;
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
        public void ExportarXmlPessoa(string fileName)
        {
            var xml = new XElement("Pessoas",
                new XElement("IdPessoaLista", PessoaViewModel.IdPessoaLista),
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
            var arquivoXml = @"C:\\Produtos.xml";
            using (var stream = new StreamWriter(arquivoXml))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(ObservableCollection<Produto>));
                serializador.Serialize(stream, Produtos);
            }
        }*/

    }
}
