namespace formulario
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
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.lblnascimento = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblcidade = new System.Windows.Forms.Label();
            this.comboBoxCidade = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNaoBinario = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtnumerocadastrado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(25, 65);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(281, 20);
            this.txtNomeCompleto.TabIndex = 0;
            this.txtNomeCompleto.Text = "Insira seu nome completo";
            this.txtNomeCompleto.Leave += new System.EventHandler(this.txtNomeCompleto_Leave);
            // 
            // lblnascimento
            // 
            this.lblnascimento.AutoSize = true;
            this.lblnascimento.Location = new System.Drawing.Point(22, 108);
            this.lblnascimento.Name = "lblnascimento";
            this.lblnascimento.Size = new System.Drawing.Size(104, 13);
            this.lblnascimento.TabIndex = 1;
            this.lblnascimento.Text = "Data de Nascimento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(142, 102);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.Location = new System.Drawing.Point(31, 165);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(40, 13);
            this.lblcidade.TabIndex = 3;
            this.lblcidade.Text = "Cidade";
            // 
            // comboBoxCidade
            // 
            this.comboBoxCidade.FormattingEnabled = true;
            this.comboBoxCidade.Items.AddRange(new object[] {
            "São paulo",
            "Rio de janeiro ",
            "Manaus",
            "Salvador",
            "Brasilia"});
            this.comboBoxCidade.Location = new System.Drawing.Point(91, 162);
            this.comboBoxCidade.Name = "comboBoxCidade";
            this.comboBoxCidade.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCidade.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNaoBinario);
            this.groupBox1.Controls.Add(this.rbMasculino);
            this.groupBox1.Controls.Add(this.rbFeminino);
            this.groupBox1.Location = new System.Drawing.Point(34, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 101);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gênero";
            // 
            // rbNaoBinario
            // 
            this.rbNaoBinario.AutoSize = true;
            this.rbNaoBinario.Location = new System.Drawing.Point(295, 46);
            this.rbNaoBinario.Name = "rbNaoBinario";
            this.rbNaoBinario.Size = new System.Drawing.Size(80, 17);
            this.rbNaoBinario.TabIndex = 2;
            this.rbNaoBinario.TabStop = true;
            this.rbNaoBinario.Text = "Não Binário";
            this.rbNaoBinario.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(155, 46);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 1;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(24, 46);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbFeminino.TabIndex = 0;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(31, 363);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(181, 55);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtnumerocadastrado
            // 
            this.txtnumerocadastrado.Location = new System.Drawing.Point(25, 28);
            this.txtnumerocadastrado.Name = "txtnumerocadastrado";
            this.txtnumerocadastrado.Size = new System.Drawing.Size(237, 20);
            this.txtnumerocadastrado.TabIndex = 7;
            this.txtnumerocadastrado.Text = "Número Cadastrado";
            this.txtnumerocadastrado.Leave += new System.EventHandler(this.txtnumerocadastrado_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtnumerocadastrado);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxCidade);
            this.Controls.Add(this.lblcidade);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblnascimento);
            this.Controls.Add(this.txtNomeCompleto);
            this.Name = "Form1";
            this.Text = "Formulario Simples";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Label lblnascimento;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.ComboBox comboBoxCidade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNaoBinario;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtnumerocadastrado;
    }
}

