namespace Projeto_Senai_Air_System
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblHora = new System.Windows.Forms.Label();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.TimerHora = new System.Windows.Forms.Timer(this.components);
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnNovoUsuario = new System.Windows.Forms.Button();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.cbIdioma = new System.Windows.Forms.ComboBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblHora.Location = new System.Drawing.Point(473, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(51, 13);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "exibiHora";
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.Location = new System.Drawing.Point(321, 124);
            this.tbxUsuario.MaxLength = 40;
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(203, 20);
            this.tbxUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.Location = new System.Drawing.Point(318, 108);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // TimerHora
            // 
            this.TimerHora.Enabled = true;
            this.TimerHora.Interval = 1;
            this.TimerHora.Tick += new System.EventHandler(this.TimerHora_Tick);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(321, 228);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrarClick);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(402, 228);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSairClick);
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.Location = new System.Drawing.Point(483, 228);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(83, 23);
            this.btnNovoUsuario.TabIndex = 3;
            this.btnNovoUsuario.Text = "NovoUsuario";
            this.btnNovoUsuario.UseVisualStyleBackColor = true;
            this.btnNovoUsuario.Click += new System.EventHandler(this.btnNovoUsuarioClick);
            // 
            // tbxSenha
            // 
            this.tbxSenha.Location = new System.Drawing.Point(321, 163);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.PasswordChar = '*';
            this.tbxSenha.Size = new System.Drawing.Size(203, 20);
            this.tbxSenha.TabIndex = 1;
            // 
            // cbIdioma
            // 
            this.cbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdioma.FormattingEnabled = true;
            this.cbIdioma.Items.AddRange(new object[] {
            "Português PT-BR",
            "Inglês"});
            this.cbIdioma.Location = new System.Drawing.Point(321, 201);
            this.cbIdioma.Name = "cbIdioma";
            this.cbIdioma.Size = new System.Drawing.Size(143, 21);
            this.cbIdioma.TabIndex = 4;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSenha.Location = new System.Drawing.Point(318, 147);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Senha";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblIdioma.Location = new System.Drawing.Point(318, 186);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(38, 13);
            this.lblIdioma.TabIndex = 0;
            this.lblIdioma.Text = "Idioma";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(244, 196);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(321, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(574, 261);
            this.Controls.Add(this.cbIdioma);
            this.Controls.Add(this.btnNovoUsuario);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.tbxUsuario);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblHora);
            this.Name = "FrmLogin";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Timer TimerHora;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnNovoUsuario;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.ComboBox cbIdioma;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblIdioma;
    }
}

