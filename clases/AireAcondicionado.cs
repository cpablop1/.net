using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    internal class AireAcondicionado
    {
        //Atributos
        public string marca;
        public string modelo;
        public string color;
        public int voltaje;
        public int btu;
        public int temperatura;

        //Métidos
        public void subirTemperatura()
        {
            temperatura++;
        }
        public void bajarTemperatura()
        {
            temperatura--;
        }
        public int darTemperaturaActual()
        {
            return temperatura;
        }
    }
}
