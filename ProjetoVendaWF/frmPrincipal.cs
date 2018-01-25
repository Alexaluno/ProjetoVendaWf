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
                frmCli.StartPosition = FormStartPosition.Manual;
                //int x = (this.Width - frmCli.Width) / 2;
                //int y = (this.Height - frmCli.Height) / 4;
                frmCli.Location = new Point(0, 0);
                frmCli.Show();
            }
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
                frmProd.StartPosition = FormStartPosition.Manual;
                //int x = (this.Width - frmProd.Width) / 2;
                //int y = (this.Height - frmProd.Height) / 4;
                frmProd.Location = new Point(907, 0);
                frmProd.Show();
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
                frmUsu.StartPosition = FormStartPosition.Manual;
                //int x = (this.Width - frmUsu.Width) / 2;
                //int y = (this.Height - frmUsu.Height) / 4;
                frmUsu.Location = new Point(453, 0);
                frmUsu.Show();
            }
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
                frmCli.StartPosition = FormStartPosition.Manual;
                //int x = (this.Width - frmCli.Width) / 30;
                //int y = (this.Height - frmCli.Height) / 1;
                frmCli.Location = new Point(0, 251);
                frmCli.Show();
            }
        }

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
                //int x = (this.Width - frmUsu.Width) / 2;
                //int y = (this.Height - frmUsu.Height) / 4;
                frmUsu.Location = new Point(415, 251);
                frmUsu.Show();
            }
        }

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
                //int x = (this.Width - frmProd.Width) / 2;
                //int y = (this.Height - frmProd.Height) / 4;
                frmProd.Location = new Point(779, 251);
                frmProd.Show();
            }
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmSobre = new frmSobre();
            frmSobre.ShowDialog();
        }

        private void frmPrincipal_Shown(object sender, EventArgs e)
        {
            //var retornoProdutoRepositorio = new List<Produto>();
        }
    }
}
