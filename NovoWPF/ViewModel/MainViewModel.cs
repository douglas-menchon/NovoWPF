using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoWPF.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ViewModelBase ViewModelAtual { get; }
        public MainViewModel()
        {
            ViewModelAtual = new TelaProjetoViewModel();
        }
    }
}
