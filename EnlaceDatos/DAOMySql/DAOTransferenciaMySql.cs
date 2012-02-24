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
    /// <summary>
    /// clase que realiza la crud de la tabla transferencia en la base de datos MySql
    /// </summary>
    public class DAOTransferenciaMySql: ConexionMySql,IDAOTransferencia
    {
        /// <summary>
        /// Metodo que almacena la informacion de una transferencia en la base de datos MySql
        /// </summary>
        /// <param name="transferencia">Objeto que posee la informacion del paciente a almacenar</param>
        /// <returns>verdadero si la insercion fue exitosa de lo contrario false</returns>
        public bool AgregarTransferencia(Transferencia transferencia)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "InsertarTransferencia";


                comando.Parameters.AddWithValue("@MONTO", transferencia.Monto);
                comando.Parameters.AddWithValue("@PACIENTE_OTORGA", transferencia.PacienteOtorga.Id);
                comando.Parameters.AddWithValue("@PACIENTE_RECIBE", transferencia.PacienteRecibe.Id);

                comando.Parameters["@MONTO"].Direction = ParameterDirection.Input;
                comando.Parameters["@PACIENTE_OTORGA"].Direction = ParameterDirection.Input;
                comando.Parameters["@PACIENTE_RECIBE"].Direction = ParameterDirection.Input;


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

        public bool EditarTransferencia(Transferencia transferencia)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "ModificarTransferencia";

                comando.Parameters.AddWithValue("@ID", transferencia.Id);
                comando.Parameters.AddWithValue("@MONTO", transferencia.Monto);
                comando.Parameters.AddWithValue("@PACIENTE_OTORGA", transferencia.PacienteOtorga.Id);
                comando.Parameters.AddWithValue("@PACIENTE_RECIBE", transferencia.PacienteRecibe.Id);

                comando.Parameters["@ID"].Direction = ParameterDirection.Input;
                comando.Parameters["@MONTO"].Direction = ParameterDirection.Input;
                comando.Parameters["@PACIENTE_OTORGA"].Direction = ParameterDirection.Input;
                comando.Parameters["@PACIENTE_RECIBE"].Direction = ParameterDirection.Input;
                comando.Parameters["@PRIMERAPELLIDO"].Direction = ParameterDirection.Input;
                comando.Parameters["@CORREO"].Direction = ParameterDirection.Input;
                comando.Parameters["@FECHA_INGRESO"].Direction = ParameterDirection.Input;


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

        public bool EliminarTransferencia(Transferencia transferencia)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "EliminarPersonalCirugia";

                comando.Parameters.AddWithValue("@ID", transferencia.Id);

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
