using System.ComponentModel;

namespace NovoWPF.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(dynamic nomeDaPropriedade)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nomeDaPropriedade));
        }
    }
}