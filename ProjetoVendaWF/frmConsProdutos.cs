using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Util.Entidades.Produtos;
using Util.Entidades.Produtos.Repositorio;

namespace ProjetoVendaWF
{
    public partial class frmConsProdutos : Form
    {

        public frmConsProdutos()
        {
            InitializeComponent();
            AplicarEventosNumeros(txtValprod);
        }

        private int indexRow;

        private void frmConsProdutos_Shown(object sender, EventArgs e)
        {
            //Preenche o grid com os dados armazenados em ProdutoRepositorio
            dgProdutos.DataSource = null;
            dgProdutos.DataSource = ProdutoRepositorio.ObterTodos();
            dgProdutos.Columns[2].Visible = false;
            
        }

        private void dgProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Recebe o índice da linha selecionada no datagrid
            indexRow = e.RowIndex;
            if (indexRow >= 0)
            {
                try
                {
                    //Passa os valores do grid indicados no [indice] para os campos do form
                    //DataGridViewRow row = dgProdutos.Rows[indexRow];
                    //txtDescprod.Text = row.Cells[0].Value.ToString();
                    //txtValprod.Text = row.Cells[1].Value.ToString();
                    txtDescprod.Text = dgProdutos.CurrentRow.Cells[0].Value.ToString();
                    txtValprod.Text = dgProdutos.CurrentRow.Cells[1].Value.ToString();
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
            {
                //remove o usuario selecionado no grid do Repositorio Produtos
                //var indicedalinha = indexRow;
                var idProduto = Guid.Parse(dgProdutos.Rows[indexRow].Cells[2].Value.ToString());
                ProdutoRepositorio.Remover(idProduto);
                //dgProdutos.DataSource = ProdutoRepositorio.ObterTodos();
                }
            }
    
        private void timerProdutos_Tick(object sender, EventArgs e)
        {
            dgProdutos.DataSource = null;
            dgProdutos.DataSource = ProdutoRepositorio.ObterTodos();
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
