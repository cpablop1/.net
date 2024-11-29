using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class BasquetBolista : Deportista, IBasquetbol
    {
        // Método constructor
        public BasquetBolista(string nom, string pos, int e, int est) : base(nom, pos, e, est)
        {

        }

        // Método para desarrollar la interfaz
        public bool comprobarEstatura()
        {
            if (estatura >= 190)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
