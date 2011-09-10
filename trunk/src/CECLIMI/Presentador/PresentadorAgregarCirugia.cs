using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CECLIMI.Contratos;
using Entidades;
using Logica;

namespace CECLIMI.Presentador
{
     
    public class PresentadorAgregarCirugia
    {
        private IContratoAgregarCirugia _vista;

        public PresentadorAgregarCirugia (IContratoAgregarCirugia vista)
        {
            _vista = vista;
        }

        public void BotonAceptar ()
        {
            LCirugia logica = new LCirugia();
            Cirugia cirugia = new Cirugia();

            cirugia.Nombre = _vista.TextNombreCirugia.Text;
            cirugia.Descripcion = _vista.TextDescripcionCirugia.Text;

            logica.AgregarCirugia(cirugia);
        }
    }
}
