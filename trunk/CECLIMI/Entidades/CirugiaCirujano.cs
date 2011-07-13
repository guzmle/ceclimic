﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class CirugiaCirujano: Entidad
    {
        #region Atributos
        private float _honorarios;
        private Entidad _cirujano;
        private Entidad _cirugia;
        #endregion

        #region Encapsulamiento
        public float Honorarios
        {
            get { return _honorarios; }
            set { _honorarios = value; }
        }

        public Entidad Cirugia
        {
            get { return _cirugia; }
            set { _cirugia = value; }
        }
        public Entidad Cirujano
        {
            get { return _cirujano; }
            set { _cirujano = value; }
        }
        #endregion
    }
}