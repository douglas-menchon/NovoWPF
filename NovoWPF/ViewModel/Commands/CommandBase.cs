using System;
using System.Windows.Input;
using NovoWPF.Comuns;

namespace NovoWPF.Commands
{
    public abstract class CommandBase : ICommand
    {
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
    }
}
