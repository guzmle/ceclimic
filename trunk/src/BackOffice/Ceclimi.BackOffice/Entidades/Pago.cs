using System;

namespace Entidades
{
    /// <summary>
    /// clase que hace referencia a la tabla pago de la base de datos en el sistema
    /// </summary>
    public class Pago:Entidad
    {
        #region Atributos

        private float _monto;
        private Persona _usuario = new Persona();
        private DateTime _fecha;
        private String _seguro;
        private String _tipoPago;
        #endregion

        #region Encapsulamiento
        public String TipoPago
        {
            get { return _tipoPago; }
            set { _tipoPago = value; }
        }
        public String Seguro
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
        public Persona Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        #endregion
    }
}
