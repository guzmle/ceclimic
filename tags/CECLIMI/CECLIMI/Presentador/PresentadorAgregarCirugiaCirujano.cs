using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CECLIMI.Contratos;
using Proxy;


namespace CECLIMI.Presentador
{
    public class PresentadorAgregarCirugiaCirujano
    {
        ServicioCirujanoSoap ServicioCirujanoSoap = new ServicioCirujanoSoap();
        Cirujano _cirujano = new Cirujano();
        private IContratoAgregarCirugiaCirujano _vista;
        private int _cirujanoBuscado;

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
            _cirujano = ServicioCirujanoSoap.ObtenerInformacionCirujano(Convert.ToInt32(_vista.CedulaCirujano.Text));
            if (_cirujano.Nombre != null)
            {
                LLenarInformacionCirujano();
                _vista.GrupoDatosCirujano.Visible = true;
                _vista.GrupoCirugias.Visible = true;
                _cirujanoBuscado = Convert.ToInt32(_vista.CedulaCirujano.Text);
                _cirujano.Cedula = _cirujanoBuscado;
                LlenarComboCirugias();
            }
            else
            {
                _cirujanoBuscado = 0;
                MessageBox.Show("El cirujano que intenta buscar no se encuentra registrado.", "Cuidado!", MessageBoxButtons.OK);
            }
        }

        public void LlenarComboCirugias()
        {
            foreach (Cirugia cirugia in ServicioCirujanoSoap.ObtenerCirugiasAgregarCirujano(_cirujano))
            {
                _vista.UxComboCirugias.Items.Add(cirugia);
            }
            _vista.UxComboCirugias.DisplayMember = "Nombre";
            _vista.UxComboCirugias.ValueMember = "Id";
        }

        public void LLenarInformacionCirujano()
        {
            _vista.UxNombre.Text = _cirujano.Nombre + " " + _cirujano.SegundoNombre;
            _vista.UxApellido.Text = _cirujano.PrimerApellido + " " + _cirujano.SegundoApellido;
            _vista.UxCedula.Text = _vista.CedulaCirujano.Text;
            _vista.UxCorreo.Text = _cirujano.Correo;
            _vista.UxTelefonoFijo.Text = _cirujano.TelefonoFijo;
            _vista.UxTelefonoMovil.Text = _cirujano.TelefonoMovil;
            
        }

        public void AgregarCirugia()
        {
            if (_vista.UxComboCirugias.SelectedIndex != -1)
            {
                Cirugia cirugia = (Cirugia) _vista.UxComboCirugias.SelectedItem;
                CirugiaCirujano cirugiaCirujano = new CirugiaCirujano();
                cirugiaCirujano.Cirugia = new Cirugia();
                cirugiaCirujano.Cirujano = new Cirujano();
                cirugiaCirujano.Cirugia.Id = cirugia.Id;
                cirugiaCirujano.Cirujano.Id = _cirujano.Cedula;
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
                ServicioCirugiaCirujanoSoap servicioCirugiaCirujanoSoap = new ServicioCirugiaCirujanoSoap();
                foreach (CirugiaCirujano cirugiaCirujano in cirugias)
                {
                    servicioCirugiaCirujanoSoap.AgregarCirugiaCirujano(cirugiaCirujano);
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
