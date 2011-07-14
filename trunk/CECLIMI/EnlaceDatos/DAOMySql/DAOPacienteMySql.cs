using System;
using System.Data;
using EnlaceDatos.IDAO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using MySql.Data.MySqlClient;

namespace EnlaceDatos.DAOMySql
{
    class DAOPacienteMySql: ConexionMySql,IDAOPaciente
    {
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
    }
}
