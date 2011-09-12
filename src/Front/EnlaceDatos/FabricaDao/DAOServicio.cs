using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnlaceDatos.DAOServicio;
using EnlaceDatos.IDAO;

namespace EnlaceDatos.FabricaDao
{
    /// <summary>
    /// Fabrica para los dao's que tienen que ver con el 
    /// servicio web
    /// </summary>
    class DAOServicio: DAO
    {
        #region Overrides of DAO

        public override IDAOPaciente ObtenerDAOPaciente()
        {
            return new DAOPacienteServicio();
        }

        public override IDAOCirugia ObtenerDAOCirugia()
        {
            return new DAOCirugiaServicio();
        }

        public override IDAOCirujano ObtenerDAOCirujano()
        {
            return new DAOCirujanoServicio();
        }

        public override IDAOPaqueteFinanciero ObtenerDAOPaqueteFinanciero()
        {
            return new DAOPaqueteFinancieroServicio();
        }

        public override IDAOPagos ObtenerDAOPagos()
        {
            return new DAOPagosServicios();
        }

        public override IDAOPersonalQ ObtenerDAOPersonalQ()
        {
            throw new NotImplementedException();
        }

        public override IDAOCirugiaCirujano ObtenerDAOCirugiaCirujano()
        {
           return new DAOCirugiaCirujanoServicio();
        }

        public override IDAOTransferencia ObtenerDAOTransferencia()
        {
            return new DAOTransferenciaServicio();
        }

        public override IDAOCirugiaPaquete ObtenerDAOCirugiaPaquete()
        {
            return new DAOCirugiaPaqueteFinancieroServicio();
        }

        public override IDAOCirugiaPaquetePersonalQ ObetenerDAOCirugiaPaquetePersonalQ()
        {
            return new DAOCirugiaPaquetePersonalQServicio();
        }

        #endregion
    }
}
