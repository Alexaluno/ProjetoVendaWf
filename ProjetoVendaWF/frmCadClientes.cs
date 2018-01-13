using System;
using System.Collections.Generic;
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
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            var cNome = "";
            var cCPF = "";
            var cEndereco = "";

            cNome = txtNome.Text.ToUpper();
            cCPF = txtCPF.Text.ToUpper();
            cEndereco = txtEndereco.Text.ToUpper();

            var cInfo = new Cliente(cNome, cCPF, cEndereco);
            retornoClienteRepositorio.Add(cInfo);

            //foreach (var item in retornoClienteRepositorio)
            //{
            //        MessageBox.Show("Nome: " + item.Nome + " | " + "CPF: " + item.Cpf + " | " + "Cidade: " + item.Endereco);   
            //}

            string output = string.Empty;
            foreach (var item in retornoClienteRepositorio)
            {
                output += "Nome: " + item.Nome + " | " + "CPF: " + item.Cpf + " | " + "Cidade: " + item.Endereco + "\n";
            }
            MessageBox.Show(output);

            txtNome.Text = String.Empty;
            txtCPF.Text = String.Empty;
            txtEndereco.Text = String.Empty;

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
             clienteRepositorio = new ClienteRepositorio();
             retornoClienteRepositorio = clienteRepositorio.Clientes;
        }

        private ClienteRepositorio clienteRepositorio;
        public static List<Cliente> retornoClienteRepositorio;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //implementação da consulta de cliente - foi criado uma variavel do tipo estatica no forme de cadastro de cliente e essa variavel vai servir para armazenar as informações de cliente
    }
}
