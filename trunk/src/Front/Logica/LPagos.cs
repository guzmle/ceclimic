using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<Pago> ObtenerPagosPaciente(Paciente paciente)
        {
            return DAO.ObtenerDAO(1).ObtenerDAOPagos().ObtenerPagosPaciente(paciente);
        }

        public int ValidarPagoExistente(int idpago)
        {
            return DAO.ObtenerDAO(1).ObtenerDAOPagos().ValidarPagoExistente(idpago);
        }
    }
}
