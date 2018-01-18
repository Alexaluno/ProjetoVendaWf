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

        private int indexRow;

        private void frmConsUsuarios_Shown(object sender, EventArgs e)
        {
            listaUsuarios = frmCadUsuarios.retornoUsuarioRepositorio;
            dgUsuarios.DataSource = null;
            dgUsuarios.DataSource = listaUsuarios;
        }

        private void dgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //var index = 0;
            indexRow = e.RowIndex; // recebe o índice da linha selecionada no datagrid
            if (dgUsuarios.Rows.Count == 0)
            {
                // se estiver vazio o datagrid não faz nada
                ResumeLayout();
            }
            else
            {
                // se tiver info no datagrid, prenche o textbox e o combobox com as informações dos indices definidos da linha selecionada
                //var retorno = false;
                DataGridViewRow row = dgUsuarios.Rows[indexRow];
                txtNome.Text = row.Cells[0].Value.ToString();

                if ((bool) row.Cells[1].Value == true)
                {
                    cbGrupo.SelectedIndex = 0;
                }
                else
                {
                    cbGrupo.SelectedIndex = 1;
                }
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            dgUsuarios.DataSource = null;
            dgUsuarios.DataSource = listaUsuarios;
        }

        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            if (dgUsuarios.Rows.Count == 0)
            {
                MessageBox.Show("Não existem clientes cadastrados");
                txtNome.Text = String.Empty;
                cbGrupo.SelectedIndex = -1;
            }
            else
            {
                DataGridViewRow newDataRow = dgUsuarios.Rows[indexRow];
                newDataRow.Cells[0].Value = txtNome.Text.ToUpper();
                if (cbGrupo.SelectedIndex == 0)
                {
                    newDataRow.Cells[1].Value = true;
                }
                else if (cbGrupo.SelectedIndex == 1)
                {
                    newDataRow.Cells[1].Value = false;
                }
                
            }
        }
    }
}
