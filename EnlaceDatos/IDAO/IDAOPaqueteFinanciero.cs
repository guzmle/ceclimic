using System;
using System.Collections.Generic;

using System.Text;
using Entidades;
namespace EnlaceDatos.IDAO
{
    public interface IDAOPaqueteFinanciero
    {
        int AgregarPaqueteFinanciero(PaqueteFinanciero paquete);
        bool EditarPaqueteFinanciero(PaqueteFinanciero paquete);
        bool EliminarPaqueteFinanciero(PaqueteFinanciero paquete);
        List<PaqueteFinanciero> ObtenerPaqueteFPaciente(int cedula);
        bool ModificarObservacionPaqueteFinanciero(PaqueteFinanciero paquete, string observacion);
    }
}
