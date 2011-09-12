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
    /// Summary description for ServicioPagos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioPagos : System.Web.Services.WebService
    {

        /// <summary>
        /// Servicio que se encarga de agregar pagos
        /// </summary>
        [WebMethod]
        public bool AgregarPagos(Pago pago)
        {
            LPagos logica = new LPagos();
            return logica.AgregarPagos(pago);
        }

        /// <summary>
        /// Servicio que se obtiene los pagos de un paciente
        /// </summary>
        /// <param name="paciente"></param>
        /// <returns></returns>
        [WebMethod]
        public List<Pago> ObtenerPagosPaciente(Paciente paciente)
        {
            LPagos logica = new LPagos();
            return logica.ObtenerPagosPaciente(paciente);
        }

        /// <summary>
        /// Servicio que valida que exista un pago
        /// </summary>
        /// <param name="idpago"></param>
        /// <returns></returns>
        [WebMethod]
        public int ValidarPagoExistente(int idpago)
        {
            LPagos logica = new LPagos();
            return logica.ValidarPagoExistente(idpago);
        }
    }
}
