using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        #endregion

        #region Encapsulamiento
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
