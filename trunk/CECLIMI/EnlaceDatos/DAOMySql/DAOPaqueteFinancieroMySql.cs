using System;
using EnlaceDatos.IDAO;
using MySql.Data.MySqlClient;
using System.Data;
using Entidades;

namespace EnlaceDatos.DAOMySql
{
    public class DAOPaqueteFinancieroMySql: ConexionMySql,IDAOPaqueteFinanciero 
    {
        public bool AgregarPaqueteFinanciero(PaqueteFinanciero paquete)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "InsertarPaqueteFinanciero";


                comando.Parameters.AddWithValue("@FECHA_PAQUETE", paquete.FechaPaquete);
                comando.Parameters.AddWithValue("@FECHA_LIMITE", paquete.FechaLimite);
                comando.Parameters.AddWithValue("@CIRUJANO", paquete.Cirujano.Id);
                comando.Parameters.AddWithValue("@PACIENTE", paquete.Paciente.Id);

                comando.Parameters["@FECHA_PAQUETE"].Direction = ParameterDirection.Input;
                comando.Parameters["@FECHA_LIMITE"].Direction = ParameterDirection.Input;
                comando.Parameters["@CIRUJANO"].Direction = ParameterDirection.Input;
                comando.Parameters["@PACIENTE"].Direction = ParameterDirection.Input;

                comando.ExecuteNonQuery();

                CerrarConexion();
                return true;
            }
            catch (MySqlException)
            {

                return false;
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
                comando.Parameters.AddWithValue("@CIRUJANO", paquete.Cirujano.Id);
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
    }
}
