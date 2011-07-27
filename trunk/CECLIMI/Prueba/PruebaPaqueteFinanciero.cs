using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Entidades;
using EnlaceDatos;

namespace Prueba
{
    [TestFixture]
    public class PruebaPaqueteFinanciero
    {
        [TestCase]
        public void PruebaAgregarPaqueteFinanciero()
        {

            PaqueteFinanciero paquete = new PaqueteFinanciero();

            paquete.Paciente.Id = 1;
            //paquete.Cirujano.Id = 1;
            paquete.FechaLimite = new DateTime(2010, 12, 20);
            paquete.FechaPaquete = new DateTime(2010, 12, 31);
            int respuesta = DAO.ObtenerDAO(1).ObtenerDAOPaqueteFinanciero().AgregarPaqueteFinanciero(paquete);
            Console.WriteLine(respuesta);
            bool h = false;
            if (respuesta != -1)
                h = true;
            Assert.IsTrue(h);
        }
    }
}
