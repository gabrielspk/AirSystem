namespace Projeto_Senai_Air_System.Views
{
    partial class FrmPrincipalUserComum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListarAvioes = new System.Windows.Forms.Button();
            this.btnGerenciarAviao = new System.Windows.Forms.Button();
            this.btnGerenciarCompanhia = new System.Windows.Forms.Button();
            this.btnGerenciarRelatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarAvioes
            // 
            this.btnListarAvioes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnListarAvioes.Location = new System.Drawing.Point(55, 32);
            this.btnListarAvioes.Name = "btnListarAvioes";
            this.btnListarAvioes.Size = new System.Drawing.Size(100, 60);
            this.btnListarAvioes.TabIndex = 0;
            this.btnListarAvioes.Text = "Listar Aviões";
            this.btnListarAvioes.UseVisualStyleBackColor = false;
            this.btnListarAvioes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGerenciarAviao
            // 
            this.btnGerenciarAviao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGerenciarAviao.Location = new System.Drawing.Point(368, 32);
            this.btnGerenciarAviao.Name = "btnGerenciarAviao";
            this.btnGerenciarAviao.Size = new System.Drawing.Size(100, 60);
            this.btnGerenciarAviao.TabIndex = 0;
            this.btnGerenciarAviao.Text = "gerenciarAviao";
            this.btnGerenciarAviao.UseVisualStyleBackColor = false;
            // 
            // btnGerenciarCompanhia
            // 
            this.btnGerenciarCompanhia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGerenciarCompanhia.Location = new System.Drawing.Point(55, 161);
            this.btnGerenciarCompanhia.Name = "btnGerenciarCompanhia";
            this.btnGerenciarCompanhia.Size = new System.Drawing.Size(100, 60);
            this.btnGerenciarCompanhia.TabIndex = 0;
            this.btnGerenciarCompanhia.Text = "Gerenciar Companhia";
            this.btnGerenciarCompanhia.UseVisualStyleBackColor = false;
            this.btnGerenciarCompanhia.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGerenciarRelatorio
            // 
            this.btnGerenciarRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGerenciarRelatorio.Location = new System.Drawing.Point(368, 161);
            this.btnGerenciarRelatorio.Name = "btnGerenciarRelatorio";
            this.btnGerenciarRelatorio.Size = new System.Drawing.Size(100, 60);
            this.btnGerenciarRelatorio.TabIndex = 0;
            this.btnGerenciarRelatorio.Text = "Gerenciar Relatorio";
            this.btnGerenciarRelatorio.UseVisualStyleBackColor = false;
            this.btnGerenciarRelatorio.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(532, 261);
            this.Controls.Add(this.btnGerenciarRelatorio);
            this.Controls.Add(this.btnGerenciarCompanhia);
            this.Controls.Add(this.btnGerenciarAviao);
            this.Controls.Add(this.btnListarAvioes);
            this.Name = "FrmTelaPrincipal";
            this.Text = "FrmTelaPrincipal";
            this.Load += new System.EventHandler(this.FrmTelaPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListarAvioes;
        private System.Windows.Forms.Button btnGerenciarAviao;
        private System.Windows.Forms.Button btnGerenciarCompanhia;
        private System.Windows.Forms.Button btnGerenciarRelatorio;
    }
}