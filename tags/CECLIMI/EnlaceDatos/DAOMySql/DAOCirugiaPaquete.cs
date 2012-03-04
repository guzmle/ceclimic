using System;
using System.Collections.Generic;
using System.Data;

using System.Text;
using EnlaceDatos.IDAO;
using Entidades;
using MySql.Data.MySqlClient;

namespace EnlaceDatos.DAOMySql
{
    public class DAOCirugiaPaquete: ConexionMySql,IDAOCirugiaPaquete
    {
        public int AgregarCirugiaPaquete(CirugiaPqtFinanciero cirugiaPaquete)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "InsertarCirugiaPaqueteF";

                comando.Parameters.AddWithValue("@PROTESIS", cirugiaPaquete.Protesis);
                comando.Parameters.AddWithValue("@DESCUENTO", cirugiaPaquete.Descuento);
                comando.Parameters.AddWithValue("@MONTO_CIRUJANO", cirugiaPaquete.MontoCirujano);
                comando.Parameters.AddWithValue("@CIRUGIA", cirugiaPaquete.Cirugia.Id);
                comando.Parameters.AddWithValue("@CIRUJANO", cirugiaPaquete.Cirujano.Id);
                comando.Parameters.AddWithValue("@PAQUETE", cirugiaPaquete.PaqueteFinanciero.Id);
                comando.Parameters.AddWithValue("@MAX_ID", MySqlDbType.Int32);

                comando.Parameters["@PROTESIS"].Direction = ParameterDirection.Input;
                comando.Parameters["@DESCUENTO"].Direction = ParameterDirection.Input;
                comando.Parameters["@MONTO_CIRUJANO"].Direction = ParameterDirection.Input;
                comando.Parameters["@CIRUGIA"].Direction = ParameterDirection.Input;
                comando.Parameters["@CIRUJANO"].Direction = ParameterDirection.Input;
                comando.Parameters["@PAQUETE"].Direction = ParameterDirection.Input;
                comando.Parameters["@MAX_ID"].Direction = ParameterDirection.Output;

                comando.ExecuteNonQuery();
                int idMax = (int)comando.Parameters["@MAX_ID"].Value;
                CerrarConexion();
                return idMax;
            }
            catch (MySqlException e)
            {
                Console.Write(e.Message);
                return -1;
            }
        }

        public bool EditarCirugiaPaquete(CirugiaPqtFinanciero cirugiaPaquete)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "ModificarCirugiaPaquteF";

                comando.Parameters.AddWithValue("@ID", cirugiaPaquete.Protesis);
                comando.Parameters.AddWithValue("@PROTESIS", cirugiaPaquete.Protesis);
                comando.Parameters.AddWithValue("@CIRUGIA", cirugiaPaquete.Cirugia.Id);
                comando.Parameters.AddWithValue("@PAQUETE", cirugiaPaquete.PaqueteFinanciero.Id);

                comando.Parameters["@ID"].Direction = ParameterDirection.Input;
                comando.Parameters["@PROTESIS"].Direction = ParameterDirection.Input;
                comando.Parameters["@FECHA_OPERACION"].Direction = ParameterDirection.Input;
                comando.Parameters["@CIRUGIA"].Direction = ParameterDirection.Input;
                comando.Parameters["@PAQUETE"].Direction = ParameterDirection.Input;

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

        public bool EliminarCirugiaPaquete(int id)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "EliminarCirugiaPaqueteF";


                comando.Parameters.AddWithValue("@ID", id);

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

        public List<CirugiaPqtFinanciero> ObtenerCirugiasPaqueteFinanciero(PaqueteFinanciero paquete)
        {
            try
            {
                List<CirugiaPqtFinanciero> cirugias = new List<CirugiaPqtFinanciero>();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "ObtenerCirugiasPaqueteFinanciero";


                comando.Parameters.AddWithValue("@idPaquete", paquete.Id);
                comando.Parameters["@idPaquete"].Direction = ParameterDirection.Input;

                MySqlDataReader reader = comando.ExecuteReader();
                int contador = 1;
                while (reader.Read())
                {
                    CirugiaPqtFinanciero cirugiaPqt = new CirugiaPqtFinanciero();
                    cirugiaPqt.Cirugia.Nombre = reader.GetString(0);
                    cirugiaPqt.Cirujano.Nombre = reader.GetString(1);
                    cirugiaPqt.Protesis = reader.GetFloat(2);
                    cirugiaPqt.MontoCirujano = reader.GetFloat(3);
                    cirugiaPqt.Descuento = reader.GetFloat(4);
                    cirugias.Add(cirugiaPqt);
                    contador++;
                }

                reader.Close();
                CerrarConexion();
                return cirugias;
            }
            catch (MySqlException e)
            {
                Console.Write(e.Message);
                return null;
            }
        }
    }
}
