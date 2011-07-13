using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class CirugiaPqtFinanciero
    {
        #region Atributos
        private DateTime _fechaOperacion;
        private Entidad _paqueteFinanciero;
        private Entidad _cirugia;
        #endregion

        #region Encapsulamiento

        public DateTime FechaOperacion
        {
            get { return _fechaOperacion; }
            set { _fechaOperacion = value; }
        }

        public Entidad Cirugia
        {
            get { return _cirugia; }
            set { _cirugia = value; }
        }
        public Entidad PaqueteFinanciero
        {
            get { return _paqueteFinanciero; }
            set { _paqueteFinanciero = value; }
        }
        #endregion
    }
}
