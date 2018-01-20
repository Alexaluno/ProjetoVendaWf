using System;
using System.Collections.Generic;
using System.Linq;
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
            //dgUsuarios.DataSource = null;
            //dgUsuarios.DataSource = listaUsuarios;
            //dgUsuarios.Columns[2].Visible = false;
            if (dgUsuarios.Rows.Count == 0)
            {
                //nao faz nada
                dgUsuarios.DataSource = listaUsuarios;
            }
            else
            {
                dgUsuarios.DataSource = null;
                dgUsuarios.DataSource = listaUsuarios;
                dgUsuarios.Columns[2].Visible = false;
            }
        }

        private void dgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // recebe o índice da linha selecionada no datagrid
            indexRow = e.RowIndex; 
            if (indexRow < 0)
            {
                // se estiver vazio o datagrid, não faz nada
            }
            else
            {
                // se tiver dados no datagrid, prenche o textbox e o combobox com as informações dos indices definidos da linha selecionada
                try
                {
                    DataGridViewRow row = dgUsuarios.Rows[indexRow];
                    txtNome.Text = row.Cells[0].Value.ToString();

                    if ((bool)row.Cells[1].Value == true)
                    {
                        cbGrupo.SelectedIndex = 0;
                    }
                    else
                    {
                        cbGrupo.SelectedIndex = 1;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    // Não faz nada
                }
                
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (dgUsuarios.Rows.Count == 0)
            {
                MessageBox.Show("Não existem usuários cadastrados");
                txtNome.Text = string.Empty;
                cbGrupo.SelectedIndex = -1;
            }
            else
            {   // Grava as atualizações feitas direto no list
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
        // Atualiza o grid em tempo de execução
        private void timerUsuarios_Tick(object sender, EventArgs e)
        {
            if (dgUsuarios.Rows.Count == 0)
            {
                //não faz nada
                dgUsuarios.DataSource = listaUsuarios;
            }
            else
            {
                dgUsuarios.DataSource = null;
                dgUsuarios.DataSource = listaUsuarios;
                dgUsuarios.Columns[2].Visible = false;
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgUsuarios.CurrentRow != null)
            {   //remove o usuario selecionado no grid do list
                listaUsuarios.RemoveAt(dgUsuarios.CurrentRow.Index);
                dgUsuarios.DataSource = listaUsuarios.ToList();
            }
        }
    }
}
