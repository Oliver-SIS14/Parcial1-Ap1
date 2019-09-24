using Parcial1_Ap1.DAL;
using Parcial1_Ap1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_Ap1.BLL
{
    public class EvaluacionBLL
    {

        public static bool Guardar(Evaluacion evaluacion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Evaluacion.Add(evaluacion) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Evaluacion evaluacion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(evaluacion).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static Evaluacion Buscar(int id)
        {
            Evaluacion evaluacion = new Evaluacion();
            Contexto db = new Contexto();

            try
            {
                evaluacion = db.Evaluacion.Find(id); 
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return evaluacion;
        }

        public static bool Eliminar (int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            var eliminar = db.Evaluacion.Find(id);

            try
            {
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static decimal CalcularPerdido(decimal valor, decimal logrado)
        {
            return valor - logrado;
        }

        public static List<Evaluacion> GetList(Expression<Func<Evaluacion,bool>> evaluacion)
        {
            List<Evaluacion> Lista = new List<Evaluacion>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.Evaluacion.Where(evaluacion).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }
    }
}
