using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Conexion_BD.Datos;

namespace Conexion_BD.Logica
{
    internal class LCliente
    {
        public void crear(string nom, string ape, string dire, string tel, string nId)
        {
            try
            {
                DCliente dc = new DCliente(nom, ape, dire, tel, nId);

                if (dc.existeCliente() == false)
                {
                    if (dc.crear() == true)
                    {
                        MessageBox.Show("Cliente registrado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al registrar cliente");
                    }
                }
                else
                {
                    MessageBox.Show("El cliente ya existe en la base de datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DCliente getDatosCliente(string numId)
        {
            try
            {
                DCliente dc = new DCliente();
                dc.NUMID = numId;

                return dc.getDatosCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
