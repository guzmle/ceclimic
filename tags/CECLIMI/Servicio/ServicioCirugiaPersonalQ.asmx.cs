using System.Collections.Generic;
using System.Web.Services;
using Entidades;
using Logica;

namespace Servicio
{
    /// <summary>
    /// Summary description for ServicioCirugiaPersonalQ
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioCirugiaPersonalQ : System.Web.Services.WebService
    {

        /// <summary>
        /// Servicio que  agregar cirugia - personalQ
        /// </summary>
        /// <param name="personalPaquete"></param>
        [WebMethod]
        public bool AgregarCirugiaPersonalQ(PersonalPaquete personalPaquete)
        {
            LCirugiaPersonalQ logica = new LCirugiaPersonalQ();
            return logica.AgregarCirugiaPersonalQ(personalPaquete);
        }

        /// <summary>
        /// Servcio que obtiene una lista del personalquirurgico de la base de datos
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public List<Personal> ObtenerPersonalQ()
        {
            LPersonalQuirurgico logica = new LPersonalQuirurgico();
            return logica.ObtenerPersonalQ();
        }
    }
}
