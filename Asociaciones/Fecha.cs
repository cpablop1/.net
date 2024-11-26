using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociaciones
{
    internal class Fecha
    {
        // Atributo
        private int dia;
        private int mes;
        private int anio;

        // Método constructor
        public Fecha(int d, int m, int a)
        {
            dia = d;
            mes = m;
            anio = a;
        }

        //Métoos Getters
        public string getFecha()
        {
            string fecha = $"{dia}/{mes}/{anio}";

            return fecha;
        }
    }
}
