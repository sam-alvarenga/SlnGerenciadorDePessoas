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
            lblMensagem = new Label();
            lstPessoas = new ListBox();
            btnGerar = new Button();
            btnExcluirLista = new Button();
            pnlForm = new Panel();
            btnLimpar = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            lblNome = new Label();
            txtIdade = new TextBox();
            txtNome = new TextBox();
            btnCriarPessoa = new Button();
            btnVerPessoa = new Button();
            lblIdade = new Label();
            label1 = new Label();
            cmbFormatoRelatorio = new ComboBox();
            pnlForm.SuspendLayout();
            SuspendLayout();
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
            // btnGerar
            // 
            btnGerar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGerar.ForeColor = SystemColors.ActiveCaptionText;
            btnGerar.Location = new Point(502, 394);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(152, 31);
            btnGerar.TabIndex = 17;
            btnGerar.Text = "&Gerar Documento";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // btnExcluirLista
            // 
            btnExcluirLista.BackColor = Color.Red;
            btnExcluirLista.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcluirLista.ForeColor = Color.White;
            btnExcluirLista.Location = new Point(688, 394);
            btnExcluirLista.Name = "btnExcluirLista";
            btnExcluirLista.Size = new Size(152, 31);
            btnExcluirLista.TabIndex = 18;
            btnExcluirLista.Text = "&Excluir Lista";
            btnExcluirLista.UseVisualStyleBackColor = false;
            btnExcluirLista.Click += btnExcluirLista_Click;
            // 
            // pnlForm
            // 
            pnlForm.BackColor = SystemColors.Window;
            pnlForm.Controls.Add(btnLimpar);
            pnlForm.Controls.Add(btnExcluir);
            pnlForm.Controls.Add(btnSalvar);
            pnlForm.Controls.Add(lblNome);
            pnlForm.Controls.Add(txtIdade);
            pnlForm.Controls.Add(txtNome);
            pnlForm.Controls.Add(btnCriarPessoa);
            pnlForm.Controls.Add(btnVerPessoa);
            pnlForm.Controls.Add(lblIdade);
            pnlForm.Location = new Point(39, 61);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(420, 321);
            pnlForm.TabIndex = 19;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpar.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpar.Location = new Point(147, 247);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(258, 44);
            btnLimpar.TabIndex = 25;
            btnLimpar.Text = "&Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(15, 247);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(126, 44);
            btnExcluir.TabIndex = 24;
            btnExcluir.Text = "E&xcluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.ForeColor = SystemColors.ActiveCaptionText;
            btnSalvar.Location = new Point(293, 182);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 44);
            btnSalvar.TabIndex = 23;
            btnSalvar.Text = "&Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = SystemColors.HotTrack;
            lblNome.Location = new Point(15, 32);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(61, 21);
            lblNome.TabIndex = 22;
            lblNome.Text = "Nome:";
            // 
            // txtIdade
            // 
            txtIdade.BackColor = SystemColors.Info;
            txtIdade.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdade.Location = new Point(135, 97);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(100, 34);
            txtIdade.TabIndex = 21;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.Info;
            txtNome.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(135, 29);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(270, 34);
            txtNome.TabIndex = 20;
            // 
            // btnCriarPessoa
            // 
            btnCriarPessoa.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCriarPessoa.Location = new Point(15, 182);
            btnCriarPessoa.Name = "btnCriarPessoa";
            btnCriarPessoa.Size = new Size(126, 44);
            btnCriarPessoa.TabIndex = 19;
            btnCriarPessoa.Text = "&Criar Pessoa";
            btnCriarPessoa.UseVisualStyleBackColor = true;
            btnCriarPessoa.Click += btnCriarPessoa_Click;
            // 
            // btnVerPessoa
            // 
            btnVerPessoa.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerPessoa.ForeColor = SystemColors.ActiveCaptionText;
            btnVerPessoa.Location = new Point(147, 182);
            btnVerPessoa.Name = "btnVerPessoa";
            btnVerPessoa.Size = new Size(140, 44);
            btnVerPessoa.TabIndex = 18;
            btnVerPessoa.Text = "&Ver Detalhes";
            btnVerPessoa.UseVisualStyleBackColor = true;
            btnVerPessoa.Click += btnVerPessoa_Click;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdade.ForeColor = SystemColors.HotTrack;
            lblIdade.Location = new Point(15, 100);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(57, 21);
            lblIdade.TabIndex = 17;
            lblIdade.Text = "Idade:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(502, 347);
            label1.Name = "label1";
            label1.Size = new Size(152, 21);
            label1.TabIndex = 26;
            label1.Text = "Formato Relatório:";
            // 
            // cmbFormatoRelatorio
            // 
            cmbFormatoRelatorio.BackColor = SystemColors.Info;
            cmbFormatoRelatorio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormatoRelatorio.FormattingEnabled = true;
            cmbFormatoRelatorio.Items.AddRange(new object[] { "TXT", "JSON" });
            cmbFormatoRelatorio.Location = new Point(660, 349);
            cmbFormatoRelatorio.Name = "cmbFormatoRelatorio";
            cmbFormatoRelatorio.Size = new Size(180, 23);
            cmbFormatoRelatorio.TabIndex = 27;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 456);
            Controls.Add(cmbFormatoRelatorio);
            Controls.Add(label1);
            Controls.Add(pnlForm);
            Controls.Add(btnExcluirLista);
            Controls.Add(btnGerar);
            Controls.Add(lstPessoas);
            Controls.Add(lblMensagem);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Gerenciador de Pessoas";
            Load += Form1_Load;
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblMensagem;
        private ListBox lstPessoas;
        private Button btnGerar;
        private Button btnExcluirLista;
        private Panel pnlForm;
        private Button btnLimpar;
        private Button btnExcluir;
        private Button btnSalvar;
        private Label lblNome;
        private TextBox txtIdade;
        private TextBox txtNome;
        private Button btnCriarPessoa;
        private Button btnVerPessoa;
        private Label lblIdade;
        private Label label1;
        private ComboBox cmbFormatoRelatorio;
    }
}