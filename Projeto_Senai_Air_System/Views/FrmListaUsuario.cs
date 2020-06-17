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
    public partial class FrmListaUsuario : Form
    {
        public FrmListaUsuario()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new FrmCadastro().ShowDialog();
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new FrmPrincipal().ShowDialog();
        }
    }
}
