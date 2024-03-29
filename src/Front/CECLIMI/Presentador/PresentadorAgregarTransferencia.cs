﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CECLIMI.Contratos;
using Entidades;
using Logica;

namespace CECLIMI.Presentador
{
    public class PresentadorAgregarTransferencia
    {
        #region variables
        private IContratoAgregarTransferencia _vista;
        LPaciente logica = new LPaciente();
        Paciente paciente = new Paciente();
        #endregion

        #region constructor
        public PresentadorAgregarTransferencia(IContratoAgregarTransferencia vista)
        {
            _vista = vista;
        }

        //metodo que busca la informacion de un paciente segun la cedula de identidad proporcionada
        public void BuscarInformacionPaciente()
        {
            try
            {
                paciente = logica.ObtenerInformacionPaciente(Convert.ToInt32(_vista.TextoCiPaciente.Text));
                if (paciente.Nombre != null)
                {
                    paciente.Id = Convert.ToInt64(_vista.TextoCiPaciente.Text);
                    CargarInformacionEnText(paciente);
                    LPagos lPagos = new LPagos();
                    Double monto = 0;
                    foreach (Pago pago in lPagos.ObtenerPagosPaciente(paciente))
                    {
                        _vista.GridInformacionPagos.Rows.Add(pago.Id, pago.Fecha, pago.Monto);
                        monto += pago.Monto;
                    }
                    _vista.GridInformacionPagos.Visible = true;
                    _vista.TextoTotalAbonadoModificar.Text = monto.ToString("##,##.##") + " BsF.";
                    _vista.TextoTotalAbonadoModificar.Visible = _vista.TextoTotalAbonado.Visible = true;
                }
                else
                {
                    DialogResult result =
                    MessageBox.Show("No hay pacientes en el sistema registrado con esa cedula", "Cuidado!", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                DialogResult result =
                    MessageBox.Show("Por favor introduzca una cedula valida.", "Cuidado!", MessageBoxButtons.OK);
            }
        }

        //metodo que permite buscar otro usuario, y borra todo lo que fue cargardo previamente.
        public void BotonModificar()
        {
            _vista.GrupoDatosPaciente1.Visible = false;
            _vista.GroupInformacionTransferencia.Visible = false;
            _vista.GrupoInfrormacionPaciente.Visible = true;
            _vista.GrupoEstatusCuenta.Visible = false;
            _vista.TextoCiPaciente.Text = "";
            _vista.TextoNombrePacienteIngresado.Text = "";
            _vista.TextoApellidoPacienteIngresado.Text = "";
            _vista.TextoCiPacienteIngresado.Text = "";
            _vista.TextoCorreoElectronicoPacienteIngresado.Text = "";
            _vista.TextoTelefonoFijoPacienteIngresado.Text = "";
            _vista.TextoTelefonoMovilPacienteIngresado.Text = "";
            _vista.GridInformacionPagos.Rows.Clear();
            _vista.TextoTotalAbonadoModificar.Text = "";

            _vista.Label8.Visible = _vista.TextoCiBeneficiario.Visible = _vista.BuscarBeneficiario.Visible = true;
            _vista.TextNb.Visible = _vista.TextAb.Visible = _vista.TextMp.Visible = _vista.TextBsf.Visible =
                _vista.TextoMontoPagar.Visible = false;
            _vista.TextoCiBeneficiario.Text = "";
            _vista.TextoNombreBeneficiario.Text = "";
            _vista.TextoApellidoBeneficiario.Text = "";
            _vista.TextoMontoPagar.Text = "";
            _vista.TextoNombreBeneficiario.Visible = _vista.TextoApellidoBeneficiario.Visible = false;
        }

        //metodo que rellena toda la informacion al buscar un paciente
        public void CargarInformacionEnText(Paciente paciente)
        {
            _vista.GrupoInfrormacionPaciente.Visible = false;
            _vista.GrupoDatosPaciente1.Visible = true;
            _vista.GroupInformacionTransferencia.Visible = _vista.GrupoEstatusCuenta.Visible = true;
            _vista.TextoNombrePacienteIngresado.Text = paciente.Nombre + " " + paciente.SegundoNombre;
            _vista.TextoApellidoPacienteIngresado.Text = paciente.PrimerApellido + " " + paciente.SegundoApellido;
            _vista.TextoCiPacienteIngresado.Text = paciente.Id.ToString();
            _vista.TextoCorreoElectronicoPacienteIngresado.Text = paciente.Correo;
            _vista.TextoTelefonoFijoPacienteIngresado.Text = paciente.Telefono;
            _vista.TextoTelefonoMovilPacienteIngresado.Text = paciente.TelefonoMovil;
        }

        public void BuscarBeneficiario()
        {
            try
            {
                paciente = logica.ObtenerInformacionPaciente(Convert.ToInt32(_vista.TextoCiBeneficiario.Text));
                if (paciente.Nombre != null)
                {
                    _vista.Label8.Visible = _vista.TextoCiBeneficiario.Visible = _vista.BuscarBeneficiario.Visible = false;
                    _vista.TextNb.Visible = _vista.TextAb.Visible = _vista.TextMp.Visible = _vista.TextBsf.Visible = 
                        _vista.TextoMontoPagar.Visible = true;
                    _vista.TextoNombreBeneficiario.Text = paciente.Nombre;
                    _vista.TextoApellidoBeneficiario.Text = paciente.PrimerApellido;
                    _vista.TextoNombreBeneficiario.Visible = _vista.TextoApellidoBeneficiario.Visible = true;
                }
                else
                {
                    DialogResult result =
                    MessageBox.Show("No hay pacientes en el sistema registrado con esa cedula", "Cuidado!", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                DialogResult result =
                    MessageBox.Show("Por favor introduzca una cedula valida.", "Cuidado!", MessageBoxButtons.OK);
            }
        }

        public void ClickAceptar()
        {
            Transferencia transferencia = new Transferencia(); ;
            transferencia.PacienteOtorga.Id = Convert.ToInt32(_vista.TextoCiPacienteIngresado.Text);
            transferencia.PacienteRecibe.Id = Convert.ToInt32(_vista.TextoCiBeneficiario.Text);
            transferencia.Monto = Convert.ToInt32(_vista.TextoMontoPagar.Text);
            LTransferencia lTransferencia = new LTransferencia();
            lTransferencia.AgregarTransferencia(transferencia);
        }
        #endregion
    }
}
