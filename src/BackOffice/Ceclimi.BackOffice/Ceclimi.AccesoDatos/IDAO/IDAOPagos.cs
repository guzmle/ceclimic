using System.Collections.Generic;
using Entidades;

namespace Ceclimi.AccesoDatos.IDAO
{
    public interface IDAOPagos
    {
        bool AgregarPago(Pago pago);
        bool EditarPago(Pago pago);
        bool EliminarPago(Pago pago);
        List<Pago> ObtenerPagosPaciente(Paciente paciente);
        int ValidarPagoExistente(int idpago);
    }
}
