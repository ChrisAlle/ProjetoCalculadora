namespace apBalanceamento
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
      this.txtSequencia = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnVerificar = new System.Windows.Forms.Button();
      this.chkBalanceada = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // txtSequencia
      // 
      this.txtSequencia.Location = new System.Drawing.Point(79, 48);
      this.txtSequencia.Name = "txtSequencia";
      this.txtSequencia.Size = new System.Drawing.Size(307, 20);
      this.txtSequencia.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(14, 48);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(59, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Expressão:";
      // 
      // btnVerificar
      // 
      this.btnVerificar.Location = new System.Drawing.Point(79, 85);
      this.btnVerificar.Name = "btnVerificar";
      this.btnVerificar.Size = new System.Drawing.Size(75, 36);
      this.btnVerificar.TabIndex = 2;
      this.btnVerificar.Text = "Verificar";
      this.btnVerificar.UseVisualStyleBackColor = true;
      this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
      // 
      // chkBalanceada
      // 
      this.chkBalanceada.AutoSize = true;
      this.chkBalanceada.Location = new System.Drawing.Point(205, 84);
      this.chkBalanceada.Name = "chkBalanceada";
      this.chkBalanceada.Size = new System.Drawing.Size(89, 17);
      this.chkBalanceada.TabIndex = 3;
      this.chkBalanceada.Text = "Balanceada?";
      this.chkBalanceada.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(398, 137);
      this.Controls.Add(this.chkBalanceada);
      this.Controls.Add(this.btnVerificar);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtSequencia);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtSequencia;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnVerificar;
    private System.Windows.Forms.CheckBox chkBalanceada;
  }
}

