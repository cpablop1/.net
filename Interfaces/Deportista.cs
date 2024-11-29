using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Deportista
    {

        // Atributos
        protected string nombres;
        protected string posicion;
        protected int edad;
        protected int estatura;

        // Método Constructor
        public Deportista() { }
        public Deportista(string nom, string pos, int e, int est)
        {
            nombres = nom;
            posicion = pos;
            edad = e;
            estatura = est;
        }

        // Métodos de accesos (Getters/Setters)
        /*public string NOMBRES
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string POSICION
        {
            get { return posicion; }
            set { posicion = value; }
        }

        public int EDAD
        {
            get { return edad; }
            set { edad = value; }
        }

        public double ESTATURA
        {
            get { return estatura; }
            set { estatura = value; }
        }*/
    }
}
