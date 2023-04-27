using NovoWPF.Commands;
using NovoWPF.View;
using System.Collections.ObjectModel;
using System.Windows;

namespace NovoWPF.ViewModel.Commands
{
    public class SalvarProdutoCommand : CommandBase
    {
        public ObservableCollection<Produto> Produtos { get; set; }

        public override void Execute(object parameter)
        {
            AbrirCadastroProdutoCommand dados = new AbrirCadastroProdutoCommand();
            MessageBox.Show($"o valor é ");
        }


    }
}
