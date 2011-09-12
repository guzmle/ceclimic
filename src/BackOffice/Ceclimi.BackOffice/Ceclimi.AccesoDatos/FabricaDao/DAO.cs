using Ceclimi.AccesoDatos.IDAO;

namespace Ceclimi.AccesoDatos.FabricaDao
{
    public abstract class DAO
    {

        
        public static DAO ObtenerDAO(int baseDatos)
        {
            switch (baseDatos)
            {
                case 1:
                    {
                        return new FabricaDAOMySql();
                        break;
                    }
                case 2:
                    return null;

                default:
                    return null;
            }
        }

        public abstract IDAOPaciente ObtenerDAOPaciente();
        public abstract IDAOCirugia ObtenerDAOCirugia();
        public abstract IDAOCirujano ObtenerDAOCirujano();
        public abstract IDAOPaqueteFinanciero ObtenerDAOPaqueteFinanciero();
        public abstract IDAOPagos ObtenerDAOPagos();
        public abstract IDAOPersonalQ ObtenerDAOPersonalQ();
        public abstract IDAOCirugiaCirujano ObtenerDAOCirugiaCirujano();
        public abstract IDAOTransferencia ObtenerDAOTransferencia();
        public abstract IDAOCirugiaPaquete ObtenerDAOCirugiaPaquete();
        public abstract IDAOCirugiaPaquetePersonalQ ObetenerDAOCirugiaPaquetePersonalQ();
    }
}
