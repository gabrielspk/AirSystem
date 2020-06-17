namespace Projeto_Senai_Air_System.Views
{
    partial class FrmCadastro
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
            this.lblEndereço = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblNomeSobrenome = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.confirmarTextBox = new System.Windows.Forms.TextBox();
            this.sobrenomeTextBox = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.tbxN = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.dtpNascimento = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEndereço
            // 
            this.lblEndereço.AutoSize = true;
            this.lblEndereço.BackColor = System.Drawing.Color.Black;
            this.lblEndereço.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEndereço.Location = new System.Drawing.Point(12, 41);
            this.lblEndereço.Name = "lblEndereço";
            this.lblEndereço.Size = new System.Drawing.Size(53, 13);
            this.lblEndereço.TabIndex = 0;
            this.lblEndereço.Text = "Endereço";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(112, 12);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(125, 20);
            this.nomeTextBox.TabIndex = 1;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.Image = global::Projeto_Senai_Air_System.Properties.Resources.userImage;
            this.fotoPictureBox.Location = new System.Drawing.Point(428, 12);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(126, 118);
            this.fotoPictureBox.TabIndex = 2;
            this.fotoPictureBox.TabStop = false;
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Location = new System.Drawing.Point(411, 171);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(98, 17);
            this.cbAdmin.TabIndex = 3;
            this.cbAdmin.Text = "É administrador";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Black;
            this.lblSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSenha.Location = new System.Drawing.Point(12, 119);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Senha";
            // 
            // lblNomeSobrenome
            // 
            this.lblNomeSobrenome.AutoSize = true;
            this.lblNomeSobrenome.BackColor = System.Drawing.Color.Black;
            this.lblNomeSobrenome.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNomeSobrenome.Location = new System.Drawing.Point(12, 15);
            this.lblNomeSobrenome.Name = "lblNomeSobrenome";
            this.lblNomeSobrenome.Size = new System.Drawing.Size(35, 13);
            this.lblNomeSobrenome.TabIndex = 0;
            this.lblNomeSobrenome.Text = "Nome";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Black;
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsuario.Location = new System.Drawing.Point(12, 93);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.BackColor = System.Drawing.Color.Black;
            this.lblConfirmarSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(12, 145);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(85, 13);
            this.lblConfirmarSenha.TabIndex = 0;
            this.lblConfirmarSenha.Text = "Confirmar Senha";
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.Location = new System.Drawing.Point(112, 38);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(199, 20);
            this.enderecoTextBox.TabIndex = 1;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Location = new System.Drawing.Point(112, 90);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(125, 20);
            this.usuarioTextBox.TabIndex = 1;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(112, 116);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(125, 20);
            this.senhaTextBox.TabIndex = 1;
            this.senhaTextBox.UseSystemPasswordChar = true;
            // 
            // confirmarTextBox
            // 
            this.confirmarTextBox.Location = new System.Drawing.Point(112, 142);
            this.confirmarTextBox.Name = "confirmarTextBox";
            this.confirmarTextBox.PasswordChar = '*';
            this.confirmarTextBox.Size = new System.Drawing.Size(125, 20);
            this.confirmarTextBox.TabIndex = 1;
            this.confirmarTextBox.UseSystemPasswordChar = true;
            // 
            // sobrenomeTextBox
            // 
            this.sobrenomeTextBox.Location = new System.Drawing.Point(243, 12);
            this.sobrenomeTextBox.Name = "sobrenomeTextBox";
            this.sobrenomeTextBox.Size = new System.Drawing.Size(125, 20);
            this.sobrenomeTextBox.TabIndex = 1;
            // 
            // btnAlterar
            // 
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAlterar.Location = new System.Drawing.Point(411, 139);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeletar.Location = new System.Drawing.Point(492, 139);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 4;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // tbxN
            // 
            this.tbxN.Location = new System.Drawing.Point(317, 38);
            this.tbxN.Name = "tbxN";
            this.tbxN.Size = new System.Drawing.Size(51, 20);
            this.tbxN.TabIndex = 1;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(112, 64);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(241, 20);
            this.dtpData.TabIndex = 5;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.AutoSize = true;
            this.dtpNascimento.BackColor = System.Drawing.Color.Black;
            this.dtpNascimento.ForeColor = System.Drawing.SystemColors.Control;
            this.dtpNascimento.Location = new System.Drawing.Point(12, 70);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(63, 13);
            this.dtpNascimento.TabIndex = 0;
            this.dtpNascimento.Text = "Nascimento";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastrar.Location = new System.Drawing.Point(137, 171);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(579, 227);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.cbAdmin);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(this.confirmarTextBox);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(this.sobrenomeTextBox);
            this.Controls.Add(this.tbxN);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblNomeSobrenome);
            this.Controls.Add(this.lblConfirmarSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.lblEndereço);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "FrmCadastro";
            this.Text = "FrmCadastro";
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEndereço;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.CheckBox cbAdmin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblNomeSobrenome;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox confirmarTextBox;
        private System.Windows.Forms.TextBox sobrenomeTextBox;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.TextBox tbxN;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label dtpNascimento;
        private System.Windows.Forms.Button btnCadastrar;
    }
}