using NovoWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoWPF.View
{
    public class Produto : ViewModelBase
    {
        public int _idProduto;
        public int IdProduto
        {
            get
            {
                return _idProduto;
            }
            set
            {
                _idProduto = value;
                OnPropertyChanged("IdProduto");
            }
        }

        public string _nomeProduto;
        public string NomeProduto
        {
            get
            {
                return _nomeProduto;
            }
            set
            {
                _nomeProduto = value;
                OnPropertyChanged("NomePessoa");
            }
        }


        public string _codigo;
        public string Codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                _codigo = value;
                OnPropertyChanged("Codigo");
            }
        }

        public double _valor;
        public double Valor
        {
            get
            {
                return _valor;
            }
            set
            {
                _valor = value;
                OnPropertyChanged("Valor");
            }
        }
        public int _qntdProduto;
        public int QntdProduto
        {
            get
            {
                return _qntdProduto;
            }
            set
            {
                _qntdProduto = value;
                OnPropertyChanged("QntdProduto");
            }
        }

        public Produto()
        {
        }

        public Produto(int idProduto, string nomeProduto, string codigo, double valor)
        {
            IdProduto = idProduto;
            NomeProduto = nomeProduto;
            Codigo = codigo;
            Valor = valor;
        }

        public Produto(int idProduto, string nomeProduto, double valor, int qntdProduto)
        {
            IdProduto = idProduto;
            NomeProduto = nomeProduto;
            Valor = valor;
            QntdProduto = qntdProduto;
        }
    }
}
