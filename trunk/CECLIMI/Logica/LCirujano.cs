using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnlaceDatos;
using Entidades;

namespace Logica
{
    /// <summary>
    /// clase que lleva el control de la logica de negocio con al entidad Cirujano
    /// </summary>
    public class LCirujano
    {
        /// <summary>
        /// obtiene una lista de cirujanos que va a ser mostrada en la ventana insertar cirugia.
        /// </summary>
        /// <param name="cirugia"></param>
        /// <returns></returns>
        public List<Cirujano> ObtenerCirujanos(Entidad cirugia)
        {
            return DAO.ObtenerDAO(1).ObtenerDAOCirujano().ObtenerCirujanos(cirugia);
        }
    }
}
