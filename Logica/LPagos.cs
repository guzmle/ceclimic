using System;
using System.Collections.Generic;

using System.Text;
using EnlaceDatos;
using Entidades;

namespace Logica
{
    /// <summary>
    /// Todos los metodos que lleva la logica de negocio con la entidad pagos
    /// </summary>
    public class LPagos
    {
        /// <summary>
        /// metodo que se encarga de la logica de agregar pagos
        /// </summary>
        public bool AgregarPagos(Pago pago)
        {
            return DAO.ObtenerDAO(1).ObtenerDAOPagos().AgregarPago(pago);
        }

        /// <summary>
        /// Metodo que obtiene los pagos de un paciente especifico
        /// </summary>
        /// <param name="paciente"></param>
        /// <returns></returns>
        public List<Pago> ObtenerPagosPaciente(Paciente paciente)
        {
            return DAO.ObtenerDAO(1).ObtenerDAOPagos().ObtenerPagosPaciente(paciente);
        }

        /// <summary>
        /// Metodo que valida la existencia de un pago
        /// </summary>
        /// <param name="idpago"></param>
        /// <returns></returns>
        public int ValidarPagoExistente(string idpago)
        {
            return DAO.ObtenerDAO(1).ObtenerDAOPagos().ValidarPagoExistente(idpago);
        }

        /// <summary>
        /// Metodo que obtiene los pagos de un paquete financiero
        /// </summary>
        /// <param name="paquete"></param>
        /// <returns></returns>
        public List<Pago> ObtenerPagosPaqueteFinanciero(PaqueteFinanciero paquete)
        {
            return DAO.ObtenerDAO(1).ObtenerDAOPagos().ObtenerPagosPaqueteFinanciero(paquete);
        }
    }
}
