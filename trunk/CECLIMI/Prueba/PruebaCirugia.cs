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
    public class PruebaCirugia
    {
        [TestCase]
        public void PruebaAgregarCirugia()
        {
            Cirugia cirugia = new Cirugia();
            cirugia.Nombre = "Cirugia";
            cirugia.Descripcion = "Descripcion";
            bool respuesta = DAO.ObtenerDAO(1).ObtenerDAOCirugia().AgregarCirugia(cirugia);
            Assert.IsTrue(respuesta);
        }
    }
}
