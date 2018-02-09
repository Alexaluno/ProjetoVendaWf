using System;
using System.Linq;
using System.Windows.Forms;
using Util.Entidades.Produtos;
using Util.Entidades.Produtos.Repositorio;

namespace ProjetoVendaWF
{
    public partial class frmCadProdutos : Form
    {
        
        public frmCadProdutos()
        {
            InitializeComponent();

            AplicarEventosNumero(txtValprod);
            AplicarEventosNumero(txtQuant);
        }

        private void btnCadProd_Click(object sender, EventArgs e)
        {
            var pDesc = txtDescProd.Text;
            var pQuant = txtQuant.Text;
            var pValor = txtValprod.Text;

            //Grava os valores dentro da Classe Produtos
            if (txtDescProd.Text != "" && txtQuant.Text != "" && txtValprod.Text != "")
            {
                var pinfo = new Produto(pDesc, Convert.ToInt32(pQuant), decimal.Parse(pValor));
                ProdutoRepositorio.Adicionar(pinfo);
                MessageBox.Show(ProdutoRepositorio.mensagem());

                txtDescProd.Text = string.Empty;
                txtQuant.Text = string.Empty;
                txtValprod.Text = string.Empty;
                txtDescProd.Focus();
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos !", "Cadastro de Produtos", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                if (pDesc == "")
                {
                    txtDescProd.Focus();
                }
                if (pQuant == "")
                {
                    txtQuant.Focus();
                }
                if (pValor == "")
                {
                    txtValprod.Focus();
                }
            }

            //string output = string.Empty;
            //foreach (var item in ProdutoRepositorio.ObterTodos())
            //{
            //    output += "Nome: " + item.Descricao + " | " + "Valor: R$" + item.Valor + "\n";
            //}
            //MessageBox.Show(output);

            //Limpa os campos e seta o foco no 1º campo do form
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Fecha o form
            Close();
        }

        private void frmCadProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            //Habilita o uso do Enter para trocar de campo no form
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        //Função para permitir somente números e virgula
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
        //Aplica as funções aos respectivos eventos
        private void AplicarEventosNumero(TextBox txt)
        {
            txt.KeyPress += ApenasValorNumerico;
        }

    }
}
