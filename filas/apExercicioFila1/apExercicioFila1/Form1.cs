using System;
using System.IO;
using System.Windows.Forms;

namespace apExercicioFila1
{
  public partial class FrmNaufragio : Form
  {

    FilaLista<Naufrago>[] fila;
    public FrmNaufragio()
    {
      InitializeComponent();
    }

    private void btnIniciar_Click(object sender, EventArgs e)
    {
      if (dlgAbrir.ShowDialog() == DialogResult.OK)
      {
        Enfileirar();
        Desembarcar();
        GerarObituario();
      }
    }

    void ExibirFilas()
    {
      for (int qualFila = 0; qualFila < 5; qualFila++)
      {
        Naufrago[] pessoasNaFila = fila[qualFila].ToArray();
        if (dgvFila.RowCount < pessoasNaFila.Length)
          dgvFila.RowCount = pessoasNaFila.Length;
        for (int linha = 0; linha < pessoasNaFila.Length; linha++)
          dgvFila.Rows[linha].Cells[qualFila].Value = pessoasNaFila[linha].Nome;
      }
    }
    void Enfileirar()
    {
      fila = new FilaLista<Naufrago>[5];
      for (int i = 0; i < 5; i++)
        fila[i] = new FilaLista<Naufrago>();

      var arquivo = new StreamReader(dlgAbrir.FileName);
      int qualFila = 0;
      while (!arquivo.EndOfStream)
      {
        var linha = arquivo.ReadLine();
        var naufrago = new Naufrago(linha.Substring(0, 30),
                                    int.Parse(linha.Substring(30, 3)),
                                    linha.Substring(33, 1)[0]);
        if (naufrago.Sexo == 'F')
          if (naufrago.Idade < 16)
            qualFila = 0;
          else
            if (naufrago.Idade < 36)
            qualFila = 2;
          else
            qualFila = 3;
        else  // sexo masculino
          if (naufrago.Idade < 16)
          qualFila = 1;
        else
          qualFila = 4;
        fila[qualFila].Enfileirar(naufrago);
      }
      ExibirFilas();
    }
    void Desembarcar()
    {
      txtRelatorio.Clear();
      txtRelatorio.AppendText("Bote Lugar  Nome                             Idade Sexo" +
        Environment.NewLine);
      int qualFila = 0;
      int qualBote = 1;
      int qualLugarDoBote = 1;
      bool acabou = false;
      while (!acabou)
      {
        if (qualFila >= 5)
          acabou = true;
        else
          if (qualLugarDoBote > 10)  // acabou um bote
        {
          qualLugarDoBote = 1;
          qualBote++;
          if (qualBote > 10)  // acabaram todos os botes
            acabou = true;
        }
        else
        if (fila[qualFila].EstaVazia())
        {
          qualFila++;
        }
        else
        {
          var umSalvo = fila[qualFila].Retirar();
          txtRelatorio.AppendText(
            $"{qualBote,2} {qualLugarDoBote,3}      {umSalvo.Nome}  {umSalvo.Idade,4}    {umSalvo.Sexo}" +
            Environment.NewLine);
          qualLugarDoBote++;
        }

      }
    }

    void GerarObituario()
    {
      txtObituario.Clear();
      txtObituario.AppendText("Nome                             Idade Sexo" +
              Environment.NewLine);

      for (int qualFila = 0; qualFila < 5; qualFila++)
      {
        while (!fila[qualFila].EstaVazia())
        {
          var naoSalvo = fila[qualFila].Retirar();
          txtObituario.AppendText(
            $"{naoSalvo.Nome}  {naoSalvo.Idade,4}    {naoSalvo.Sexo}" +
            Environment.NewLine);
        }
      }
    }
  }
}
