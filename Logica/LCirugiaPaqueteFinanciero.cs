﻿using System;
using System.Collections.Generic;

using System.Text;
using EnlaceDatos;
using Entidades;

namespace Logica
{
    /// <summary>
    /// Todos los metodos que lleva la logica de negocio con la entidad cirugia - paquete financiero
    /// </summary>
    public class LCirugiaPaqueteFinanciero
    {
        /// <summary>
        /// metodo que se encarga de la logica de agregar cirugia - paquete financiero
        /// </summary>
        /// <param name="cirugia - paqueteFinanciero"></param>
        /// <returns></returns>
        public int AgregarCirugiaPaquete(CirugiaPqtFinanciero cirugiaPqtFinanciero)
        {
            return DAO.ObtenerDAO(1).ObtenerDAOCirugiaPaquete().AgregarCirugiaPaquete(cirugiaPqtFinanciero);
        }

        public bool EliminarCirugiaPaquete(int id)
        {
            return DAO.ObtenerDAO(1).ObtenerDAOCirugiaPaquete().EliminarCirugiaPaquete(id);
        }

        public List<CirugiaPqtFinanciero> ObtenerCirugiasPaqueteFinanciero(PaqueteFinanciero paquete)
        {
            return DAO.ObtenerDAO(1).ObtenerDAOCirugiaPaquete().ObtenerCirugiasPaqueteFinanciero(paquete);
        }
    }
}
