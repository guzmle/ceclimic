using System;

namespace Entidades
{
    public class Usuario:Persona
    {
        #region Atributos

        private String _apodo;
        private String _password;
        #endregion

        #region Encapsulamiento
        public string Apodo
        {
            get { return _apodo; }
            set { _apodo = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        #endregion
    }
}
