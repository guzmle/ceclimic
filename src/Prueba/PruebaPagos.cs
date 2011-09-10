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
    public class PruebaPagos
    {
        [TestCase]
        public void PruebaAgregarPagos()
        {
            Pago pago = new Pago();
            pago.Id = 22;
            pago.Monto = 222;
            pago.Nombre = "mama";
            pago.Fecha = DateTime.Now;
            pago.Seguro = "Caracas";
            pago.TipoPago = "pre";
            pago.Usuario.Id = 2;
            bool respuesta = DAO.ObtenerDAO(1).ObtenerDAOPagos().AgregarPago(pago);
            Assert.IsTrue(respuesta);
        }
        [TestCase]
        public void PruebaValidarPago()
        {
            int respuesta = DAO.ObtenerDAO(1).ObtenerDAOPagos().ValidarPagoExistente(2);
            Assert.IsNull(respuesta);
        }
    }
}
