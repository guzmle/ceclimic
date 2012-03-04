using System;
using System.Collections.Generic;
using System.Data;

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

        public bool EditarCirugiaCirujano(float honorario,int cirugia, int cirujano)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "ModificarCirugiaCirujano";

                Console.WriteLine("aaaaaa" + honorario);

                comando.Parameters.AddWithValue("@HONORARIOS", honorario);
                comando.Parameters.AddWithValue("@CIRUJANO", cirujano);
                comando.Parameters.AddWithValue("@CIRUGIA", cirugia);

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

        public List<CirugiaCirujano> ObtenerCirugiasCirujano(int cedula)
        {
            List<CirugiaCirujano> retorno = new List<CirugiaCirujano>();
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "ObtenerCirugiaCirujano";

                comando.Parameters.AddWithValue("@cedula", cedula);
                comando.Parameters["@cedula"].Direction = ParameterDirection.Input;
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    CirugiaCirujano cirugiaCirujano = new CirugiaCirujano();
                    cirugiaCirujano.Nombre = reader.GetString(0);
                    cirugiaCirujano.Honorarios = reader.GetFloat(1);
                    cirugiaCirujano.Cirugia.Id = reader.GetInt32(2);
                    cirugiaCirujano.Cirujano.Id = reader.GetInt32(3);
                    retorno.Add(cirugiaCirujano);
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
                    retorno = float.Parse(reader.GetString(1));
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