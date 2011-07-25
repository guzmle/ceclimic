using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CECLIMI.Contratos;

namespace CECLIMI.Presentador
{
    public class PresentadorModificarPaciente
    {
        private IContratoModificarPaciente _vista;

        public PresentadorModificarPaciente(IContratoModificarPaciente vista)
        {
            _vista = vista;
        }

        //mostrar informacion del paciente cuando se presiona el boton buscar.
        public void BuscarInformacionPaciente()
        {
            _vista.PrimerNombre.Visible = _vista.SegundoNombre.Visible = _vista.PrimerApellido.Visible = _vista.SegundoApellido.Visible = true;
            _vista.CiPaciente.Visible = _vista.TelefonoFijo.Visible = _vista.TelefonoMovil.Visible = _vista.CorreoElectronico.Visible = true;
            _vista.TextPrimerNombre.Visible = _vista.TextSegundoNombre.Visible = _vista.TextPrimerApellido.Visible = _vista.TextSegundoApellido.Visible = true;
            _vista.TextoCiPaciente.Visible = _vista.TextCodigoAreaFijo.Visible = _vista.TextCodigoAreaMovil.Visible = _vista.TextTelefonoFijo.Visible = true;
            _vista.TextTelefonoMovil.Visible = _vista.TextCorreoElectronico.Visible = _vista.TextIdPaciente.Visible = true;
        }
    }
}
