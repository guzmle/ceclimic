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
    public class PruebaCirugiaPersonalQ
    {
        [TestCase]
        public void PruebaAgregarCirugiaPersonalQ()
        {
            PersonalPaquete personalPaquete = new PersonalPaquete();
            personalPaquete.Paquete.Id = 1;
            personalPaquete.Personal.Id = 1;
            personalPaquete.Especialidad = "1er ayudante";
            
            bool respuesta =
                DAO.ObtenerDAO(1).ObetenerDAOCirugiaPaquetePersonalQ().AgregarCirugiaPaquetePersonalQ(personalPaquete);
            Assert.IsTrue(respuesta);
        }
    }
}
