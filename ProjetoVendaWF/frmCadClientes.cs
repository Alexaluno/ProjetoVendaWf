using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Util.Entidades.Clientes;
using Util.Entidades.Clientes.Repositorio;


namespace ProjetoVendaWF
{
    public partial class frmCadClientes : Form
    {
        public frmCadClientes()
        {
            InitializeComponent();
            AplicarEventosNumeros(txtCPF);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var cNome = txtNome.Text;
            var cCPF = txtCPF.Text;
            var cEndereco = txtEndereco.Text;

            var cInfo = new Cliente(cNome, cCPF, cEndereco);
            ClienteRepositorio.Adicionar(cInfo);
            MessageBox.Show(ClienteRepositorio.mensagem());

            txtNome.Text = String.Empty;
            txtCPF.Text = String.Empty;
            txtEndereco.Text = String.Empty;
            txtNome.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void ApenasValorNumerico(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void AplicarEventosNumeros(TextBox txt)
        {
            txt.KeyPress += ApenasValorNumerico;
        }

    }
}
