using System;
using System.Collections.Generic;

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
            float precioCirugia = DAO.ObtenerDAO(1).ObtenerDAOCirugiaCirujano().PrecioOperacion(cirugia , cirujano);
            precioCirugia += ((precioCirugia * 40) / 100) + ((precioCirugia * 30) / 100) + 2332;
            precioCirugia += ((precioCirugia*70)/30);
            return precioCirugia;
        }

        public List<CirugiaCirujano> ObtenerCirugiasCirujano (int cedula)
        {
            return DAO.ObtenerDAO(1).ObtenerDAOCirugiaCirujano().ObtenerCirugiasCirujano(cedula);
        }

        public bool EditarCirugiaCirujano (float honorario, int cirugia, int cirujano)
        {
            return DAO.ObtenerDAO(1).ObtenerDAOCirugiaCirujano().EditarCirugiaCirujano(honorario, cirugia, cirujano);
        }

        public bool AgregarCirugiaCirujano(CirugiaCirujano objeto)
        {
            return DAO.ObtenerDAO(1).ObtenerDAOCirugiaCirujano().AgregarCirugiaCirujano(objeto);
        }
    }
}
