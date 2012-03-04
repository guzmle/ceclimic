using System.Windows.Forms;

namespace CECLIMI.Contratos
{
    /// <summary>
    /// Clase que hace de contrato para la vista de agregar beremo de operaciones
    /// </summary>
    public interface IContratoBeremoDeOperaciones
    {
        ComboBox UxCirujanos { get; }
        GroupBox UxGrupoBeremo { get; }
        DataGridView UxGridBeremo { get; }
        Button UxBotonAceptar { get; }
    }
}
