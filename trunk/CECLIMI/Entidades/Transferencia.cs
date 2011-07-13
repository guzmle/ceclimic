using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Transferencia : Entidad
    {
        #region Atributos

        private float _monto;
        private Entidad _pacienteOtorga;
        private Entidad _pacienteRecibe;
        #endregion

        #region Encapsulamiento
        public float Descripcion
        {
            get { return _monto; }
            set { _monto = value; }
        }
        public Entidad PacienteOtorga
        {
            get { return _pacienteOtorga; }
            set { _pacienteOtorga = value; }
        }
        public Entidad PacienteRecibe
        {
            get { return _pacienteRecibe; }
            set { _pacienteRecibe = value; }
        }
        #endregion
    }
}
