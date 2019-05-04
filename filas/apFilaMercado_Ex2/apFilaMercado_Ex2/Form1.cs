using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apFilaMercado_Ex2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      
    }

    void Simular()
    {
      FilaLista<SerDaFila>[] caixas = new FilaLista<SerDaFila>[5];

      int CaixaMaisVazio()
      {
        int indiceDoCaixaMaisVazio = 0;
        for (int indice = 1; indice < caixas.Length; indice++)
          if (caixas[indice].Tamanho() < caixas[indiceDoCaixaMaisVazio].Tamanho())
            indiceDoCaixaMaisVazio = indice;

        return indiceDoCaixaMaisVazio;
      }

      void ExibirFilas()
      {
        for (int qualFila = 0; qualFila < 5; qualFila++)
        {
          for (int linhas = 0; linhas < dgvFilas.RowCount; linhas++)
          {
            for (int col = 0; col < 5; col++)
              dgvFilas.Rows[linhas].Cells[col].Value = "";
          }
          SerDaFila[] pessoasNaFila = caixas[qualFila].ToArray();
          if (dgvFilas.RowCount < pessoasNaFila.Length)
            dgvFilas.RowCount = pessoasNaFila.Length;
          for (int linha = 0; linha < pessoasNaFila.Length; linha++)
          {
            dgvFilas.Rows[linha].Cells[qualFila].Value = pessoasNaFila[linha].numero;
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);
          }
        }
      }

      int clienteAtual = 0,
          rodadasSemCliente = 0;
      Random valorAleatorio = new Random();

      for (int indice = 0; indice < caixas.Length; indice++)
      {
        caixas[indice] = new FilaLista<SerDaFila>();
      }

      do
      {
        // verificar se um cliente apareceu:
        // aparece cliente quando random < 0.08
        if (valorAleatorio.NextDouble() < 0.8)  // apareceu cliente
        {
          rodadasSemCliente = 0;  //zerou contador de rodadas consecutivas sem cliente
          clienteAtual++;
          int qualCaixa = CaixaMaisVazio();
          caixas[qualCaixa].Enfileirar(new SerDaFila(clienteAtual));
          txtEventos.AppendText($"Na fila {qualCaixa} entrou o cliente {clienteAtual}" +
            Environment.NewLine);
        }
        else
        {
          ++rodadasSemCliente;
          txtEventos.AppendText($"Não chegou cliente por {rodadasSemCliente} rodadas."
           + Environment.NewLine);

        }
        //ExibirFilas();

        if (valorAleatorio.NextDouble() < 0.82)  // cliente será atendido
        {
          int qualCaixaAtende = valorAleatorio.Next(5); // sorteia 0 a 4
          if (!caixas[qualCaixaAtende].EstaVazia())
          {
            SerDaFila pessoaAtendida = caixas[qualCaixaAtende].Retirar();
            txtEventos.AppendText($"Da fila {qualCaixaAtende} saiu o cliente {pessoaAtendida.numero}"
              + Environment.NewLine);
          }
        }
        ExibirFilas();
      }
      while (rodadasSemCliente < 5);
    }

    private void btnSimular_Click(object sender, EventArgs e)
    {
      Simular();
    }
  }
}
