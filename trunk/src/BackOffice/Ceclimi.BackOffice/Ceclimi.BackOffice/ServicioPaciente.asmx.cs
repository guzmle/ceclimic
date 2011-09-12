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
    /// Summary description for ServicioPaciente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioPaciente : System.Web.Services.WebService
    {
        /// <summary>
        /// Servicio que se encarga de la logica de agregar paciente
        /// <param name="paciente"> datos del paciente a almacenar</param>
        /// <returns> verdadero si se inserto satisfactoriamente de lo contrario falso</returns>
        /// </summary>
        [WebMethod]
        public bool AgregarPaciente(Paciente paciente)
        {
            LPaciente logica = new LPaciente();
            return logica.AgregarPaciente(paciente);
        }

        /// <summary>
        /// Servicio que revisa si el paciente que va a ser agregado no existe en el sistema
        /// <param name="cedula"> numero de cedula del paciente a verficar</param>
        /// </summary>
        [WebMethod]
        public int ValidarPacienteExistente(int cedula)
        {
            LPaciente logica = new LPaciente();
            return logica.ValidarPacienteExistente(cedula);
        }

        /// <summary>
        /// metodo que obtiene la informacion de un paciente consultado.
        /// <param name="cedula">numero de cedula del paciente a consultar</param>
        /// <returns>datos del paciente</returns>
        /// </summary>
        [WebMethod]
        public Paciente ObtenerInformacionPaciente(int cedula)
        {
            LPaciente logica = new LPaciente();
            return logica.ObtenerInformacionPaciente(cedula);
        }

        /// <summary>
        /// metodo que modifica la informacion de un paciente
        /// </summary>
        [WebMethod]
        public bool EditarPaciente(Paciente paciente)
        {
            LPaciente logica = new LPaciente();
            return logica.EditarPaciente(paciente);
        }

        /// <summary>
        /// metodo que obtiene las cirugias pertenecientes a un paciente
        /// </summary>
        [WebMethod]
        public List<Paciente> ObtenerCirugiasPaciente(int cedula)
        {
            LPaciente logica = new LPaciente();
            return logica.ObtenerCirugiasPaciente(cedula);
        }
    }
}
