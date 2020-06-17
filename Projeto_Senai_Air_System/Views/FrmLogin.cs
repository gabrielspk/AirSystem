using Projeto_Senai_Air_System.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Senai_Air_System
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = this.Size;
            this.Text = "Login | Taskool";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnNovoUsuarioClick(object sender, EventArgs e)
        {
            new FrmCadastro().ShowDialog();
        }

        private void btnSairClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Confirmação",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnEntrarClick(object sender, EventArgs e)
        {
            if (tbxUsuario.Text.Trim().Length == 0 || tbxSenha.Text.Trim().Length == 0)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Usuário ou senha vazios.", "Erro");
            }
            else
            {
                
                MessageBox.Show("Bem Vindo", "Entrada");
                new FrmPrincipal().ShowDialog();
                
            }
        }

        private void TimerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
