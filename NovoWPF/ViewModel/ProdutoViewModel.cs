using NovoWPF.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NovoWPF.ViewModel
{
    public class ProdutoViewModel 
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ComandosTela AbrirTelaProduto { get; private set; }

        public ProdutoViewModel()
        {
            AbrirTelaProduto = new ComandosTela(AbrirProduto);
        }

        public void AbrirProduto()
        { 
            MainWindow main = new MainWindow();
            main.DataContext = new ProdutoViewModel();
        }
    }
}
