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
    /// Summary description for ServicioTransferencia
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioTransferencia : System.Web.Services.WebService
    {

        /// <summary>
        /// Servicio que agrega una transferencia a la base de datos
        /// </summary>
        /// <param name="transferencia"></param>
        /// <returns></returns>
        [WebMethod]
        public bool AgregarTransferencia(Transferencia transferencia)
        {
            LTransferencia logica = new LTransferencia();
            return logica.AgregarTransferencia(transferencia);
        }
    }
}
