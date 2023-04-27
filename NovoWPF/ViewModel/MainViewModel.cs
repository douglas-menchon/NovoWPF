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
