using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;

namespace ProjetoVendaWF
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblCadastro_Click(object sender, EventArgs e)
        {
            pnlCadUsu.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            pnlCadUsu.Visible = false;
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            rtxtUsuario.SelectionAlignment = HorizontalAlignment.Center;
            rtxtSenha.SelectionAlignment = HorizontalAlignment.Center;
            rtxtUsuario2.SelectionAlignment = HorizontalAlignment.Center;
            rtxtSenha2.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
}
