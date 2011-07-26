using System;
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
                comando.Parameters.AddWithValue("@PACIENTE", paquete.Paciente.Cedula);
                comando.Parameters.AddWithValue("@idMax", MySqlDbType.Int32);

                comando.Parameters["@FECHA_PAQUETE"].Direction = ParameterDirection.Input;
                comando.Parameters["@PACIENTE"].Direction = ParameterDirection.Input;
                comando.Parameters["@idMax"].Direction = ParameterDirection.Output;

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
    }
}
