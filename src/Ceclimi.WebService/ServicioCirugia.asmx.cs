using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using Entidades;

namespace Ceclimi.WebService
{
    /// <summary>
    /// Servicio que se encarga de las operaciones con la entidad
    /// cirugia
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class ServicioCirugia : System.Web.Services.WebService
    {

        /// <summary>
        /// Servicio que se encarga de agregar una cirugia
        /// en la base de datos
        /// </summary>
        /// <param name="cirugia"></param>
        /// <returns></returns>
        [WebMethod]
        public long AgregarCirugia(Cirugia cirugia)
        {
            return 0;
        }

        /// <summary>
        /// Servicio que se encarga de obtener una lista de cirugias
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public List<Cirugia> ObtenerCirugias()
        {
            return null;
        }
    }
}
