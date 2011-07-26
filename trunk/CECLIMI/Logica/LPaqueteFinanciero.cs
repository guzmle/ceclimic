using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}

