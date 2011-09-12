using System;
using System.Collections.Generic;
using System.Data;
using Ceclimi.AccesoDatos.IDAO;
using Entidades;
using MySql.Data.MySqlClient;

namespace Ceclimi.AccesoDatos.DAOMySql
{
    public class DAOCirugiaMySql: ConexionMySql,IDAOCirugia
    {
        /// <summary>
        /// metodo que almacena los datos de una cirugia en la base de datos de MySql
        /// </summary>
        /// <param name="cirugia">Objeto que posee los datos a almacenar en la base de datos</param>
        /// <returns>verdadero si se realizo la insercion con exito de lo contrario false</returns>
        public int AgregarCirugia(Cirugia cirugia)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "InsertarCirugia";


                comando.Parameters.AddWithValue("@NOMBRE", cirugia.Nombre);
                comando.Parameters.AddWithValue("@DESCRIPCION", cirugia.Descripcion);
                comando.Parameters.AddWithValue("@IDMAX", MySqlDbType.Int32);

                comando.Parameters["@NOMBRE"].Direction = ParameterDirection.Input;
                comando.Parameters["@DESCRIPCION"].Direction = ParameterDirection.Input;
                comando.Parameters["@IDMAX"].Direction = ParameterDirection.Output;

                comando.ExecuteNonQuery();
                int id = (int) comando.Parameters["@IDMAX"].Value;

                CerrarConexion();
                return id;
            }
            catch (MySqlException e)
            {
                Console.Write((string) e.Message);
                return -1;
            }
        }

        /// <summary>
        /// metodo que deshabilita alguna cirugia de la base de datos si tener la necesidad de eliminar el registro de la misma
        /// </summary>
        /// <param name="cirugia">Objeto que posee la informacion de la cirugia a deshabilitar</param>
        /// <returns>verdadero si se realizo la eliminacion con exito de lo contrario false</returns>
        public bool EliminarCirugia(Entidad cirugia)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "EliminarCirugia";


                comando.Parameters.AddWithValue("@ID", cirugia.Id);

                comando.Parameters["@ID"].Direction = ParameterDirection.Input;

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

        /// <summary>
        /// metodo que edita los datos de una cirugia de la base de datos
        /// </summary>
        /// <param name="cirugia">Objeto que posee los datos de la cirugia a editar</param>
        /// <returns>verdadero si se realizo la edicion con exito de lo contrario false</returns>
        public bool ModificarCirugia(Cirugia cirugia)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "ModificarCirugia";

                comando.Parameters.AddWithValue("@CEDULA", cirugia.Id);
                comando.Parameters.AddWithValue("@NOMBRE", cirugia.Nombre);
                comando.Parameters.AddWithValue("@DESCRIPCION", cirugia.Descripcion);

                comando.Parameters["@CEDULA"].Direction = ParameterDirection.Input;
                comando.Parameters["@NOMBRE"].Direction = ParameterDirection.Input;
                comando.Parameters["@DESCRIPCION"].Direction = ParameterDirection.Input;

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

        public List<Cirugia> ObtenerCirugias()
        {
            List<Cirugia> retorno = new List<Cirugia>();
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "ObtenerCirugias";
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Cirugia cirugia = new Cirugia();
                    cirugia.Nombre = reader.GetString(0);
                    cirugia.Id = reader.GetInt64(1);
                    retorno.Add(cirugia);
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
