using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociaciones
{
    internal class Cliente
    {
        // Atributos
        private string nombres;
        private string apellidos;
        private string numId;
        private string celular;

        // Método constructor
        public Cliente(string nom, string ape, string id, string cel)
        {
            nombres = nom;
            apellidos = ape;
            numId = id;
            celular = cel;
        }

        // Métodos Setters
        public void setNombres(string nom)
        {
            nombres = nom;
        }

        public void setApellidos(string ape)
        {
            apellidos = ape;
        }

        public void setNumId(string id)
        {
            numId = id;
        }

        public void setCelular(string cel)
        {
            celular = cel;
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

        public string getCelular()
        {
            return celular;
        }
    }
}
