using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace EnlaceDatos.IDAO
{
    public interface IDAOCirugiaPaquete
    {
        bool AgregarCirugiaPaquete(CirugiaPqtFinanciero cirugiaPaquete);
        bool EditarCirugiaPaquete(CirugiaPqtFinanciero cirugiaPaquete);
        bool EliminarCirugiaPaquete(CirugiaPqtFinanciero cirugiaPaquete);
    }
}
