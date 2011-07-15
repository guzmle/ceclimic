using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CECLIMI.Contratos;

namespace CECLIMI.Presentador
{
    public class PresentadorAgregarCirujano
    {
        private IContratoAgregarCirujano _vista;

        public PresentadorAgregarCirujano(IContratoAgregarCirujano vista)
        {
            _vista = vista;
        }

        public void AccionBoton()
        {
            _vista.Etiqueta.Text = _vista.Texto.Text;
        }
    }
}
