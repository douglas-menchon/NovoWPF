using NovoWPF.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace NovoWPF.View
{
    /// <summary>
    /// Interação lógica para CadastroPessoaView.xam
    /// </summary>
    public partial class CadastroPessoaView : Window
    {
        public CadastroPessoaView()
        {
            InitializeComponent();        
        }

        private void CPFBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TelaProjetoViewModel telaProjetoViewModel = new TelaProjetoViewModel();
            telaProjetoViewModel.AceitarApenasNumeros(CPFBox);
        }
    }
}
