using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsForms
{
    public class BotoesECampos
    {
        public void LimparCampos(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {

                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }

                if (ctrl is ComboBox)
                {
                    ((ComboBox)(ctrl)).Text = String.Empty;
                }

                if(ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)(ctrl)).Text = String.Empty;
                }
            }
        }

        public void LiberarBotoes(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is Button && ctrl.Name == "btnInserir")
                {
                    ((Button)(ctrl)).Enabled = false;
                }
                else if (ctrl is Button)
                {
                    ((Button)(ctrl)).Enabled = true;
                }
            }
        }

        public void BloquearBotoes(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is Button && ctrl.Name == "btnInserir")
                {
                    ((Button)(ctrl)).Enabled = true;
                }
                else if (ctrl is Button)
                {
                    ((Button)(ctrl)).Enabled = false;
                }
            }
        }
    }
}
