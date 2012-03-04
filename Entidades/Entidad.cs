using System;
using System.Collections.Generic;

using System.Text;

namespace Entidades
{
    public abstract class Entidad
    {
        #region Atributos

        private long _id;
        private String _nombre;

        #endregion

        #region Encapsulamiento
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        
        #endregion

        
    }
}
