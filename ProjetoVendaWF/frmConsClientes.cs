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
        private List<Cliente> listaClientes;
        public frmConsClientes()
        {
            InitializeComponent();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var retornoClienteRepositorio = ClienteRepositorio.Clientes;


            listaClientes = frmCadClientes.retornoClienteRepositorio;
            dgClientes.DataSource = null;
            dgClientes.DataSource = listaClientes;
        

        }

        private void frmConsClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
