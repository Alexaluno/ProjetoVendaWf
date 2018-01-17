using System;
using System.Drawing;
using System.Windows.Forms;


namespace ProjetoVendaWF
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmCadClientes)
                {
                    frm.BringToFront();
                    frm.WindowState = FormWindowState.Normal;
                    open = true;
                }
            }
            if (!open)
            {
                Form frmCli = new frmCadClientes();
                frmCli.MdiParent = this;
                frmCli.Show();
                frmCli.Location = new Point(0,0);

            }
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmCadProdutos)
                {
                    frm.BringToFront();
                    frm.WindowState = FormWindowState.Normal;
                    open = true;
                }
            }
            if (!open)
            {
                Form frmProd = new frmCadProdutos();
                frmProd.MdiParent = this;
                frmProd.Show();
                frmProd.Location = new Point(480,0);
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmCadUsuarios)
                {
                    frm.BringToFront();
                    frm.WindowState = FormWindowState.Normal;
                    open = true;
                }
            }
            if (!open)
            {
                Form frmUsu = new frmCadUsuarios();
                frmUsu.MdiParent = this;
                frmUsu.Show();
                frmUsu.Location = new Point(1000,0);
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            var produtoRepositorio = new Util.Entidades.Produtos.Repositorio.ProdutoRepositorio();
            var retornoProdutoRepositorio = produtoRepositorio.Produtos;

            var vendaRepositorio = new Util.Entidades.Vendas.Repositorio.VendaRepositorio();
            var retornoVendaRepositorio = vendaRepositorio.Vendas;
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmConsClientes)
                {
                    frm.BringToFront();
                    frm.WindowState = FormWindowState.Normal;
                    open = true;
                }
            }
            if (!open)
            {
              
                Form frmCli = new frmConsClientes();
                frmCli.MdiParent = this;
                frmCli.Show();
                frmCli.Location = new Point(0, 0);

            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipal.ActiveForm.Close();
        }
    }
}
