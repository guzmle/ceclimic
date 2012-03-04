using System;
using System.Collections.Generic;

using System.Text;
using Entidades;

namespace EnlaceDatos.IDAO
{
    public interface IDAOCirugiaPaquete
    {
        int AgregarCirugiaPaquete(CirugiaPqtFinanciero cirugiaPaquete);
        bool EditarCirugiaPaquete(CirugiaPqtFinanciero cirugiaPaquete);
        bool EliminarCirugiaPaquete(int id);
        List<CirugiaPqtFinanciero> ObtenerCirugiasPaqueteFinanciero(PaqueteFinanciero paquete);
    }
}
