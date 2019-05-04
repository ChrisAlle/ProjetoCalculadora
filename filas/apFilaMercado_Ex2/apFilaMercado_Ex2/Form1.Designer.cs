namespace apFilaMercado_Ex2
{
  partial class Form1
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
      this.dgvFilas = new System.Windows.Forms.DataGridView();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.txtEventos = new System.Windows.Forms.TextBox();
      this.btnSimular = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dgvFilas)).BeginInit();
      this.SuspendLayout();
      // 
      // dgvFilas
      // 
      this.dgvFilas.AllowUserToDeleteRows = false;
      this.dgvFilas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.dgvFilas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvFilas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
      this.dgvFilas.Location = new System.Drawing.Point(12, 42);
      this.dgvFilas.Name = "dgvFilas";
      this.dgvFilas.Size = new System.Drawing.Size(341, 290);
      this.dgvFilas.TabIndex = 0;
      // 
      // Column1
      // 
      this.Column1.HeaderText = "Caixa 1";
      this.Column1.Name = "Column1";
      this.Column1.Width = 55;
      // 
      // Column2
      // 
      this.Column2.HeaderText = "Caixa 2";
      this.Column2.Name = "Column2";
      this.Column2.Width = 55;
      // 
      // Column3
      // 
      this.Column3.HeaderText = "Caixa 3";
      this.Column3.Name = "Column3";
      this.Column3.Width = 55;
      // 
      // Column4
      // 
      this.Column4.HeaderText = "Caixa 4";
      this.Column4.Name = "Column4";
      this.Column4.Width = 55;
      // 
      // Column5
      // 
      this.Column5.HeaderText = "Caixa 5";
      this.Column5.Name = "Column5";
      this.Column5.Width = 55;
      // 
      // txtEventos
      // 
      this.txtEventos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtEventos.Location = new System.Drawing.Point(362, 12);
      this.txtEventos.Multiline = true;
      this.txtEventos.Name = "txtEventos";
      this.txtEventos.Size = new System.Drawing.Size(342, 320);
      this.txtEventos.TabIndex = 1;
      // 
      // btnSimular
      // 
      this.btnSimular.Location = new System.Drawing.Point(125, 10);
      this.btnSimular.Name = "btnSimular";
      this.btnSimular.Size = new System.Drawing.Size(75, 23);
      this.btnSimular.TabIndex = 2;
      this.btnSimular.Text = "Simular";
      this.btnSimular.UseVisualStyleBackColor = true;
      this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(718, 344);
      this.Controls.Add(this.btnSimular);
      this.Controls.Add(this.txtEventos);
      this.Controls.Add(this.dgvFilas);
      this.Name = "Form1";
      this.Text = "Simulação de filas de mercado";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvFilas)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvFilas;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    private System.Windows.Forms.TextBox txtEventos;
    private System.Windows.Forms.Button btnSimular;
  }
}

