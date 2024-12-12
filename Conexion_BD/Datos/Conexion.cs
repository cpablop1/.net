using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;

namespace Conexion_BD.Datos
{
    internal class Conexion
    {
        protected SqlConnection bd = new SqlConnection("Data Source=PABLO\\SQLEXPRESS;Initial Catalog=tienda;Integrated Security=True;TrustServerCertificate=True");

        public bool conectar()
        {
            try
            {
                bd.Open();

                if(bd.State == ConnectionState.Open)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void desconectar()
        {
            try
            {
                if(bd.State == ConnectionState.Open)
                {
                    bd.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
