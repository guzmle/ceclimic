using System;
using EnlaceDatos;
using Entidades;
using NUnit.Framework;

namespace Prueba
{
    [TestFixture]
    public class PruebaCirujano
    {
        [TestCase]
        public void PruebaAgregarCirujano()
        {
            Cirujano cirujano = new Cirujano();

            cirujano.Nombre = "prueba";
            cirujano.SegundoNombre = "prueba";
            cirujano.PrimerApellido = "prueba";
            cirujano.SegundoApellido = "prueba";
            cirujano.TelefonoFijo = "5767299";
            cirujano.TelefonoMovil = "5767299";
            cirujano.Cedula = 18001107;
            cirujano.Correo = "prueba";

            bool respuesta = DAO.ObtenerDAO(1).ObtenerDAOCirujano().AgregarCirujano(cirujano);
            Assert.IsTrue(respuesta);
            
        }
    }
}
