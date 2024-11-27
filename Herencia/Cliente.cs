using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Cliente : Persona
    {
        private int puntos;
        // Método Constructor
        public Cliente(string nom, string ape, string iId, string dire, string tel, int pts) : base(nom, ape, iId, dire, tel)
        {
            puntos = pts;
        }

        // Métodos Getters
        public int getPuntos()
        {
            return puntos;
        }

        // Métodos Setters
        public void setPuntos(int p)
        {
            puntos = p;
        }

        // Sobre escritura del metodo padre
        public override void darDescripcion()
        {
            MessageBox.Show($"Nombres: {getNombres()} Apellidos: {getApellidos()} ID: {getNumId()} Dirección: {getDireccion()} Teléfono: {getTelefono()} Puntos: {puntos}");
        }
    }
}
