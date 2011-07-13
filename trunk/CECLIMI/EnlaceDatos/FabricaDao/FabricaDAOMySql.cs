using EnlaceDatos.DAOMySql;
using EnlaceDatos.IDAO;

namespace EnlaceDatos.FabricaDao
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
            throw new System.NotImplementedException();
        }
        public override IDAOTransferencia ObtenerDAOTransferencia()
        {
            throw new System.NotImplementedException();
        }
        public override IDAOCirugiaPaquete ObtenerDAOCirugiaPaquete()
        {
            throw new System.NotImplementedException();
        }
        public override IDAOCirugiaPaquetePersonalQ ObetenerDAOCirugiaPaquetePersonalQ()
        {
            throw new System.NotImplementedException();
        }
    }
}
