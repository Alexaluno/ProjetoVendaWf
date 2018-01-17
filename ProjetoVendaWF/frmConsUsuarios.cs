using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util.Entidades.Usuarios;

namespace ProjetoVendaWF
{
    public partial class frmConsUsuarios : Form
    {
        private List<Usuario> listaUsuarios;
        public frmConsUsuarios()
        {
            InitializeComponent();
        }

        private void frmConsUsuarios_Shown(object sender, EventArgs e)
        {
            listaUsuarios = frmCadUsuarios.retornoUsuarioRepositorio;
        }
    }
}
