using System;
using System.Collections.Generic;
using System.Data;
using Ceclimi.AccesoDatos.IDAO;
using Entidades;
using MySql.Data.MySqlClient;

namespace Ceclimi.AccesoDatos.DAOMySql
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

                comando.Parameters.AddWithValue("@IDPAGO", pago.Id);
                comando.Parameters.AddWithValue("@MONTO", pago.Monto);
                comando.Parameters.AddWithValue("@NOMBRE", pago.Nombre);
                comando.Parameters.AddWithValue("@FECHA", pago.Fecha);
                comando.Parameters.AddWithValue("@SEGURO", pago.Seguro);
                comando.Parameters.AddWithValue("@TIPO_PAGO", pago.TipoPago);
                comando.Parameters.AddWithValue("@PACIENTE", pago.Usuario.Id);

                comando.Parameters["@IDPAGO"].Direction = ParameterDirection.Input;
                comando.Parameters["@MONTO"].Direction = ParameterDirection.Input;
                comando.Parameters["@NOMBRE"].Direction = ParameterDirection.Input;
                comando.Parameters["@FECHA"].Direction = ParameterDirection.Input;
                comando.Parameters["@SEGURO"].Direction = ParameterDirection.Input;
                comando.Parameters["@TIPO_PAGO"].Direction = ParameterDirection.Input;
                comando.Parameters["@PACIENTE"].Direction = ParameterDirection.Input;


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
                Console.Write((string) e.Message);
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
                Console.Write((string) e.Message);
                return false;
            }
        }

        public List<Pago> ObtenerPagosPaciente(Paciente paciente)
        {
            List<Pago> retorno = new List<Pago>();
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "ObtenerPagosPaciente";


                comando.Parameters.AddWithValue("@IDPACIENTE", paciente.Id);
                comando.Parameters["@IDPACIENTE"].Direction = ParameterDirection.Input;

                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Pago pago = new Pago();
                    pago.Id = reader.GetInt64(0);
                    pago.Monto = (float) reader.GetDouble(1);
                    pago.Fecha = reader.GetDateTime(2);
                    retorno.Add(pago);
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

        public int ValidarPagoExistente(int idpago)
        {
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "ValidarPagoExistente";


                comando.Parameters.AddWithValue("@IDPAGO", idpago);
                comando.Parameters.AddWithValue("@RESULTADO", MySqlDbType.Int32);

                comando.Parameters["@IDPAGO"].Direction = ParameterDirection.Input;
                comando.Parameters["@RESULTADO"].Direction = ParameterDirection.Output;

                comando.ExecuteNonQuery();
                int resultado = Convert.ToInt32((object) comando.Parameters["@RESULTADO"].Value);
                return resultado;
            }
            catch (MySqlException e)
            {
                Console.Write((string) e.Message);
                return -1;
            }

        }
    }
}
