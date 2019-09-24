using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_Ap1.Entidades
{
    public class Evaluacion
    {
        [key]
        public int Evaluacionid { get; set; }
        public DateTime Fecha { get; set; }
        public string Estudiante { get; set; }
        public decimal Valor { get; set; }
        public decimal Logrado { get; set; }
        public decimal Perdidos { get; set; }
        public int Pronostico { get; set; }

        public Evaluacion()
        {
        }
    }
}
