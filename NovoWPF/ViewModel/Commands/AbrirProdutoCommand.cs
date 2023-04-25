using NovoWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoWPF.Commands
{
    public class AbrirProdutoCommand : CommandBase
    {
        public override void Execute(object parameter)
        {
            MainWindow mainWindow = new MainWindow();

            mainWindow.DataContext = new ProdutoViewModel();
            
        }
    }
}
