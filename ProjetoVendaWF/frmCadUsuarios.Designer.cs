namespace ProjetoVendaWF
{
    partial class frmCadUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadUsuarios));
            this.panelCadUsu = new System.Windows.Forms.Panel();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.labelUsu1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panelCadUsu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCadUsu
            // 
            this.panelCadUsu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCadUsu.Controls.Add(this.cbGrupo);
            this.panelCadUsu.Controls.Add(this.label1);
            this.panelCadUsu.Controls.Add(this.txtUsuario);
            this.panelCadUsu.Controls.Add(this.labelUsu1);
            this.panelCadUsu.Location = new System.Drawing.Point(12, 12);
            this.panelCadUsu.Name = "panelCadUsu";
            this.panelCadUsu.Size = new System.Drawing.Size(415, 80);
            this.panelCadUsu.TabIndex = 0;
            // 
            // cbGrupo
            // 
            this.cbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "USUÁRIO"});
            this.cbGrupo.Location = new System.Drawing.Point(109, 42);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(175, 21);
            this.cbGrupo.TabIndex = 4;
            this.cbGrupo.Enter += new System.EventHandler(this.cbGrupo_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Grupo do Usuário:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(109, 13);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(295, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // labelUsu1
            // 
            this.labelUsu1.AutoSize = true;
            this.labelUsu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUsu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsu1.Location = new System.Drawing.Point(3, 16);
            this.labelUsu1.Name = "labelUsu1";
            this.labelUsu1.Size = new System.Drawing.Size(108, 13);
            this.labelUsu1.TabIndex = 0;
            this.labelUsu1.Text = "Nome do Usuário:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(113, 102);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(245, 102);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCadUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(439, 133);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.panelCadUsu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmCadUsuarios";
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.frmCadUsuarios_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadUsuarios_KeyDown);
            this.panelCadUsu.ResumeLayout(false);
            this.panelCadUsu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCadUsu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label labelUsu1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbGrupo;
    }
}