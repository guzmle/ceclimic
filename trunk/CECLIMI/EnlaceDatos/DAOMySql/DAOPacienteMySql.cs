using System;
using System.Data;
using EnlaceDatos.IDAO;
using Entidades;
using MySql.Data.MySqlClient;

namespace EnlaceDatos.DAOMySql
{
    /// <summary>
    /// clase que realiza la crud de la tabla paciente en la base de datos MySql
    /// </summary>
    class DAOPacienteMySql: ConexionMySql,IDAOPaciente
    {
        /// <summary>
        /// Metodo que almacena la informacion de un paciente en la base de datos MySql
        /// </summary>
        /// <param name="paciente">Objeto que posee la informacion del paciente a almacenar</param>
        /// <returns>verdadero si la insercion fue exitosa de lo contrario false</returns>
        public bool AgregarPaciente(Paciente paciente)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "InsertarPaciente";


                comando.Parameters.AddWithValue("@CEDULA", paciente.Cedula);
                comando.Parameters.AddWithValue("@PRIMERNOMBRE", paciente.Nombre);
                comando.Parameters.AddWithValue("@SEGUNDONOMBRE", paciente.SegundoNombre);
                comando.Parameters.AddWithValue("@PRIMERAPELLIDO", paciente.PrimerApellido);
                comando.Parameters.AddWithValue("@SEGUNDOAPELLIDO", paciente.SegundoApellido);
                comando.Parameters.AddWithValue("@TELEFONOFIJO", paciente.Telefono);
                comando.Parameters.AddWithValue("@TELEFONOMOVIL", paciente.TelefonoMovil);
                comando.Parameters.AddWithValue("@CORREO", paciente.Correo);
                comando.Parameters.AddWithValue("@FECHA_INGRESO",paciente.FechaIngreso);

                comando.Parameters["@CEDULA"].Direction = ParameterDirection.Input;
                comando.Parameters["@PRIMERNOMBRE"].Direction = ParameterDirection.Input;
                comando.Parameters["@SEGUNDONOMBRE"].Direction = ParameterDirection.Input;
                comando.Parameters["@PRIMERAPELLIDO"].Direction = ParameterDirection.Input;
                comando.Parameters["@SEGUNDOAPELLIDO"].Direction = ParameterDirection.Input;
                comando.Parameters["@TELEFONOFIJO"].Direction = ParameterDirection.Input;
                comando.Parameters["@TELEFONOMOVIL"].Direction = ParameterDirection.Input;
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

        /// <summary>
        /// Metodo que edita la informacion de un paciente en la base de datos
        /// </summary>
        /// <param name="paciente">Objeto que posee la informacion a editar</param>
        /// <returns>verdadero si la insercion fue exitosa de lo contrario false</returns>
        public bool EditarPaciente(Paciente paciente)
        {

            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "ModificarPaciente";


                comando.Parameters.AddWithValue("@CEDULA", paciente.Cedula);
                comando.Parameters.AddWithValue("@PRIMERNOMBRE", paciente.Nombre);
                comando.Parameters.AddWithValue("@SEGUNDONOMBRE", paciente.SegundoNombre);
                comando.Parameters.AddWithValue("@PRIMERAPELLIDO", paciente.PrimerApellido);
                comando.Parameters.AddWithValue("@SEGUNDOAPELLIDO", paciente.SegundoApellido);
                comando.Parameters.AddWithValue("@TELEFONOFIJO", paciente.Telefono);
                comando.Parameters.AddWithValue("@TELEFONOMOVIL", paciente.TelefonoMovil);
                comando.Parameters.AddWithValue("@CORREO", paciente.Correo);

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

                return false;
            }
        }

        /// <summary>
        /// Metodo que deshabilita un paciente de la base de datos pero no elimina el registro permanentemente
        /// </summary>
        /// <param name="paciente">Objeto que posee la informacion del registro a eliminar</param>
        /// <returns>verdadero si la eliminacion fue exitosa</returns>
        public bool EliminarPaciente(Entidad paciente)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "EliminarPaciente";


                comando.Parameters.AddWithValue("@ID", paciente.Id);

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
        /// metodo utilizado para validar que un paciente no este en la base de datos al insertarlo
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        public int ValidarPacienteExistente(int cedula)
        {
            try
            {
                
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "ValidacionPacienteExistente";


                comando.Parameters.AddWithValue("@CEDULA",cedula);
                comando.Parameters.AddWithValue("@resultado", MySqlDbType.Int32);

                comando.Parameters["@CEDULA"].Direction = ParameterDirection.Input;
                comando.Parameters["@resultado"].Direction = ParameterDirection.Output;

                comando.ExecuteNonQuery();
                int resultado = Convert.ToInt32(comando.Parameters["@resultado"].Value);
                return resultado;
            }
            catch (MySqlException e)
            {
                Console.Write(e.Message);
                return -1;
            }
            
        }

        /// <summary>
        /// Obtiene la informacion del paciente a consultar.
        /// </summary>
        public Paciente ObtenerInformacionPaciente(int cedula)
        {
            try
            {
                Paciente paciente = new Paciente();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "ObtenerInformacionPaciente";


                comando.Parameters.AddWithValue("@Cedula", cedula);
                comando.Parameters["@Cedula"].Direction = ParameterDirection.Input;

                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    paciente.Nombre = reader.GetString(0);
                    paciente.SegundoNombre = reader.GetString(1);
                    paciente.PrimerApellido = reader.GetString(2);
                    paciente.SegundoApellido = reader.GetString(3);
                    paciente.Telefono = reader.GetString(4);
                    paciente.TelefonoMovil = reader.GetString(5);
                    paciente.Correo = reader.GetString(6);
                }

                reader.Close();
                CerrarConexion();
                return paciente;
            }
            catch (MySqlException e)
            {
                Console.Write(e.Message);
                return null;
            }
        }
    }
}
