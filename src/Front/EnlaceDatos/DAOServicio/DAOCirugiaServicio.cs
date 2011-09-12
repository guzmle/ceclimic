using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnlaceDatos.IDAO;
using Proxy.ProxyCirugia;
using Cirugia = Entidades.Cirugia;
using Entidad = Entidades.Entidad;
using CirugiaServicio = Proxy.ProxyCirugia.Cirugia;

namespace EnlaceDatos.DAOServicio
{
    /// <summary>
    /// Clase que mantiene el control sobre la entidad cirugia
    /// </summary>
    class DAOCirugiaServicio:IDAOCirugia 
    {
        #region Implementation of IDAOCirugia

        /// <summary>
        /// Metodo que almacena una cirugia en la base de datos
        /// </summary>
        /// <param name="cirugia"></param>
        /// <returns></returns>
        public int AgregarCirugia(Cirugia cirugia)
        {
            try
            {
                ServicioCirugia servicio = new ServicioCirugia();
                CirugiaServicio cirugiaServicio = new CirugiaServicio();
                cirugiaServicio.Descripcion = cirugia.Descripcion;
                cirugiaServicio.Nombre = cirugia.Nombre;
                return int.Parse(servicio.AgregarCirugia(cirugiaServicio).ToString());

            }
            catch (Exception)
            {
                return -1;
            }
            

        }

        public bool EliminarCirugia(Entidad cirugia)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Metodo que modifica los datos de una cirugia ya almacenada
        /// </summary>
        /// <param name="cirugia"></param>
        /// <returns></returns>
        public bool ModificarCirugia(Cirugia cirugia)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Metodo que obtiene todas las cirugias del sistema
        /// </summary>
        /// <returns></returns>
        public List<Cirugia> ObtenerCirugias()
        {
            List<Cirugia> retorno = new List<Cirugia>();
            try
            {
                ServicioCirugia servicio = new ServicioCirugia();
                foreach (CirugiaServicio cirugiaServicio in servicio.ObtenerCirugias())
                {
                    Cirugia cirugia = new Cirugia();
                    cirugia.Id = cirugiaServicio.Id;
                    cirugia.Descripcion = cirugiaServicio.Descripcion;
                    cirugia.Nombre = cirugiaServicio.Nombre;
                }
                return retorno;

            }
            catch (Exception)
            {
                return retorno;
            }
        }

        #endregion
    }
}
