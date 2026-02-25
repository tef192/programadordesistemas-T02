namespace Calculidade
{
    partial class frmCalcularidade
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
            this.lbnAnodenascimento = new System.Windows.Forms.Label();
            this.txtAnoNasc = new System.Windows.Forms.TextBox();
            this.lblAnoaAtual = new System.Windows.Forms.Label();
            this.txtAnoAtual = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbnAnodenascimento
            // 
            this.lbnAnodenascimento.AutoSize = true;
            this.lbnAnodenascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnAnodenascimento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbnAnodenascimento.Location = new System.Drawing.Point(314, 120);
            this.lbnAnodenascimento.Name = "lbnAnodenascimento";
            this.lbnAnodenascimento.Size = new System.Drawing.Size(165, 20);
            this.lbnAnodenascimento.TabIndex = 0;
            this.lbnAnodenascimento.Text = "Ano de Nascimento";
            // 
            // txtAnoNasc
            // 
            this.txtAnoNasc.Location = new System.Drawing.Point(280, 170);
            this.txtAnoNasc.Name = "txtAnoNasc";
            this.txtAnoNasc.Size = new System.Drawing.Size(222, 20);
            this.txtAnoNasc.TabIndex = 1;
            // 
            // lblAnoaAtual
            // 
            this.lblAnoaAtual.AutoSize = true;
            this.lblAnoaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoaAtual.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAnoaAtual.Location = new System.Drawing.Point(352, 214);
            this.lblAnoaAtual.Name = "lblAnoaAtual";
            this.lblAnoaAtual.Size = new System.Drawing.Size(73, 16);
            this.lblAnoaAtual.TabIndex = 2;
            this.lblAnoaAtual.Text = "Ano Atual";
            
            // 
            // txtAnoAtual
            // 
            this.txtAnoAtual.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAnoAtual.Location = new System.Drawing.Point(280, 264);
            this.txtAnoAtual.Name = "txtAnoAtual";
            this.txtAnoAtual.Size = new System.Drawing.Size(222, 20);
            this.txtAnoAtual.TabIndex = 3;
            this.txtAnoAtual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnoAtual_KeyPress);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIdade.Location = new System.Drawing.Point(382, 310);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(18, 20);
            this.lblIdade.TabIndex = 4;
            this.lblIdade.Text = "0";
            // 
            // frmCalcularidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.txtAnoAtual);
            this.Controls.Add(this.lblAnoaAtual);
            this.Controls.Add(this.txtAnoNasc);
            this.Controls.Add(this.lbnAnodenascimento);
            this.Name = "frmCalcularidade";
            this.Text = "Calcula Idade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnAnodenascimento;
        private System.Windows.Forms.TextBox txtAnoNasc;
        private System.Windows.Forms.Label lblAnoaAtual;
        private System.Windows.Forms.TextBox txtAnoAtual;
        private System.Windows.Forms.Label lblIdade;
    }
}

