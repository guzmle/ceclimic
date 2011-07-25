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
        /// <param name="paciente"></param>
        /// <returns></returns>
        public bool AgregarPaciente(Paciente paciente)
        {
            
            return DAO.ObtenerDAO(1).ObtenerDAOPaciente().AgregarPaciente(paciente);
        }
    }
}
