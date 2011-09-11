using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnlaceDatos;
using Entidades;

namespace Logica
{
    /// <summary>
    /// Clase que mantiene el control de la logica de negocio de la entidad cirugia
    /// </summary>
    public class LCirugia
    {
        /// <summary>
        /// metodo que lleva el control de la logica de agregar cirugia
        /// </summary>
        /// <param name="cirugia"></param>
        public long AgregarCirugia( Cirugia cirugia)
        {
            return DAO.ObtenerDAO(1).ObtenerDAOCirugia().AgregarCirugia(cirugia);
        }

        /// <summary>
        /// metodo que lleva el control de la logica de obtener cirugias
        /// </summary>
        /// <returns></returns>
        public List<Cirugia> ObtenerCirugias()
        {
            return DAO.ObtenerDAO(1).ObtenerDAOCirugia().ObtenerCirugias();
        }

        
    }
}
