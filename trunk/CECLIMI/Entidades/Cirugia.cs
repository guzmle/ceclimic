using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    /// <summary>
    /// clase que hace referencia a la tabla cirugia de la base de datos en el sistema
    /// </summary>
    public class Cirugia: Entidad
    {
        #region Atributos

        private String _descripcion;
        #endregion

        #region Encapsulamiento
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        #endregion
    }
}
