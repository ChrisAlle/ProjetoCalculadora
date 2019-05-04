using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaAlfabetica
{
    class Pessoa : IComparable<Pessoa>, 
                   ICriterioDeSeparacao<Pessoa>
    {
        static int tamanhoNome = 30,
                   tamanhoEndereco = 30,
                   tamanhoTelefone = 12; 
        string nome, endereco, telefone;

        public Pessoa(string n, string e, string t)
        {
            Nome     = n;
            Endereco = e;
            Telefone = t;
        }

        public override string ToString()
        {
            return nome+" "+endereco+" "+telefone;
        }

        public string LinhaParaGravar()
        {
            return nome + endereco + telefone;
        }

        public bool Separar()
        {
            return false;
        }

        public int CompareTo(Pessoa outra)
        {
            return nome.CompareTo(outra.nome);
        }
        public string Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                while (value.Length < tamanhoEndereco)
                    value += " ";
                endereco = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                while (value.Length < tamanhoNome)
                    value += " ";
                nome = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                while (value.Length < tamanhoTelefone)
                    value += " ";
                telefone = value;
            }
        }
    }
}
