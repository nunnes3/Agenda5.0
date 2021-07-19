using eAgenda.Controladores.CompromissoModule;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
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


    public partial class FormCompromisso : Form
    {
        private Contato contato;
        private BotoesECampos botoesECampos;
        private ControladorCompromisso controladorCompromisso;
        public FormCompromisso()
        {
            botoesECampos = new BotoesECampos();
            controladorCompromisso = new ControladorCompromisso();
            InitializeComponent();

            dataGridViewCompromisso.DataSource = PopulandoGridTodosCompromissos();
        }
        #region Metodos

        public void InserirCompromisso()
        {
            string assunto = textBoxAssunto.Text;
            string local = textBoxLocal.Text;
            string link = textBoxLink.Text;
            DateTime data = dateTimePickerData.Value;
            TimeSpan horaInicio = Convert.ToDateTime(maskedTextBoxHoraInicio.Text).TimeOfDay;
            TimeSpan horaTermino = Convert.ToDateTime(maskedTextBoxHoraTermino.Text).TimeOfDay;
            Compromisso compromisso = null;

            compromisso = new Compromisso(assunto, local, link, data, horaInicio, horaTermino, contato);
            string resultadoValidacao = compromisso.Validar();
            bool verificaHorario = controladorCompromisso.VerificarHorarioOcupado(data, horaInicio, horaTermino);

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                if (verificaHorario == false)
                {
                    controladorCompromisso.InserirNovo(compromisso);
                }

                resultadoValidacao = "";
                resultadoValidacao += "Nesta data e horário já tem um compromisso agendado";
                MessageBox.Show(resultadoValidacao);
                botoesECampos.LimparCampos(this.Controls);
            }
            else
            {

                MessageBox.Show(resultadoValidacao);
                botoesECampos.LimparCampos(this.Controls);
            }

        }

        public void EditarCompromisso()
        {
            int id = Convert.ToInt32(textBoxId.Text);
            string assunto = textBoxAssunto.Text;
            string local = textBoxLocal.Text;
            string link = textBoxLink.Text;
            DateTime data = dateTimePickerData.Value;
            TimeSpan horaInicio = Convert.ToDateTime(maskedTextBoxHoraInicio.Text).TimeOfDay;
            TimeSpan horaTermino = Convert.ToDateTime(maskedTextBoxHoraTermino.Text).TimeOfDay;
            Compromisso compromisso = null;
            bool verificaHorario = controladorCompromisso.VerificarHorarioOcupado(data, horaInicio, horaTermino);
            compromisso = new Compromisso(assunto, local, link, data, horaInicio, horaTermino, contato);
            string resultadoValidacao = compromisso.Validar();
            

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                if(verificaHorario == false)
                {
                    controladorCompromisso.Editar(id, compromisso);
                }
             
                    resultadoValidacao = "";
                    resultadoValidacao += "Nesta data e horário já tem um compromisso agendado";
                    MessageBox.Show(resultadoValidacao);
                    botoesECampos.LimparCampos(this.Controls);
            }
            else{

                MessageBox.Show(resultadoValidacao);
                botoesECampos.LimparCampos(this.Controls);
            }
        }

        public void ExcluirCompromisso()
        {
            int id = Convert.ToInt32(textBoxId.Text);
            controladorCompromisso.Excluir(id);
        }
        private DataTable PopulandoGridTodosCompromissos()
        {
            DataTable formandoColunas = Colunas();
            List<Compromisso> compromissos = controladorCompromisso.SelecionarTodos();
            PopulandoLinhas(formandoColunas, compromissos);

            return formandoColunas;
        }

        private DataTable PopulandoGridCompromissosPassados()
        {
            DataTable formandoColunas = Colunas();
            List<Compromisso> compromissos = controladorCompromisso.SelecionarCompromissosPassados(DateTime.Now);
            PopulandoLinhas(formandoColunas, compromissos);

            return formandoColunas;
        }

        private DataTable PopulandoGridCompromissosFuturos()
        {
            DataTable formandoColunas = Colunas();
            List<Compromisso> compromissos = controladorCompromisso.SelecionarCompromissosFuturos(DateTime.Now, dateTimePickerData.Value);
            PopulandoLinhas(formandoColunas, compromissos);

            return formandoColunas;
        }

        private void PopulandoLinhas(DataTable formandoColunas, List<Compromisso> compromissos)
        {

            foreach (var compromisso in compromissos)
            {
                var novaLinha = formandoColunas.NewRow();

                novaLinha["ID"] = compromisso.Id;
                novaLinha["Assunto"] = compromisso.Assunto;
                novaLinha["Data"] = compromisso.Data.ToShortDateString();
                if (compromisso.Contato != null)
                {
                    novaLinha["Contato"] = compromisso.Contato.Nome;
                }
                formandoColunas.Rows.Add(novaLinha);
            }
        }

        private static DataTable Colunas()
        {
            DataTable formandoColunas = new DataTable();

            formandoColunas.Columns.Add("ID");
            formandoColunas.Columns.Add("Assunto");
            formandoColunas.Columns.Add("Data");
            formandoColunas.Columns.Add("Contato");
            return formandoColunas;
        }

        #endregion

        #region Eventos

        private void button1_Click(object sender, EventArgs e)
        {
            FormSelecionarContato formSelecionarContato = new FormSelecionarContato();
            formSelecionarContato.ShowDialog();
            contato = formSelecionarContato.Contato;

            if (contato != null)
            {
                textBoxIdContato.Text = contato.Nome;
            }


        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            botoesECampos.LimparCampos(panelCompromissos.Controls);
            botoesECampos.BloquearBotoes(this.Controls);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            InserirCompromisso();
            botoesECampos.LimparCampos(panelCompromissos.Controls);

            dataGridViewCompromisso.DataSource = PopulandoGridTodosCompromissos();
            dataGridViewCompromisso.DataSource = PopulandoGridCompromissosPassados();
            dataGridViewCompromisso.DataSource = PopulandoGridCompromissosFuturos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarCompromisso();
            botoesECampos.LimparCampos(panelCompromissos.Controls);

            dataGridViewCompromisso.DataSource = PopulandoGridTodosCompromissos();
            dataGridViewCompromisso.DataSource = PopulandoGridCompromissosPassados();
            dataGridViewCompromisso.DataSource = PopulandoGridCompromissosFuturos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirCompromisso();
            botoesECampos.LimparCampos(panelCompromissos.Controls);

            dataGridViewCompromisso.DataSource = PopulandoGridTodosCompromissos();
            dataGridViewCompromisso.DataSource = PopulandoGridCompromissosPassados();
            dataGridViewCompromisso.DataSource = PopulandoGridCompromissosFuturos();
        }

        private void radioButtonSim_CheckedChanged(object sender, EventArgs e)
        {
            textBoxLocal.Enabled = true;
            textBoxLink.Enabled = false;
        }

        private void radioButtonNao_CheckedChanged(object sender, EventArgs e)
        {
            textBoxLocal.Enabled = false;
            textBoxLink.Enabled = true;
        }

        private void dataGridViewCompromisso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridViewCompromisso.CurrentRow.Cells[0].Value.ToString();
            int id = Convert.ToInt32(textBoxId.Text);

            Compromisso compromisso = controladorCompromisso.SelecionarPorId(id);

            textBoxId.Text = compromisso.Id.ToString();
            if (compromisso.Contato != null)
            {
                textBoxIdContato.Text = compromisso.Contato.Nome;
            }
            else
            {
                textBoxIdContato.Text = String.Empty;
            }
            textBoxAssunto.Text = compromisso.Assunto;
            textBoxLink.Text = compromisso.Link;
            textBoxLocal.Text = compromisso.Local;
            dateTimePickerData.Value = compromisso.Data;
            maskedTextBoxHoraInicio.Text = compromisso.HoraInicio.ToString();
            maskedTextBoxHoraTermino.Text = compromisso.HoraTermino.ToString();
            contato = compromisso.Contato;

            botoesECampos.LiberarBotoes(this.Controls);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewCompromisso.DataSource = PopulandoGridCompromissosFuturos();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewCompromisso.DataSource = PopulandoGridCompromissosPassados();
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            dataGridViewCompromisso.DataSource = PopulandoGridTodosCompromissos();
        }

        #endregion
    }
}
