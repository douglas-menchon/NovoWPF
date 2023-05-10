using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace NovoWPF.View.Pedido
{
    /// <summary>
    /// Lógica interna para InserirPedidoView.xaml
    /// </summary>
    public partial class InserirPedidoView : Window
    {
        public InserirPedidoView()
        {
            InitializeComponent();
        }

        private void QntdProdPedBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            AceitarApenasNumeros(qntdProdPedBox);
        }
        public void AceitarApenasNumeros(TextBox textBox)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Digite apenas números");
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
            }
        }
    }
}
