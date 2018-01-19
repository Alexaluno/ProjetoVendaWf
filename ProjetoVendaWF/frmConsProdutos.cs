using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util.Entidades.Produtos;
using Util.Entidades.Produtos.Repositorio;

namespace ProjetoVendaWF
{
    public partial class frmConsProdutos : Form
    {

        private List<Produto> listaProdutos;

        public frmConsProdutos()
        {
            InitializeComponent();
        }

        private int indexRow;

        private void frmConsProdutos_Shown(object sender, EventArgs e)
        {
            listaProdutos = frmCadProdutos.retornoProdutoRepositorio;
            dgProdutos.DataSource = null;
            dgProdutos.DataSource = listaProdutos;
        }

        private void dgProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // recebe o índice da linha selecionada no datagrid
            indexRow = e.RowIndex;
            if (indexRow < 0)
            {
                // se estiver vazio o datagrid, não faz nada
                // não faz nada
            }
            else
            {
                // se tiver dados no datagrid, prenche o textbox e o combobox com as informações dos indices definidos da linha selecionada
                try
                {
                    DataGridViewRow row = dgProdutos.Rows[indexRow];
                    txtDescricao.Text = row.Cells[0].Value.ToString();
                    txtValor.Text = row.Cells[1].Value.ToString();
                }
                catch (IndexOutOfRangeException)
                {
                    // Não faz nada
                }

            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (dgProdutos.Rows.Count == 0)
            {
                MessageBox.Show("Não existem usuários cadastrados");
                txtDescricao.Text = string.Empty;
                txtValor.Text = string.Empty;
            }
            else
            {   // Grava as atualizações feitas direto no list
                DataGridViewRow newDataRow = dgProdutos.Rows[indexRow];
                newDataRow.Cells[0].Value = txtDescricao.Text;
                newDataRow.Cells[1].Value = txtValor.Text;
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgProdutos.CurrentRow != null)
            {   //remove o usuario selecionado no grid do list
                listaProdutos.RemoveAt(dgProdutos.CurrentRow.Index);
                dgProdutos.DataSource = listaProdutos.ToList();
            }
        }

        private void timerProdutos_Tick(object sender, EventArgs e)
        {
            dgProdutos.DataSource = null;
            dgProdutos.DataSource = listaProdutos;
        }
    }
}
