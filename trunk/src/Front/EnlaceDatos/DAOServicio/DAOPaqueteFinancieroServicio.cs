using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnlaceDatos.IDAO;
using Proxy.ProxyPaqueteFinanciero;
using Paciente = Proxy.ProxyPaqueteFinanciero.Paciente;
using PaqueteFinanciero = Entidades.PaqueteFinanciero;
using PaqueteFinancieroServicio = Proxy.ProxyPaqueteFinanciero.PaqueteFinanciero;

namespace EnlaceDatos.DAOServicio
{
    class DAOPaqueteFinancieroServicio:IDAOPaqueteFinanciero 
    {
        #region Implementation of IDAOPaqueteFinanciero

        public int AgregarPaqueteFinanciero(PaqueteFinanciero paquete)
        {
            try
            {
                ServicioPaqueteFinanciero servicio = new ServicioPaqueteFinanciero();
                PaqueteFinancieroServicio paqueteServicio = new PaqueteFinancieroServicio();
                paqueteServicio.FechaLimite = paquete.FechaLimite;
                paqueteServicio.FechaPaquete = paquete.FechaPaquete;
                paqueteServicio.Paciente = new Paciente();
                paqueteServicio.Paciente.Cedula = paquete.Paciente.Cedula;

                return servicio.AgregarPaqueteFinanciero(paqueteServicio);

            }
            catch (Exception)
            {
                return -1;
            }
        }

        public bool EditarPaqueteFinanciero(PaqueteFinanciero paquete)
        {
            throw new NotImplementedException();
        }

        public bool EliminarPaqueteFinanciero(PaqueteFinanciero paquete)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
