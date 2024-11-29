using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    internal class Matematicas
    {
        public static int potenciacion(int b, int e)
        {
            int resultado = 1;

            for(int i = 0; i < e; i++)
            {
                resultado = resultado * b;
            }

            return resultado;
        }
    }
}
