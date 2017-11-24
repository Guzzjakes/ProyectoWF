﻿using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ProyectoWF {

    internal class Conexion {
        public static string cadena = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=ProyectoWF; Integrated Security=True; MultipleActiveResultSets=True";
        public static SqlConnection conexion;

        public Conexion()
        {

        }

        public static SqlConnection getConexion()
        {
            try
            {
                if (conexion == null)
                {
                    conexion = new SqlConnection
                    {
                        ConnectionString = cadena
                    };
                    conexion.Open();
                }


            }
            catch (Exception e)
            {
                Console.WriteLine("error "+e);
            }

            return conexion;
        }


        public static void cerrarConexion()
        {
            try
            {
                conexion.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("error "+e);
            }
        }

    }
}