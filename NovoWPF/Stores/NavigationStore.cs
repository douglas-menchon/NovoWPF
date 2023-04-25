using NovoWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoWPF.Stores
{
    public class NavigationStore
    {
        private ViewModelBase _viewModelAtual;
        private ViewModelBase ViewModelAtual
        {
            get => _viewModelAtual;
            set
            {
                _viewModelAtual = value;
            }
        }
    }
}
