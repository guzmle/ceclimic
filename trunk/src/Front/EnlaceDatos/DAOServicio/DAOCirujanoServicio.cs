using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnlaceDatos.IDAO;
using Proxy.ProxyCirujano;
using Cirujano = Entidades.Cirujano;
using Entidad = Entidades.Entidad;
using CirujanoServicio = Proxy.ProxyCirujano.Cirujano;
using EntidadServicio = Proxy.ProxyCirujano.Entidad;

namespace EnlaceDatos.DAOServicio
{
    class DAOCirujanoServicio: IDAOCirujano 
    {
        #region Implementation of IDAOCirujano

        public bool AgregarCirujano(Cirujano cirujano)
        {
            throw new NotImplementedException();
        }

        public bool EliminarCirujano(Entidad cirujano)
        {
            throw new NotImplementedException();
        }

        public bool EditarCirujano(Cirujano cirujano)
        {
            try
            {
                ServicioCirujano servicio = new ServicioCirujano();
                CirujanoServicio cirujanoServicio = new CirujanoServicio();

                cirujanoServicio.Cedula = cirujano.Cedula;
                cirujanoServicio.Correo = cirujano.Correo;
                cirujanoServicio.Nombre = cirujano.Nombre;
                cirujanoServicio.PrimerApellido = cirujano.PrimerApellido;
                cirujanoServicio.SegundoApellido = cirujano.SegundoApellido;
                cirujanoServicio.SegundoNombre = cirujano.SegundoNombre;
                cirujanoServicio.Telefono = cirujano.Telefono;
                cirujanoServicio.TelefonoMovil = cirujano.TelefonoMovil;
                cirujanoServicio.TelefonoFijo = cirujano.TelefonoFijo;
                return servicio.EditarCirujano(cirujanoServicio);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Cirujano ObtenerInformacionCirujano(int cedula)
        {
            try
            {

                ServicioCirujano servicio = new ServicioCirujano();
                CirujanoServicio cirujanoServicio = servicio.ObtenerInformacionCirujano(cedula);
                Cirujano cirujano = new Cirujano();
                cirujano.Id = cirujanoServicio.Id;
                cirujano.Cedula = cirujanoServicio.Cedula;
                cirujano.Correo = cirujanoServicio.Correo;
                cirujano.Nombre = cirujanoServicio.Nombre;
                cirujano.PrimerApellido = cirujanoServicio.PrimerApellido;
                cirujano.SegundoApellido = cirujanoServicio.SegundoApellido;
                cirujano.SegundoNombre = cirujanoServicio.SegundoNombre;
                cirujano.Telefono = cirujanoServicio.Telefono;
                cirujano.TelefonoMovil = cirujanoServicio.TelefonoMovil;
                cirujano.TelefonoFijo = cirujanoServicio.TelefonoFijo;
                return cirujano;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Cirujano> ObtenerCirujanos(Entidad cirugia)
        {
            List<Cirujano> retorno = new List<Cirujano>();
            try
            {
                CirujanoServicio entidad = new CirujanoServicio();
                entidad.Id = cirugia.Id;
                ServicioCirujano servicio = new ServicioCirujano();
                foreach (var cirujanoServicio in servicio.ObtenerCirujanos( entidad))
                {
                    Cirujano cirujano = new Cirujano();
                    cirujano.Id = cirujanoServicio.Id;
                    cirujano.Cedula = cirujanoServicio.Cedula;
                    cirujano.Correo = cirujanoServicio.Correo;
                    cirujano.Nombre = cirujanoServicio.Nombre;
                    cirujano.PrimerApellido = cirujanoServicio.PrimerApellido;
                    cirujano.SegundoApellido = cirujanoServicio.SegundoApellido;
                    cirujano.SegundoNombre = cirujanoServicio.SegundoNombre;
                    cirujano.Telefono = cirujanoServicio.Telefono;
                    cirujano.TelefonoMovil = cirujanoServicio.TelefonoMovil;
                    cirujano.TelefonoFijo = cirujanoServicio.TelefonoFijo;
                    retorno.Add(cirujano);
                }
                
                
                return retorno;

            }
            catch (Exception)
            {
                return retorno;
            }
        }

        #endregion
    }
}
