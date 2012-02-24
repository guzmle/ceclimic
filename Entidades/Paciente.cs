using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    /// <summary>
    /// clase que mantiene el control de la entidad Paciente
    /// </summary>
    public class Paciente: Persona
    {
        #region Atributos
        private DateTime _fechaIngreso;
        private String _telefonoMovil;
        #endregion

        #region Encapsulamiento

        public DateTime FechaIngreso
        {
            get { return _fechaIngreso; }
            set { _fechaIngreso = value; }
        }

        public string TelefonoMovil
        {
            get { return _telefonoMovil; }
            set { _telefonoMovil = value; }
        }

        #endregion
       
    }
}
