using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using EnlaceDatos.IDAO;
using Entidades;
using MySql.Data.MySqlClient;

namespace EnlaceDatos.DAOMySql
{
    class DAOCirugiaCirujanoMySql: ConexionMySql,IDAOCirugiaCirujano
    {
        public bool AgregarCirugiaCirujano(CirugiaCirujano objeto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "InsertarCirugiaCirujano";


                comando.Parameters.AddWithValue("@HONORARIOS", objeto.Honorarios);
                comando.Parameters.AddWithValue("@CIRUJANO", objeto.Cirujano.Id);
                comando.Parameters.AddWithValue("@CIRUGIA", objeto.Cirugia.Id);

                comando.Parameters["@HONORARIOS"].Direction = ParameterDirection.Input;
                comando.Parameters["@CIRUJANO"].Direction = ParameterDirection.Input;
                comando.Parameters["@CIRUGIA"].Direction = ParameterDirection.Input;


                comando.ExecuteNonQuery();

                CerrarConexion();
                return true;
            }
            catch (MySqlException e)
            {
                Console.Write(e.Message);
                return false;
            }
        }

        public bool EditarCirugiaCirujano(CirugiaCirujano objeto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "ModificarCirugiaCirujano";

                comando.Parameters.AddWithValue("@ID", objeto.Id);
                comando.Parameters.AddWithValue("@HONORARIOS", objeto.Honorarios);
                comando.Parameters.AddWithValue("@CIRUJANO", objeto.Cirujano.Id);
                comando.Parameters.AddWithValue("@CIRUGIA", objeto.Cirugia.Id);

                comando.Parameters["@ID"].Direction = ParameterDirection.Input;
                comando.Parameters["@HONORARIOS"].Direction = ParameterDirection.Input;
                comando.Parameters["@CIRUJANO"].Direction = ParameterDirection.Input;
                comando.Parameters["@CIRUGIA"].Direction = ParameterDirection.Input;


                comando.ExecuteNonQuery();

                CerrarConexion();
                return true;
            }
            catch (MySqlException e)
            {
                Console.Write(e.Message);
                return false;
            }
        }

        public bool EliminarCirugiaCirujano(CirugiaCirujano objeto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "EliminarCirugiaCirujano";


                comando.Parameters.AddWithValue("@ID", objeto.Id);

                comando.Parameters["@ID"].Direction = ParameterDirection.Input;

                comando.ExecuteNonQuery();

                CerrarConexion();
                return true;
            }
            catch (MySqlException)
            {

                return false;
            }
        }

        public float PrecioOperacion(Cirugia cirugia, Cirujano cirujano)
        {
            float retorno = 0;
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "ObtenerHonorarioCirugiaCirujano";


                comando.Parameters.AddWithValue("@idCirugia", cirugia.Id);
                comando.Parameters["@idCirugia"].Direction = ParameterDirection.Input;

                comando.Parameters.AddWithValue("@idCirujano", cirujano.Id);
                comando.Parameters["@idCirujano"].Direction = ParameterDirection.Input;
                
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    retorno = reader.GetUInt64(1);
                }

                reader.Close();
                CerrarConexion();
                return retorno;
            }
            catch (MySqlException e)
            {
                Console.Write(e.Message);
                return retorno;
            }
        }
    }
}