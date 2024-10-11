namespace PrjGerenciadorPessoas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblIdade = new Label();
            lblMensagem = new Label();
            btnVerPessoa = new Button();
            btnCriarPessoa = new Button();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            lblNome = new Label();
            lstPessoas = new ListBox();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            btnGerar = new Button();
            btnExcluirLista = new Button();
            SuspendLayout();
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdade.ForeColor = SystemColors.HotTrack;
            lblIdade.Location = new Point(42, 129);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(69, 28);
            lblIdade.TabIndex = 1;
            lblIdade.Text = "Idade:";
            lblIdade.Click += lblIdade_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblMensagem.ForeColor = SystemColors.HotTrack;
            lblMensagem.Location = new Point(28, 320);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 28);
            lblMensagem.TabIndex = 7;
            // 
            // btnVerPessoa
            // 
            btnVerPessoa.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerPessoa.ForeColor = SystemColors.ActiveCaptionText;
            btnVerPessoa.Location = new Point(174, 211);
            btnVerPessoa.Name = "btnVerPessoa";
            btnVerPessoa.Size = new Size(140, 44);
            btnVerPessoa.TabIndex = 8;
            btnVerPessoa.Text = "&Ver Detalhes";
            btnVerPessoa.UseVisualStyleBackColor = true;
            btnVerPessoa.Click += btnVerPessoa_Click;
            // 
            // btnCriarPessoa
            // 
            btnCriarPessoa.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCriarPessoa.Location = new Point(42, 211);
            btnCriarPessoa.Name = "btnCriarPessoa";
            btnCriarPessoa.Size = new Size(126, 44);
            btnCriarPessoa.TabIndex = 9;
            btnCriarPessoa.Text = "&Criar Pessoa";
            btnCriarPessoa.UseVisualStyleBackColor = true;
            btnCriarPessoa.Click += btnCriarPessoa_Click;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.Info;
            txtNome.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(162, 58);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(270, 34);
            txtNome.TabIndex = 10;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtIdade
            // 
            txtIdade.BackColor = SystemColors.Info;
            txtIdade.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdade.Location = new Point(162, 126);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(100, 34);
            txtIdade.TabIndex = 11;
            txtIdade.TextChanged += txtIdade_TextChanged;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = SystemColors.HotTrack;
            lblNome.Location = new Point(42, 61);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(74, 28);
            lblNome.TabIndex = 12;
            lblNome.Text = "Nome:";
            lblNome.Click += lblNome_Click;
            // 
            // lstPessoas
            // 
            lstPessoas.FormattingEnabled = true;
            lstPessoas.ItemHeight = 15;
            lstPessoas.Location = new Point(502, 61);
            lstPessoas.Name = "lstPessoas";
            lstPessoas.Size = new Size(338, 259);
            lstPessoas.TabIndex = 13;
            lstPessoas.SelectedIndexChanged += lstPessoas_SelectedIndexChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.ForeColor = SystemColors.ActiveCaptionText;
            btnSalvar.Location = new Point(320, 211);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 44);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "&Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(42, 276);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(126, 44);
            btnExcluir.TabIndex = 15;
            btnExcluir.Text = "E&xcluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpar.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpar.Location = new Point(174, 276);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(258, 44);
            btnLimpar.TabIndex = 16;
            btnLimpar.Text = "&Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnGerar
            // 
            btnGerar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGerar.ForeColor = SystemColors.ActiveCaptionText;
            btnGerar.Location = new Point(522, 350);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(128, 44);
            btnGerar.TabIndex = 17;
            btnGerar.Text = "&Gerar Documento";
            btnGerar.UseVisualStyleBackColor = true;
            // 
            // btnExcluirLista
            // 
            btnExcluirLista.BackColor = Color.Red;
            btnExcluirLista.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcluirLista.ForeColor = Color.White;
            btnExcluirLista.Location = new Point(676, 350);
            btnExcluirLista.Name = "btnExcluirLista";
            btnExcluirLista.Size = new Size(128, 44);
            btnExcluirLista.TabIndex = 18;
            btnExcluirLista.Text = "&Excluir Lista";
            btnExcluirLista.UseVisualStyleBackColor = false;
            btnExcluirLista.Click += btnExcluirLista_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 428);
            Controls.Add(btnExcluirLista);
            Controls.Add(btnGerar);
            Controls.Add(btnLimpar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(lstPessoas);
            Controls.Add(lblNome);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(btnCriarPessoa);
            Controls.Add(btnVerPessoa);
            Controls.Add(lblMensagem);
            Controls.Add(lblIdade);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Gerenciador de Pessoas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblIdade;
        private Label lblMensagem;
        private Button btnVerPessoa;
        private Button btnCriarPessoa;
        private TextBox txtNome;
        private TextBox txtIdade;
        private Label lblNome;
        private ListBox lstPessoas;
        private Button btnSalvar;
        private Button btnExcluir;
        private Button btnLimpar;
        private Button btnGerar;
        private Button btnExcluirLista;
    }
}