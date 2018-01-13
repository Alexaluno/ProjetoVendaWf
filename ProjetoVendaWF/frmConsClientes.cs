using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util.Entidades.Clientes;
using Util.Entidades.Clientes.Repositorio;

namespace ProjetoVendaWF
{
    public partial class frmConsClientes : Form
    {
        public frmConsClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var retornoClienteRepositorio = ClienteRepositorio.Clientes;

            //foreach (var item in retornoClienteRepositorio)
            //{
            //    MessageBox.Show("Nome: " + item.Nome + " | " + "CPF: " + item.Cpf + " | " + "Cidade: " + item.Endereco);
            //}
        }
    }
}
