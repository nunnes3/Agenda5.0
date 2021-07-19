using eAgenda.Controladores.ContatoModule;
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
    public partial class FormContato : Form
    {
        private ControladorContato controladorContato;
        private BotoesECampos botoesECampos;

        

        public FormContato()
        {
            controladorContato = new ControladorContato();
            botoesECampos = new BotoesECampos();

            InitializeComponent();

            dataGridViewContato.DataSource = PopulandoGridContato();
        }

        #region Metodos
        public void InserirContato()
        {
            
            string nome = textBoxNome.Text;
            string email = textBoxEmail.Text;
            string telefone = maskedTextBoxTelefone.Text;
            string empresa = textBoxEmpresa.Text;
            string cargo = textBoxCargo.Text;

            Contato contato = new Contato(nome,email,telefone,empresa,cargo);

            string resultadoValidacao = contato.Validar();
            if(resultadoValidacao == "ESTA_VALIDO")
            {
                controladorContato.InserirNovo(contato);
            }
            else
            {
                MessageBox.Show(resultadoValidacao);
                botoesECampos.LimparCampos(panelContatos.Controls);
            }
        }

        public void EditarContato()
        {
            int id = Convert.ToInt32(textBoxId.Text);
            string nome = textBoxNome.Text;
            string email = textBoxEmail.Text;
            string telefone = maskedTextBoxTelefone.Text;
            string cargo = textBoxCargo.Text;
            string empresa = textBoxEmpresa.Text;

            Contato contato = new Contato(nome, email, telefone, empresa, cargo);

            string resultadoValidacao = contato.Validar();
            if (resultadoValidacao == "ESTA_VALIDO")
            {
                controladorContato.Editar(id,contato);
            }
            else
            {
                MessageBox.Show(resultadoValidacao);
                botoesECampos.LimparCampos(panelContatos.Controls);
            }
        }

        public void ExcluirContato()
        {
            int id = Convert.ToInt32(textBoxId.Text);
            controladorContato.Excluir(id);
        }

        private DataTable PopulandoGridContato()
        {
            DataTable formandoColunas = Colunas();
            List<Contato> contatos = controladorContato.SelecionarTodos();
            PopulandoLinhas(formandoColunas, contatos);

            return formandoColunas;
        }

        private void PopulandoLinhas(DataTable formandoColunas, List<Contato> contatos)
        {
            foreach (var contato in contatos)
            {
                var novaLinha = formandoColunas.NewRow();

                novaLinha["ID"] = contato.Id;
                novaLinha["Nome"] = contato.Nome;
                novaLinha["Email"] = contato.Email;
                novaLinha["Telefone"] = contato.Telefone;

                formandoColunas.Rows.Add(novaLinha);
            }
        }

        private static DataTable Colunas()
        {
            DataTable formandoColunas = new DataTable();

            formandoColunas.Columns.Add("ID");
            formandoColunas.Columns.Add("Nome");
            formandoColunas.Columns.Add("Email");
            formandoColunas.Columns.Add("Telefone");
            return formandoColunas;
        }

        #endregion

        #region Eventos

        private void btnNovo_Click(object sender, EventArgs e)
        {
            botoesECampos.LimparCampos(panelContatos.Controls);
            botoesECampos.BloquearBotoes(this.Controls);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            InserirContato();
            botoesECampos.LimparCampos(panelContatos.Controls);

            dataGridViewContato.DataSource = PopulandoGridContato();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarContato();
            botoesECampos.LimparCampos(panelContatos.Controls);

            dataGridViewContato.DataSource = PopulandoGridContato();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirContato();
            botoesECampos.LimparCampos(panelContatos.Controls);

            dataGridViewContato.DataSource = PopulandoGridContato();
        }

        private void dataGridViewContato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridViewContato.CurrentRow.Cells[0].Value.ToString();
            int id = Convert.ToInt32(textBoxId.Text);

            Contato contato = controladorContato.SelecionarPorId(id);

            textBoxId.Text = contato.Id.ToString();
            textBoxNome.Text = contato.Nome;
            textBoxEmail.Text = contato.Email;
            maskedTextBoxTelefone.Text = contato.Telefone;
            textBoxCargo.Text = contato.Cargo;
            textBoxEmpresa.Text = contato.Empresa;

            botoesECampos.LiberarBotoes(this.Controls);
        }

        #endregion
    }
}
