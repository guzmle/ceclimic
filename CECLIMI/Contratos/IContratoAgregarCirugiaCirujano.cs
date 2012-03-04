using System.Windows.Forms;

namespace CECLIMI.Contratos
{
    /// <summary>
    /// Clase que hace de contrato para la vista de agregar cirujia cirujano 
    /// </summary>
    public interface IContratoAgregarCirugiaCirujano
    {
        #region Grupo para iniciar la busqueda
        GroupBox GrupoInfoCirujano { get; }
        TextBox CedulaCirujano { get; }
        Button BotonBuscar { get; }
        #endregion

        #region Grupo Informacion cirujano
        GroupBox GrupoDatosCirujano { get; }
        Label UxNombre { get; }
        Label UxApellido { get; }
        Label UxCedula { get; }
        Label UxCorreo { get; }
        Label UxTelefonoFijo { get; }
        Label UxTelefonoMovil { get; }
        #endregion

        #region Grupo Cirugias agregar
        GroupBox GrupoCirugias { get; }
        ComboBox UxComboCirugias { get; }
        TextBox UxMontoCirugia { get; }
        Button BotonAgregarIqx { get; }
        Button BotonEliminarIqx { get; }
        DataGridView GridCirugiasAgregar { get; }
        #endregion

        Button BotonAceptar { get; }
        Button BotonCancelar { get; }
    }
}
