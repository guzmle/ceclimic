using Ceclimi.AccesoDatos.DAOMySql;
using Ceclimi.AccesoDatos.IDAO;

namespace Ceclimi.AccesoDatos.FabricaDao
{
    public class FabricaDAOMySql: DAO
    {
        public override IDAOPaciente ObtenerDAOPaciente()
        {
            return new DAOPacienteMySql();
        }
        public override IDAOCirugia ObtenerDAOCirugia()
        {
            return new DAOCirugiaMySql();
        }
        public override IDAOCirujano ObtenerDAOCirujano()
        {
            return new DAOCirujanoMySql();
        }
        public override IDAOPaqueteFinanciero ObtenerDAOPaqueteFinanciero()
        {
            return new DAOPaqueteFinancieroMySql();
        }
        public override IDAOPagos ObtenerDAOPagos()
        {
            return new DAOPagosMySql();
        }
        public override IDAOPersonalQ ObtenerDAOPersonalQ()
        {
            return new DAOPersonalQMySql();
        }
        public override IDAOCirugiaCirujano ObtenerDAOCirugiaCirujano()
        {
            return new DAOCirugiaCirujanoMySql();
        }
        public override IDAOTransferencia ObtenerDAOTransferencia()
        {
            return new DAOTransferenciaMySql();
        }
        public override IDAOCirugiaPaquete ObtenerDAOCirugiaPaquete()
        {
            return new DAOCirugiaPaquete();
        }
        public override IDAOCirugiaPaquetePersonalQ ObetenerDAOCirugiaPaquetePersonalQ()
        {
            return new DAOCirugiaPaquetePersonalQ();
        }
    }
}
