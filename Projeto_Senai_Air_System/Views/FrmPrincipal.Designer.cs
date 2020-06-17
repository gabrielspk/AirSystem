namespace Projeto_Senai_Air_System.Views
{
    partial class FrmPrincipal
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
            this.btnListarUsuario = new System.Windows.Forms.Button();
            this.btnListarAvioes = new System.Windows.Forms.Button();
            this.btnGerenciarAviao = new System.Windows.Forms.Button();
            this.btnGerenciarCompanhia = new System.Windows.Forms.Button();
            this.btnGerenciarRelatorios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarUsuario
            // 
            this.btnListarUsuario.BackColor = System.Drawing.Color.Gold;
            this.btnListarUsuario.Location = new System.Drawing.Point(51, 54);
            this.btnListarUsuario.Name = "btnListarUsuario";
            this.btnListarUsuario.Size = new System.Drawing.Size(100, 60);
            this.btnListarUsuario.TabIndex = 0;
            this.btnListarUsuario.Text = "Listar Usuarios";
            this.btnListarUsuario.UseVisualStyleBackColor = false;
            this.btnListarUsuario.Click += new System.EventHandler(this.btnListarUsuario_Click);
            // 
            // btnListarAvioes
            // 
            this.btnListarAvioes.BackColor = System.Drawing.Color.Gold;
            this.btnListarAvioes.Location = new System.Drawing.Point(213, 54);
            this.btnListarAvioes.Name = "btnListarAvioes";
            this.btnListarAvioes.Size = new System.Drawing.Size(100, 60);
            this.btnListarAvioes.TabIndex = 0;
            this.btnListarAvioes.Text = "Listar Aviões";
            this.btnListarAvioes.UseVisualStyleBackColor = false;
            // 
            // btnGerenciarAviao
            // 
            this.btnGerenciarAviao.BackColor = System.Drawing.Color.Gold;
            this.btnGerenciarAviao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGerenciarAviao.Location = new System.Drawing.Point(369, 54);
            this.btnGerenciarAviao.Name = "btnGerenciarAviao";
            this.btnGerenciarAviao.Size = new System.Drawing.Size(100, 60);
            this.btnGerenciarAviao.TabIndex = 0;
            this.btnGerenciarAviao.Text = "Gerenciar Avião";
            this.btnGerenciarAviao.UseVisualStyleBackColor = false;
            // 
            // btnGerenciarCompanhia
            // 
            this.btnGerenciarCompanhia.BackColor = System.Drawing.Color.Gold;
            this.btnGerenciarCompanhia.Location = new System.Drawing.Point(51, 151);
            this.btnGerenciarCompanhia.Name = "btnGerenciarCompanhia";
            this.btnGerenciarCompanhia.Size = new System.Drawing.Size(100, 60);
            this.btnGerenciarCompanhia.TabIndex = 0;
            this.btnGerenciarCompanhia.Text = "Gerenciar Companhia";
            this.btnGerenciarCompanhia.UseVisualStyleBackColor = false;
            // 
            // btnGerenciarRelatorios
            // 
            this.btnGerenciarRelatorios.BackColor = System.Drawing.Color.Gold;
            this.btnGerenciarRelatorios.Location = new System.Drawing.Point(213, 151);
            this.btnGerenciarRelatorios.Name = "btnGerenciarRelatorios";
            this.btnGerenciarRelatorios.Size = new System.Drawing.Size(100, 60);
            this.btnGerenciarRelatorios.TabIndex = 0;
            this.btnGerenciarRelatorios.Text = "Gerenciar Relatorio";
            this.btnGerenciarRelatorios.UseVisualStyleBackColor = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(532, 261);
            this.Controls.Add(this.btnGerenciarAviao);
            this.Controls.Add(this.btnListarAvioes);
            this.Controls.Add(this.btnGerenciarRelatorios);
            this.Controls.Add(this.btnGerenciarCompanhia);
            this.Controls.Add(this.btnListarUsuario);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnListarUsuario;
        private System.Windows.Forms.Button btnListarAvioes;
        private System.Windows.Forms.Button btnGerenciarAviao;
        private System.Windows.Forms.Button btnGerenciarCompanhia;
        private System.Windows.Forms.Button btnGerenciarRelatorios;
    }
}