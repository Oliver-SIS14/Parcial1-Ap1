using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcial1_Ap1.BLL;
using Parcial1_Ap1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_Ap1.BLL.Tests
{
    [TestClass()]
    public class EvaluacionBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Evaluacion evaluacion = new Evaluacion();

            evaluacion.Estudiante = "Ramon";
            evaluacion.Fecha = DateTime.Now;
            evaluacion.Valor = 30;
            evaluacion.Logrado = 15;

            paso = EvaluacionBLL.Guardar(evaluacion);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = false;
            Evaluacion evaluacion = new Evaluacion();

            evaluacion.Estudiante = "Ramon";
            evaluacion.Fecha = DateTime.Now;
            evaluacion.Valor = 30;
            evaluacion.Logrado = 15;
            evaluacion.Evaluacionid = 7;

            paso = EvaluacionBLL.Modificar(evaluacion);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Evaluacion evaluacion = new Evaluacion();

            evaluacion = EvaluacionBLL.Buscar(2);

            bool paso =  evaluacion!= null;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;

            paso = EvaluacionBLL.Eliminar(3);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void CalcularPerdidoTest()
        {
            bool paso = false;
            paso = EvaluacionBLL.CalcularPerdido(30, 15) != 0;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var listado = new List<Evaluacion>();

            listado = EvaluacionBLL.GetList(p => true);
            Assert.AreEqual(listado != null, true);
        }
    }
}