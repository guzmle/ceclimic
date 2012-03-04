using System;
using System.Collections.Generic;

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
            int respuesta = DAO.ObtenerDAO(1).ObtenerDAOCirugia().AgregarCirugia(cirugia);
            bool h = false;
            if (respuesta != -1)
                h = true;
            Assert.IsTrue(h);
        }
    }
}
