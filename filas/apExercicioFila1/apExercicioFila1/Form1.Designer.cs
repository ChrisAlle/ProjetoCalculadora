namespace apExercicioFila1
{
  partial class FrmNaufragio
  {
    /// <summary>
    /// Variável de designer necessária.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpar os recursos que estão sendo usados.
    /// </summary>
    /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código gerado pelo Windows Form Designer

    /// <summary>
    /// Método necessário para suporte ao Designer - não modifique 
    /// o conteúdo deste método com o editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnIniciar = new System.Windows.Forms.Button();
      this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tbFilas = new System.Windows.Forms.TabPage();
      this.dgvFila = new System.Windows.Forms.DataGridView();
      this.Coluna0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.coluna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.coluna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.coluna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.coluna4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tpRelatorio = new System.Windows.Forms.TabPage();
      this.txtRelatorio = new System.Windows.Forms.TextBox();
      this.tpObituario = new System.Windows.Forms.TabPage();
      this.txtObituario = new System.Windows.Forms.TextBox();
      this.tabControl1.SuspendLayout();
      this.tbFilas.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvFila)).BeginInit();
      this.tpRelatorio.SuspendLayout();
      this.tpObituario.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnIniciar
      // 
      this.btnIniciar.Location = new System.Drawing.Point(13, 2);
      this.btnIniciar.Name = "btnIniciar";
      this.btnIniciar.Size = new System.Drawing.Size(75, 25);
      this.btnIniciar.TabIndex = 0;
      this.btnIniciar.Text = "Iniciar";
      this.btnIniciar.UseVisualStyleBackColor = true;
      this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
      // 
      // dlgAbrir
      // 
      this.dlgAbrir.DefaultExt = "*.txt";
      this.dlgAbrir.FileName = "openFileDialog1";
      this.dlgAbrir.InitialDirectory = "c:\\temp";
      // 
      // tabControl1
      // 
      this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl1.Controls.Add(this.tbFilas);
      this.tabControl1.Controls.Add(this.tpRelatorio);
      this.tabControl1.Controls.Add(this.tpObituario);
      this.tabControl1.Location = new System.Drawing.Point(0, 33);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(584, 251);
      this.tabControl1.TabIndex = 1;
      // 
      // tbFilas
      // 
      this.tbFilas.Controls.Add(this.dgvFila);
      this.tbFilas.Location = new System.Drawing.Point(4, 22);
      this.tbFilas.Name = "tbFilas";
      this.tbFilas.Padding = new System.Windows.Forms.Padding(3);
      this.tbFilas.Size = new System.Drawing.Size(576, 225);
      this.tbFilas.TabIndex = 0;
      this.tbFilas.Text = "Filas";
      this.tbFilas.UseVisualStyleBackColor = true;
      // 
      // dgvFila
      // 
      this.dgvFila.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvFila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvFila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coluna0,
            this.coluna1,
            this.coluna2,
            this.coluna3,
            this.coluna4});
      this.dgvFila.Location = new System.Drawing.Point(9, 6);
      this.dgvFila.Name = "dgvFila";
      this.dgvFila.Size = new System.Drawing.Size(559, 213);
      this.dgvFila.TabIndex = 2;
      // 
      // Coluna0
      // 
      this.Coluna0.HeaderText = "F 0-15";
      this.Coluna0.Name = "Coluna0";
      // 
      // coluna1
      // 
      this.coluna1.HeaderText = "M 0-15";
      this.coluna1.Name = "coluna1";
      // 
      // coluna2
      // 
      this.coluna2.HeaderText = "F 16-35";
      this.coluna2.Name = "coluna2";
      // 
      // coluna3
      // 
      this.coluna3.HeaderText = "F > 35";
      this.coluna3.Name = "coluna3";
      // 
      // coluna4
      // 
      this.coluna4.HeaderText = "H > 15";
      this.coluna4.Name = "coluna4";
      // 
      // tpRelatorio
      // 
      this.tpRelatorio.Controls.Add(this.txtRelatorio);
      this.tpRelatorio.Location = new System.Drawing.Point(4, 22);
      this.tpRelatorio.Name = "tpRelatorio";
      this.tpRelatorio.Padding = new System.Windows.Forms.Padding(3);
      this.tpRelatorio.Size = new System.Drawing.Size(576, 225);
      this.tpRelatorio.TabIndex = 1;
      this.tpRelatorio.Text = "Relatório";
      this.tpRelatorio.UseVisualStyleBackColor = true;
      // 
      // txtRelatorio
      // 
      this.txtRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtRelatorio.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtRelatorio.Location = new System.Drawing.Point(9, 7);
      this.txtRelatorio.Multiline = true;
      this.txtRelatorio.Name = "txtRelatorio";
      this.txtRelatorio.Size = new System.Drawing.Size(559, 212);
      this.txtRelatorio.TabIndex = 0;
      // 
      // tpObituario
      // 
      this.tpObituario.Controls.Add(this.txtObituario);
      this.tpObituario.Location = new System.Drawing.Point(4, 22);
      this.tpObituario.Name = "tpObituario";
      this.tpObituario.Padding = new System.Windows.Forms.Padding(3);
      this.tpObituario.Size = new System.Drawing.Size(576, 225);
      this.tpObituario.TabIndex = 2;
      this.tpObituario.Text = "Obituário Naval";
      this.tpObituario.UseVisualStyleBackColor = true;
      // 
      // txtObituario
      // 
      this.txtObituario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtObituario.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtObituario.Location = new System.Drawing.Point(9, 6);
      this.txtObituario.Multiline = true;
      this.txtObituario.Name = "txtObituario";
      this.txtObituario.Size = new System.Drawing.Size(559, 212);
      this.txtObituario.TabIndex = 1;
      // 
      // FrmNaufragio
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(584, 287);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.btnIniciar);
      this.Name = "FrmNaufragio";
      this.Text = "Treinamento de Naufrágio";
      this.tabControl1.ResumeLayout(false);
      this.tbFilas.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvFila)).EndInit();
      this.tpRelatorio.ResumeLayout(false);
      this.tpRelatorio.PerformLayout();
      this.tpObituario.ResumeLayout(false);
      this.tpObituario.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnIniciar;
    private System.Windows.Forms.OpenFileDialog dlgAbrir;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tbFilas;
    private System.Windows.Forms.DataGridView dgvFila;
    private System.Windows.Forms.TabPage tpRelatorio;
    private System.Windows.Forms.TextBox txtRelatorio;
    private System.Windows.Forms.DataGridViewTextBoxColumn Coluna0;
    private System.Windows.Forms.DataGridViewTextBoxColumn coluna1;
    private System.Windows.Forms.DataGridViewTextBoxColumn coluna2;
    private System.Windows.Forms.DataGridViewTextBoxColumn coluna3;
    private System.Windows.Forms.DataGridViewTextBoxColumn coluna4;
    private System.Windows.Forms.TabPage tpObituario;
    private System.Windows.Forms.TextBox txtObituario;
  }
}

