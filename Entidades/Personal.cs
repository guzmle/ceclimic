using System;
using System.Collections.Generic;

using System.Text;

namespace Entidades
{
    public class Personal: Persona
    {
        #region Atributos

        private String _especializacion;
        #endregion

        #region Encapsulamiento
        public string Especializacion
        {
            get { return _especializacion; }
            set { _especializacion = value; }
        }
        #endregion
    }
}
