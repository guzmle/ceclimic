﻿using System.Collections.Generic;
using Ceclimi.AccesoDatos.FabricaDao;
using Entidades;

namespace Logica
{
    public class LPersonalQuirurgico
    {
        /// <summary>
        /// metodo que obtiene una lista del personalquirurgico de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Personal> ObtenerPersonalQ()
        {
            return DAO.ObtenerDAO(1).ObtenerDAOPersonalQ().ObtenerPersonalQ();
        }
    }
}