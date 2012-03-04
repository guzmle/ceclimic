using EnlaceDatos;
using Entidades;

namespace Logica
{
    /// <summary>
    /// Clase que lleva la logica de la entidad transferencia
    /// </summary>
    public class LTransferencia
    {
        /// <summary>
        /// Metodo que agrega los datos de una transferencia
        /// </summary>
        /// <param name="transferencia"></param>
        /// <returns></returns>
        public bool AgregarTransferencia(Transferencia transferencia)
        {
            return DAO.ObtenerDAO(1).ObtenerDAOTransferencia().AgregarTransferencia(transferencia);
        }
    }
}
