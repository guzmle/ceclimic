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
        private Cirujano _cirujano = new Cirujano();
        private Cirugia _cirugia = new Cirugia();
        #endregion
        #region Constructores

        public CirugiaCirujano()
        {
            _cirugia = new Cirugia();
            _cirujano = new Cirujano();
        }
        #endregion

        #region Encapsulamiento
        public float Honorarios
        {
            get { return _honorarios; }
            set { _honorarios = value; }
        }

        public Cirugia Cirugia
        {
            get { return _cirugia; }
            set { _cirugia = value; }
        }
        public Cirujano Cirujano
        {
            get { return _cirujano; }
            set { _cirujano = value; }
        }
        #endregion
    }
}
