using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apBalanceamento
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    public static bool Combinam(char fecha, char abre)
    {
      return ((fecha == ']' && abre == '[') ||
              (fecha == ')' && abre == '(') ||
              (fecha == '}' && abre == '{'));
    }

    public static bool EstaBalanceada(String entrada)
    {
      // construtor com tamanho default; topo valerá -1
      PilhaVetor<char> p = new PilhaVetor<char>();
      bool balanceada = true;
      int indice = 0;
      char simbolo;
      char caracterAbertura;
      for (indice = 0; balanceada && indice < entrada.Length; indice++)
      {
        simbolo = entrada[indice];
        if (simbolo == '{' || simbolo == '[' || simbolo == '(')
        {
          p.Empilhar(simbolo); // chamada causa overhead
        }
        else
        if (simbolo == '}' || simbolo == ']' || simbolo == ')')
          if (p.EstaVazia())
             balanceada = false; // pois a pilha já esvaziou
          else
          {
            caracterAbertura = p.Desempilhar();
            if (!Combinam(simbolo, caracterAbertura))
                balanceada = false;
          }
      }
      if (!p.EstaVazia())
         balanceada = false;
      return balanceada;
    }
    private void btnVerificar_Click(object sender, EventArgs e)
    {
      chkBalanceada.Checked = EstaBalanceada(txtSequencia.Text);
    }
  }
}
