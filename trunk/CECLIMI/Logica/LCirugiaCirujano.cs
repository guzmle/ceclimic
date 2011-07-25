using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnlaceDatos;
using Entidades;

namespace Logica
{
    /// <summary>
    /// clase que lleva el control de la logica de negocio con al entidad Cirugia-cirujano
    /// </summary>
    public class LCirugiaCirujano
    {
        public float ObtenerCirugiaCirujano(Cirugia cirugia,Cirujano cirujano)
        {
            //return DAO.ObtenerDAO(1).ObtenerDAOCirujano().ObtenerCirujanos(cirugia);
            return DAO.ObtenerDAO(1).ObtenerDAOCirugiaCirujano().PrecioOperacion(cirugia , cirujano);
        }


    }
}
