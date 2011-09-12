namespace Entidades
{
    public class Transferencia : Entidad
    {
        #region Atributos

        private float _monto;
        private Persona _pacienteOtorga = new Persona();
        private Persona _pacienteRecibe = new Persona();
        #endregion

        #region Encapsulamiento
        public float Monto
        {
            get { return _monto; }
            set { _monto = value; }
        }
        public Persona PacienteOtorga
        {
            get { return _pacienteOtorga; }
            set { _pacienteOtorga = value; }
        }
        public Persona PacienteRecibe
        {
            get { return _pacienteRecibe; }
            set { _pacienteRecibe = value; }
        }
        #endregion
    }
}
