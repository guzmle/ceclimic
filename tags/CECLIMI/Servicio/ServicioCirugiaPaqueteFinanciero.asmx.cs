using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Entidades;
using Logica;

namespace Servicio
{
    /// <summary>
    /// Summary description for ServicioCirugiaPaqueteFinanciero
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioCirugiaPaqueteFinanciero : System.Web.Services.WebService
    {

        /// <summary>
        /// metodo que se encarga de la logica de agregar cirugia - paquete financiero
        /// </summary>
        /// <param name="cirugiaPqtFinanciero"></param>
        /// <returns></returns>
        [WebMethod]
        public int AgregarCirugiaPaquete(CirugiaPqtFinanciero cirugiaPqtFinanciero)
        {
            LCirugiaPaqueteFinanciero logica = new LCirugiaPaqueteFinanciero();
            return logica.AgregarCirugiaPaquete(cirugiaPqtFinanciero);
        }

        /// <summary>
        /// Servicio que elimina una cirugiaPaquete de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [WebMethod]
        public bool EliminarCirugiaPaquete(int id)
        {
            LCirugiaPaqueteFinanciero logica = new LCirugiaPaqueteFinanciero();
            return logica.EliminarCirugiaPaquete(id);
        }
        
        /// <summary>
        /// Metodo que Obtiene las cirujias paquete financienro que existen en la base de datos
        /// </summary>
        /// <param name="paquete"></param>
        /// <returns></returns>
        [WebMethod]
        public List<CirugiaPqtFinanciero> ObtenerCirugiasPaqueteFinanciero(PaqueteFinanciero paquete)
        {
            LCirugiaPaqueteFinanciero logica = new LCirugiaPaqueteFinanciero();
            return logica.ObtenerCirugiasPaqueteFinanciero(paquete);
        }
    }
}
