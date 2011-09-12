using System;

namespace Entidades
{
    public class PersonalPaquete:Entidad
    {
        #region Atributos
        private String _especialidad;
        private CirugiaPqtFinanciero _cirugia = new CirugiaPqtFinanciero();
        private Persona _personal = new Persona();
        #endregion

        #region Encapsulamiento

        public String Especialidad
        {
            get { return _especialidad; }
            set { _especialidad = value; }
        }

        public CirugiaPqtFinanciero Cirugia
        {
            get { return _cirugia; }
            set { _cirugia = value; }
        }
        public Persona Personal
        {
            get { return _personal; }
            set { _personal = value; }
        }
        #endregion
    }
}
