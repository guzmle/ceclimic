using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CECLIMI.Contratos
{
    public interface IContratoBeremoDeOperaciones
    {
        ComboBox UxCirujanos { get; }
        GroupBox UxGrupoBeremo { get; }
        DataGridView UxGridBeremo { get; }
        Button UxBotonAceptar { get; }
    }
}
