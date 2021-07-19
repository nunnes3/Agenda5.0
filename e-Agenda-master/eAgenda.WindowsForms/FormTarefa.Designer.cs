
namespace eAgenda.WindowsForms
{
    partial class FormTarefa
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
            this.lblTarefa = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxPercentual = new System.Windows.Forms.TextBox();
            this.panelTarefas = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonPendentes = new System.Windows.Forms.RadioButton();
            this.radioButtonConcluidas = new System.Windows.Forms.RadioButton();
            this.dataGridViewTarefa = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPrioridade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dateTimePickerConclusao = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataInicial = new System.Windows.Forms.DateTimePicker();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.radioButtonTodas = new System.Windows.Forms.RadioButton();
            this.panelTarefas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarefa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTarefa
            // 
            this.lblTarefa.AutoSize = true;
            this.lblTarefa.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarefa.Location = new System.Drawing.Point(542, 9);
            this.lblTarefa.Name = "lblTarefa";
            this.lblTarefa.Size = new System.Drawing.Size(129, 43);
            this.lblTarefa.TabIndex = 0;
            this.lblTarefa.Text = "Tarefas";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(66, 55);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(290, 22);
            this.textBoxTitulo.TabIndex = 2;
            // 
            // textBoxPercentual
            // 
            this.textBoxPercentual.Enabled = false;
            this.textBoxPercentual.Location = new System.Drawing.Point(66, 220);
            this.textBoxPercentual.Name = "textBoxPercentual";
            this.textBoxPercentual.Size = new System.Drawing.Size(135, 22);
            this.textBoxPercentual.TabIndex = 3;
            // 
            // panelTarefas
            // 
            this.panelTarefas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTarefas.Controls.Add(this.radioButtonTodas);
            this.panelTarefas.Controls.Add(this.label6);
            this.panelTarefas.Controls.Add(this.textBoxId);
            this.panelTarefas.Controls.Add(this.label5);
            this.panelTarefas.Controls.Add(this.radioButtonPendentes);
            this.panelTarefas.Controls.Add(this.radioButtonConcluidas);
            this.panelTarefas.Controls.Add(this.dataGridViewTarefa);
            this.panelTarefas.Controls.Add(this.label4);
            this.panelTarefas.Controls.Add(this.comboBoxPrioridade);
            this.panelTarefas.Controls.Add(this.label3);
            this.panelTarefas.Controls.Add(this.label2);
            this.panelTarefas.Controls.Add(this.label1);
            this.panelTarefas.Controls.Add(this.lblTitulo);
            this.panelTarefas.Controls.Add(this.dateTimePickerConclusao);
            this.panelTarefas.Controls.Add(this.dateTimePickerDataInicial);
            this.panelTarefas.Controls.Add(this.textBoxTitulo);
            this.panelTarefas.Controls.Add(this.textBoxPercentual);
            this.panelTarefas.Location = new System.Drawing.Point(225, 56);
            this.panelTarefas.Name = "panelTarefas";
            this.panelTarefas.Size = new System.Drawing.Size(836, 571);
            this.panelTarefas.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "ID";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(486, 53);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(111, 22);
            this.textBoxId.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tipo Listagem";
            // 
            // radioButtonPendentes
            // 
            this.radioButtonPendentes.AutoSize = true;
            this.radioButtonPendentes.Location = new System.Drawing.Point(647, 209);
            this.radioButtonPendentes.Name = "radioButtonPendentes";
            this.radioButtonPendentes.Size = new System.Drawing.Size(97, 21);
            this.radioButtonPendentes.TabIndex = 14;
            this.radioButtonPendentes.TabStop = true;
            this.radioButtonPendentes.Text = "Pendentes";
            this.radioButtonPendentes.UseVisualStyleBackColor = true;
            this.radioButtonPendentes.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonConcluidas
            // 
            this.radioButtonConcluidas.AutoSize = true;
            this.radioButtonConcluidas.Location = new System.Drawing.Point(492, 239);
            this.radioButtonConcluidas.Name = "radioButtonConcluidas";
            this.radioButtonConcluidas.Size = new System.Drawing.Size(98, 21);
            this.radioButtonConcluidas.TabIndex = 13;
            this.radioButtonConcluidas.TabStop = true;
            this.radioButtonConcluidas.Text = "Concluidas";
            this.radioButtonConcluidas.UseVisualStyleBackColor = true;
            this.radioButtonConcluidas.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dataGridViewTarefa
            // 
            this.dataGridViewTarefa.AllowUserToAddRows = false;
            this.dataGridViewTarefa.AllowUserToDeleteRows = false;
            this.dataGridViewTarefa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTarefa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTarefa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewTarefa.Location = new System.Drawing.Point(66, 266);
            this.dataGridViewTarefa.MultiSelect = false;
            this.dataGridViewTarefa.Name = "dataGridViewTarefa";
            this.dataGridViewTarefa.ReadOnly = true;
            this.dataGridViewTarefa.RowHeadersWidth = 51;
            this.dataGridViewTarefa.RowTemplate.Height = 24;
            this.dataGridViewTarefa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTarefa.Size = new System.Drawing.Size(716, 276);
            this.dataGridViewTarefa.TabIndex = 12;
            this.dataGridViewTarefa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTarefa_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(644, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Prioridade Nível";
            // 
            // comboBoxPrioridade
            // 
            this.comboBoxPrioridade.FormattingEnabled = true;
            this.comboBoxPrioridade.Items.AddRange(new object[] {
            "0",
            "1 ",
            "2 "});
            this.comboBoxPrioridade.Location = new System.Drawing.Point(647, 53);
            this.comboBoxPrioridade.Name = "comboBoxPrioridade";
            this.comboBoxPrioridade.Size = new System.Drawing.Size(135, 24);
            this.comboBoxPrioridade.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Percentual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Data Conclusão";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data Inical";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(63, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(43, 17);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Titulo";
            // 
            // dateTimePickerConclusao
            // 
            this.dateTimePickerConclusao.Enabled = false;
            this.dateTimePickerConclusao.Location = new System.Drawing.Point(492, 134);
            this.dateTimePickerConclusao.Name = "dateTimePickerConclusao";
            this.dateTimePickerConclusao.Size = new System.Drawing.Size(290, 22);
            this.dateTimePickerConclusao.TabIndex = 5;
            // 
            // dateTimePickerDataInicial
            // 
            this.dateTimePickerDataInicial.Enabled = false;
            this.dateTimePickerDataInicial.Location = new System.Drawing.Point(66, 134);
            this.dateTimePickerDataInicial.Name = "dateTimePickerDataInicial";
            this.dateTimePickerDataInicial.Size = new System.Drawing.Size(290, 22);
            this.dateTimePickerDataInicial.TabIndex = 4;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(25, 278);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(177, 51);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Enabled = false;
            this.btnInserir.Location = new System.Drawing.Point(25, 137);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(177, 51);
            this.btnInserir.TabIndex = 5;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(25, 206);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(177, 51);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(25, 56);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(177, 51);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonTodas
            // 
            this.radioButtonTodas.AutoSize = true;
            this.radioButtonTodas.Location = new System.Drawing.Point(493, 209);
            this.radioButtonTodas.Name = "radioButtonTodas";
            this.radioButtonTodas.Size = new System.Drawing.Size(69, 21);
            this.radioButtonTodas.TabIndex = 18;
            this.radioButtonTodas.TabStop = true;
            this.radioButtonTodas.Text = "Todas";
            this.radioButtonTodas.UseVisualStyleBackColor = true;
            this.radioButtonTodas.CheckedChanged += new System.EventHandler(this.radioButtonTodas_CheckedChanged);
            // 
            // FormTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1093, 642);
            this.Controls.Add(this.lblTarefa);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.panelTarefas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTarefa";
            this.Text = "Tarefa";
            this.panelTarefas.ResumeLayout(false);
            this.panelTarefas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarefa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTarefa;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxPercentual;
        private System.Windows.Forms.Panel panelTarefas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPrioridade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DateTimePicker dateTimePickerConclusao;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataInicial;
        private System.Windows.Forms.DataGridView dataGridViewTarefa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonPendentes;
        private System.Windows.Forms.RadioButton radioButtonConcluidas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.RadioButton radioButtonTodas;
    }
}