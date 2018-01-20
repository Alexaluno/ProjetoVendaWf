using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Util.Entidades.Produtos;

namespace ProjetoVendaWF
{
    public partial class frmConsProdutos : Form
    {

        private List<Produto> listaProdutos;

        public frmConsProdutos()
        {
            InitializeComponent();
            AplicarEventosNumeros(txtValprod);
        }

        private int indexRow;

        private void frmConsProdutos_Shown(object sender, EventArgs e)
        {
            listaProdutos = frmCadProdutos.retornoProdutoRepositorio;
            dgProdutos.DataSource = null;
            dgProdutos.DataSource = listaProdutos;
            dgProdutos.Columns[2].Visible = false;
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
                    txtDescprod.Text = row.Cells[0].Value.ToString();
                    txtValprod.Text = row.Cells[1].Value.ToString();
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
                txtDescprod.Text = string.Empty;
                txtValprod.Text = string.Empty;
            }
            else
            {   // Grava as atualizações feitas direto no list
                DataGridViewRow newDataRow = dgProdutos.Rows[indexRow];
                newDataRow.Cells[0].Value = txtDescprod.Text;
                newDataRow.Cells[1].Value = txtValprod.Text;
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
            dgProdutos.Columns[2].Visible = false;
        }

        private void ApenasValorNumerico(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void AplicarEventosNumeros(TextBox txt)
        {
            txt.KeyPress += ApenasValorNumerico;
        }

    }
}
