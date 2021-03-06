﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Util.Entidades.Usuarios;
using Util.Entidades.Usuarios.Repositorio;

namespace ProjetoVendaWF
{
    public partial class frmCadUsuarios : Form
    {
        public frmCadUsuarios()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var uNome = string.Empty;
            var uGrupo = false;
            var index = 0;

            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Campo Usuário não pode ser vazio !");
                txtUsuario.Focus();
                return;
            }
            else
            {
                uNome = txtUsuario.Text;
            }

            index = cbGrupo.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("Campo Grupo não pode ser vazio !");
                cbGrupo.DroppedDown = true;
                return;
            }
            else if (index == 0)
            {
                uGrupo = true;
            }
            else if (index == 1)
            {
                uGrupo = false;
            }

            var uInfo = new Usuario(uNome, uGrupo);
            UsuarioRepositorio.Adicionar(uInfo);
            MessageBox.Show(UsuarioRepositorio.mensagem());


            string output = string.Empty;
            foreach (var item in UsuarioRepositorio.ObterTodos())
            {
                output += "Nome: " + item.Nome + " \t " + "Grupo: " + item.Administrador + "\n";
            }
            MessageBox.Show(output);

            txtUsuario.Text = string.Empty;
            cbGrupo.SelectedIndex = -1;
            txtUsuario.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void cbGrupo_Enter(object sender, EventArgs e)
        {
            cbGrupo.DroppedDown = true;
        }
    }
}
