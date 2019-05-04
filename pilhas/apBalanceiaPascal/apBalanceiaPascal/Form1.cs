using System;
using System.IO;
using System.Windows.Forms;

namespace apBalanceiaPascal
{
  public partial class frmBalanco : Form
  {
    public frmBalanco()
    {
      InitializeComponent();
    }

    private void btnProcessar_Click(object sender, EventArgs e)
    {
      if (dlgAbrir.ShowDialog() == DialogResult.OK)
        Processar();
    }

    bool EhLetra(char c)
    {
      return ( (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') );
    }
    void Processar()
    {
      lsbBalanceado.Items.Clear();
      lsbOriginal.Items.Clear();

      bool houveErro = false;
      int numeroDoBloco = 0;
      var pilha = new PilhaLista<Palavra>();
      var arquivo = new StreamReader(dlgAbrir.FileName);
      while (!arquivo.EndOfStream && !houveErro)
      {
        string linha = arquivo.ReadLine();
        string linhaDeSaida = "";
        int posicaoNaLinha = 0;
        while (posicaoNaLinha < linha.Length && !houveErro)
        {
          string palavraLida = "";
          char caracter = linha[posicaoNaLinha];
          if (EhLetra(caracter))  // começou palavra, percorremos até terminar a palavra
          {
            int ondeComecouAPalavra = posicaoNaLinha;
            while (posicaoNaLinha < linha.Length && EhLetra(linha[posicaoNaLinha]))
            {
              posicaoNaLinha++;
            }
            int quantosCaracteresTemAPalavra = posicaoNaLinha - ondeComecouAPalavra;
            palavraLida = linha.Substring(ondeComecouAPalavra, quantosCaracteresTemAPalavra);
            string palavraEmMaiusculo = palavraLida.ToUpper();
            if (palavraEmMaiusculo.Equals("BEGIN") ||  // palavra abre bloco de comando?
                palavraEmMaiusculo.Equals("CASE") ||
                palavraEmMaiusculo.Equals("REPEAT"))
            {
              numeroDoBloco++;
              pilha.Empilhar(new Palavra(palavraLida, numeroDoBloco));
              linhaDeSaida += palavraLida + " {" + numeroDoBloco + "} ";
            }
            else  // poderá ser palavra que encerra bloco de comandos
            if (palavraEmMaiusculo.Equals("END") ||  // palavra abre bloco de comando?
                palavraEmMaiusculo.Equals("UNTIL"))
            {
              var palavraDesempilhada = pilha.Desempilhar();
              if (palavraEmMaiusculo.Equals("END"))
              {
                if (palavraDesempilhada.palavra.ToUpper().Equals("BEGIN") || // está correto
                    palavraDesempilhada.palavra.ToUpper().Equals("CASE")
                   )
                {
                  linhaDeSaida += palavraLida + " {" + palavraDesempilhada.numero + "} ";
                }
                else
                {
                  houveErro = true;
                  linhaDeSaida += "END sem o Begin ou Case correspondente.";
                }
              }
              else
                if (palavraEmMaiusculo.Equals("UNTIL"))
              {
                if (palavraDesempilhada.palavra.ToUpper().Equals("REPEAT")) // está correto
                {
                  linhaDeSaida += palavraLida + " {" + palavraDesempilhada.numero + "} ";
                }
                else
                {
                  houveErro = true;
                  linhaDeSaida += "UNTIL sem o Repeat correspondente.";
                }
              }
            }
            else
              linhaDeSaida += palavraLida;
          }
          else
          {
            linhaDeSaida += caracter.ToString();
            posicaoNaLinha++;
          }
        } // while
        lsbOriginal.Items.Add(linha);
        lsbBalanceado.Items.Add(linhaDeSaida);
      }
      if (houveErro)
         lsbBalanceado.Items.Add("Desbalanceado!");
      if (!pilha.EstaVazia())
        lsbBalanceado.Items.Add("Há begin, Case ou Repeat a mais.");
      arquivo.Close();
    }

  }
}
