using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociaciones
{
    internal class Almacen
    {
        // Asociación con Venta
        private Venta[] ventas;

        public Almacen()
        {
            ventas = new Venta[100];
        }

        // Funcion para crear una venta
        public void crearVenta(int tv, Cliente cte, Fecha f)
        {
            bool resultado = false;
            for(int i = 0; i < ventas.Length; i++)
            {
                if (ventas[i] == null)
                {
                    ventas[i] = new Venta(i+1, tv, cte, f);
                    resultado = true;
                    break;
                }
            }

            if (resultado)
            {
                MessageBox.Show("La venta fue creada correctamente.");
            }
            else
            {
                MessageBox.Show("Hubo un error al crear la venta.");
            }
        }

        public Venta getUltimaVenta()
        {
            Venta venta = null;

            if (ventas[0] != null)
            {
                for (int i = 1; i < ventas.Length; i++)
                {
                    if (ventas[i] == null)
                    {
                        venta = ventas[i - 1];
                        break;
                    }
                }
            }

            return venta;
        }

        //public Venta getVenta()
        public Venta[] getVentas()
        {
            /*Venta v = null;

            for (int i = 0;i < ventas.Length; i++)
            {
                v = ventas[i];
            }

            Console.WriteLine(ventas);

            return v;*/

            return ventas;
        }
    }
}
