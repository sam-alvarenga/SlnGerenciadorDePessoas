﻿namespace PrjGerenciadorPessoas
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
            SuspendLayout();
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdade.ForeColor = SystemColors.HotTrack;
            lblIdade.Location = new Point(28, 152);
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
            lblMensagem.Location = new Point(38, 384);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 28);
            lblMensagem.TabIndex = 7;
            // 
            // btnVerPessoa
            // 
            btnVerPessoa.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerPessoa.ForeColor = SystemColors.ActiveCaptionText;
            btnVerPessoa.Location = new Point(134, 235);
            btnVerPessoa.Name = "btnVerPessoa";
            btnVerPessoa.Size = new Size(124, 44);
            btnVerPessoa.TabIndex = 8;
            btnVerPessoa.Text = "&Ver Pessoa";
            btnVerPessoa.UseVisualStyleBackColor = true;
            btnVerPessoa.Click += btnVerPessoa_Click;
            // 
            // btnCriarPessoa
            // 
            btnCriarPessoa.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCriarPessoa.Location = new Point(293, 235);
            btnCriarPessoa.Name = "btnCriarPessoa";
            btnCriarPessoa.Size = new Size(124, 44);
            btnCriarPessoa.TabIndex = 9;
            btnCriarPessoa.Text = "&Ver Pessoa";
            btnCriarPessoa.UseVisualStyleBackColor = true;
            btnCriarPessoa.Click += btnCriarPessoa_Click;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.Info;
            txtNome.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(122, 84);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(371, 34);
            txtNome.TabIndex = 10;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtIdade
            // 
            txtIdade.BackColor = SystemColors.Info;
            txtIdade.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdade.Location = new Point(122, 146);
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
            lblNome.Location = new Point(23, 87);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(74, 28);
            lblNome.TabIndex = 12;
            lblNome.Text = "Nome:";
            lblNome.Click += lblNome_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 398);
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
    }
}