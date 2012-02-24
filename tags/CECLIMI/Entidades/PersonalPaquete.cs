using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class PersonalPaquete:Entidad
    {
        #region Atributos
        private String _especialidad;
        private PaqueteFinanciero _paquete = new PaqueteFinanciero();
        private Persona _personal = new Persona();
        #endregion

        #region Encapsulamiento

        public String Especialidad
        {
            get { return _especialidad; }
            set { _especialidad = value; }
        }

        public PaqueteFinanciero Paquete
        {
            get { return _paquete; }
            set { _paquete = value; }
        }
        public Persona Personal
        {
            get { return _personal; }
            set { _personal = value; }
        }
        #endregion
    }
}
