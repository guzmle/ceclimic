using System;
using System.Collections.Generic;

using System.Text;
using Entidades;

namespace EnlaceDatos.IDAO
{
    public interface IDAOPagos
    {
        bool AgregarPago(Pago pago);
        bool EditarPago(Pago pago);
        bool EliminarPago(Pago pago);
        List<Pago> ObtenerPagosPaciente(Paciente paciente);
        int ValidarPagoExistente(string idpago);
        List<Pago> ObtenerPagosPaqueteFinanciero(PaqueteFinanciero paquete);
    }
}
