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
    public class DAOCirujanoMySql: ConexionMySql, IDAOCirujano
    {
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
            catch (MySqlException)
            {

                return false;
            }
        }
    }
}
