using NovoWPF.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NovoWPF.View
{
    /// <summary>
    /// Interação lógica para CadastroProdutoView.xam
    /// </summary>
    public partial class CadastroProdutoView : Window
    {
        public CadastroProdutoView()
        {
            InitializeComponent();
        }

        public ObservableCollection<Produto> Produtos { get; set; }

        private void BtnSalvarProduto_Click(object sender, RoutedEventArgs e)
        {
            AbrirCadastroProdutoCommand command = new AbrirCadastroProdutoCommand();
            DadosProduto();
            MessageBox.Show("vai");
            //Close();
        }

        public void DadosProduto()
        {
            CadastroProdutoView cadastroProdutoView = new CadastroProdutoView();

            Produto produto = new Produto();
            produto.IdProduto = int.Parse(cadastroProdutoView.idProdutoBox.Text);
            produto.NomeProduto = cadastroProdutoView.nomeProdutoBox.Text;
            produto.Codigo = cadastroProdutoView.codigoProdutoBox.Text;

            if (!string.IsNullOrEmpty(cadastroProdutoView.valorProdutoBox.Text))
            {
                produto.Valor = double.Parse(cadastroProdutoView.valorProdutoBox.Text);
            }

            Produtos.Add(produto);

            ProdutoView view = new ProdutoView(Produtos);
            view.dataGridProduto.ItemsSource = Produtos; //aqui
            view.dataGridProduto.Items.Refresh();
        }

    }
}
