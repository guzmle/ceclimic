using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CECLIMI.Contratos;
using EnlaceDatos;
using Entidades;
using Logica;

namespace CECLIMI.Presentador
{
    public class PresentadorModificarCirugiaCirujano
    {
        private IContratoModificarCirugiaCirujano _vista;
        LCirujano lCirujano = new LCirujano();
        LCirugiaCirujano logica = new LCirugiaCirujano();
        Cirujano cirujano = new Cirujano();

        public PresentadorModificarCirugiaCirujano(IContratoModificarCirugiaCirujano vista)
        {
            _vista = vista;
        }

        public void BuscarCirujano ()
        {
            try
            {
                cirujano = lCirujano.ObtenerInformacionCirujano(Convert.ToInt32(_vista.TextCiCirujano.Text));
                if (cirujano.Nombre != null)
                {
                    _vista.TextNombreModificar.Text = cirujano.Nombre + " " + cirujano.SegundoNombre;
                    _vista.TextApellidoModificar.Text = cirujano.PrimerApellido + " " + cirujano.SegundoApellido;
                    _vista.TextTelefonoModificar.Text = cirujano.TelefonoFijo;
                    _vista.TextTelefonoMovilModificar.Text = cirujano.TelefonoMovil;
                    _vista.TextCorreoModificar.Text = cirujano.Correo;
                    _vista.GrupoInformacionCirujano.Visible = false;
                    _vista.GrupoDatosCirujano.Visible = true;

                    foreach (CirugiaCirujano cirugiaCirujano in logica.ObtenerCirugiasCirujano(Convert.ToInt32(_vista.TextCiCirujano.Text)))
                    {
                        _vista.GridInformacionCirugiasCirujano.Rows.Add(cirugiaCirujano.Nombre, cirugiaCirujano.Honorarios, cirugiaCirujano.Honorarios, cirugiaCirujano.Cirugia.Id, cirugiaCirujano.Cirujano.Id);
                    }
                    _vista.GroupCirugiasCirujano.Visible = true;
                }
                else
                {
                    DialogResult result =
                    MessageBox.Show("El cirujano que intenta buscar no se encuentra registrado.", "Cuidado!", MessageBoxButtons.OK);
                }
            }
            catch (Exception e)
            {
                DialogResult result =
                    MessageBox.Show("La cedula del cirujano no puede contener caracteres numericos.", "Cuidado!", MessageBoxButtons.OK);
            }
        }

        public void BotonAceptar ()
        {
            if (_vista.GridInformacionCirugiasCirujano.Rows.Count != 0)
            {
                for (int i = 0; i < _vista.GridInformacionCirugiasCirujano.Rows.Count; i++)
                {
                    if (!_vista.GridInformacionCirugiasCirujano.Rows[i].Cells["honorario"].Value.ToString().Equals(_vista.GridInformacionCirugiasCirujano.Rows[i].Cells["honorarioOriginal"].Value.ToString()))
                    {
                        logica.EditarCirugiaCirujano(
                            float.Parse(
                                (_vista.GridInformacionCirugiasCirujano.Rows[i].Cells["honorario"].Value.ToString())),
                            Convert.ToInt32(
                                _vista.GridInformacionCirugiasCirujano.Rows[i].Cells["id_cirugia"].Value.ToString()),
                            Convert.ToInt32(
                                _vista.GridInformacionCirugiasCirujano.Rows[i].Cells["id_cirujano"].Value.ToString()));
                    }
                }
                DialogResult result =
                MessageBox.Show("El honorario de las cirugias han sido modificadas con exito.", "Cuidado!", MessageBoxButtons.OK);
            }
        }
    }
}
