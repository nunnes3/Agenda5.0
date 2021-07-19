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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnContatos_Click(object sender, EventArgs e)
        {

            FormContato formContato = new FormContato();
            AbrirForm(formContato);
        }

        private void btnTarefas_Click(object sender, EventArgs e)
        {
            FormTarefa formTarefa = new FormTarefa();
            AbrirForm(formTarefa);
        }

        private void btnCompromissos_Click(object sender, EventArgs e)
        {
            FormCompromisso formCompromisso = new FormCompromisso();
            AbrirForm(formCompromisso);
        }

        private void AbrirForm(Form tela)
        {
            tela.TopLevel = false;
            this.panelTelas.Controls.Add(tela);
            tela.Show();
            tela.BringToFront();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        
    }
}
