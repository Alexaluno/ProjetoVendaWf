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
            AplicarEventosNumero(txtValprod);
        }

        private void btnCadProd_Click(object sender, EventArgs e)
        {
            var pDesc = txtDescProd.Text;
            var pValor = txtValprod.Text;
            
            //Grava os valores dentro da Classe Produtos
            var pinfo = new Produto(pDesc, decimal.Parse(pValor));
            ProdutoRepositorio.Adicionar(pinfo);
            MessageBox.Show(ProdutoRepositorio.mensagem());

            //Limpa os campos e seta o foco no 1º campo do form
            txtDescProd.Text = string.Empty;
            txtValprod.Text = string.Empty;
            txtDescProd.Focus();
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
        
        //Função para mudar o texto para maiusculo
        private void EscreveMaiusculo(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.CharacterCasing = CharacterCasing.Upper;
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
        private void AplicarEventosTexto(TextBox txt)
        {
            txt.TextChanged += EscreveMaiusculo;
        }

        private void frmCadProdutos_Load(object sender, EventArgs e)
        {
            
        }
    }
}
