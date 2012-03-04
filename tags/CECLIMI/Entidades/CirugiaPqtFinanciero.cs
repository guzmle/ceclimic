using System;
using System.Collections.Generic;

using System.Text;

namespace Entidades
{
    public class CirugiaPqtFinanciero:Entidad
    {
        #region Atributos
        private float _protesis;
        private float _descuento;
        private float _montoCirujano;
        private Cirugia _cirugia = new Cirugia();
        private Cirujano _cirujano = new Cirujano();
        private PaqueteFinanciero _paqueteFinanciero = new PaqueteFinanciero();
        #endregion

        #region Encapsulamiento

        public float MontoCirujano
        {
            get { return _montoCirujano; }
            set { _montoCirujano = value; }
        }
        public float Descuento
        {
            get { return _descuento; }
            set { _descuento = value; }
        }
        public Cirujano Cirujano
        {
            get { return _cirujano; }
            set { _cirujano = value; }
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
