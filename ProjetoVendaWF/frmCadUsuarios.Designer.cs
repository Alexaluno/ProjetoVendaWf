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
            this.label1 = new System.Windows.Forms.Label();
            this.clbUsu = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelUsu1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelCadUsu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCadUsu
            // 
            this.panelCadUsu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCadUsu.Controls.Add(this.label1);
            this.panelCadUsu.Controls.Add(this.clbUsu);
            this.panelCadUsu.Controls.Add(this.textBox1);
            this.panelCadUsu.Controls.Add(this.labelUsu1);
            this.panelCadUsu.Location = new System.Drawing.Point(12, 12);
            this.panelCadUsu.Name = "panelCadUsu";
            this.panelCadUsu.Size = new System.Drawing.Size(400, 70);
            this.panelCadUsu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Grupo do Usuário:";
            // 
            // clbUsu
            // 
            this.clbUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbUsu.FormattingEnabled = true;
            this.clbUsu.Items.AddRange(new object[] {
            "Administrador",
            "Usuário"});
            this.clbUsu.Location = new System.Drawing.Point(113, 29);
            this.clbUsu.Name = "clbUsu";
            this.clbUsu.Size = new System.Drawing.Size(120, 34);
            this.clbUsu.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 20);
            this.textBox1.TabIndex = 1;
            // 
            // labelUsu1
            // 
            this.labelUsu1.AutoSize = true;
            this.labelUsu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUsu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsu1.Location = new System.Drawing.Point(3, 5);
            this.labelUsu1.Name = "labelUsu1";
            this.labelUsu1.Size = new System.Drawing.Size(108, 13);
            this.labelUsu1.TabIndex = 0;
            this.labelUsu1.Text = "Nome do Usuário:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(113, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(240, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 119);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelCadUsu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsuarios";
            this.Text = "Cadastro de Usuários";
            this.panelCadUsu.ResumeLayout(false);
            this.panelCadUsu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCadUsu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbUsu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelUsu1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}