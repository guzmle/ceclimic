using System.Collections.Generic;
using System.Web.Services;
using Entidades;
using Logica;

namespace Ceclimi.BackOffice
{
    /// <summary>
    /// Summary description for ServicioCirujano
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioCirujano : WebService
    {

        /// <summary>
        /// obtiene una lista de cirujanos que va a ser mostrada en la ventana insertar cirugia.
        /// </summary>
        /// <param name="cirugia"></param>
        /// <returns></returns>
        [WebMethod]
        public List<Cirujano> ObtenerCirujanos(Entidad cirugia)
        {
            LCirujano logica = new LCirujano();
            return logica.ObtenerCirujanos(cirugia);
        }

        /// <summary>
        /// Servicio que obtiene la informacion de in cirujano dado su cedula
        /// </summary>
        /// <param name="cedula">cedula del cirujano</param>
        /// <returns>datos del cirujano</returns>
        [WebMethod]
        public Cirujano ObtenerInformacionCirujano(int cedula)
        {
            LCirujano logica = new LCirujano();
            return logica.ObtenerInformacionCirujano(cedula);
        }

        /// <summary>
        /// Servicio que edita los datos de un cirujano
        /// </summary>
        /// <param name="cirujano"></param>
        /// <returns></returns>
        [WebMethod]
        public bool EditarCirujano(Cirujano cirujano)
        {
            LCirujano logica = new LCirujano();
            return logica.EditarCirujano(cirujano);
        }
    }
}
