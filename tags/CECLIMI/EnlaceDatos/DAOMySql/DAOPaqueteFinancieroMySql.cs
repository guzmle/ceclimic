using System;
using System.Collections.Generic;
using EnlaceDatos.IDAO;
using MySql.Data.MySqlClient;
using System.Data;
using Entidades;

namespace EnlaceDatos.DAOMySql
{
    public class DAOPaqueteFinancieroMySql: ConexionMySql,IDAOPaqueteFinanciero 
    {
        public int AgregarPaqueteFinanciero(PaqueteFinanciero paquete)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "InsertarPaqueteFinanciero";


                comando.Parameters.AddWithValue("@FECHA_PAQUETE", paquete.FechaPaquete);
                comando.Parameters.AddWithValue("@FECHA_OPERACION", paquete.FechaOperacion);
                comando.Parameters.AddWithValue("@PACIENTE", paquete.Paciente.Cedula);
                comando.Parameters.AddWithValue("@idMax", MySqlDbType.Int32);
                comando.Parameters.AddWithValue("@OBSERVACION", paquete.Observacion);

                comando.Parameters["@FECHA_PAQUETE"].Direction = ParameterDirection.Input;
                comando.Parameters["@FECHA_OPERACION"].Direction = ParameterDirection.Input;
                comando.Parameters["@PACIENTE"].Direction = ParameterDirection.Input;
                comando.Parameters["@idMax"].Direction = ParameterDirection.Output;
                comando.Parameters["@OBSERVACION"].Direction = ParameterDirection.Input;

                comando.ExecuteNonQuery();
                int id = (int)comando.Parameters["@idMax"].Value;

                CerrarConexion();
                return id;
            }
            catch (MySqlException)
            {

                return -1;
            }
        }

        public bool EditarPaqueteFinanciero(PaqueteFinanciero paquete)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "ModificarPaqueteFinanciero";

                comando.Parameters.AddWithValue("@ID", paquete.Id);
                comando.Parameters.AddWithValue("@FECHA_PAQUETE", paquete.FechaPaquete);
                comando.Parameters.AddWithValue("@FECHA_LIMITE", paquete.FechaLimite);
                comando.Parameters.AddWithValue("@PACIENTE", paquete.Paciente.Id);

                comando.Parameters["@ID"].Direction = ParameterDirection.Input;
                comando.Parameters["@FECHA_PAQUETE"].Direction = ParameterDirection.Input;
                comando.Parameters["@FECHA_LIMITE"].Direction = ParameterDirection.Input;
                comando.Parameters["@CIRUJANO"].Direction = ParameterDirection.Input;
                comando.Parameters["@PACIENTE"].Direction = ParameterDirection.Input;

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

        public bool EliminarPaqueteFinanciero(PaqueteFinanciero paquete)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "EliminarPaqueteFinanciero";

                comando.Parameters.AddWithValue("@ID", paquete.Id);

                comando.Parameters["@ID"].Direction = ParameterDirection.Input;


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

        public List<PaqueteFinanciero> ObtenerPaqueteFPaciente(int cedula)
        {
            try
            {
                List<PaqueteFinanciero> paqueteFinancieros = new List<PaqueteFinanciero>();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "ObtenerPaqueteFPaciente";


                comando.Parameters.AddWithValue("@Cedula", cedula);
                comando.Parameters["@Cedula"].Direction = ParameterDirection.Input;

                MySqlDataReader reader = comando.ExecuteReader();
                int contador = 1;
                while (reader.Read())
                {
                    PaqueteFinanciero paqueteFinanciero = new PaqueteFinanciero();
                    paqueteFinanciero.Id = reader.GetInt32(0);
                    paqueteFinanciero.Nombre = contador + " - " + reader.GetDateTime(1).ToString().Split(' ')[0];
                    paqueteFinanciero.FechaPaquete = reader.GetDateTime(1);
                    paqueteFinanciero.FechaOperacion = reader.GetDateTime(2);
                    paqueteFinanciero.Observacion = reader.GetString(3);
                    paqueteFinancieros.Add(paqueteFinanciero);
                    contador++;
                }

                reader.Close();
                CerrarConexion();
                return paqueteFinancieros;
            }
            catch (MySqlException e)
            {
                Console.Write(e.Message);
                return null;
            }
        }

        
    }
}
