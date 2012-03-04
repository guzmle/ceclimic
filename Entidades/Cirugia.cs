﻿using System;
using System.Collections.Generic;

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
        private Cirujano _cirujano = new Cirujano();
        #endregion

        #region Encapsulamiento
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public Cirujano Cirujano
        {
            get { return _cirujano; }
            set { _cirujano = value; }
        }

        #endregion
    }
}
