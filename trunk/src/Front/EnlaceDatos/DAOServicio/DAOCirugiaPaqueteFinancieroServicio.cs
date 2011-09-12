using System;
using EnlaceDatos.IDAO;
using Proxy.ProxyCirugiaPaqueteFinanciero;
using CirugiaPqtFinanciero = Entidades.CirugiaPqtFinanciero;
using CirugiaPqtFinancieroServicio = Proxy.ProxyCirugiaPaqueteFinanciero.CirugiaPqtFinanciero;
namespace EnlaceDatos.DAOServicio
{
    class DAOCirugiaPaqueteFinancieroServicio:IDAOCirugiaPaquete 
    {
        #region Implementation of IDAOCirugiaPaquete

        public int AgregarCirugiaPaquete(CirugiaPqtFinanciero cirugiaPaquete)
        {
            try
            {
                ServicioCirugiaPaqueteFinanciero servicio = new ServicioCirugiaPaqueteFinanciero();
                CirugiaPqtFinancieroServicio cirugiaPaqueteServicio = new CirugiaPqtFinancieroServicio();
                cirugiaPaqueteServicio.Cirugia = new Proxy.ProxyCirugiaPaqueteFinanciero.Cirugia();
                cirugiaPaqueteServicio.Cirugia.Id = cirugiaPaquete.Cirugia.Id;
                cirugiaPaqueteServicio.Cirujano = new Proxy.ProxyCirugiaPaqueteFinanciero.Cirujano();
                cirugiaPaqueteServicio.Cirujano.Id = cirugiaPaquete.Id;
                cirugiaPaqueteServicio.Descuento = cirugiaPaquete.Descuento;
                cirugiaPaqueteServicio.FechaOperacion = cirugiaPaquete.FechaOperacion;
                cirugiaPaqueteServicio.MontoCirujano = cirugiaPaqueteServicio.MontoCirujano;
                cirugiaPaqueteServicio.Nombre = cirugiaPaquete.Nombre;
                cirugiaPaqueteServicio.Protesis = cirugiaPaquete.Protesis;
                return servicio.AgregarCirugiaPaquete(cirugiaPaqueteServicio);



            }
            catch (Exception)
            {
                return -1;
            }
        }

        public bool EditarCirugiaPaquete(CirugiaPqtFinanciero cirugiaPaquete)
        {
            throw new NotImplementedException();
        }

        public bool EliminarCirugiaPaquete(int id)
        {
            try
            {
                ServicioCirugiaPaqueteFinanciero servicio = new ServicioCirugiaPaqueteFinanciero();
                return servicio.EliminarCirugiaPaquete(id);
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion
    }
}
