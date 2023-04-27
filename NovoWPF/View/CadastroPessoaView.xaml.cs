using NovoWPF.ViewModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NovoWPF.View
{
    /// <summary>
    /// Interação lógica para CadastroPessoaView.xam
    /// </summary>
    public partial class CadastroPessoaView : Window
    {
        public CadastroPessoaView()
        {
            CadastroPessoaViewModel vm = new CadastroPessoaViewModel(); // this creates an instance of the ViewModel
            DataContext = vm;
            InitializeComponent();
            if (vm.CloseAction == null)
                vm.CloseAction =  () => { Sair(); };
        }
        public void Sair()
        {
            Close();
        }

        private void BtnCancelarPessoa_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
