using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apExercicioFila1
{
  class Naufrago : IComparable<Naufrago>, IGravarEmArquivo
  {
     string nome;
     int idade;
     char sexo;

    public Naufrago(string nome, int idade, char sexo)
    {
      this.nome = nome;
      this.idade = idade;
      this.sexo = sexo;
    }

    public string Nome { get => nome; set => nome = value; }
    public int Idade { get => idade; set => idade = value; }
    public char Sexo { get => sexo; set => sexo = value; }

    public int CompareTo(Naufrago other)
    {
      return 0;
    }

    public string ParaArquivo()
    {
      return nome.PadRight(30, ' ') + idade.ToString().PadLeft(3, ' ') + sexo.ToString();
    }
  }
}
