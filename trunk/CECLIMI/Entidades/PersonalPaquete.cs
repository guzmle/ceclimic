using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class PersonalPaquete
    {
        #region Atributos
        private String _especialidad;
        private DateTime _fechaLimite;
        private Entidad _cirugia;
        private Entidad _personal;
        #endregion

        #region Encapsulamiento

        public String Especialidad
        {
            get { return _especialidad; }
            set { _especialidad = value; }
        }

        public DateTime FechaLimite
        {
            get { return _fechaLimite; }
            set { _fechaLimite = value; }
        }

        public Entidad Cirugia
        {
            get { return _cirugia; }
            set { _cirugia = value; }
        }
        public Entidad Personal
        {
            get { return _personal; }
            set { _personal = value; }
        }
        #endregion
    }
}
