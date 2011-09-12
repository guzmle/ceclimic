using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using Entidades;
using Logica;

namespace Ceclimi.BackOffice
{
    /// <summary>
    /// Summary description for ServicioCirugia
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class ServicioCirugia : System.Web.Services.WebService
    {

        /// <summary>
        /// Servicio que Almacena una cirugia en la base de datos
        /// </summary>
        /// <param name="cirugia">datos de la cirugia a alamcenar</param>
        [WebMethod]
        public long AgregarCirugia(Cirugia cirugia)
        {
            LCirugia logica = new LCirugia();
            return logica.AgregarCirugia(cirugia);
        }

        /// <summary>
        /// metodo que lleva el control de la logica de obtener cirugias
        /// </summary>
        /// <returns>lista de todas las cirugias</returns>
        [WebMethod]
        public List<Cirugia> ObtenerCirugias()
        {
            LCirugia logica = new LCirugia();
            return logica.ObtenerCirugias();
        }
    }
}
