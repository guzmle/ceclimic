using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnlaceDatos.IDAO;
using Proxy.ProxyPaciente;
using Entidad = Entidades.Entidad;
using Paciente = Entidades.Paciente;
using PacienteServicio = Proxy.ProxyPaciente.Paciente;
namespace EnlaceDatos.DAOServicio
{
    class DAOPacienteServicio: IDAOPaciente
    {
        #region Implementation of IDAOPaciente
        /// <summary>
        /// Metodo que agrega un paciente a la base datos
        /// </summary>
        /// <param name="paciente"></param>
        /// <returns></returns>
        public bool AgregarPaciente(Paciente paciente)
        {
            try
            {
                PacienteServicio pacienteServicio = new PacienteServicio();
                ServicioPaciente servicio = new ServicioPaciente();

                pacienteServicio.Cedula = paciente.Cedula;
                pacienteServicio.Correo = paciente.Correo;
                pacienteServicio.FechaIngreso = paciente.FechaIngreso;
                pacienteServicio.Nombre = paciente.Nombre;
                pacienteServicio.PrimerApellido = paciente.PrimerApellido;
                pacienteServicio.SegundoApellido = paciente.SegundoApellido;
                pacienteServicio.SegundoNombre = paciente.SegundoNombre;
                pacienteServicio.Telefono = paciente.Telefono;
                pacienteServicio.TelefonoMovil = paciente.TelefonoMovil;

                servicio.AgregarPaciente(pacienteServicio);
                return true;
            }catch(Exception)
            {
                return false;
            }
 
        }

        /// <summary>
        /// Metodo que edita los datos de un paciente
        /// </summary>
        /// <param name="paciente"></param>
        /// <returns></returns>
        public bool EditarPaciente(Paciente paciente)
        {
            try
            {
                PacienteServicio pacienteServicio = new PacienteServicio();
                ServicioPaciente servicio = new ServicioPaciente();

                pacienteServicio.Id = paciente.Id;
                pacienteServicio.Cedula = paciente.Cedula;
                pacienteServicio.Correo = paciente.Correo;
                pacienteServicio.FechaIngreso = paciente.FechaIngreso;
                pacienteServicio.Nombre = paciente.Nombre;
                pacienteServicio.PrimerApellido = paciente.PrimerApellido;
                pacienteServicio.SegundoApellido = paciente.SegundoApellido;
                pacienteServicio.SegundoNombre = paciente.SegundoNombre;
                pacienteServicio.Telefono = paciente.Telefono;
                pacienteServicio.TelefonoMovil = paciente.TelefonoMovil;

                servicio.EditarPaciente(pacienteServicio);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Metodo que elimina un paciente de la base de datos
        /// </summary>
        /// <param name="paciente"></param>
        /// <returns></returns>
        public bool EliminarPaciente(Entidad paciente)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Metodo que valida que un paciente exista
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        public int ValidarPacienteExistente(int cedula)
        {
            try
            {
                PacienteServicio pacienteServicio = new PacienteServicio();
                ServicioPaciente servicio = new ServicioPaciente();


                int retorno = servicio.ValidarPacienteExistente(cedula);
                return retorno;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        /// <summary>
        /// Metodo que obtiene los datos de un paciente dado su cedula
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        public Paciente ObtenerInformacionPaciente(int cedula)
        {
            try
            {
                Paciente paciente = new Paciente();
                ServicioPaciente servicio = new ServicioPaciente();
                PacienteServicio pacienteServicio =
                servicio.ObtenerInformacionPaciente(cedula);

                paciente.Id = pacienteServicio.Id;
                paciente.Cedula = pacienteServicio.Cedula;
                paciente.Correo = pacienteServicio.Correo;
                paciente.FechaIngreso = pacienteServicio.FechaIngreso;
                paciente.Nombre = pacienteServicio.Nombre;
                paciente.PrimerApellido = pacienteServicio.PrimerApellido;
                paciente.SegundoApellido = pacienteServicio.SegundoApellido;
                paciente.SegundoNombre = pacienteServicio.SegundoNombre;
                paciente.Telefono = pacienteServicio.Telefono;
                paciente.TelefonoMovil = pacienteServicio.TelefonoMovil;

                return paciente;
            }
            catch (Exception)
            {
                return new Paciente();
            }
        }

        /// <summary>
        /// Metodo que obtiene ls
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        public List<Paciente> ObtenerCirugiasPaciente(int cedula)
        {
            List<Paciente> retorno = new List<Paciente>();
            try
            {
                ServicioPaciente servicio = new ServicioPaciente();
                foreach (PacienteServicio pacienteServicio in servicio.ObtenerCirugiasPaciente(cedula))
                {
                    Paciente paciente = new Paciente();
                    paciente.Id = pacienteServicio.Id;
                    paciente.Cedula = pacienteServicio.Cedula;
                    paciente.Correo = pacienteServicio.Correo;
                    paciente.FechaIngreso = pacienteServicio.FechaIngreso;
                    paciente.Nombre = pacienteServicio.Nombre;
                    paciente.PrimerApellido = pacienteServicio.PrimerApellido;
                    paciente.SegundoApellido = pacienteServicio.SegundoApellido;
                    paciente.SegundoNombre = pacienteServicio.SegundoNombre;
                    paciente.Telefono = pacienteServicio.Telefono;
                    paciente.TelefonoMovil = pacienteServicio.TelefonoMovil;
                    retorno.Add(paciente);
                    
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
