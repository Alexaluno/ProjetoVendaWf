﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Util.Entidades.Produtos.Repositorio;
using Util.Entidades.Vendas;
using Util.Entidades.Vendas.Repositorio;

namespace ProjetoVendaWF
{
    public partial class frmCadVendas : Form
    {
        public frmCadVendas()
        {
            InitializeComponent();
        }

        //private VendaRepositorio vendaRepositorio;
        public static List<Venda> retornoVendaRepositorio;

        #region Centralizar Texto na Barra de Titulo
        private void UpdateTextPosition()
        {
            Graphics g = this.CreateGraphics();
            Double startingPoint = (this.Width / 2) - (g.MeasureString(this.Text.Trim(), this.Font).Width / 2);
            Double widthOfASpace = g.MeasureString(" ", this.Font).Width;
            String tmp = " ";
            Double tmpWidth = 0;

            while ((tmpWidth + widthOfASpace) < startingPoint)
            {
                tmp += " ";
                tmpWidth += widthOfASpace;
            }
            this.Text = tmp + this.Text.Trim();
        }
        #endregion

        private void frmCadVendas_Load(object sender, EventArgs e)
        {
            UpdateTextPosition();
            dgVenda.DataSource = ProdutoRepositorio.ObterTodos();
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            groupBox.Visible = true;
            btnNovaVenda.Enabled = false;
        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {

        }
    }
}
