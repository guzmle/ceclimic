using System;
using System.Data;
using EnlaceDatos.IDAO;
using Entidades;
using MySql.Data.MySqlClient;

namespace EnlaceDatos.DAOMySql
{
    public class DAOCirugiaPaquetePersonalQ : ConexionMySql,IDAOCirugiaPaquetePersonalQ
    {
        public bool AgregarCirugiaPaquetePersonalQ(PersonalPaquete personalPaquete)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "InsertarPersonalCirugia";


                comando.Parameters.AddWithValue("@CIRUGIA_PAQUETE", personalPaquete.Cirugia.Id);
                comando.Parameters.AddWithValue("@PERSONAL", personalPaquete.Personal.Id);
                comando.Parameters.AddWithValue("@ESPECIALIZACION", personalPaquete.Especialidad);

                comando.Parameters["@CIRUGIA_PAQUETE"].Direction = ParameterDirection.Input;
                comando.Parameters["@PERSONAL"].Direction = ParameterDirection.Input;
                comando.Parameters["@ESPECIALIZACION"].Direction = ParameterDirection.Input;

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

        public bool EditarCirugiaPaquetePersonalQ(PersonalPaquete personalPaquete)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "ModificarPersonalCirugia";

                comando.Parameters.AddWithValue("@ID", personalPaquete.Id);
                comando.Parameters.AddWithValue("@CIRUGIA_PAQUETE", personalPaquete.Cirugia.Id);
                comando.Parameters.AddWithValue("@PERSONAL", personalPaquete.Personal.Id);
                comando.Parameters.AddWithValue("@ESPECIALIZACION", personalPaquete.Personal.Id);
                
                comando.Parameters["@ID"].Direction = ParameterDirection.Input;
                comando.Parameters["@CIRUGIA_PAQUETE"].Direction = ParameterDirection.Input;
                comando.Parameters["@PERSONAL"].Direction = ParameterDirection.Input;
                comando.Parameters["@ESPECIALIZACION"].Direction = ParameterDirection.Input;

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

        public bool EliminarCirugiaPaquetePersonalQ(PersonalPaquete personalPaquete)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "EliminarPersonalCirugia";

                comando.Parameters.AddWithValue("@ID", personalPaquete.Id);

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
