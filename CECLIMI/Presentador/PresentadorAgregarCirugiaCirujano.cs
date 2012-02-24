using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CECLIMI.Contratos;
using Entidades;
using Logica;

namespace CECLIMI.Presentador
{
    public class PresentadorAgregarCirugiaCirujano
    {
        LCirujano lCirujano = new LCirujano();
        Cirujano cirujano = new Cirujano();
        private IContratoAgregarCirugiaCirujano _vista;
        private int cirujanoBuscado = 0;

        private List<CirugiaCirujano> cirugias = new List<CirugiaCirujano>();

        public PresentadorAgregarCirugiaCirujano (IContratoAgregarCirugiaCirujano vista)
        {
            _vista = vista;
        }

        /// <summary>
        /// Metodo que bsuca la informacion del cirujano al que se le va a ingresar las cirugias.
        /// </summary>
        public void BuscarInformacionCirujano()
        {
            cirujano = lCirujano.ObtenerInformacionCirujano(Convert.ToInt32(_vista.CedulaCirujano.Text));
            if (cirujano.Nombre != null)
            {
                LLenarInformacionCirujano();
                _vista.GrupoDatosCirujano.Visible = true;
                _vista.GrupoCirugias.Visible = true;
                cirujanoBuscado = Convert.ToInt32(_vista.CedulaCirujano.Text);
                cirujano.Cedula = cirujanoBuscado;
                LlenarComboCirugias();
            }
            else
            {
                cirujanoBuscado = 0;
                DialogResult result =
                    MessageBox.Show("El cirujano que intenta buscar no se encuentra registrado.", "Cuidado!", MessageBoxButtons.OK);
            }
        }

        public void LlenarComboCirugias()
        {
            foreach (Cirugia cirugia in lCirujano.ObtenerCirugiasAgregarCirujano(cirujano))
            {
                _vista.UxComboCirugias.Items.Add(cirugia);
            }
            _vista.UxComboCirugias.DisplayMember = "Nombre";
            _vista.UxComboCirugias.ValueMember = "Id";
        }

        public void LLenarInformacionCirujano()
        {
            _vista.UxNombre.Text = cirujano.Nombre + " " + cirujano.SegundoNombre;
            _vista.UxApellido.Text = cirujano.PrimerApellido + " " + cirujano.SegundoApellido;
            _vista.UxCedula.Text = _vista.CedulaCirujano.Text;
            _vista.UxCorreo.Text = cirujano.Correo;
            _vista.UxTelefonoFijo.Text = cirujano.TelefonoFijo;
            _vista.UxTelefonoMovil.Text = cirujano.TelefonoMovil;
            
        }

        public void AgregarCirugia()
        {
            if (_vista.UxComboCirugias.SelectedIndex != -1)
            {
                Cirugia cirugia = (Cirugia) _vista.UxComboCirugias.SelectedItem;
                CirugiaCirujano cirugiaCirujano = new CirugiaCirujano();
                cirugiaCirujano.Cirugia.Id = cirugia.Id;
                cirugiaCirujano.Cirujano.Id = cirujano.Cedula;
                cirugiaCirujano.Honorarios = Convert.ToSingle(_vista.UxMontoCirugia.Text);
                cirugias.Add(cirugiaCirujano);
                _vista.GridCirugiasAgregar.Rows.Add(cirugia.Nombre, "Bsf." + cirugiaCirujano.Honorarios);
                _vista.UxComboCirugias.SelectedIndex = -1;
                _vista.UxMontoCirugia.Text = "";
            }
        }

        /// <summary>
        /// Metodo para eliminar intervencion del datagrid
        /// </summary>
        public void EliminarIntervencionQuirurgica()
        {
            if (_vista.GridCirugiasAgregar.Rows.Count >= 1)
            {
                int filaEliminar = _vista.GridCirugiasAgregar.Rows.Count - 1;
                _vista.GridCirugiasAgregar.Rows.RemoveAt(filaEliminar);
                cirugias.RemoveAt(filaEliminar);
            }
        }

        public bool BotonAceptar()
        {
            bool respuesta;
            if (_vista.GridCirugiasAgregar.Rows.Count >= 1)
            {
                LCirugiaCirujano lCirugiaCirujano = new LCirugiaCirujano();
                foreach (CirugiaCirujano cirugiaCirujano in cirugias)
                {
                    lCirugiaCirujano.AgregarCirugiaCirujano(cirugiaCirujano);
                }
                respuesta = true;
                DialogResult result =
                        MessageBox.Show("Cirugias Agregadas Correctamente,", "Transaccion Correcta", MessageBoxButtons.OK);
            }
            else
            {
                respuesta = false;
                DialogResult result =
                        MessageBox.Show("Debe agregar cirugias antes de aceptar la transacción.", "Alerta", MessageBoxButtons.OK);
            }
            return respuesta;
        }
    }
}
