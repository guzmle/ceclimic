using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnlaceDatos.IDAO;
using MySql.Data.MySqlClient;
using System.Data;
using Entidades;

namespace EnlaceDatos.DAOMySql
{
    public class DAOPaqueteFinancieroMySql: Conexion,IDAOPaqueteFinanciero 
    {
        public bool AgregarPaqueteFinanciero(PaqueteFinanciero paquete)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "AgregarAseguradora";


                comando.Parameters.AddWithValue("@FECHA_PAQUETE", paquete.FechaPaquete);
                comando.Parameters.AddWithValue("@FECHA_LIMITE", paquete.FechaLimite);
                comando.Parameters.AddWithValue("@CIRUJANO", paquete.Cirujano.Id);
                comando.Parameters.AddWithValue("@PACIENTE", paquete.Paciente.Id);

                comando.Parameters["@FECHA_PAQUETE"].Direction = ParameterDirection.Input;
                comando.Parameters["@FECHA_LIMITE"].Direction = ParameterDirection.Input;
                comando.Parameters["@CIRUJANO"].Direction = ParameterDirection.Input;
                comando.Parameters["@PACIENTE"].Direction = ParameterDirection.Input;

                comando.ExecuteNonQuery();

                int id = (int)comando.Parameters["@id"].Value;

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
