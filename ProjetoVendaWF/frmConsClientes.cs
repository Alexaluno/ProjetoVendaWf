using System;
using System.Windows.Forms;
using Util.Entidades.Clientes.Repositorio;

namespace ProjetoVendaWF
{
    public partial class frmConsClientes : Form
    {
        //private List<Cliente> listaClientes;
        public frmConsClientes()
        {
            InitializeComponent();
        }

        private int indexRow;

        private void frmConsClientes_Load(object sender, EventArgs e)
        {
            dgClientes.DataSource = null;
            dgClientes.DataSource = ClienteRepositorio.ObterTodos();
        }

         //atualizar os dados das celulas selecionadas no datagrid
        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            if (dgClientes.Rows.Count == 0)
            {
                MessageBox.Show("Não existem clientes cadastrados");
                txtNome.Text = String.Empty;
                txtEndereco.Text = String.Empty;
            }
            else
            {
                if (txtNome.Text != "")
                {
                    DataGridViewRow newDataRow = dgClientes.Rows[indexRow];
                    newDataRow.Cells[0].Value = txtNome.Text.ToUpper();
                    newDataRow.Cells[2].Value = txtEndereco.Text.ToUpper();
                }
                else
                {
                    MessageBox.Show("Selecione um cliente para atualizar");
                }
            }
        }

        private void dgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //indexRow = e.RowIndex; // recebe o índice da linha selecionada no datagrid
            if (dgClientes.Rows.Count > 0)
            {
                txtNome.Text = dgClientes.CurrentRow.Cells[0].Value.ToString();
                txtEndereco.Text = dgClientes.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgClientes.CurrentRow != null)
            {
                var idCliente = Guid.Parse(dgClientes.Rows[indexRow].Cells[3].Value.ToString());
                ClienteRepositorio.Remover(idCliente);
            }
        }

        //Atualiza o grid em tempo de execução
        private void timerClientes_Tick(object sender, EventArgs e)
        {
            if (dgClientes.Rows.Count == 0)
            {
                dgClientes.DataSource = null;
                dgClientes.DataSource = ClienteRepositorio.ObterTodos();
            }
            else
            {
                dgClientes.Refresh();
            }
        }
    }
}
