using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace EnlaceDatos.DAOMySql
{
    public class ConexionMySql
    {
        private string _direccion = "127.0.0.1";
        private string _usuario = "root";
        private string _password = "asdasd";
        private string _nombreBaseDatos = "ceclimi";
        private MySqlConnection conn;

        /// <summary>
        /// metodo que abre la conexion con la base de datos
        /// </summary>
        public MySqlConnection Conexion()
        {
            conn = new MySqlConnection();
            string cadenaConexion = "server=" + _direccion + ";uid=" + _usuario + ";pwd="
                + _password + ";database=" + _nombreBaseDatos + ";";

            try
            {
                conn.ConnectionString = cadenaConexion;
                conn.Open();
            }
            catch (MySqlException)
            {
                return null;
            }
            return conn;
        }

        /// <summary>
        /// metodo que cierra la conexion con la base de datos
        /// </summary>
        public void CerrarConexion()
        {
            conn.Close();
        }
    }
}
