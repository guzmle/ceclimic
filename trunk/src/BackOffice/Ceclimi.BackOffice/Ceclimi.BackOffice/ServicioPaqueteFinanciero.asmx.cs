using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Entidades;
using Logica;

namespace Ceclimi.BackOffice
{
    /// <summary>
    /// Summary description for ServicioPaqueteFinanciero
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioPaqueteFinanciero : System.Web.Services.WebService
    {
        /// <summary>
        /// Servicio que se encarga de agregar paquete financiero
        /// </summary>
        /// <param name="paqueteFinanciero"></param>
        /// <returns></returns>
        [WebMethod]
        public int AgregarPaqueteFinanciero(PaqueteFinanciero paqueteFinanciero)
        {
            LPaqueteFinanciero logica = new LPaqueteFinanciero();
            return logica.AgregarPaqueteFinanciero(paqueteFinanciero);
        }
    }
}
