using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polinomios
{
    class Polinomio : ListaSimples<Termo>
    {
        public Polinomio somar(Polinomio outra)
        {
            Polinomio lista3 = new Polinomio();
            this.iniciarPercursoSequencial();
            outra.iniciarPercursoSequencial();
            NoLista<Termo> aux = null;
            while (this.Atual != null && outra.Atual != null)
            {
                if (this.Atual.Info.CompareTo(
                    outra.Atual.Info) < 0)
                {
                    lista3.InserirAposFim(
                        new Termo(  this.Atual.Info.Coeficiente,
                                    this.Atual.Info.Expoente)
                        );
                    this.atual = this.atual.Prox;
                }
                else
                  if (outra.atual.Info.CompareTo(
                       this.atual.Info) < 0)
                {
                    lista3.InserirAposFim(new Termo(outra.Atual.Info.Coeficiente,
                                    outra.Atual.Info.Expoente));
                    outra.atual = outra.atual.Prox;
                }
                else
                {
                    if (this.Atual.Info.Coeficiente + outra.Atual.Info.Coeficiente != 0)
                       lista3.InserirAposFim(
                        new Termo(this.Atual.Info.Coeficiente + outra.Atual.Info.Coeficiente,
                                    this.Atual.Info.Expoente));
                    this.atual = this.atual.Prox;
                    outra.atual = outra.atual.Prox;
                }
            }  // while

            while (this.atual != null) // acabou o percurso da lista1
            {
                lista3.InserirAposFim(
                    new Termo(this.Atual.Info.Coeficiente,
                            this.Atual.Info.Expoente)
                );
                this.atual = this.atual.Prox;
            }
            while (outra.atual != null) // acabou o percurso da lista1
            {
                lista3.InserirAposFim(new Termo(outra.Atual.Info.Coeficiente,
                                outra.Atual.Info.Expoente));
                outra.atual = outra.atual.Prox;
            }

            return lista3; 
        }

        public Polinomio multiplicar(Polinomio B)
        {
            return default(Polinomio);
        }

        public void Exibir (TextBox onde)
        {
            onde.Text = "";
            this.iniciarPercursoSequencial();
            while (this.podePercorrer())
            {
                onde.Text += this.Atual.Info.ToString() + " ";
            }
        }
    }
}
