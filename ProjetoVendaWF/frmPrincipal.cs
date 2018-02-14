using System;
using System.Windows.Forms;

namespace ProjetoVendaWF
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        #region Carrega Form Cadastro de Clientes
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
                frmCli.StartPosition = FormStartPosition.Manual;
                //int x = (this.Width - frmCli.Width) / 2;
                //int y = (this.Height - frmCli.Height) / 4;
                //frmCli.Location = new Point(0, 0);
                frmCli.Show();
                frmCli.BringToFront();
            }
        }
        #endregion

        #region Carrega Form Cadasatro de Produtos
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
                frmProd.StartPosition = FormStartPosition.Manual;
                frmProd.Show();
            }
        }
        #endregion

        #region Carrega Form Cadastro de Usuarios
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
                frmUsu.StartPosition = FormStartPosition.Manual;
                frmUsu.Show();
            }
        }
        #endregion

        #region Carrega Form Consulta de Clientes
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
                frmCli.StartPosition = FormStartPosition.Manual;
                frmCli.Show();
            }
        }
        #endregion

        #region Carrega Form Consulta de Produtos
        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmConsProdutos)
                {
                    frm.BringToFront();
                    frm.WindowState = FormWindowState.Normal;
                    open = true;
                }
            }
            if (!open)
            {
                Form frmProd = new frmConsProdutos();
                frmProd.MdiParent = this;
                frmProd.StartPosition = FormStartPosition.Manual;
                frmProd.Show();
            }
        }
        #endregion

        #region Carrega Form Consulta de Usuarios
        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmConsUsuarios)
                {
                    frm.BringToFront();
                    frm.WindowState = FormWindowState.Normal;
                    open = true;
                }
            }
            if (!open)
            {
                Form frmUsu = new frmConsUsuarios();
                frmUsu.MdiParent = this;
                frmUsu.StartPosition = FormStartPosition.Manual;
                frmUsu.Show();
            }
        }
        #endregion

        #region Carrega Form Cadastro de Vendas
        private void vendasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmCadVendas)
                {
                    frm.BringToFront();
                    frm.WindowState = FormWindowState.Normal;
                    open = true;
                }
            }
            if (!open)
            {
                Form frmVenda = new frmCadVendas();
                frmVenda.MdiParent = this;
                frmVenda.StartPosition = FormStartPosition.Manual;
                frmVenda.Show();
            }
        }
        #endregion

        #region Carrega Form Consulta de Vendas

        #endregion

        #region Carrega Form Sobre
        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmSobre = new frmSobre();
            frmSobre.ShowDialog();
        }
        #endregion
        
    }
}
