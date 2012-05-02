using System;
using System.Windows.Forms;
using CECLIMI.Contratos;
using Proxy;


namespace CECLIMI.Presentador
{
    public class PresentadorAgregarCirujano
    {
        private IContratoAgregarCirujano _vista;

        public PresentadorAgregarCirujano(IContratoAgregarCirujano vista)
        {
            _vista = vista;
        }

        /// <summary>
        /// Metodo que inserta un cirjuano
        /// </summary>
        /// <returns></returns>
        public bool InsertarCirujano()
        {
            bool respuesta = false;
            if(ComprobarCamposObligatorios() && ComprobarCampoNumericoCedula())
            {
                Cirujano cirujano = new Cirujano();
                ServicioCirujanoSoap logica = new ServicioCirujanoSoap();
                cirujano = logica.ObtenerInformacionCirujano(Convert.ToInt32(_vista.Cedula.Text));
                if ( cirujano.Nombre == null )
                {
                    cirujano.Nombre = _vista.PNombre.Text;
                    cirujano.SegundoNombre = _vista.SNombre.Text;
                    cirujano.PrimerApellido = _vista.PApellido.Text;
                    cirujano.SegundoApellido = _vista.SApellido.Text;
                    cirujano.TelefonoFijo = _vista.CodigoTelefonoFijo.Text + _vista.TelefonoFijo.Text;
                    cirujano.TelefonoMovil = _vista.CodigoTelefonoMovil.Text + _vista.TelefonoMovil.Text;
                    cirujano.Correo = _vista.CorreoElectronico.Text;
                    cirujano.Cedula = Convert.ToInt32(_vista.Cedula.Text);
                    logica.AgregarCirujano(cirujano);
                    respuesta = true;
                }
                else
                {
                    DialogResult result =
                        MessageBox.Show("Ya se encuentra un cirujano con esta cedula en el sistema.", "Alerta", MessageBoxButtons.OK);
                }
            }
            return respuesta;
        }

        /// <summary>
        /// Esta funcion comprueba si los campos obligatorios han sido llenado.
        /// </summary>
        /// <returns> retorna true en caso de que este bien y false en caso de que este mal.</returns>
        public bool ComprobarCamposObligatorios()
        {
            _vista.MensajePNombre.Visible = false;
            _vista.MensajePApellido.Visible = false;
            _vista.MensajeCedula.Visible = false;
            _vista.MensajeTelefonoMovil.Visible = false;
            bool respuesta = false;
            if (_vista.PNombre.Text.Length != 0)
                respuesta = true;
            else
                _vista.MensajePNombre.Visible = true;

            if (_vista.PApellido.Text.Length != 0)
                respuesta = true;
            else
                _vista.MensajePApellido.Visible = true;

            if (_vista.Cedula.Text.Length != 0)
                respuesta = true;
            else
            {
                _vista.MensajeCedula.Text = "Este campo es obligatorio";
                _vista.MensajeCedula.Visible = true;
            }

            if (_vista.TelefonoMovil.Text.Length != 0 && _vista.CodigoTelefonoMovil.Text.Length != 0)
                respuesta = true;
            else
                _vista.MensajeTelefonoMovil.Visible = true;

            return respuesta;
        }

        /// <summary>
        /// Metodo que comprueba el campo de cedula sea numerico
        /// </summary>
        /// <returns></returns>
        public bool ComprobarCampoNumericoCedula()
        {
            _vista.MensajeCedula.Visible = false;
            try
            {
                Convert.ToInt32(_vista.Cedula.Text);
                return true;
            }
            catch (Exception)
            {
                _vista.MensajeCedula.Text = "Cedula no puede contener caracteres numericos.";
                _vista.MensajeCedula.Visible = true;
                return false;
            }
        }
    }
}
