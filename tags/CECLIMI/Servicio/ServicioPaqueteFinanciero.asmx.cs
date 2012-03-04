using System.Collections.Generic;
using System.Web.Services;
using Entidades;
using Logica;

namespace Servicio
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
        
        /// <summary>
        /// Metodo que obtiene los paquetes financiero de un paciente dado su numero de cedula
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        [WebMethod]
        public List<PaqueteFinanciero> ObtenerPaqueteFPaciente(int cedula)
        {
            LPaqueteFinanciero logica = new LPaqueteFinanciero();
            return logica.ObtenerPaqueteFPaciente(cedula);
        }
    }
}
