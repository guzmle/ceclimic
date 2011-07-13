using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class PaqueteFinanciero
    {
        #region Atributos
        private DateTime _fechaPaquete;
        private DateTime _fechaLimite;
        private Entidad _cirujano;
        private Entidad _paciente;
        #endregion

        #region Encapsulamiento

        public DateTime FechaPaquete
        {
            get { return _fechaPaquete; }
            set { _fechaPaquete = value; }
        }

        public DateTime FechaLimite
        {
            get { return _fechaLimite; }
            set { _fechaLimite = value; }
        }

        public Entidad Cirujano
        {
            get { return _cirujano; }
            set { _cirujano = value; }
        }
        public Entidad Paciente
        {
            get { return _paciente; }
            set { _paciente = value; }
        }
        #endregion
    }
}
