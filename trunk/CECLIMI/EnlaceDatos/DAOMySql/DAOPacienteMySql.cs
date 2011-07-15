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
            catch (MySqlException)
            {

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
                comando.Parameters.AddWithValue("@FECHA_INGRESO", paciente.FechaIngreso);

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
            catch (MySqlException)
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
            catch (MySqlException)
            {

                return false;
            }
        }
    }
}
