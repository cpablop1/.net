using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Conexion_BD.Datos
{
    internal class DCliente:Conexion
    {
        private int id;
        private string nombres;
        private string apellidos;
        private string direccion;
        private string telefono;
        private string calificacion;
        private string numId;

        private SqlCommand cmd;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string NOMBRES
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string APELLIDOS
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string DIRECCION
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string TELEFONO
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string CALIFICACION
        {
            get { return calificacion; }
            set { calificacion = value; }
        }

        public string NUMID
        {
            get { return numId; }
            set { numId = value; }
        }

        public bool crear()
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO CLIENTES(NOMBRES, APELLIDOS, DIRECCION, TELEFONO, CALIFICACION, NUM_ID)" +
                $"VALUES('{nombres}', '{apellidos}', '{direccion}', '{telefono}', '{calificacion}', '{numId}')");

                cmd.Connection = bd;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                desconectar();
            }
            
        }
    }
}
