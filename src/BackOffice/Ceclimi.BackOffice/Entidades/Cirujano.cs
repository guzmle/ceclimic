using System;

namespace Entidades
{
    /// <summary>
    /// clase que hace referencia a la tabla cirujnao de la base de datos en el sistema
    /// </summary>
    public class Cirujano: Persona
    {
        #region Atributos
        private String _telefonoMovil;
        private String _telefonoFijo;
        #endregion

        #region Encapsulamiento
        public string TelefonoMovil
        {
            get { return _telefonoMovil; }
            set { _telefonoMovil = value; }
        }
        public string TelefonoFijo
        {
            get { return _telefonoFijo; }
            set { _telefonoFijo = value; }
        }
        #endregion
    }
}
