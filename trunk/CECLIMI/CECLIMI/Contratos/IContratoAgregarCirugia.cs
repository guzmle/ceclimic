using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CECLIMI.Contratos
{
    public interface IContratoAgregarCirugia
    {
        TextBox TextNombre { get; }
        TextBox TextDescripcion { get; }
        Button BotonAceptar { get; }
    }
}
