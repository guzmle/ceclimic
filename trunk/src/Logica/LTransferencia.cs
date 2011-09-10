using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnlaceDatos;
using Entidades;

namespace Logica
{
    public class LTransferencia
    {
        public bool AgregarTransferencia(Transferencia transferencia)
        {
            return DAO.ObtenerDAO(1).ObtenerDAOTransferencia().AgregarTransferencia(transferencia);
        }
    }
}
