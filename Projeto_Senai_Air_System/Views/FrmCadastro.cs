using Projeto_Senai_Air_System.Models;
using Projeto_Senai_Air_System.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Senai_Air_System.Views
{
    public partial class FrmCadastro : Form
    {
        private Usuario usuario = null;
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            
        }        

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivos de imagens(*.jpg;*.png)|*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fotoPictureBox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja Remover sua foto?", "Confirmação",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                fotoPictureBox.Image = null;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!Utils.temCamposVazio(this))
            {
                UsuarioRepository repository = new UsuarioRepository();
                if (this.usuario == null)
                {
                    Usuario usuario = new Usuario
                    {
                        nome = nomeTextBox.Text,
                        sobrenome = sobrenomeTextBox.Text,
                        endereco = enderecoTextBox.Text,
                        usuario = usuarioTextBox.Text,
                        senha = senhaTextBox.Text
                    };
                    repository.adicionar(usuario);

                    MessageBox.Show("Usuario Cadastrado.",
                        "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
            MessageBox.Show("Verifique campos obrigatórios",
                                "Aviso", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }     
        }
    }
}
