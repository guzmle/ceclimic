using System;
using System.Collections.Generic;
using System.Data;
using Ceclimi.AccesoDatos.IDAO;
using Entidades;
using MySql.Data.MySqlClient;

namespace Ceclimi.AccesoDatos.DAOMySql
{
    /// <summary>
    /// clase que realiza la crud de la tabla personal_quirurjico en la base de datos MySql
    /// </summary>
    class DAOPersonalQMySql: ConexionMySql,IDAOPersonalQ
    {
        /// <summary>
        /// Metodo que almacena los datos de un cirujano en la base de datos
        /// </summary>
        /// <param name="personal">Objeto que posee la informacion a almacenar</param>
        /// <returns>verdadero si la incersion fue exitosa de lo contrario false</returns>
        public bool AgregarPersonalQ(Personal personal)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "InsertarPersonalQuirurgico";


                comando.Parameters.AddWithValue("@CEDULA", personal.Cedula);
                comando.Parameters.AddWithValue("@PRIMERNOMBRE", personal.Nombre);
                comando.Parameters.AddWithValue("@SEGUNDONOMBRE", personal.SegundoNombre);
                comando.Parameters.AddWithValue("@PRIMERAPELLIDO", personal.PrimerApellido);
                comando.Parameters.AddWithValue("@SEGUNDOAPELLIDO", personal.SegundoApellido);
                comando.Parameters.AddWithValue("@ESPECIALIZACION", personal.Especializacion);
                comando.Parameters.AddWithValue("@TELEFONO", personal.Telefono);
                comando.Parameters.AddWithValue("@CORREO", personal.Correo);

                comando.Parameters["@CEDULA"].Direction = ParameterDirection.Input;
                comando.Parameters["@PRIMERNOMBRE"].Direction = ParameterDirection.Input;
                comando.Parameters["@SEGUNDONOMBRE"].Direction = ParameterDirection.Input;
                comando.Parameters["@PRIMERAPELLIDO"].Direction = ParameterDirection.Input;
                comando.Parameters["@SEGUNDOAPELLIDO"].Direction = ParameterDirection.Input;
                comando.Parameters["@ESPECIALIZACION"].Direction = ParameterDirection.Input;
                comando.Parameters["@TELEFONO"].Direction = ParameterDirection.Input;
                comando.Parameters["@CORREO"].Direction = ParameterDirection.Input;


                comando.ExecuteNonQuery();

                CerrarConexion();
                return true;
            }
            catch (MySqlException e)
            {
                Console.Write((string) e.Message);
                return false;
            }
        }

        public bool EditarPersonalQ(Personal personal)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "ModificarPersonalQuirurgico";

                comando.Parameters.AddWithValue("@CI", personal.Cedula);
                comando.Parameters.AddWithValue("@PRIMERNOMBRE", personal.Nombre);
                comando.Parameters.AddWithValue("@SEGUNDONOMBRE", personal.SegundoNombre);
                comando.Parameters.AddWithValue("@PRIMERAPELLIDO", personal.PrimerApellido);
                comando.Parameters.AddWithValue("@SEGUNDOAPELLIDO", personal.SegundoApellido);
                comando.Parameters.AddWithValue("@ESPECIALIZACION", personal.Especializacion);
                comando.Parameters.AddWithValue("@TELEFONO", personal.Telefono);
                comando.Parameters.AddWithValue("@CORREO", personal.Correo);

                comando.Parameters["@CI"].Direction = ParameterDirection.Input;
                comando.Parameters["@PRIMERNOMBRE"].Direction = ParameterDirection.Input;
                comando.Parameters["@SEGUNDONOMBRE"].Direction = ParameterDirection.Input;
                comando.Parameters["@PRIMERAPELLIDO"].Direction = ParameterDirection.Input;
                comando.Parameters["@SEGUNDOAPELLIDO"].Direction = ParameterDirection.Input;
                comando.Parameters["@ESPECIALIZACION"].Direction = ParameterDirection.Input;
                comando.Parameters["@TELEFONO"].Direction = ParameterDirection.Input;
                comando.Parameters["@CORREO"].Direction = ParameterDirection.Input;


                comando.ExecuteNonQuery();

                CerrarConexion();
                return true;
            }
            catch (MySqlException e)
            {
                Console.Write((string) e.Message);
                return false;
            }
        }

        public bool EliminarPersonalQ(Personal personal)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "EliminarPersonalQuirurgico";

                comando.Parameters.AddWithValue("@CI", personal.Id);

                comando.Parameters["@CI"].Direction = ParameterDirection.Input;


                comando.ExecuteNonQuery();

                CerrarConexion();
                return true;
            }
            catch (MySqlException e)
            {
                Console.Write((string) e.Message);
                return false;
            }
        }

        public List<Personal> ObtenerPersonalQ()
        {
            List<Personal> retorno = new List<Personal>();
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "ObtenerPersonalQ";
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Personal personal = new Personal();
                    personal.Nombre = reader.GetString(0);
                    personal.Id = reader.GetInt64(1);
                    retorno.Add(personal);
                }

                reader.Close();
                CerrarConexion();
                return retorno;
            }
            catch (MySqlException e)
            {
                Console.Write((string) e.Message);
                return retorno;
            }

        }
    }
}
