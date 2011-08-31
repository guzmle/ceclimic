using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnlaceDatos;
using Entidades;

namespace Logica
{
    /// <summary>
    /// Todos los metodos que lleva la logica de negocio con la entidad paciente
    /// </summary>
    public class LPaciente
    {
        /// <summary>
        /// metodo que se encarga de la logica de agregar paciente
        /// </summary>
        public bool AgregarPaciente(Paciente paciente)
        {
            return DAO.ObtenerDAO(1).ObtenerDAOPaciente().AgregarPaciente(paciente);
        }

        /// <summary>
        /// metodo que revisa si el paciente que va a ser agregado no existe en el sistema
        /// </summary>
        public int ValidarPacienteExistente(int cedula)
        {
            return DAO.ObtenerDAO(1).ObtenerDAOPaciente().ValidarPacienteExistente(cedula);
        }

        /// <summary>
        /// metodo que obtiene la informacion de un paciente consultado.
        /// </summary>
        public Paciente ObtenerInformacionPaciente(int cedula)
        {
            return DAO.ObtenerDAO(1).ObtenerDAOPaciente().ObtenerInformacionPaciente(cedula);
        }

        /// <summary>
        /// metodo que modifica la informacion de un paciente
        /// </summary>
        public bool EditarPaciente(Paciente paciente)
        {
            return DAO.ObtenerDAO(1).ObtenerDAOPaciente().EditarPaciente(paciente);
        }

        /// <summary>
        /// metodo que obtiene las cirugias pertenecientes a un paciente
        /// </summary>
        public List<Paciente> ObtenerCirugiasPaciente(int cedula)
        {
            return DAO.ObtenerDAO(1).ObtenerDAOPaciente().ObtenerCirugiasPaciente(cedula);
        }
    }
}
