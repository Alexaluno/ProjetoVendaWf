using System;
using System.Collections.Generic;
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

            AplicarEventosTexto(txtDescProd);
            AplicarEventosNumeros(txtValprod);
        }

        private ProdutoRepositorio produtoRepositorio;
        public static List<Produto> retornoProdutoRepositorio;

        private void frmCadProdutos_Load(object sender, EventArgs e)
        {
            produtoRepositorio = new ProdutoRepositorio();
            retornoProdutoRepositorio = produtoRepositorio.Produtos;
        }

        private void btnCadProd_Click(object sender, EventArgs e)
        {
            var pDesc = string.Empty;
            var pValor = string.Empty;

            if (txtDescProd.Text == "")
            {
                MessageBox.Show("Campo não pode ser vazio !");
                txtDescProd.Focus();
                return;
            }
            else
            {
                pDesc = txtDescProd.Text;
            }

            if (txtValprod.Text == "")
            {
                MessageBox.Show("Campo não pode ser vazio !");
                txtValprod.Focus();
                return;
            }
            else
            {
                pValor = txtValprod.Text;
            }
            
            var pinfo = new Produto(pDesc, decimal.Parse(pValor));
            retornoProdutoRepositorio.Add(pinfo);

            string output = string.Empty;
            foreach (var item in retornoProdutoRepositorio)
            {
                output += "Produto: " + item.Descricao + " | " + "Valor: R$" + item.Valor + "\n";
            }
            MessageBox.Show(output);

            txtDescProd.Text = string.Empty;
            txtValprod.Text = string.Empty;
            txtDescProd.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        ////Função para colocar a mascara
        //private void RetornarMascara(object sender, EventArgs e)
        //{
        //    TextBox txt = (TextBox)sender;
        //    txt.Text = decimal.Parse(txt.Text).ToString("C2");
        //}
        ////Função para retirar a mascara
        //private void TirarMascara(object sender, EventArgs e)
        //{
        //    TextBox txt = (TextBox)sender;
        //    txt.Text = txt.Text.Replace("R$", "").Trim();
        //}
        
        //Função para mudar o texto para maiusculo
        private void EscreveMaiusculo(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.CharacterCasing = CharacterCasing.Upper;
        }

        //Função para somente permitir números e virgula
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
        //Aplica todas as funções aos respectivos eventos
        private void AplicarEventosNumeros(TextBox txt)
        {
            //txt.Enter += TirarMascara;
            //txt.Leave += RetornarMascara;
            txt.KeyPress += ApenasValorNumerico;
        }
        private void AplicarEventosTexto(TextBox txt)
        {
            txt.TextChanged += EscreveMaiusculo;
        }
    }
}
