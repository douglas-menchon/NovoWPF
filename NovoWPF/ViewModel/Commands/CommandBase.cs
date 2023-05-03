using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using NovoWPF.View;

namespace NovoWPF.Commands
{
    public abstract class CommandBase : ICommand
    {
        public ObservableCollection<Pessoa> Pessoas { get; set; } = new ObservableCollection<Pessoa>();

        private string idPessoaTextBox;
        public string IdPessoaTextBox
        {
            get
            {
                return idPessoaTextBox;
            }
            set
            {
                idPessoaTextBox = value;
                OnPropertyChanged("IdPessoaTextBox");
            }
        }
        private string nomePessoaTextBox;
        public string NomePessoaTextBox
        {
            get
            {
                return nomePessoaTextBox;
            }
            set
            {
                nomePessoaTextBox = value;
                OnPropertyChanged("NomePessoaTextBox");
            }
        }
        private string cpfTextBox;
        public string CPFTextBox
        {
            get
            {
                return cpfTextBox;
            }
            set
            {
                cpfTextBox = value;
                OnPropertyChanged("CPFTextBox");
            }
        }
        private string enderecoTextBox;
        public string EnderecoTextBox
        {
            get
            {
                return enderecoTextBox;
            }
            set
            {
                enderecoTextBox = value;
                OnPropertyChanged("EnderecoTextBox");
            }
        }

        public event EventHandler CanExecuteChanged; //Sempre que o valor for mudado no CanExecute será registrado aqui

        public virtual bool CanExecute(object parameter) //método para definir se pode executar, caso falso o botão é desabilitado
        {
            return true;
        }

        public abstract void Execute(object parameter); //Tudo que colocará aqui será executado

        protected void OnCanExecutedChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(dynamic nomeDaPropriedade)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nomeDaPropriedade));
        }
    }
}
