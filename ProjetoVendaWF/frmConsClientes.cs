﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Util.Entidades.Clientes;

namespace ProjetoVendaWF
{
    public partial class frmConsClientes : Form
    {
        private List<Cliente> listaClientes;
        public frmConsClientes()
        {
            InitializeComponent();
        }

        private int indexRow;

        private void frmConsClientes_Load(object sender, EventArgs e)
        {
            //dgClientes.Columns[3].Visible = false;
        }

         //atualizar os dados das celulas selecionadas no datagrid
        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            if (dgClientes.Rows.Count == 0)
            {
                MessageBox.Show("Não existem clientes cadastrados");
                txtNome.Text = String.Empty;
                txtEndereco.Text = String.Empty;
            }
            else
            {
                DataGridViewRow newDataRow = dgClientes.Rows[indexRow];
                newDataRow.Cells[0].Value = txtNome.Text.ToUpper();
                newDataRow.Cells[2].Value = txtEndereco.Text.ToUpper();
            }
        }

        private void dgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex; // recebe o índice da linha selecionada no datagrid
            if (indexRow >= 0)
            {
                try
                {
                    DataGridViewRow row = dgClientes.Rows[indexRow];
                    txtNome.Text = row.Cells[0].Value.ToString();
                    txtEndereco.Text = row.Cells[2].Value.ToString();
                }
                catch (IndexOutOfRangeException)
                {
                    // Não faz nada
                }

                // se estiver vazio o datagrid, não faz nada
                // não faz nada
            }
            //else
            //{
                // se tiver dados no datagrid, prenche o textbox e o combobox com as informações dos indices definidos da linha selecionada
                //try
                //{
                //    DataGridViewRow row = dgClientes.Rows[indexRow];
                //    txtNome.Text = row.Cells[0].Value.ToString();
                //    txtEndereco.Text = row.Cells[2].Value.ToString();
                //}
                //catch (IndexOutOfRangeException)
                //{
                //    // Não faz nada
                //}
            //}
        }

        private void frmConsClientes_Shown(object sender, EventArgs e)
        {
            listaClientes = frmCadClientes.retornoClienteRepositorio;
            dgClientes.DataSource = null;
            dgClientes.DataSource = listaClientes;
            if (dgClientes.Rows.Count >= 0)
            {
                dgClientes.Columns[3].Visible = false;
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            dgClientes.DataSource = null;
            dgClientes.DataSource = listaClientes;
        }

        private void timerClientes_Tick(object sender, EventArgs e)
        {
            dgClientes.DataSource = null;
            dgClientes.DataSource = listaClientes;
            if (dgClientes.Rows.Count >= 0)
            {
                dgClientes.Columns[3].Visible = false;
            }

            //lblNome.Text = Location.X.ToString();
            //lblEndereco.Text = Location.Y.ToString();
        }
    }
}
