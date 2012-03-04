using System.Collections.Generic;
using System.Web.Services;
using Entidades;
using Logica;

namespace Servicio
{
    /// <summary>
    /// Summary description for ServicioCirugiaCirujano
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioCirugiaCirujano : WebService
    {

        /// <summary>
        /// Servicio que obtiene una cirugia cirujano
        /// </summary>
        /// <param name="cirugia">datos de la cirugia</param>
        /// <param name="cirujano">datos del cirujano</param>
        /// <returns></returns>
        [WebMethod]
        public float ObtenerCirugiaCirujano(Cirugia cirugia, Cirujano cirujano)
        {
            LCirugiaCirujano logica = new LCirugiaCirujano();
            return logica.ObtenerCirugiaCirujano(cirugia, cirujano);
        }

        /// <summary>
        /// Servicio que obtiene todas las cirugias de un cirujano
        /// </summary>
        /// <param name="cedula">cedula del cirujano</param>
        /// <returns>lista de Cirugias</returns>
        [WebMethod]
        public List<CirugiaCirujano> ObtenerCirugiasCirujano(int cedula)
        {

            LCirugiaCirujano logica = new LCirugiaCirujano();
            return logica.ObtenerCirugiasCirujano(cedula);
        }

        /// <summary>
        /// Servicio que edita los datos de una cirugia cirujano
        /// </summary>
        /// <param name="honorario">datos del honorario a cambia</param>
        /// <param name="cirugia">id de la cirugia</param>
        /// <param name="cirujano">datos del cirujano</param>
        /// <returns></returns>
        [WebMethod]
        public bool EditarCirugiaCirujano(float honorario, int cirugia, int cirujano)
        {
            LCirugiaCirujano logica = new LCirugiaCirujano();
            return logica.EditarCirugiaCirujano(honorario, cirugia, cirujano);
        }

        /// <summary>
        /// Metodo que agrega los datos en cirujia cirujano
        /// </summary>
        /// <param name="objeto"></param>
        /// <returns></returns>
        [WebMethod]
        public bool AgregarCirugiaCirujano(CirugiaCirujano objeto)
        {
            LCirugiaCirujano logica = new LCirugiaCirujano();
            return logica.AgregarCirugiaCirujano(objeto);
        }
    }
}
