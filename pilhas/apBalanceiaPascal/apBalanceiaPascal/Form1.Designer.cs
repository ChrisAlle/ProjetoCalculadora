namespace apBalanceiaPascal
{
  partial class frmBalanco
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
      this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
      this.lsbOriginal = new System.Windows.Forms.ListBox();
      this.lsbBalanceado = new System.Windows.Forms.ListBox();
      this.btnProcessar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // dlgAbrir
      // 
      this.dlgAbrir.DefaultExt = "*.pas";
      this.dlgAbrir.FileName = "openFileDialog1";
      this.dlgAbrir.InitialDirectory = "c:\\temp";
      // 
      // lsbOriginal
      // 
      this.lsbOriginal.FormattingEnabled = true;
      this.lsbOriginal.Location = new System.Drawing.Point(2, 40);
      this.lsbOriginal.Name = "lsbOriginal";
      this.lsbOriginal.ScrollAlwaysVisible = true;
      this.lsbOriginal.Size = new System.Drawing.Size(389, 368);
      this.lsbOriginal.TabIndex = 0;
      // 
      // lsbBalanceado
      // 
      this.lsbBalanceado.FormattingEnabled = true;
      this.lsbBalanceado.Location = new System.Drawing.Point(397, 40);
      this.lsbBalanceado.Name = "lsbBalanceado";
      this.lsbBalanceado.ScrollAlwaysVisible = true;
      this.lsbBalanceado.Size = new System.Drawing.Size(442, 368);
      this.lsbBalanceado.TabIndex = 1;
      // 
      // btnProcessar
      // 
      this.btnProcessar.Location = new System.Drawing.Point(356, 3);
      this.btnProcessar.Name = "btnProcessar";
      this.btnProcessar.Size = new System.Drawing.Size(75, 31);
      this.btnProcessar.TabIndex = 2;
      this.btnProcessar.Text = "Processar";
      this.btnProcessar.UseVisualStyleBackColor = true;
      this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
      // 
      // frmBalanco
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(841, 420);
      this.Controls.Add(this.btnProcessar);
      this.Controls.Add(this.lsbBalanceado);
      this.Controls.Add(this.lsbOriginal);
      this.Name = "frmBalanco";
      this.Text = "Balanceamento de comandos de programa";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.OpenFileDialog dlgAbrir;
    private System.Windows.Forms.ListBox lsbOriginal;
    private System.Windows.Forms.ListBox lsbBalanceado;
    private System.Windows.Forms.Button btnProcessar;
  }
}

