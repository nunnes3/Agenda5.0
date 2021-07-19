
namespace eAgenda.WindowsForms
{
    partial class Menu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelTelas = new System.Windows.Forms.Panel();
            this.btnCompromissos = new System.Windows.Forms.Button();
            this.btnTarefas = new System.Windows.Forms.Button();
            this.btnContatos = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panelMenu.Controls.Add(this.btnCompromissos);
            this.panelMenu.Controls.Add(this.btnTarefas);
            this.panelMenu.Controls.Add(this.btnContatos);
            this.panelMenu.Location = new System.Drawing.Point(-1, -1);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(252, 725);
            this.panelMenu.TabIndex = 0;
            // 
            // panelTelas
            // 
            this.panelTelas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTelas.Location = new System.Drawing.Point(271, 12);
            this.panelTelas.Name = "panelTelas";
            this.panelTelas.Size = new System.Drawing.Size(1159, 692);
            this.panelTelas.TabIndex = 1;
            // 
            // btnCompromissos
            // 
            this.btnCompromissos.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnCompromissos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCompromissos.FlatAppearance.BorderSize = 0;
            this.btnCompromissos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompromissos.Image = global::eAgenda.WindowsForms.Properties.Resources.icons8_sala_de_reuniões_40;
            this.btnCompromissos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompromissos.Location = new System.Drawing.Point(-3, 435);
            this.btnCompromissos.Name = "btnCompromissos";
            this.btnCompromissos.Size = new System.Drawing.Size(252, 77);
            this.btnCompromissos.TabIndex = 2;
            this.btnCompromissos.Text = "Compromissos";
            this.btnCompromissos.UseVisualStyleBackColor = false;
            this.btnCompromissos.Click += new System.EventHandler(this.btnCompromissos_Click);
            // 
            // btnTarefas
            // 
            this.btnTarefas.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnTarefas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTarefas.FlatAppearance.BorderSize = 0;
            this.btnTarefas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarefas.Image = global::eAgenda.WindowsForms.Properties.Resources.icons8_tarefas_40;
            this.btnTarefas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTarefas.Location = new System.Drawing.Point(-3, 277);
            this.btnTarefas.Name = "btnTarefas";
            this.btnTarefas.Size = new System.Drawing.Size(252, 77);
            this.btnTarefas.TabIndex = 1;
            this.btnTarefas.Text = "Tarefas";
            this.btnTarefas.UseVisualStyleBackColor = false;
            this.btnTarefas.Click += new System.EventHandler(this.btnTarefas_Click);
            // 
            // btnContatos
            // 
            this.btnContatos.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnContatos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnContatos.FlatAppearance.BorderSize = 0;
            this.btnContatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContatos.Image = global::eAgenda.WindowsForms.Properties.Resources.icons8_contatos_40;
            this.btnContatos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContatos.Location = new System.Drawing.Point(-3, 134);
            this.btnContatos.Name = "btnContatos";
            this.btnContatos.Size = new System.Drawing.Size(252, 77);
            this.btnContatos.TabIndex = 0;
            this.btnContatos.Text = "Contatos";
            this.btnContatos.UseVisualStyleBackColor = false;
            this.btnContatos.Click += new System.EventHandler(this.btnContatos_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1442, 716);
            this.Controls.Add(this.panelTelas);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eAgenda 5.0";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnCompromissos;
        private System.Windows.Forms.Button btnTarefas;
        private System.Windows.Forms.Button btnContatos;
        private System.Windows.Forms.Panel panelTelas;
    }
}

