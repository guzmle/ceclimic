using System.Collections.Generic;
using Ceclimi.AccesoDatos.FabricaDao;
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

        public List<CirugiaCirujano> ObtenerCirugiasCirujano (int cedula)
        {
            return DAO.ObtenerDAO(1).ObtenerDAOCirugiaCirujano().ObtenerCirugiasCirujano(cedula);
        }

        public bool EditarCirugiaCirujano (float honorario, int cirugia, int cirujano)
        {
            return DAO.ObtenerDAO(1).ObtenerDAOCirugiaCirujano().EditarCirugiaCirujano(honorario, cirugia, cirujano);
        }
    }
}
