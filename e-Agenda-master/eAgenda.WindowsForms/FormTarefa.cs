using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.TarefaModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsForms
{
    public partial class FormTarefa : Form
    {
        private BotoesECampos botoesECampos;
        private ControladorTarefa controladorTarefa;
        public FormTarefa()
        {
            botoesECampos = new BotoesECampos();
            controladorTarefa = new ControladorTarefa();

            InitializeComponent();
            dateTimePickerDataInicial.Value = DateTime.Now;
            dataGridViewTarefa.DataSource = PopulandoGridTodasTarefas();
        }

        #region Metodos
        private void InserirTarefa()
        {
            string titulo = textBoxTitulo.Text;
            DateTime dataInicial = dateTimePickerDataInicial.Value;
            int numeroPrioridade = Convert.ToInt32(comboBoxPrioridade.Text);

            Tarefa tarefa = new Tarefa(titulo, dataInicial, (PrioridadeEnum)numeroPrioridade);

            string resultadoValidacao = tarefa.Validar();
            if (resultadoValidacao == "ESTA_VALIDO")
            {
                controladorTarefa.InserirNovo(tarefa);
            }
            else
            {
                MessageBox.Show(resultadoValidacao);
                botoesECampos.LimparCampos(panelTarefas.Controls);
            }
        }

        private void EditarTarefa()
        {
            int id = Convert.ToInt32(textBoxId.Text);
            string titulo = textBoxTitulo.Text;
            DateTime dataInicial = dateTimePickerDataInicial.Value;
            DateTime dataConclusao = dateTimePickerConclusao.Value;
            int numeroPrioridade = Convert.ToInt32(comboBoxPrioridade.Text);
            int percentual = Convert.ToInt32(textBoxPercentual.Text);

            Tarefa tarefa = new Tarefa(titulo, dataInicial, (PrioridadeEnum)numeroPrioridade);
            tarefa.AtualizarPercentual(percentual, dataConclusao);

            string resultadoValidacao = tarefa.Validar();
            if (resultadoValidacao == "ESTA_VALIDO")
            {
                controladorTarefa.Editar(id,tarefa);
            }
            else
            {
                MessageBox.Show(resultadoValidacao);
                botoesECampos.LimparCampos(panelTarefas.Controls);
            }

        }

        private void ExcluirTarefa()
        {
            int id = Convert.ToInt32(textBoxId.Text);
            controladorTarefa.Excluir(id);
        }

        private static void PopulandoLinhas(DataTable formandoColunas, List<Tarefa> tarefas)
        {
            foreach (var tarefa in tarefas)
            {
                var novaLinha = formandoColunas.NewRow();

                novaLinha["ID"] = tarefa.Id;
                novaLinha["Titulo"] = tarefa.Titulo;
                novaLinha["Prioridade"] = tarefa.Prioridade;
                novaLinha["Percentual"] = tarefa.Percentual;

                formandoColunas.Rows.Add(novaLinha);
            }
        }

        private static DataTable Colunas()
        {
            DataTable formandoColunas = new DataTable();

            formandoColunas.Columns.Add("ID");
            formandoColunas.Columns.Add("Titulo");
            formandoColunas.Columns.Add("Prioridade");
            formandoColunas.Columns.Add("Percentual");
            return formandoColunas;
        }

        private DataTable PopularGridTarefasConcluidas()
        {
            

            DataTable formandoColunas = Colunas();
            List<Tarefa> tarefas = controladorTarefa.SelecionarTodasTarefasConcluidas();
            PopulandoLinhas(formandoColunas, tarefas);

            return formandoColunas;
        }

        private DataTable PopulandoGridTarefasPendentes()
        {
            DataTable formandoColunas = Colunas();
            List<Tarefa> tarefas = controladorTarefa.SelecionarTodasTarefasPendentes();
            PopulandoLinhas(formandoColunas, tarefas);

            return formandoColunas;
        }

        private DataTable PopulandoGridTodasTarefas()
        {
            DataTable formandoColunas = Colunas();
            List<Tarefa> tarefas = controladorTarefa.SelecionarTodos();
            PopulandoLinhas(formandoColunas, tarefas);

            return formandoColunas;
        }

        #endregion

        #region Eventos

        private void btnNovo_Click(object sender, EventArgs e)
        {
            InserirTarefa();
            botoesECampos.LimparCampos(panelTarefas.Controls);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            LiberarCampos();
            EditarTarefa();
            BloquarCampos();
            botoesECampos.LimparCampos(panelTarefas.Controls);

            dataGridViewTarefa.DataSource = PopularGridTarefasConcluidas();
            dataGridViewTarefa.DataSource = PopulandoGridTodasTarefas();
            dataGridViewTarefa.DataSource = PopulandoGridTarefasPendentes();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirTarefa();

            dataGridViewTarefa.DataSource = PopularGridTarefasConcluidas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            botoesECampos.LimparCampos(panelTarefas.Controls);
            botoesECampos.BloquearBotoes(this.Controls);

            dataGridViewTarefa.DataSource = PopularGridTarefasConcluidas();
            dataGridViewTarefa.DataSource = PopulandoGridTodasTarefas();
            dataGridViewTarefa.DataSource = PopulandoGridTarefasPendentes();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewTarefa.DataSource = PopularGridTarefasConcluidas();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewTarefa.DataSource = PopulandoGridTarefasPendentes();
        }

        private void radioButtonTodas_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewTarefa.DataSource = PopulandoGridTodasTarefas();
        }

        private void dataGridViewTarefa_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textBoxId.Text = dataGridViewTarefa.CurrentRow.Cells[0].Value.ToString();
            int id = Convert.ToInt32(textBoxId.Text);

            Tarefa tarefa = controladorTarefa.SelecionarPorId(id);

            textBoxId.Text = tarefa.Id.ToString();
            textBoxTitulo.Text = tarefa.Titulo;
            textBoxPercentual.Text = tarefa.Percentual.ToString();
            comboBoxPrioridade.Text = tarefa.Prioridade.Chave.ToString();
            dateTimePickerDataInicial.Value = tarefa.DataCriacao;
            dateTimePickerConclusao.Value = tarefa.DataCriacao;

            LiberarCampos();
            botoesECampos.LiberarBotoes(this.Controls);
        }
       
        private void LiberarCampos()
        {
            textBoxPercentual.Enabled = true;
            dateTimePickerConclusao.Enabled = true;
            textBoxPercentual.Enabled = true;
        }

        private void BloquarCampos()
        {
            textBoxPercentual.Enabled = false;
            dateTimePickerConclusao.Enabled = false;
            textBoxPercentual.Enabled = false;
        }

        #endregion
    }
}

