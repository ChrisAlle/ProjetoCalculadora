using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apBalanceiaPascal
{
  class Palavra : IComparable<Palavra>
  {
    public string palavra;
    public int numero;

    public Palavra(string s, int n)
    {
      palavra = s;
      numero = n;
    }

    public int CompareTo(Palavra outra)
    {
      return palavra.CompareTo(outra.palavra);
    }
  }
}
