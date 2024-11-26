using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociaciones
{
    internal class Venta
    {
        // Atributo
        private int numVenta;
        private double totalVenta;

        // Asociaciones
        private Cliente cliente;
        private Fecha fechaVenta;

        // Métedos constructores
        public Venta(int nv, double tv, Cliente cte, Fecha f)
        {
            numVenta = nv;
            totalVenta = tv;
            cliente = cte;
            fechaVenta = f;
        }

        // Métodos Setters
        public void setNumVenta(int nv)
        {
            numVenta = nv;
        }

        public void setTotalVenta(double tv)
        {
            totalVenta = tv;
        }

        public void setCliente(Cliente cte)
        {
            cliente = cte;
        }

        public void setFecha(Fecha f)
        {
            fechaVenta = f;
        }

        // Métodos Getters
        public int getNumVenta()
        {
            return numVenta;
        }

        public double getTotalVenta()
        {
            return totalVenta;
        }

        public Cliente getCliente()
        {
            return cliente;
        }

        public Fecha getFechaVenta()
        {
            return fechaVenta;
        }
    }
}
