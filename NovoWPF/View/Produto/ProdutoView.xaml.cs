using System.Windows;
using System.Windows.Controls;

namespace NovoWPF.View
{
    /// <summary>
    /// Interação lógica para ProdutoView.xaml
    /// </summary>
    public partial class ProdutoView : Window
{
    public ProdutoView()
    {
        InitializeComponent();       
    }

        private void MaximoTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            AceitarApenasNumeros(maximoTB);
        }

        private void MinimoTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            AceitarApenasNumeros(minimoTB);
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
