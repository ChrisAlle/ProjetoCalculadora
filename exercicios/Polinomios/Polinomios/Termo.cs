using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polinomios
{
    class Termo : IComparable<Termo>,
        ICriterioDeSeparacao<Termo>
    {
        double coeficiente;
        int expoente;

        public Termo(double c, int e)
        {
            coeficiente = c;
            expoente = e;
        }

        public double Coeficiente
        {
            get
            {
                return coeficiente;
            }

            set
            {
                coeficiente = value;
            }
        }

        public int Expoente
        {
            get
            {
                return expoente;
            }

            set
            {
                expoente = value;
            }
        }

        public int CompareTo(Termo outro)
        {
            return expoente - outro.expoente;
        }

        public bool Separar()
        {
            return false;
        }

        public override string ToString()
        {
            return coeficiente + " " + expoente;
        }
    }
}
