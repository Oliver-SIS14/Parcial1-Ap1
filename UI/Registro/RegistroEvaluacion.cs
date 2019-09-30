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

namespace Parcial1_Ap1.UI.Registro
{
    public partial class RegistroEvaluacion : Form
    {
        public RegistroEvaluacion()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            IDNumericUpDown.Value = 0;
            EstudianteTextBox.Text = string.Empty;
            ValorTextBox.Text = string.Empty;
            LogradoTextBox.Text = string.Empty;
            PerdidoTextBox.Text = string.Empty;
            PronosticoComboBox.Text = string.Empty;
            FechaDateTimePicker.Value = DateTime.Now;
        }
        
        public void LlenarCampo(Evaluacion evaluacion)
        {
            IDNumericUpDown.Value = evaluacion.Evaluacionid;
            EstudianteTextBox.Text = evaluacion.Estudiante;
            FechaDateTimePicker.Value = evaluacion.Fecha.Date;
            ValorTextBox.Text = Convert.ToString(evaluacion.Valor);
            PerdidoTextBox.Text = Convert.ToString(EvaluacionBLL.CalcularPerdido(evaluacion.Valor, evaluacion.Logrado));

            if (EvaluacionBLL.CalcularPerdido(evaluacion.Valor, evaluacion.Logrado) > (evaluacion.Valor * (decimal)0.30)) 
            {
                PronosticoComboBox.SelectedIndex = 2;
            }
            else
            if (EvaluacionBLL.CalcularPerdido(evaluacion.Valor, evaluacion.Logrado) <= (evaluacion.Valor * (decimal)0.30) && EvaluacionBLL.CalcularPerdido(evaluacion.Valor, evaluacion.Logrado) >= (evaluacion.Valor * (decimal)0.25))
            {
                PronosticoComboBox.SelectedIndex = 1;
            }
            else
            if (EvaluacionBLL.CalcularPerdido(evaluacion.Valor, evaluacion.Logrado) < (evaluacion.Valor * (decimal)0.25))
            {
                PronosticoComboBox.SelectedIndex = 0;
            }

            LogradoTextBox.Text = Convert.ToString(evaluacion.Logrado);
            PronosticoComboBox.Text = Convert.ToString(PronosticoComboBox.SelectedItem); 
        }

        public Evaluacion LlenarClase()
        {
            Evaluacion evaluacion = new Evaluacion();

            evaluacion.Evaluacionid = Convert.ToInt32(IDNumericUpDown.Value);
            evaluacion.Estudiante = EstudianteTextBox.Text;
            evaluacion.Fecha = FechaDateTimePicker.Value;
            evaluacion.Valor = Convert.ToDecimal(ValorTextBox.Text);
            evaluacion.Logrado = Convert.ToDecimal(LogradoTextBox.Text);
            evaluacion.Perdidos = EvaluacionBLL.CalcularPerdido(evaluacion.Valor, evaluacion.Logrado);

            if (EvaluacionBLL.CalcularPerdido(evaluacion.Valor, evaluacion.Logrado) > (evaluacion.Valor * (decimal)0.30))
            {
                PronosticoComboBox.SelectedIndex = 2;
            }
            else
            if (EvaluacionBLL.CalcularPerdido(evaluacion.Valor, evaluacion.Logrado) <= (evaluacion.Valor * (decimal)0.30) && EvaluacionBLL.CalcularPerdido(evaluacion.Valor, evaluacion.Logrado) >= (evaluacion.Valor * (decimal)0.25))
            {
                PronosticoComboBox.SelectedIndex = 1;
            }
            else
            if (EvaluacionBLL.CalcularPerdido(evaluacion.Valor, evaluacion.Logrado) > (evaluacion.Valor * (decimal)0.25))
            {
                PronosticoComboBox.SelectedIndex = 0;
            }


            evaluacion.Pronostico = Convert.ToInt32(PronosticoComboBox.SelectedIndex);

            return evaluacion;
        }

        public bool ExisteEnLaBaseDeDatos()
        {
            Evaluacion evaluacion = EvaluacionBLL.Buscar((int)IDNumericUpDown.Value);
            return evaluacion != null;
        }

        public bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(EstudianteTextBox.Text))
            {
                MyErrorProvider.SetError(EstudianteTextBox, "Introduccion no valida en el campo Estudiante");
                EstudianteTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(LogradoTextBox.Text) || Convert.ToDecimal(LogradoTextBox.Text) < 0)
            {
                MyErrorProvider.SetError(LogradoTextBox, "Introduccion no valida en el campo logrado");
                LogradoTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ValorTextBox.Text) || Convert.ToDecimal(ValorTextBox.Text) < 0)
            {
                MyErrorProvider.SetError(ValorTextBox, "Introduccion no valida en el campo valor");
                ValorTextBox.Focus();
                paso = false;
            }
            if (Convert.ToDecimal(LogradoTextBox.Text) < 0)
            {
                MyErrorProvider.SetError(LogradoTextBox, "El valor introducido en el campo logrado es incorrecto");
                LogradoTextBox.Focus();
                paso = false;
            }
            
            if (Convert.ToDecimal(ValorTextBox.Text) < 0)
            {
                MyErrorProvider.SetError(ValorTextBox, "El valor introducido en el campo valor es incorrecto");
                ValorTextBox.Focus();
                paso = false;
            }

            if (Convert.ToDecimal(LogradoTextBox.Text) > Convert.ToDecimal(ValorTextBox.Text))
            {
                MyErrorProvider.SetError(LogradoTextBox, "El valor introducido en el campo logrado es incorrecto");
                LogradoTextBox.Focus();
                paso = false;
            }
            return paso;
        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Evaluacion evaluacion = new Evaluacion();

            if (!Validar())
                return;

            evaluacion = LlenarClase();

            if (IDNumericUpDown.Value == 0)
                paso = EvaluacionBLL.Guardar(evaluacion);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar, no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = EvaluacionBLL.Modificar(evaluacion);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No fue posible guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IDNumericUpDown.Text, out id);

            Evaluacion evaluacion = new Evaluacion();
            evaluacion = EvaluacionBLL.Buscar(id);
            
                Limpiar();
            if(evaluacion == null)
            {
                MessageBox.Show("No encontrado");
            }
            else
            {
                LlenarCampo(evaluacion);

            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();

            int id;
            int.TryParse(IDNumericUpDown.Text, out id);

            Limpiar();

            if (EvaluacionBLL.Buscar(id)!=null) 
            {

               if (EvaluacionBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
               else
                {
                MyErrorProvider.SetError(IDNumericUpDown, "No se pudo eliminar");
                IDNumericUpDown.Focus();
                }

            }
            else
            {
                MessageBox.Show("Evaluacion no encontrada","Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MyErrorProvider.SetError(IDNumericUpDown, "No se pudo eliminar");
                IDNumericUpDown.Focus();
            }

        }

        private void ValorTextBox_TextChanged(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(ValorTextBox.Text))
            {
                ValorTextBox.Text = Convert.ToString(0);
            }
            if (string.IsNullOrWhiteSpace(LogradoTextBox.Text))
            {
                LogradoTextBox.Text = Convert.ToString(0);
            }

            if (Convert.ToDecimal(ValorTextBox.Text) < 0)
            {
                MyErrorProvider.SetError(ValorTextBox, "El valor introducido en el campo valor es incorrecto");
                ValorTextBox.Focus();
            }
            else
                MyErrorProvider.Clear();

            if (Convert.ToDecimal(LogradoTextBox.Text) > Convert.ToDecimal(ValorTextBox.Text))
            {
                MyErrorProvider.SetError(LogradoTextBox, "El valor introducido en el campo logrado es incorrecto");
                LogradoTextBox.Focus();
            }
            else
                MyErrorProvider.Clear();


            if (Convert.ToDecimal(LogradoTextBox.Text) < 0)
            {
                MyErrorProvider.SetError(LogradoTextBox, "El valor introducido en el campo logrado es incorrecto");
                LogradoTextBox.Focus();
            }
            else
                MyErrorProvider.Clear();

            decimal valor = Convert.ToDecimal(ValorTextBox.Text);
            decimal logrado = Convert.ToDecimal(LogradoTextBox.Text);

            decimal perdido = valor - logrado;

            PerdidoTextBox.Text = Convert.ToString(perdido);

        }

        private void LogradoTextBox_TextChanged(object sender, EventArgs e)
        {

            MyErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(ValorTextBox.Text))
            {
                ValorTextBox.Text = Convert.ToString(0);
            }
            if (string.IsNullOrWhiteSpace(LogradoTextBox.Text))
            {
                LogradoTextBox.Text = Convert.ToString(0);
            }

            if (Convert.ToDecimal(LogradoTextBox.Text) < 0)
            {
                MyErrorProvider.SetError(LogradoTextBox, "El valor introducido en el campo logrado es incorrecto");
                LogradoTextBox.Focus();
                return;
            }
            else
                MyErrorProvider.Clear();

            if (Convert.ToDecimal(ValorTextBox.Text) < 0)
            {
                MyErrorProvider.SetError(ValorTextBox, "El valor introducido en el campo valor es incorrecto");
                ValorTextBox.Focus();
                return;
            }
            else
                MyErrorProvider.Clear();


            if (Convert.ToDecimal(LogradoTextBox.Text) > Convert.ToDecimal(ValorTextBox.Text))
            {
                MyErrorProvider.SetError(LogradoTextBox, "El valor introducido en el campo logrado es incorrecto");
                LogradoTextBox.Focus();
                return;
            }
            else
                MyErrorProvider.Clear();

            decimal valor = Convert.ToDecimal(ValorTextBox.Text);
            decimal logrado = Convert.ToDecimal(LogradoTextBox.Text);

            decimal perdido = valor - logrado;

            PerdidoTextBox.Text = Convert.ToString(perdido);

            if (EvaluacionBLL.CalcularPerdido(valor, logrado) > (valor * (decimal)0.30))
            {
                PronosticoComboBox.SelectedIndex = 2;
            }

            else
            if (EvaluacionBLL.CalcularPerdido(valor, logrado) <= (valor * (decimal)0.30) && EvaluacionBLL.CalcularPerdido(valor, logrado) >= (valor * (decimal)0.25))
            {
                PronosticoComboBox.SelectedIndex = 1;
            }

            else
            if (EvaluacionBLL.CalcularPerdido(valor, logrado) < (valor * (decimal)0.25))
            {
                PronosticoComboBox.SelectedIndex = 0;
            }

        }

    }
}
