using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polinomios
{
    public interface ICriterioDeSeparacao<Dado>
    {
        bool Separar();
    }
}
