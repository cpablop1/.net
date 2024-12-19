﻿using System;
using System.Collections.Generic;
using System.Data;
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
        private string numId;
        private string calificacion;

        private SqlCommand cmd;

        // Metodo constructor
        public DCliente(string nom, string ape, string dire, string tel, string nId)
        {
            nombres = nom;
            apellidos = ape;
            direccion = dire;
            telefono = tel;
            numId = nId;
        }

        public DCliente()
        {

        }

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


        public string NUMID
        {
            get { return numId; }
            set { numId = value; }
        }

        public string CALIFICACION
        {
            get { return calificacion;  }
            set { calificacion = value; }
        }

        public bool crear()
        {
            conectar();
            try
            {
                cmd = new SqlCommand("INSERT INTO tienda.CLIENTES(NOMBRES, APELLIDOS, DIRECCION, TELEFONO, CALIFICACION, NUM_ID)" +
                $"VALUES('{nombres}', '{apellidos}', '{direccion}', '{telefono}', 'A', '{numId}')");

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

        public DCliente getDatosCliente()
        {
            try
            {
                conectar();

                string consulta = $"SELECT * FROM tienda.CLIENTES WHERE NUM_ID='{numId}'";

                cmd = new SqlCommand(consulta, bd);

                if (cmd.ExecuteNonQuery() == -1)
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);

                    adp.Fill(dt);

                    DataRow dr = dt.Rows[0];

                    DCliente dc = new DCliente(dr["NOMBRES"].ToString(), dr["APELLIDOS"].ToString(), dr["DIRECCION"].ToString(), dr["TELEFONO"].ToString(), numId);
                    dc.ID = int.Parse(dr["id"].ToString());
                    dc.CALIFICACION = dr["CALIFICACION"].ToString();

                    return dc;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                desconectar();
            }
        }

        public bool existeCliente()
        {
            try
            {
                conectar();

                string consulta = $"SELECT COUNT(*) FROM tienda.CLIENTES WHERE NUM_ID='{numId}'";

                cmd = new SqlCommand(consulta, bd);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
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