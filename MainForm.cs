using Parcial1_Ap1.UI.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_Ap1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Formulario = new RegistroEvaluacion();
            Formulario.MdiParent = this;
            Formulario.Show();
        }
    }
}
