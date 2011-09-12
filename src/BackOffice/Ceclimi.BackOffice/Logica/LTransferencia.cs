using Ceclimi.AccesoDatos.FabricaDao;
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
