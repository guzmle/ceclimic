using System;
using System.Collections.Generic;

using System.Text;
using System.Windows.Forms;
using CECLIMI.Contratos;

using Proxys;


namespace CECLIMI.Presentador
{
    public class PresentadorModificarCirujano
    {
        ServicioCirujanoSoap ServicioCirujanoSoap = new ServicioCirujanoSoap();
        Cirujano cirujano = new Cirujano();
        private IContratoModificarCirujano _vista;
        private int cirujanoBuscado = 0;
        public PresentadorModificarCirujano (IContratoModificarCirujano vista)
        {
            _vista = vista;
        }

        public void BuscarCirujano ()
        {
            cirujano = ServicioCirujanoSoap.ObtenerInformacionCirujano(Convert.ToInt32(_vista.TextCiCirujano.Text));
            if (cirujano.Nombre != null)
            {
                _vista.TextPrimerNombre.Text = cirujano.Nombre;
                _vista.TextSegundoNombre.Text = cirujano.SegundoNombre;
                _vista.TextPrimerApellido.Text = cirujano.PrimerApellido;
                _vista.TextSegundoApellido.Text = cirujano.SegundoApellido;
                if (cirujano.Telefono.Length > 1)
                {
                    _vista.TextCodigoAreaFijo.Text = cirujano.Telefono.Substring(0, 3);
                    _vista.TextTelefonoFijo.Text = cirujano.Telefono.Substring(3);
                }
                if (cirujano.TelefonoMovil.Length > 1)
                {
                    _vista.TextCodigoAreaMovil.Text = cirujano.TelefonoMovil.Substring(0, 3);
                    _vista.TextTelefonoMovil.Text = cirujano.TelefonoMovil.Substring(3);
                }
                _vista.TextCorreoElectronico.Text = cirujano.Correo;
                _vista.GrupoDatosCirujano.Visible = true;
                cirujanoBuscado = Convert.ToInt32(_vista.TextCiCirujano.Text);
            }
            else
            {
                cirujanoBuscado = 0;
                DesactivarCamposDeGrupoInformacionCirujano();
                DialogResult result =
                    MessageBox.Show("El cirujano que intenta buscar no se encuentra registrado.", "Cuidado!", MessageBoxButtons.OK);
            }
        }

        public void DesactivarCamposDeGrupoInformacionCirujano()
        {
            _vista.TextPrimerNombre.Text = "";
            _vista.TextSegundoNombre.Text = "";
            _vista.TextPrimerApellido.Text = "";
            _vista.TextSegundoApellido.Text = "";
            _vista.TextCodigoAreaFijo.Text = "";
            _vista.TextTelefonoFijo.Text = "";
            _vista.TextCodigoAreaMovil.Text = "";
            _vista.TextTelefonoMovil.Text = "";
            _vista.TextCorreoElectronico.Text = "";
            _vista.GrupoDatosCirujano.Visible = false;
        }

        public bool ClickBotonAceptar ()
        {
            bool resultado;
            if (!ValidarCamposTelefonicos())
            {
                DialogResult result =
                MessageBox.Show("Los campos telefonicos estan en el formato incorrecto.", "Cuidado!", MessageBoxButtons.OK);
                resultado = false;
            }
            else if (cirujanoBuscado != 0)
            {
                cirujano.Cedula = Convert.ToInt32(cirujanoBuscado);
                cirujano.Nombre = _vista.TextPrimerNombre.Text;
                cirujano.SegundoNombre = _vista.TextSegundoNombre.Text;
                cirujano.PrimerApellido = _vista.TextPrimerApellido.Text;
                cirujano.SegundoApellido = _vista.TextSegundoApellido.Text;
                cirujano.Telefono = _vista.TextCodigoAreaFijo.Text + _vista.TextTelefonoFijo.Text;
                cirujano.TelefonoMovil = _vista.TextCodigoAreaMovil.Text + _vista.TextTelefonoMovil.Text;
                cirujano.Correo = _vista.TextCorreoElectronico.Text;
                resultado = ServicioCirujanoSoap.EditarCirujano(cirujano);
            }
            else
            {
                DialogResult result =
                MessageBox.Show("Debe buscar al cirujano para poder completar la operacion.", "Cuidado!", MessageBoxButtons.OK);
                resultado = false;
            }
            return resultado;
        }

        public bool ValidarCamposTelefonicos ()
        {
            try
            {
                if (_vista.TextTelefonoFijo.Text.Length > 0)
                {
                    if (_vista.TextCodigoAreaFijo.Text.Length != 3)
                        return false;
                }
                else if (_vista.TextCodigoAreaFijo.Text.Length != 0)
                {
                    return false;
                }

                if (_vista.TextTelefonoMovil.Text.Length > 0)
                {
                    if (_vista.TextCodigoAreaMovil.Text.Length != 3)
                        return false;
                }
                else if (_vista.TextCodigoAreaMovil.Text.Length != 0)
                {
                    return false;
                }

                if (_vista.TextTelefonoFijo.Text.Length != 7 && _vista.TextTelefonoFijo.Text.Length != 0)
                    return false;
                if (_vista.TextTelefonoMovil.Text.Length != 7 && _vista.TextTelefonoMovil.Text.Length != 0)
                    return false;

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
