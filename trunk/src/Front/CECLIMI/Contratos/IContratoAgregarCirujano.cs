using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CECLIMI.Contratos
{
    public interface IContratoAgregarCirujano
    {
        Label Etiqueta { get; }
        TextBox Texto { get; }
    }
}
