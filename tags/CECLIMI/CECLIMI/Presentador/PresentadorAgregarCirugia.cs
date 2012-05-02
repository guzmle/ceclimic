using System.Windows.Forms;
using CECLIMI.Contratos;
using Proxy;

namespace CECLIMI.Presentador
{
     
    public class PresentadorAgregarCirugia
    {
        private IContratoAgregarCirugia _vista;

        public PresentadorAgregarCirugia (IContratoAgregarCirugia vista)
        {
            _vista = vista;
        }

        public long BotonAceptar ()
        {
            _vista.MensajeDeError.Visible = false;
            long respuesta = -1;
            if (ComprobarCamposObligatorios())
            {
                ServicioCirugiaSoap logica = new ServicioCirugiaSoap();
                Cirugia cirugia = new Cirugia();
                cirugia.Nombre = _vista.TextNombreCirugia.Text;
                cirugia.Descripcion = _vista.TextDescripcionCirugia.Text;
                respuesta = logica.AgregarCirugia(cirugia);
                DialogResult result =
                        MessageBox.Show("Cirugia Agregada Correctamente.", "Transaccion Correcta", MessageBoxButtons.OK);
            }
            return respuesta;
        }

        /// <summary>
        /// Esta funcion comprueba si los campos obligatorios han sido llenado.
        /// </summary>
        /// <returns> retorna true en caso de que este bien y false en caso de que este mal.</returns>
        public bool ComprobarCamposObligatorios()
        {
            bool respuesta = false;
            if (_vista.TextNombreCirugia.Text.Length != 0)
                respuesta = true;
            else
                _vista.MensajeDeError.Visible = true;
            return respuesta;
        }
    }
}
