using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnlaceDatos;
using Entidades;
using NUnit.Framework;

namespace Prueba
{
    [TestFixture]
    public class PruebaPaciente
    {
        [TestCase]
        public void PruebaAgregarPaciente()
        {
            Paciente paciente = new Paciente();

            paciente.Nombre = "prueba";
            paciente.SegundoNombre = "prueba";
            paciente.PrimerApellido = "prueba";
            paciente.SegundoApellido = "prueba";
            paciente.Telefono = "5767299";
            paciente.TelefonoMovil = "5767299";
            paciente.Cedula = 18001107;
            paciente.FechaIngreso = new DateTime(2010,12,12);
            paciente.Correo = "prueba";

            bool respuesta = DAO.ObtenerDAO(1).ObtenerDAOPaciente().AgregarPaciente(paciente);
            Assert.IsTrue(respuesta);
        }
    }
}
