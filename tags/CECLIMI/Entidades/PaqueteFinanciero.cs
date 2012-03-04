using System;
using System.Collections.Generic;

using System.Text;

namespace Entidades
{
    public class PaqueteFinanciero: Entidad
    {
        #region Atributos
        private DateTime _fechaPaquete;
        private DateTime _fechaLimite;
        private Paciente _paciente = new Paciente();
        private DateTime _fechaOperacion;
        private string _observacion;
        #endregion

        #region Encapsulamiento

        public DateTime FechaOperacion
        {
            get { return _fechaOperacion; }
            set { _fechaOperacion = value; }
        }
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

        public Paciente Paciente
        {
            get { return _paciente; }
            set { _paciente = value; }
        }

        public string Observacion
        {
            get { return _observacion; }
            set { _observacion = value; }
        }

        #endregion
    }
}
