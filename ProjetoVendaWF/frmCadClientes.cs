using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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

        private ClienteRepositorio clienteRepositorio;
        public static List<Cliente> retornoClienteRepositorio;

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var cNome = txtNome.Text;
            var cCPF = txtCPF.Text;
            var cEndereco = txtEndereco.Text;

            var cInfo = new Cliente(cNome, cCPF, cEndereco);
            retornoClienteRepositorio.Add(cInfo);

            //string output = string.Empty;
            //foreach (var item in retornoClienteRepositorio)
            //{
            //    output += "Nome: " + item.Nome + " | " + "CPF: " + item.Cpf + " | " + "Cidade: " + item.Endereco + "\n";
            //}
            //MessageBox.Show(output);

            txtNome.Text = String.Empty;
            txtCPF.Text = String.Empty;
            txtEndereco.Text = String.Empty;
            txtNome.Focus();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
             clienteRepositorio = new ClienteRepositorio();
             retornoClienteRepositorio = clienteRepositorio.Clientes;
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

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {
            txtEndereco.CharacterCasing = CharacterCasing.Upper;
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
