using System;
using System.Collections.Generic;

using System.Text;
using Entidades;

namespace EnlaceDatos.IDAO
{
    public interface IDAOPaciente
    {
        bool AgregarPaciente(Paciente paciente);
        bool EditarPaciente(Paciente paciente);
        bool EliminarPaciente(Entidad paciente);
        int ValidarPacienteExistente(int cedula);
        Paciente ObtenerInformacionPaciente(int cedula);
        List<Paciente> ObtenerCirugiasPaciente(int cedula);
    }
}
