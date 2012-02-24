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
    public class PruebaCirugiaPaqueteFinanciero
    {
        [TestCase]
        public void PruebaAgregarCirugiaPaqueteFinanciero()
        {
            CirugiaPqtFinanciero cirugiaPqtFinanciero = new CirugiaPqtFinanciero();
            cirugiaPqtFinanciero.Protesis = 500;
            cirugiaPqtFinanciero.Cirugia.Id = 1;
            cirugiaPqtFinanciero.Cirujano.Id = 1;
            cirugiaPqtFinanciero.PaqueteFinanciero.Id = 1;
            
            int respuesta = DAO.ObtenerDAO(1).ObtenerDAOCirugiaPaquete().AgregarCirugiaPaquete(cirugiaPqtFinanciero);
            bool h = false;
            if (respuesta!= -1)
                h = true;

            //cirugiaPqtFinanciero.Descripcion = "Descripcion";
            //bool respuesta = DAO.ObtenerDAO(1).ObtenerDAOCirugia().AgregarCirugia(cirugia);
            Assert.IsTrue(h);
        }
    }
}
