
namespace eAgenda.WindowsForms
{
    partial class FormCompromisso
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
            this.panelCompromissos = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButtonPassados = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonNao = new System.Windows.Forms.RadioButton();
            this.radioButtonSim = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBoxHoraTermino = new System.Windows.Forms.MaskedTextBox();
            this.textBoxIdContato = new System.Windows.Forms.TextBox();
            this.textBoxLocal = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.dataGridViewCompromisso = new System.Windows.Forms.DataGridView();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.textBoxAssunto = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.lblTarefa = new System.Windows.Forms.Label();
            this.panelCompromissos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompromisso)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCompromissos
            // 
            this.panelCompromissos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCompromissos.Controls.Add(this.radioButton2);
            this.panelCompromissos.Controls.Add(this.radioButtonPassados);
            this.panelCompromissos.Controls.Add(this.radioButton1);
            this.panelCompromissos.Controls.Add(this.label5);
            this.panelCompromissos.Controls.Add(this.label4);
            this.panelCompromissos.Controls.Add(this.radioButtonNao);
            this.panelCompromissos.Controls.Add(this.radioButtonSim);
            this.panelCompromissos.Controls.Add(this.label3);
            this.panelCompromissos.Controls.Add(this.textBoxLink);
            this.panelCompromissos.Controls.Add(this.buttonBuscar);
            this.panelCompromissos.Controls.Add(this.label2);
            this.panelCompromissos.Controls.Add(this.maskedTextBoxHoraInicio);
            this.panelCompromissos.Controls.Add(this.label1);
            this.panelCompromissos.Controls.Add(this.dateTimePickerData);
            this.panelCompromissos.Controls.Add(this.maskedTextBoxHoraTermino);
            this.panelCompromissos.Controls.Add(this.textBoxIdContato);
            this.panelCompromissos.Controls.Add(this.textBoxLocal);
            this.panelCompromissos.Controls.Add(this.lblId);
            this.panelCompromissos.Controls.Add(this.textBoxId);
            this.panelCompromissos.Controls.Add(this.dataGridViewCompromisso);
            this.panelCompromissos.Controls.Add(this.labelTelefone);
            this.panelCompromissos.Controls.Add(this.lblEmpresa);
            this.panelCompromissos.Controls.Add(this.labelEmail);
            this.panelCompromissos.Controls.Add(this.lblNome);
            this.panelCompromissos.Controls.Add(this.textBoxAssunto);
            this.panelCompromissos.Location = new System.Drawing.Point(223, 56);
            this.panelCompromissos.Name = "panelCompromissos";
            this.panelCompromissos.Size = new System.Drawing.Size(836, 571);
            this.panelCompromissos.TabIndex = 6;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(660, 174);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 21);
            this.radioButton2.TabIndex = 35;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Todos";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // radioButtonPassados
            // 
            this.radioButtonPassados.AutoSize = true;
            this.radioButtonPassados.Location = new System.Drawing.Point(660, 228);
            this.radioButtonPassados.Name = "radioButtonPassados";
            this.radioButtonPassados.Size = new System.Drawing.Size(91, 21);
            this.radioButtonPassados.TabIndex = 34;
            this.radioButtonPassados.TabStop = true;
            this.radioButtonPassados.Text = "Passados";
            this.radioButtonPassados.UseVisualStyleBackColor = true;
            this.radioButtonPassados.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(660, 201);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 21);
            this.radioButton1.TabIndex = 33;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Futuros";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(657, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Tipo de Listagem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Encontro Presencial ?";
            // 
            // radioButtonNao
            // 
            this.radioButtonNao.AutoSize = true;
            this.radioButtonNao.Location = new System.Drawing.Point(491, 221);
            this.radioButtonNao.Name = "radioButtonNao";
            this.radioButtonNao.Size = new System.Drawing.Size(55, 21);
            this.radioButtonNao.TabIndex = 30;
            this.radioButtonNao.Text = "Não";
            this.radioButtonNao.UseVisualStyleBackColor = true;
            this.radioButtonNao.CheckedChanged += new System.EventHandler(this.radioButtonNao_CheckedChanged);
            // 
            // radioButtonSim
            // 
            this.radioButtonSim.AutoSize = true;
            this.radioButtonSim.Checked = true;
            this.radioButtonSim.Location = new System.Drawing.Point(491, 183);
            this.radioButtonSim.Name = "radioButtonSim";
            this.radioButtonSim.Size = new System.Drawing.Size(52, 21);
            this.radioButtonSim.TabIndex = 29;
            this.radioButtonSim.TabStop = true;
            this.radioButtonSim.Text = "Sim";
            this.radioButtonSim.UseVisualStyleBackColor = true;
            this.radioButtonSim.CheckedChanged += new System.EventHandler(this.radioButtonSim_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Link";
            // 
            // textBoxLink
            // 
            this.textBoxLink.Enabled = false;
            this.textBoxLink.Location = new System.Drawing.Point(66, 100);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(290, 22);
            this.textBoxLink.TabIndex = 27;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(757, 54);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(74, 23);
            this.buttonBuscar.TabIndex = 26;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Contato";
            // 
            // maskedTextBoxHoraInicio
            // 
            this.maskedTextBoxHoraInicio.Location = new System.Drawing.Point(66, 221);
            this.maskedTextBoxHoraInicio.Mask = "00:00";
            this.maskedTextBoxHoraInicio.Name = "maskedTextBoxHoraInicio";
            this.maskedTextBoxHoraInicio.Size = new System.Drawing.Size(72, 22);
            this.maskedTextBoxHoraInicio.TabIndex = 24;
            this.maskedTextBoxHoraInicio.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Hora Termino";
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Location = new System.Drawing.Point(491, 125);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(340, 22);
            this.dateTimePickerData.TabIndex = 22;
            // 
            // maskedTextBoxHoraTermino
            // 
            this.maskedTextBoxHoraTermino.Location = new System.Drawing.Point(201, 221);
            this.maskedTextBoxHoraTermino.Mask = "00:00";
            this.maskedTextBoxHoraTermino.Name = "maskedTextBoxHoraTermino";
            this.maskedTextBoxHoraTermino.Size = new System.Drawing.Size(72, 22);
            this.maskedTextBoxHoraTermino.TabIndex = 21;
            this.maskedTextBoxHoraTermino.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxIdContato
            // 
            this.textBoxIdContato.Enabled = false;
            this.textBoxIdContato.Location = new System.Drawing.Point(640, 55);
            this.textBoxIdContato.Name = "textBoxIdContato";
            this.textBoxIdContato.Size = new System.Drawing.Size(111, 22);
            this.textBoxIdContato.TabIndex = 19;
            // 
            // textBoxLocal
            // 
            this.textBoxLocal.Location = new System.Drawing.Point(66, 149);
            this.textBoxLocal.Name = "textBoxLocal";
            this.textBoxLocal.Size = new System.Drawing.Size(290, 22);
            this.textBoxLocal.TabIndex = 18;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(489, 17);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(110, 17);
            this.lblId.TabIndex = 17;
            this.lblId.Text = "ID Compromisso";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(492, 55);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(111, 22);
            this.textBoxId.TabIndex = 16;
            // 
            // dataGridViewCompromisso
            // 
            this.dataGridViewCompromisso.AllowUserToAddRows = false;
            this.dataGridViewCompromisso.AllowUserToDeleteRows = false;
            this.dataGridViewCompromisso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCompromisso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompromisso.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewCompromisso.Location = new System.Drawing.Point(66, 266);
            this.dataGridViewCompromisso.MultiSelect = false;
            this.dataGridViewCompromisso.Name = "dataGridViewCompromisso";
            this.dataGridViewCompromisso.ReadOnly = true;
            this.dataGridViewCompromisso.RowHeadersWidth = 51;
            this.dataGridViewCompromisso.RowTemplate.Height = 24;
            this.dataGridViewCompromisso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCompromisso.Size = new System.Drawing.Size(716, 276);
            this.dataGridViewCompromisso.TabIndex = 12;
            this.dataGridViewCompromisso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCompromisso_CellClick);
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(63, 183);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(75, 17);
            this.labelTelefone.TabIndex = 9;
            this.labelTelefone.Text = "Hora Início";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(489, 96);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(38, 17);
            this.lblEmpresa.TabIndex = 8;
            this.lblEmpresa.Text = "Data";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(63, 125);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 17);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "Local";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(63, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(59, 17);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Assunto";
            // 
            // textBoxAssunto
            // 
            this.textBoxAssunto.Location = new System.Drawing.Point(66, 55);
            this.textBoxAssunto.Name = "textBoxAssunto";
            this.textBoxAssunto.Size = new System.Drawing.Size(290, 22);
            this.textBoxAssunto.TabIndex = 2;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(25, 56);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(177, 51);
            this.btnNovo.TabIndex = 25;
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
            this.btnExcluir.TabIndex = 24;
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
            this.btnEditar.TabIndex = 23;
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
            this.btnInserir.TabIndex = 22;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lblTarefa
            // 
            this.lblTarefa.AutoSize = true;
            this.lblTarefa.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarefa.Location = new System.Drawing.Point(513, 9);
            this.lblTarefa.Name = "lblTarefa";
            this.lblTarefa.Size = new System.Drawing.Size(238, 43);
            this.lblTarefa.TabIndex = 23;
            this.lblTarefa.Text = "Compromissos";
            // 
            // FormCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1093, 642);
            this.Controls.Add(this.lblTarefa);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.panelCompromissos);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInserir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCompromisso";
            this.Text = "Compromisso";
            this.panelCompromissos.ResumeLayout(false);
            this.panelCompromissos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompromisso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCompromissos;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHoraTermino;
        private System.Windows.Forms.TextBox textBoxLocal;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.DataGridView dataGridViewCompromisso;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox textBoxAssunto;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label lblTarefa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHoraInicio;
        private System.Windows.Forms.Button buttonBuscar;
        public System.Windows.Forms.TextBox textBoxIdContato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonNao;
        private System.Windows.Forms.RadioButton radioButtonSim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.RadioButton radioButtonPassados;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}