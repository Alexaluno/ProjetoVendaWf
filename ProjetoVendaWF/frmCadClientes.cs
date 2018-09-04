using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
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
        }

        private void limparTextBoxes(Control.ControlCollection controles)
        {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (Control ctrl in controles)
            {
                //Se o contorle for um TextBox...
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
                foreach (Control ctrl2 in controles)
                {
                    //Se o controle for um MaskedTextBox...
                    if (ctrl2 is MaskedTextBox)
                    {
                        ((MaskedTextBox)(ctrl2)).Text = String.Empty;
                    }
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var cNome = txtNome.Text;
            var cCPF = maskCPF.Text;
            var cNascimento = dtpNascimento.Text;
            var cEndereco = txtEndereco.Text;
            var cNumero = txtNumero.Text;
            var cSexo = "";
            var cBairro = txtBairro.Text;
            var cComplemento = txtComplemento.Text;
            var cCep = maskCEP.Text;
            var cTelefone = maskTelefone.Text;
            var cCelular = maskCelular.Text;
            var cEmail = txtEmail.Text;
            var cCidade = cbMunicipio.SelectedItem.ToString();
            var cUf = cbEstado.SelectedItem.ToString();
            
            if (rbtnMasculino.Checked)
            {
                cSexo = "M";
            }
            else
            {
                cSexo = "F";
            }

            if (Validacao.ValidaCPF.IsCpf(cCPF))
            {
                cCPF = Regex.Replace(cCPF, @"[^\d]", "");
                var cInfo = new Cliente(cNome, cCPF, cNascimento, cEndereco, cNumero, cSexo, cBairro,
                                        cComplemento, cCep, cTelefone, cCelular, cEmail, cCidade, cUf);
                ClienteRepositorio.Adicionar(cInfo);
                MessageBox.Show(ClienteRepositorio.mensagem());

                limparTextBoxes(gpbCliente.Controls);
                dtpNascimento.Value = DateTime.Now;
                rbtnMasculino.Checked = false;
                rbtnFeminino.Checked = false;
                cbMunicipio.SelectedIndex = -1;
                cbEstado.SelectedIndex = -1;
                txtNome.Focus();
            }
            else
            {
                maskCPF.Focus();
                maskCPF.SelectionStart = 0;
                MessageBox.Show("Digite um CPF válido !", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }    

        private void maskValor_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            toolTip1.ToolTipTitle = "Caractere informado inválido";
            toolTip1.Show("Somente digitos de (0-9) são permitidos.", maskCPF, maskCPF.Location, 5000);
        }

        private void frmCadClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void maskCPF_Enter(object sender, EventArgs e)
        {
            maskCPF.Mask = "000,000,000-00";
            maskCPF.MaskInputRejected += new MaskInputRejectedEventHandler(maskValor_MaskInputRejected);
        }

        private void frmCadClientes_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
            cbEstado.SelectedIndex = 0;
            cbMunicipio.SelectedIndex = 0;
            //List<Color> lstColour = new List<Color>();
            //foreach (Control c in gpbSexo.Controls)
            //    lstColour.Add(c.ForeColor);

            //gpbSexo.ForeColor = Color.Black; //the colour you prefer for the text

            //int index = 0;
            //foreach (Control c in gpbSexo.Controls)
            //{
            //    c.ForeColor = lstColour[index];
            //    index++;
            //}
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
