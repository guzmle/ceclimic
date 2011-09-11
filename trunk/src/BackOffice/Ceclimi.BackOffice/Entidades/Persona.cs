using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Persona: Entidad
    {
        #region Atributos
        private long _cedula;
        private String _segundoNombre;
        private String _primerApellido;
        private String _segundoApellido;
        private String _telefono;
        private String _correo;
        #endregion

        #region Encapsulamiento

        public long Cedula
        {
            get { return _cedula; }
            set { _cedula = value; }
        }

        public string SegundoNombre
        {
            get { return _segundoNombre; }
            set { _segundoNombre = value; }
        }

        public string PrimerApellido
        {
            get { return _primerApellido; }
            set { _primerApellido = value; }
        }

        public string SegundoApellido
        {
            get { return _segundoApellido; }
            set { _segundoApellido = value; }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public string Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }

        #endregion
    }
}
