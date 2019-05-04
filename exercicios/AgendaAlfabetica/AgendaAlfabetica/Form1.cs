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

namespace AgendaAlfabetica
{
    public partial class frmAgenda : Form
    {
        ListaSimples<Pessoa>[] lista = null;
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            lista = new ListaSimples<Pessoa>[26]; // vetor
                                                  // lista[0] ==> lista['A'] ... lista[25] ==> lista['Z']

            // instanciar cada posição do vetor de listas
            for (int indice = 0; indice < 26; indice++)
                lista[indice] = new ListaSimples<Pessoa>();

            LerArquivo();
        }

        private void LerArquivo()
        {
            StreamReader arquivo = new StreamReader("c:\\temp\\dadosAgenda.txt");
            string linha = "";
            while ((linha = arquivo.ReadLine()) != null)
            {
                var novaPessoa = new Pessoa(linha.Substring(0, 30),  // nome
                                            linha.Substring(30, 30), // endereço 
                                            linha.Substring(60));    // telefone

                char inicial = novaPessoa.Nome[0].ToString().ToUpper()[0];
                lista[inicial - 'A'].InserirAposFim(novaPessoa);
            }
            arquivo.Close();

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
           // lsbDados.Items.Clear();
            dgvAgenda.RowCount = 1;
            int ultimaLinhaUsada = 0;
            for (int indice = 0; indice < 26; indice++)
            {
                dgvAgenda.RowCount = dgvAgenda.RowCount +
                    lista[indice].QuantosNos;

                lista[indice].iniciarPercursoSequencial();
                while (lista[indice].podePercorrer())
                {
                    dgvAgenda.Rows[ultimaLinhaUsada].Cells[0].Value =
                        lista[indice].Atual.Info.Nome;
                    dgvAgenda.Rows[ultimaLinhaUsada].Cells[1].Value =
                        lista[indice].Atual.Info.Endereco;
                    dgvAgenda.Rows[ultimaLinhaUsada].Cells[2].Value =
                        lista[indice].Atual.Info.Telefone;
                    ultimaLinhaUsada++;
             //       lsbDados.Items.Add(lista[indice].Atual.Info.ToString());
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
            {
                char inicial = txtNome.Text[0].ToString().ToUpper()[0];
                var procurado = new Pessoa(txtNome.Text, "", "");


                if (lista[inicial - 'A'].existeDado(procurado))
                {
                    txtEndereco.Text = lista[inicial - 'A'].Atual.Info.Endereco;
                    txtTelefone.Text = lista[inicial - 'A'].Atual.Info.Telefone;
                }
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtEndereco.Text != "")
            {
                char inicial = txtNome.Text[0].ToString().ToUpper()[0];
                var procurado = new Pessoa(txtNome.Text, "", "");


                if (!lista[inicial - 'A'].existeDado(procurado))
                {
                    var pessoa = new Pessoa(txtNome.Text, txtEndereco.Text,
                                            txtTelefone.Text);
                    lista[inicial - 'A'].inserirEmOrdem(pessoa);
                }
                else
                    MessageBox.Show("Já existe esse nome!");
            }


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
            {
                char inicial = txtNome.Text[0].ToString().ToUpper()[0];
                var procurado = new Pessoa(txtNome.Text, "", "");


                if (lista[inicial - 'A'].removerDado(procurado))
                    MessageBox.Show("Excluído!");
                else
                    MessageBox.Show("Não existe esse nome!");
            }


        }

        private void frmAgenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter arquivo = new StreamWriter("c:\\temp\\dadosAgenda.txt");
            for (int indice = 0; indice < 26; indice++)
            {
                lista[indice].iniciarPercursoSequencial();
                while (lista[indice].podePercorrer())
                {
                    arquivo.WriteLine(lista[indice].Atual.Info.LinhaParaGravar());
                }
            }
            arquivo.Close();
        }
    }
}
