using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    /// <summary>
    /// clase que mantiene el control de la entidad Paciente
    /// </summary>
    public class Paciente: Entidad
    {
        #region Atributos
        private String _segundoNombre;
        private String _primerApellido;
        private String _segundoApellido;
        private String _telefono;
        private String _correo;
        private DateTime _fechaIngreso;
        #endregion

        #region Encapsulamiento

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

        public DateTime FechaIngreso
        {
            get { return _fechaIngreso; }
            set { _fechaIngreso = value; }
        }
        
        #endregion
       
    }
}
