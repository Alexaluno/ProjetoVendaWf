using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Util.Entidades.Usuarios;
using Util.Entidades.Usuarios.Repositorio;

namespace ProjetoVendaWF
{
    public partial class frmCadUsuarios : Form
    {
        public frmCadUsuarios()
        {
            InitializeComponent();
        }

        private UsuarioRepositorio usuarioRepositorio;
        public static List<Usuario> retornoUsuarioRepositorio;

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.CharacterCasing = CharacterCasing.Upper;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var uNome = string.Empty;
            var uGrupo = false;
            var index = 0;

            uNome = txtUsuario.Text;
            index = cbGrupo.SelectedIndex;

            if (index == 0)
            {
                uGrupo = true;
            }
            else
            {
                uGrupo = false;
            }
            var uInfo = new Usuario(uNome, uGrupo);
            retornoUsuarioRepositorio.Add(uInfo);

            string output = string.Empty;
            foreach (var item in retornoUsuarioRepositorio)
            {
                output += "Nome: " + item.Nome + " | " + "Grupo: " + item.Administrador + "\n";
            }
            MessageBox.Show(output);

            txtUsuario.Text = string.Empty;
            txtUsuario.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void frmCadUsuarios_Load(object sender, EventArgs e)
        {
            var usuarioRepositorio = new UsuarioRepositorio();
            var retornoUsuarioRepositorio = usuarioRepositorio.Usuarios;
        }
    }
}
