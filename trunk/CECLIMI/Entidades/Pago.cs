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
        private Entidad _usuario;
        #endregion

        #region Encapsulamiento
        public float Descripcion
        {
            get { return _monto; }
            set { _monto = value; }
        }
        public Entidad Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        #endregion
    }
}
