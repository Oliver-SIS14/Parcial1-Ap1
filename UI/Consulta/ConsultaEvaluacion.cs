using Parcial1_Ap1.BLL;
using Parcial1_Ap1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_Ap1.UI.Consulta
{
    public partial class ConsultaEvaluacion : Form
    {
        public ConsultaEvaluacion()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Evaluacion>();

            if(CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: //Todo
                        listado = EvaluacionBLL.GetList(p => true);
                        break;
                    case 1://ID
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        listado = EvaluacionBLL.GetList(p => p.Evaluacionid == id);
                        break;
                    case 2://Estudiante
                        listado = EvaluacionBLL.GetList(p => p.Estudiante.Contains(CriterioTextBox.Text));
                        break;
                }

                listado = listado.Where(c => c.Fecha.Date >= DesdeDateTimePicker.Value.Date && c.Fecha.Date <= HastaDateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = EvaluacionBLL.GetList(p => true);
            }

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }
    }
}
