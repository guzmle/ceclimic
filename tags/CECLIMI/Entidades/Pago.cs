using System;
using System.Collections.Generic;

using System.Text;

namespace Entidades
{
    /// <summary>
    /// clase que hace referencia a la tabla pago de la base de datos en el sistema
    /// </summary>
    public class Pago:Entidad
    {
        #region Atributos
        private string _factura;
        private float _monto;
        private DateTime _fecha;
        private string _seguro;
        private string _tipoPago;
        private PaqueteFinanciero _paquete = new PaqueteFinanciero();
        private Paciente _paciente = new Paciente();
        #endregion

        #region Encapsulamiento
        public string TipoPago
        {
            get { return _tipoPago; }
            set { _tipoPago = value; }
        }
        public string Seguro
        {
            get { return _seguro; }
            set { _seguro = value; }
        }
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        public float Monto
        {
            get { return _monto; }
            set { _monto = value; }
        }

        public string Factura
        {
            get { return _factura; }
            set { _factura = value; }
        }

        public PaqueteFinanciero Paquete
        {
            get { return _paquete; }
            set { _paquete = value; }
        }

        public Paciente Paciente
        {
            get { return _paciente; }
            set { _paciente = value; }
        }

        #endregion
    }
}
