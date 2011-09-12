using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnlaceDatos.IDAO;
using Proxy.ProxyPagos;
using Paciente = Entidades.Paciente;
using Pago = Entidades.Pago;
using PagoServicio = Proxy.ProxyPagos.Pago;
using Persona = Proxy.ProxyPagos.Persona;
using PacienteServicio = Proxy.ProxyPagos.Paciente;

namespace EnlaceDatos.DAOServicio
{
    class DAOPagosServicios:IDAOPagos
    {
        #region Implementation of IDAOPagos

        public bool AgregarPago(Pago pago)
        {
            try
            {
                ServicioPagos servicio = new ServicioPagos();
                PagoServicio pagoServicio = new PagoServicio();
                pagoServicio.Monto = pago.Monto;
                pagoServicio.Nombre = pago.Nombre;
                pagoServicio.Seguro = pago.Seguro;
                pagoServicio.TipoPago = pago.TipoPago;
                pagoServicio.Usuario = new Persona();
                pagoServicio.Usuario.Id = pago.Id;

                return servicio.AgregarPagos(pagoServicio);

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditarPago(Pago pago)
        {
            throw new NotImplementedException();
        }

        public bool EliminarPago(Pago pago)
        {
            throw new NotImplementedException();
        }

        public List<Pago> ObtenerPagosPaciente(Paciente paciente)
        {
            List<Pago> retorno = new List<Pago>();
            try
            {
                ServicioPagos servicio = new ServicioPagos();
                PacienteServicio persona = new PacienteServicio();
                persona.Id = paciente.Id;
                foreach (PagoServicio pagoServicio in servicio.ObtenerPagosPaciente(persona))
                {
                    Pago pago = new Pago();
                    pago.Monto = pagoServicio.Monto;
                    pago.Nombre = pagoServicio.Nombre;
                    pago.Seguro = pagoServicio.Seguro;
                    pago.TipoPago = pagoServicio.TipoPago;
                    pago.Usuario.Id = pagoServicio.Id;
                    retorno.Add(pago);

                }
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        public int ValidarPagoExistente(int idpago)
        {
            try
            {
                ServicioPagos servicio = new ServicioPagos();
                return servicio.ValidarPagoExistente(idpago);
            }
            catch (Exception)
            {
                return -1;
            }
        }

        #endregion
    }
}
