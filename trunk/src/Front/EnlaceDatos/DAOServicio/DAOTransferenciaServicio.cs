using System;
using EnlaceDatos.IDAO;
using Proxy.ProxyTransferencia;
using Transferencia = Entidades.Transferencia;
using TransferenciaServicio = Proxy.ProxyTransferencia.Transferencia;

namespace EnlaceDatos.DAOServicio
{
    class DAOTransferenciaServicio:IDAOTransferencia 
    {
        #region Implementation of IDAOTransferencia

        public bool AgregarTransferencia(Transferencia transferencia)
        {
            try
            {
                ServicioTransferencia servicio = new ServicioTransferencia();
                TransferenciaServicio transferenciaServicio = new TransferenciaServicio();
                transferenciaServicio.PacienteOtorga = new Persona();
                transferenciaServicio.PacienteRecibe = new Persona();

                transferenciaServicio.Monto = transferencia.Monto;
                transferenciaServicio.Nombre = transferencia.Nombre;
                transferenciaServicio.PacienteOtorga.Id = transferencia.PacienteOtorga.Id;
                transferenciaServicio.PacienteRecibe.Id = transferencia.PacienteRecibe.Id;

                return servicio.AgregarTransferencia(transferenciaServicio);

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditarTransferencia(Transferencia transferencia)
        {
            throw new NotImplementedException();
        }

        public bool EliminarTransferencia(Transferencia transferencia)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
