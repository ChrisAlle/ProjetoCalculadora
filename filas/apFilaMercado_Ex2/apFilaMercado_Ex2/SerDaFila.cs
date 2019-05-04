using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apFilaMercado_Ex2
{
  class SerDaFila : IComparable<SerDaFila>, IGravarEmArquivo
  {
    public int numero;
    public SerDaFila(int quem)
    {
      numero = quem;
    }
    public int CompareTo(SerDaFila outro)
    {
      return numero - outro.numero;
    }

    public string ParaArquivo()
    {
      return numero.ToString().PadRight(10, ' ');
    }
  }
}
