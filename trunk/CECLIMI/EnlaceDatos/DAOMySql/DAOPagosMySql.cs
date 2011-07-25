using System;
using System.Data;
using EnlaceDatos.IDAO;
using Entidades;
using MySql.Data.MySqlClient;

namespace EnlaceDatos.DAOMySql
{
    /// <summary>
    /// clase que realiza la crud de la tabla pagos en la base de datos MySql
    /// </summary>
    public class DAOPagosMySql: ConexionMySql,IDAOPagos
    {
        /// <summary>
        /// Metodo que almacena los datos un pago en la base de datos
        /// </summary>
        /// <param name="pago">Objeto que posee la informacion del pago a insertar</param>
        /// <returns>verdadero si la insercion fue exitosa de lo contrario false</returns>
        public bool AgregarPago(Pago pago)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "InsertarPago";


                comando.Parameters.AddWithValue("@MONTO", pago.Monto);
                comando.Parameters.AddWithValue("@NOMBRE", pago.Nombre);
                comando.Parameters.AddWithValue("@PACIENTE", pago.Usuario.Id);

                comando.Parameters["@MONTO"].Direction = ParameterDirection.Input;
                comando.Parameters["@NOMBRE"].Direction = ParameterDirection.Input;
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

        public bool EditarPago(Pago pago)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "ModificarPago";

                comando.Parameters.AddWithValue("@ID", pago.Id);
                comando.Parameters.AddWithValue("@MONTO", pago.Monto);
                comando.Parameters.AddWithValue("@NOMBRE", pago.Nombre);
                comando.Parameters.AddWithValue("@PACIENTE", pago.Usuario.Id);

                comando.Parameters["@ID"].Direction = ParameterDirection.Input;
                comando.Parameters["@MONTO"].Direction = ParameterDirection.Input;
                comando.Parameters["@NOMBRE"].Direction = ParameterDirection.Input;
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

        public bool EliminarPago(Pago pago)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "EliminarPago";

                comando.Parameters.AddWithValue("@ID", pago.Id);

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
