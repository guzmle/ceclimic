
using Ceclimi.AccesoDatos.FabricaDao;
using Entidades;

namespace Logica
{
    /// <summary>
    /// Clase que mantiene el control de la logica de negocio de la entidad Cirugia - PersonalQ
    /// </summary>
    public class LCirugiaPersonalQ
    {
        /// <summary>
        /// metodo que lleva el control de la logica de agregar cirugia - personalQ
        /// </summary>
        /// <param name="personalPaquete"></param>
        public bool AgregarCirugiaPersonalQ(PersonalPaquete personalPaquete)
        {
            return DAO.ObtenerDAO(1).ObetenerDAOCirugiaPaquetePersonalQ().AgregarCirugiaPaquetePersonalQ(personalPaquete);
        }
    }
}
