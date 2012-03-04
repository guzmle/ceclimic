using System.Collections.Generic;
using EnlaceDatos;
using Entidades;

namespace Logica
{
    /// <summary>
    /// Todos los metodos que lleva la logica de negocio con la entidad paquete financiero
    /// </summary>
    public class LPaqueteFinanciero
    {
        /// <summary>
        /// metodo que se encarga de la logica de agregar paquete financiero
        /// </summary>
        /// <param name="paqueteFinanciero"></param>
        /// <returns></returns>
        public int AgregarPaqueteFinanciero(PaqueteFinanciero paqueteFinanciero)
        {
            return DAO.ObtenerDAO(1).ObtenerDAOPaqueteFinanciero().AgregarPaqueteFinanciero(paqueteFinanciero);
        }

        /// <summary>
        /// Metodo que obtiene los paquetes financiero de un paciente dado su numero de cedula
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        public List<PaqueteFinanciero> ObtenerPaqueteFPaciente(int cedula)
        {
            return DAO.ObtenerDAO(1).ObtenerDAOPaqueteFinanciero().ObtenerPaqueteFPaciente(cedula);
        }
    }
}

