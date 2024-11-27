using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Persona
    {
        private string nombres;
        private string apellidos;
        private string numId;
        private string direccion;
        private string telefono;

        // Método Constructor
        public Persona(string nom, string ape, string iId, string dire, string tel)
        {
            nombres = nom;
            apellidos = ape;
            numId = iId;
            direccion = dire;
            telefono = tel;
        }

        // Métodos Getters
        public string getNombres()
        {
            return nombres;
        }

        public string getApellidos()
        {
            return apellidos;
        }

        public string getNumId()
        {
            return numId;
        }

        public string getDireccion()
        {
            return direccion;
        }

        public string getTelefono()
        {
            return telefono;
        }

        public virtual void darDescripcion()
        {
            MessageBox.Show($"Nombres: {nombres} Apellidos: {apellidos} ID: {numId} Dirección: {direccion} Teléfono: {telefono}");
        }
    }
}
