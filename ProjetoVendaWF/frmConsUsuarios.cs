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
        //BindingSource bs = new BindingSource();

        public frmConsUsuarios()
        {
            InitializeComponent();
        }

        private int indexRow;

        private void dgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // recebe o índice da linha selecionada no datagrid
            indexRow = e.RowIndex; 
            if (indexRow >= 0)
            {
                //Se estiver vazio o datagrid, não faz nada
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
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {   //Testa se existe usuario cadastrado
            if (dgUsuarios.Rows.Count == 0)
            {
                MessageBox.Show("Não existem usuários cadastrados");
                txtNome.Text = string.Empty;
                cbGrupo.SelectedIndex = -1;
            }
            else
            {   //Se existir, grava as alterações feitas no cadastro de usuario
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
            dgUsuarios.DataSource = null;
            dgUsuarios.DataSource = listaUsuarios;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgUsuarios.CurrentRow != null)
            {   //remove o usuario selecionado no grid do list
                listaUsuarios.RemoveAt(dgUsuarios.CurrentRow.Index);
                dgUsuarios.DataSource = listaUsuarios.ToList();
            }
        }

        private void frmConsUsuarios_Load(object sender, EventArgs e)
        {
            //Recebe os dados do usuario vindos do form de cadastro
            listaUsuarios = frmCadUsuarios.retornoUsuarioRepositorio;
            dgUsuarios.DataSource = null;
            dgUsuarios.DataSource = listaUsuarios;
        }
    }
}
