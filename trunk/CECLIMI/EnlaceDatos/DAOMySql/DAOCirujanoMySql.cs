using System;
using System.Collections.Generic;
using System.Data;
using EnlaceDatos.IDAO;
using Entidades;
using MySql.Data.MySqlClient;

namespace EnlaceDatos.DAOMySql
{
    /// <summary>
    /// clase que realiza la crud de la tabla cirujano en la base de datos MySql
    /// </summary>
    public class DAOCirujanoMySql: ConexionMySql, IDAOCirujano
    {
        /// <summary>
        /// Metodo que almacena los datos de un cirujano en la base de datos
        /// </summary>
        /// <param name="cirujano">Objeto que posee la informacion a almacenar</param>
        /// <returns>verdadero si la incersion fue exitosa de lo contrario false</returns>
        public bool AgregarCirujano(Cirujano cirujano)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "Insertarcirujano";


                comando.Parameters.AddWithValue("@CEDULA", cirujano.Cedula);
                comando.Parameters.AddWithValue("@PRIMERNOMBRE", cirujano.Nombre);
                comando.Parameters.AddWithValue("@SEGUNDONOMBRE", cirujano.SegundoNombre);
                comando.Parameters.AddWithValue("@PRIMERAPELLIDO", cirujano.PrimerApellido);
                comando.Parameters.AddWithValue("@SEGUNDOAPELLIDO", cirujano.SegundoApellido);
                comando.Parameters.AddWithValue("@TELEFONOFIJO", cirujano.TelefonoFijo);
                comando.Parameters.AddWithValue("@TELEFONOMOVIL", cirujano.TelefonoMovil);
                comando.Parameters.AddWithValue("@CORREO", cirujano.Correo);

                comando.Parameters["@CEDULA"].Direction = ParameterDirection.Input;
                comando.Parameters["@PRIMERNOMBRE"].Direction = ParameterDirection.Input;
                comando.Parameters["@SEGUNDONOMBRE"].Direction = ParameterDirection.Input;
                comando.Parameters["@PRIMERAPELLIDO"].Direction = ParameterDirection.Input;
                comando.Parameters["@SEGUNDOAPELLIDO"].Direction = ParameterDirection.Input;
                comando.Parameters["@TELEFONOFIJO"].Direction = ParameterDirection.Input;
                comando.Parameters["@TELEFONOMOVIL"].Direction = ParameterDirection.Input;
                comando.Parameters["@CORREO"].Direction = ParameterDirection.Input;


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

        /// <summary>
        /// Metodo que deshabilita un cirujano de la base de datos pero no elimina el registro permanentemente
        /// </summary>
        /// <param name="cirujano">Objeto con los datos del cirujano a eliminar</param>
        /// <returns></returns>
        public bool EliminarCirujano(Entidad cirujano)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "EliminarCirujano";


                comando.Parameters.AddWithValue("@ID", cirujano.Id);

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
        /// <summary>
        /// Metodo que edita los datos de un cirujano en la base de datos
        /// </summary>
        /// <param name="cirujano">Objeto que posee la informacion a editar</param>
        /// <returns>verdadero si la edicion fue exitosa de lo contrario false</returns>
        public bool EditarCirujano(Cirujano cirujano)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "ModificarCirujano";


                comando.Parameters.AddWithValue("@ID", cirujano.Cedula);
                comando.Parameters.AddWithValue("@PRIMERNOMBRE", cirujano.Nombre);
                comando.Parameters.AddWithValue("@SEGUNDONOMBRE", cirujano.SegundoNombre);
                comando.Parameters.AddWithValue("@PRIMERAPELLIDO", cirujano.PrimerApellido);
                comando.Parameters.AddWithValue("@SEGUNDOAPELLIDO", cirujano.SegundoApellido);
                comando.Parameters.AddWithValue("@TELEFONOFIJO", cirujano.TelefonoFijo);
                comando.Parameters.AddWithValue("@TELEFONOMOVIL", cirujano.TelefonoMovil);
                comando.Parameters.AddWithValue("@CORREO", cirujano.Correo);

                comando.Parameters["@ID"].Direction = ParameterDirection.Input;
                comando.Parameters["@PRIMERNOMBRE"].Direction = ParameterDirection.Input;
                comando.Parameters["@SEGUNDONOMBRE"].Direction = ParameterDirection.Input;
                comando.Parameters["@PRIMERAPELLIDO"].Direction = ParameterDirection.Input;
                comando.Parameters["@SEGUNDOAPELLIDO"].Direction = ParameterDirection.Input;
                comando.Parameters["@TELEFONOFIJO"].Direction = ParameterDirection.Input;
                comando.Parameters["@TELEFONOMOVIL"].Direction = ParameterDirection.Input;
                comando.Parameters["@CORREO"].Direction = ParameterDirection.Input;


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

        /// <summary>
        /// Obtener una Lista de Cirujanos dado una cirugia
        /// </summary>
        /// <param name="cirugia"></param>
        /// <returns></returns>
        public List<Cirujano> ObtenerCirujanos(Entidad cirugia)
        {
            List<Cirujano> retorno = new List<Cirujano>();
            try
            {
                
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "ObtenerCirujanosCirugia";


                comando.Parameters.AddWithValue("@idCirugia", cirugia.Id);
                comando.Parameters["@idCirugia"].Direction = ParameterDirection.Input;
                
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Cirujano cirujano = new Cirujano();
                    cirujano.Nombre = reader.GetString(0);
                    cirujano.Id = reader.GetInt64(1);
                    retorno.Add(cirujano);
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
