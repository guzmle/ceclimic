using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnlaceDatos.IDAO;
using Entidades;
using MySql.Data.MySqlClient;
using System.Data;

namespace EnlaceDatos.DAOMySql
{
    public class DAOCirugiaMySql: ConexionMySql,IDAOCirugia
    {
        public bool AgregarCirugia(Cirugia cirugia)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "InsertarCirugia";


                comando.Parameters.AddWithValue("@NOMBRE", cirugia.Nombre);
                comando.Parameters.AddWithValue("@DESCRIPCION", cirugia.Descripcion);

                comando.Parameters["@NOMBRE"].Direction = ParameterDirection.Input;
                comando.Parameters["@DESCRIPCION"].Direction = ParameterDirection.Input;

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
