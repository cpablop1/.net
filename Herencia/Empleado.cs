using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Empleado : Persona
    {
        private double salario;
        // Método Constructor
        public Empleado(string nom, string ape, string iId, string dire, string tel, double s) : base(nom, ape, iId, dire, tel)
        {
            salario = s;
        }

        // Métodos Setters
        public void setSalario(double s)
        {
            salario = s;
        }

        // Métodos Getters
        public string getSalario()
        {
            return salario.ToString();
        }
    }
}
