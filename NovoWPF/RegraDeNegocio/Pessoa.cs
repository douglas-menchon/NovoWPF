using NovoWPF.ViewModel;

namespace NovoWPF.RegraDeNegocio
{
    public class Pessoa : ViewModelBase
    {
        private int _idPessoa;
        public int IdPessoa
        {
            get
            {
                return _idPessoa;
            }
            set
            {
                _idPessoa = value;
                OnPropertyChanged("IdPessoa");
            }
        }

        private string _nomePessoa;
        public string NomePessoa
        {
            get
            {
                return _nomePessoa;
            }
            set
            {
                _nomePessoa = value;
                OnPropertyChanged("NomePessoa");
            }
        }


        private string _CPF;
        public string CPF
        {
            get
            {
                return _CPF;
            }
            set
            {
                _CPF = value;
                OnPropertyChanged("CPF");
            }
        }

        private string _endereco;
        public string Endereco
        {
            get
            {
                return _endereco;
            }
            set
            {
                _endereco = value;
                OnPropertyChanged("Endereco");
            }
        }

        private int _idPessoaLista;
        public int IdPessoaLista
        {
            get
            {
                return _idPessoaLista;
            }
            set
            {
                _idPessoaLista = value;
                OnPropertyChanged("IdPessoaLista");
            }
        }

        public Pessoa()
        {

        }
        public Pessoa(int id, string nome, string cpf, string endereco, int idPessoaLista)
        {
            IdPessoa = id;
            NomePessoa = nome;
            CPF = cpf;
            Endereco = endereco;
            IdPessoaLista = idPessoaLista;
        }

        public Pessoa(Pessoa pessoa)
        {
            IdPessoa = pessoa.IdPessoa;
            NomePessoa = pessoa.NomePessoa;
            CPF = pessoa.CPF;
            Endereco = pessoa.Endereco;
        }

        public static bool ValidaCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
    }
}

