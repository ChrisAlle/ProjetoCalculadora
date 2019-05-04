using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Polinomios
{
    public partial class frmPolinomio : Form
    {
        Polinomio A, B;
        public frmPolinomio()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            Polinomio res = A.somar(B);
            res.Exibir(txtResultado);
        }

        private void frmPolinomio_Load(object sender, EventArgs e)
        {
            A = new Polinomio();
            StreamReader arquivo = new StreamReader("c:\\temp\\dadosPoliA.txt");
            string linha = "";
            while ( (linha=arquivo.ReadLine())!= null)
            {
                A.InserirAposFim(new Termo(
                    Convert.ToDouble(linha.Substring(0, 5)), // coeficiente
                    Convert.ToInt32(linha.Substring(5)))   // expoente
                    );
            }
            arquivo.Close();

            B = new Polinomio();
            arquivo = new StreamReader("c:\\temp\\dadosPoliB.txt");
            linha = "";
            while ((linha = arquivo.ReadLine()) != null)
            {
                B.InserirAposFim(new Termo(
                    Convert.ToDouble(linha.Substring(0, 5)), // coeficiente
                    Convert.ToInt32(linha.Substring(5)))   // expoente
                    );
            }
            arquivo.Close();


            A.Exibir(txtA);
            B.Exibir(txtB);
        }
    }
}
