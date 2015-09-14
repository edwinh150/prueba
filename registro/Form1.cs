using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registro
{
    public partial class formRegistro : Form
    {
        public formRegistro()
        {
            InitializeComponent();
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea Gurdar esta Pelicula","Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            this.Close();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }

                if (ctrl is ComboBox)
                {
                    ctrl.Text = "";
                }

                if (ctrl is RichTextBox)
                {
                    ctrl.Text = "";
                }
            }
        }
    }
}
