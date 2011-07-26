using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class CirugiaPqtFinanciero:Entidad
    {
        #region Atributos
        private DateTime _fechaOperacion;
        private PaqueteFinanciero _paqueteFinanciero = new PaqueteFinanciero();
        private Cirugia _cirugia = new Cirugia();
        private float _protesis;
        private Cirujano _cirujano = new Cirujano();
        #endregion

        #region Encapsulamiento

        public Cirujano Cirujano
        {
            get { return _cirujano; }
            set { _cirujano = value; }
        }
        public DateTime FechaOperacion
        {
            get { return _fechaOperacion; }
            set { _fechaOperacion = value; }
        }

        public Cirugia Cirugia
        {
            get { return _cirugia; }
            set { _cirugia = value; }
        }
        public PaqueteFinanciero PaqueteFinanciero
        {
            get { return _paqueteFinanciero; }
            set { _paqueteFinanciero = value; }
        }

        public float Protesis
        {
            get { return _protesis; }
            set { _protesis = value; }
        }

        #endregion
    }
}
