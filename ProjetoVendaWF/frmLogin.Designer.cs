namespace ProjetoVendaWF
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rtxtUsuario = new System.Windows.Forms.RichTextBox();
            this.rtxtSenha = new System.Windows.Forms.RichTextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblFechar = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.pnlCadUsu = new System.Windows.Forms.Panel();
            this.cbbGrupo = new System.Windows.Forms.ComboBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.rtxtUsuario2 = new System.Windows.Forms.RichTextBox();
            this.rtxtSenha2 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.pnlCadUsu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxtUsuario
            // 
            this.rtxtUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.rtxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtUsuario.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(142)))), ((int)(((byte)(35)))));
            this.rtxtUsuario.Location = new System.Drawing.Point(64, 237);
            this.rtxtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtUsuario.Multiline = false;
            this.rtxtUsuario.Name = "rtxtUsuario";
            this.rtxtUsuario.Size = new System.Drawing.Size(270, 30);
            this.rtxtUsuario.TabIndex = 0;
            this.rtxtUsuario.Tag = "";
            this.rtxtUsuario.Text = "";
            // 
            // rtxtSenha
            // 
            this.rtxtSenha.BackColor = System.Drawing.SystemColors.Control;
            this.rtxtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtSenha.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(142)))), ((int)(((byte)(35)))));
            this.rtxtSenha.Location = new System.Drawing.Point(65, 308);
            this.rtxtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtSenha.Multiline = false;
            this.rtxtSenha.Name = "rtxtSenha";
            this.rtxtSenha.Size = new System.Drawing.Size(270, 30);
            this.rtxtSenha.TabIndex = 1;
            this.rtxtSenha.Text = "";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(82)))), ((int)(((byte)(14)))));
            this.lblUsuario.Location = new System.Drawing.Point(62, 219);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(66, 18);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(82)))), ((int)(((byte)(14)))));
            this.lblSenha.Location = new System.Drawing.Point(63, 288);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(58, 18);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.lblFechar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFechar.Location = new System.Drawing.Point(327, 6);
            this.lblFechar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(20, 19);
            this.lblFechar.TabIndex = 3;
            this.lblFechar.Text = "X";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(82)))), ((int)(((byte)(14)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Location = new System.Drawing.Point(26, 379);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(308, 40);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(82)))), ((int)(((byte)(14)))));
            this.lblCadastro.Location = new System.Drawing.Point(141, 455);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(80, 18);
            this.lblCadastro.TabIndex = 5;
            this.lblCadastro.Text = "Cadastrar";
            this.lblCadastro.Click += new System.EventHandler(this.lblCadastro_Click);
            // 
            // pnlCadUsu
            // 
            this.pnlCadUsu.Controls.Add(this.cbbGrupo);
            this.pnlCadUsu.Controls.Add(this.label6);
            this.pnlCadUsu.Controls.Add(this.label2);
            this.pnlCadUsu.Controls.Add(this.btnSalvar);
            this.pnlCadUsu.Controls.Add(this.rtxtUsuario2);
            this.pnlCadUsu.Controls.Add(this.rtxtSenha2);
            this.pnlCadUsu.Controls.Add(this.label5);
            this.pnlCadUsu.Controls.Add(this.label4);
            this.pnlCadUsu.Controls.Add(this.pictureBox1);
            this.pnlCadUsu.Location = new System.Drawing.Point(12, 34);
            this.pnlCadUsu.Name = "pnlCadUsu";
            this.pnlCadUsu.Size = new System.Drawing.Size(327, 474);
            this.pnlCadUsu.TabIndex = 6;
            this.pnlCadUsu.Visible = false;
            // 
            // cbbGrupo
            // 
            this.cbbGrupo.BackColor = System.Drawing.SystemColors.Control;
            this.cbbGrupo.DataSource = this.usuarioBindingSource;
            this.cbbGrupo.DisplayMember = "Administrador";
            this.cbbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGrupo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(142)))), ((int)(((byte)(35)))));
            this.cbbGrupo.FormattingEnabled = true;
            this.cbbGrupo.Location = new System.Drawing.Point(32, 278);
            this.cbbGrupo.Name = "cbbGrupo";
            this.cbbGrupo.Size = new System.Drawing.Size(269, 26);
            this.cbbGrupo.TabIndex = 2;
            this.cbbGrupo.ValueMember = "Administrador";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Util.Entidades.Usuarios.Usuario);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(82)))), ((int)(((byte)(14)))));
            this.label6.Location = new System.Drawing.Point(140, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Login";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(82)))), ((int)(((byte)(14)))));
            this.label2.Location = new System.Drawing.Point(29, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuário:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(82)))), ((int)(((byte)(14)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.Location = new System.Drawing.Point(31, 345);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(270, 40);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // rtxtUsuario2
            // 
            this.rtxtUsuario2.BackColor = System.Drawing.SystemColors.Control;
            this.rtxtUsuario2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtUsuario2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtUsuario2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(142)))), ((int)(((byte)(35)))));
            this.rtxtUsuario2.Location = new System.Drawing.Point(31, 132);
            this.rtxtUsuario2.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtUsuario2.Multiline = false;
            this.rtxtUsuario2.Name = "rtxtUsuario2";
            this.rtxtUsuario2.Size = new System.Drawing.Size(270, 30);
            this.rtxtUsuario2.TabIndex = 0;
            this.rtxtUsuario2.Tag = "";
            this.rtxtUsuario2.Text = "";
            // 
            // rtxtSenha2
            // 
            this.rtxtSenha2.BackColor = System.Drawing.SystemColors.Control;
            this.rtxtSenha2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtSenha2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtSenha2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(142)))), ((int)(((byte)(35)))));
            this.rtxtSenha2.Location = new System.Drawing.Point(31, 203);
            this.rtxtSenha2.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtSenha2.Multiline = false;
            this.rtxtSenha2.Name = "rtxtSenha2";
            this.rtxtSenha2.Size = new System.Drawing.Size(270, 30);
            this.rtxtSenha2.TabIndex = 1;
            this.rtxtSenha2.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(82)))), ((int)(((byte)(14)))));
            this.label5.Location = new System.Drawing.Point(28, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Grupo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(82)))), ((int)(((byte)(14)))));
            this.label4.Location = new System.Drawing.Point(29, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Senha:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoVendaWF.Properties.Resources.if_Atom_2119356;
            this.pictureBox1.Location = new System.Drawing.Point(130, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProjetoVendaWF.Properties.Resources.slice439_256;
            this.pictureBox3.Location = new System.Drawing.Point(26, 302);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjetoVendaWF.Properties.Resources.admin_button_icon_md;
            this.pictureBox2.Location = new System.Drawing.Point(25, 231);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // picLogin
            // 
            this.picLogin.Image = global::ProjetoVendaWF.Properties.Resources.if_Atom_2119356;
            this.picLogin.Location = new System.Drawing.Point(131, 60);
            this.picLogin.Margin = new System.Windows.Forms.Padding(4);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(120, 120);
            this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogin.TabIndex = 0;
            this.picLogin.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(354, 520);
            this.Controls.Add(this.pnlCadUsu);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblFechar);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.rtxtSenha);
            this.Controls.Add(this.rtxtUsuario);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picLogin);
            this.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlCadUsu.ResumeLayout(false);
            this.pnlCadUsu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.RichTextBox rtxtUsuario;
        private System.Windows.Forms.RichTextBox rtxtSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Panel pnlCadUsu;
        private System.Windows.Forms.ComboBox cbbGrupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.RichTextBox rtxtUsuario2;
        private System.Windows.Forms.RichTextBox rtxtSenha2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
    }
}