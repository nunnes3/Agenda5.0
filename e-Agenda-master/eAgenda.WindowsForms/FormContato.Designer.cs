
namespace eAgenda.WindowsForms
{
    partial class FormContato
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
            this.panelContatos = new System.Windows.Forms.Panel();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEmpresa = new System.Windows.Forms.TextBox();
            this.textBoxCargo = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.dataGridViewContato = new System.Windows.Forms.DataGridView();
            this.lblCargo = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.lblTarefa = new System.Windows.Forms.Label();
            this.panelContatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContato)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContatos
            // 
            this.panelContatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContatos.Controls.Add(this.maskedTextBoxTelefone);
            this.panelContatos.Controls.Add(this.textBoxEmpresa);
            this.panelContatos.Controls.Add(this.textBoxCargo);
            this.panelContatos.Controls.Add(this.textBoxEmail);
            this.panelContatos.Controls.Add(this.lblId);
            this.panelContatos.Controls.Add(this.textBoxId);
            this.panelContatos.Controls.Add(this.dataGridViewContato);
            this.panelContatos.Controls.Add(this.lblCargo);
            this.panelContatos.Controls.Add(this.labelTelefone);
            this.panelContatos.Controls.Add(this.lblEmpresa);
            this.panelContatos.Controls.Add(this.labelEmail);
            this.panelContatos.Controls.Add(this.lblNome);
            this.panelContatos.Controls.Add(this.textBoxNome);
            this.panelContatos.Location = new System.Drawing.Point(223, 56);
            this.panelContatos.Name = "panelContatos";
            this.panelContatos.Size = new System.Drawing.Size(836, 571);
            this.panelContatos.TabIndex = 5;
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(66, 219);
            this.maskedTextBoxTelefone.Mask = "(##)#####-####";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(206, 22);
            this.maskedTextBoxTelefone.TabIndex = 21;
            // 
            // textBoxEmpresa
            // 
            this.textBoxEmpresa.Location = new System.Drawing.Point(492, 136);
            this.textBoxEmpresa.Name = "textBoxEmpresa";
            this.textBoxEmpresa.Size = new System.Drawing.Size(290, 22);
            this.textBoxEmpresa.TabIndex = 20;
            // 
            // textBoxCargo
            // 
            this.textBoxCargo.Location = new System.Drawing.Point(647, 55);
            this.textBoxCargo.Name = "textBoxCargo";
            this.textBoxCargo.Size = new System.Drawing.Size(135, 22);
            this.textBoxCargo.TabIndex = 19;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(66, 127);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(290, 22);
            this.textBoxEmail.TabIndex = 18;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(489, 17);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 17);
            this.lblId.TabIndex = 17;
            this.lblId.Text = "ID";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(492, 53);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(111, 22);
            this.textBoxId.TabIndex = 16;
            // 
            // dataGridViewContato
            // 
            this.dataGridViewContato.AllowUserToAddRows = false;
            this.dataGridViewContato.AllowUserToDeleteRows = false;
            this.dataGridViewContato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContato.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewContato.Location = new System.Drawing.Point(66, 266);
            this.dataGridViewContato.MultiSelect = false;
            this.dataGridViewContato.Name = "dataGridViewContato";
            this.dataGridViewContato.ReadOnly = true;
            this.dataGridViewContato.RowHeadersWidth = 51;
            this.dataGridViewContato.RowTemplate.Height = 24;
            this.dataGridViewContato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewContato.Size = new System.Drawing.Size(716, 276);
            this.dataGridViewContato.TabIndex = 12;
            this.dataGridViewContato.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContato_CellClick);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(644, 17);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(46, 17);
            this.lblCargo.TabIndex = 11;
            this.lblCargo.Text = "Cargo";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(63, 182);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(64, 17);
            this.labelTelefone.TabIndex = 9;
            this.labelTelefone.Text = "Telefone";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(489, 96);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(64, 17);
            this.lblEmpresa.TabIndex = 8;
            this.lblEmpresa.Text = "Empresa";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(63, 96);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 17);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "Email";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(63, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 17);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(66, 55);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(290, 22);
            this.textBoxNome.TabIndex = 2;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(25, 56);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(177, 51);
            this.btnNovo.TabIndex = 21;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(25, 278);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(177, 51);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(25, 206);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(177, 51);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Enabled = false;
            this.btnInserir.Location = new System.Drawing.Point(25, 137);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(177, 51);
            this.btnInserir.TabIndex = 18;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lblTarefa
            // 
            this.lblTarefa.AutoSize = true;
            this.lblTarefa.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarefa.Location = new System.Drawing.Point(542, 9);
            this.lblTarefa.Name = "lblTarefa";
            this.lblTarefa.Size = new System.Drawing.Size(149, 43);
            this.lblTarefa.TabIndex = 22;
            this.lblTarefa.Text = "Contatos";
            // 
            // FormContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1093, 642);
            this.Controls.Add(this.lblTarefa);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.panelContatos);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInserir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormContato";
            this.Text = "Tarefa";
            this.panelContatos.ResumeLayout(false);
            this.panelContatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelContatos;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.DataGridView dataGridViewContato;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.TextBox textBoxEmpresa;
        private System.Windows.Forms.TextBox textBoxCargo;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label lblTarefa;
    }
}