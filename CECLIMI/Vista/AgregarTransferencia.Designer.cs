namespace CECLIMI.Vista
{
    partial class AgregarTransferencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.groupInformacionTransferencia = new System.Windows.Forms.GroupBox();
            this.buscarBeneficiario = new System.Windows.Forms.Button();
            this.textoCIBeneficiario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBsF = new System.Windows.Forms.Label();
            this.textoMontoPagar = new System.Windows.Forms.TextBox();
            this.textMP = new System.Windows.Forms.Label();
            this.textNB = new System.Windows.Forms.Label();
            this.textNombreBeneficiario = new System.Windows.Forms.Label();
            this.textApellidoBeneficiario = new System.Windows.Forms.Label();
            this.textAB = new System.Windows.Forms.Label();
            this.grupoEstatusCuenta = new System.Windows.Forms.GroupBox();
            this.textoTotalAbonadoModificar = new System.Windows.Forms.Label();
            this.textoTotalAbonado = new System.Windows.Forms.Label();
            this.gridInformacionPagos = new System.Windows.Forms.DataGridView();
            this.columnaNumeroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textInformacionPagos = new System.Windows.Forms.Label();
            this.grupoDatosPaciente1 = new System.Windows.Forms.GroupBox();
            this.botonModificarInformacion = new System.Windows.Forms.Button();
            this.textoApellidoPacienteIngresado = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.textoTelefonoFijoPacienteIngresado = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.textoCIPacienteIngresado = new System.Windows.Forms.Label();
            this.textoNombrePacienteIngresado = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.textoTelefonoMovilIngresado = new System.Windows.Forms.Label();
            this.textoCorreoElectronicoPacienteIngresado = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.grupoInformacionPaciente = new System.Windows.Forms.GroupBox();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.textoCiPaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupInformacionTransferencia.SuspendLayout();
            this.grupoEstatusCuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInformacionPagos)).BeginInit();
            this.grupoDatosPaciente1.SuspendLayout();
            this.grupoInformacionPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.botonCancelar);
            this.panel1.Controls.Add(this.botonAceptar);
            this.panel1.Controls.Add(this.groupInformacionTransferencia);
            this.panel1.Controls.Add(this.grupoEstatusCuenta);
            this.panel1.Controls.Add(this.textInformacionPagos);
            this.panel1.Controls.Add(this.grupoDatosPaciente1);
            this.panel1.Controls.Add(this.grupoInformacionPaciente);
            this.panel1.Location = new System.Drawing.Point(261, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 723);
            this.panel1.TabIndex = 10;
            // 
            // botonCancelar
            // 
            this.botonCancelar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.Image = global::CECLIMI.Properties.Resources.icono_cancelar;
            this.botonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonCancelar.Location = new System.Drawing.Point(552, 488);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(111, 29);
            this.botonCancelar.TabIndex = 32;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            // 
            // botonAceptar
            // 
            this.botonAceptar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAceptar.Image = global::CECLIMI.Properties.Resources.icono_aceptar1;
            this.botonAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonAceptar.Location = new System.Drawing.Point(847, 488);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(111, 29);
            this.botonAceptar.TabIndex = 31;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.BotonAceptarClick);
            // 
            // groupInformacionTransferencia
            // 
            this.groupInformacionTransferencia.Controls.Add(this.buscarBeneficiario);
            this.groupInformacionTransferencia.Controls.Add(this.textoCIBeneficiario);
            this.groupInformacionTransferencia.Controls.Add(this.label8);
            this.groupInformacionTransferencia.Controls.Add(this.textBsF);
            this.groupInformacionTransferencia.Controls.Add(this.textoMontoPagar);
            this.groupInformacionTransferencia.Controls.Add(this.textMP);
            this.groupInformacionTransferencia.Controls.Add(this.textNB);
            this.groupInformacionTransferencia.Controls.Add(this.textNombreBeneficiario);
            this.groupInformacionTransferencia.Controls.Add(this.textApellidoBeneficiario);
            this.groupInformacionTransferencia.Controls.Add(this.textAB);
            this.groupInformacionTransferencia.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.groupInformacionTransferencia.Location = new System.Drawing.Point(9, 359);
            this.groupInformacionTransferencia.Name = "groupInformacionTransferencia";
            this.groupInformacionTransferencia.Size = new System.Drawing.Size(962, 112);
            this.groupInformacionTransferencia.TabIndex = 30;
            this.groupInformacionTransferencia.TabStop = false;
            this.groupInformacionTransferencia.Text = "Informacion de Transferencia";
            this.groupInformacionTransferencia.Visible = false;
            // 
            // buscarBeneficiario
            // 
            this.buscarBeneficiario.Image = global::CECLIMI.Properties.Resources.boton_buscar;
            this.buscarBeneficiario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarBeneficiario.Location = new System.Drawing.Point(335, 42);
            this.buscarBeneficiario.Name = "buscarBeneficiario";
            this.buscarBeneficiario.Size = new System.Drawing.Size(30, 29);
            this.buscarBeneficiario.TabIndex = 53;
            this.buscarBeneficiario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buscarBeneficiario.UseVisualStyleBackColor = true;
            this.buscarBeneficiario.Click += new System.EventHandler(this.BuscarBeneficiarioClick);
            // 
            // textoCIBeneficiario
            // 
            this.textoCIBeneficiario.Location = new System.Drawing.Point(188, 43);
            this.textoCIBeneficiario.Name = "textoCIBeneficiario";
            this.textoCIBeneficiario.Size = new System.Drawing.Size(141, 26);
            this.textoCIBeneficiario.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "CI Beneficiario:";
            // 
            // textBsF
            // 
            this.textBsF.AutoSize = true;
            this.textBsF.Location = new System.Drawing.Point(910, 46);
            this.textBsF.Name = "textBsF";
            this.textBsF.Size = new System.Drawing.Size(33, 20);
            this.textBsF.TabIndex = 2;
            this.textBsF.Text = "BsF";
            this.textBsF.Visible = false;
            // 
            // textoMontoPagar
            // 
            this.textoMontoPagar.Location = new System.Drawing.Point(763, 40);
            this.textoMontoPagar.Name = "textoMontoPagar";
            this.textoMontoPagar.Size = new System.Drawing.Size(141, 26);
            this.textoMontoPagar.TabIndex = 1;
            this.textoMontoPagar.Visible = false;
            // 
            // textMP
            // 
            this.textMP.AutoSize = true;
            this.textMP.Location = new System.Drawing.Point(638, 46);
            this.textMP.Name = "textMP";
            this.textMP.Size = new System.Drawing.Size(119, 20);
            this.textMP.TabIndex = 0;
            this.textMP.Text = "Monto a Transferir:";
            this.textMP.Visible = false;
            // 
            // textNB
            // 
            this.textNB.AutoSize = true;
            this.textNB.Location = new System.Drawing.Point(45, 44);
            this.textNB.Name = "textNB";
            this.textNB.Size = new System.Drawing.Size(135, 20);
            this.textNB.TabIndex = 54;
            this.textNB.Text = "Nombre Beneficiario:";
            this.textNB.Visible = false;
            // 
            // textNombreBeneficiario
            // 
            this.textNombreBeneficiario.AutoSize = true;
            this.textNombreBeneficiario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreBeneficiario.Location = new System.Drawing.Point(186, 46);
            this.textNombreBeneficiario.Name = "textNombreBeneficiario";
            this.textNombreBeneficiario.Size = new System.Drawing.Size(58, 18);
            this.textNombreBeneficiario.TabIndex = 55;
            this.textNombreBeneficiario.Text = "label33";
            this.textNombreBeneficiario.Visible = false;
            // 
            // textApellidoBeneficiario
            // 
            this.textApellidoBeneficiario.AutoSize = true;
            this.textApellidoBeneficiario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellidoBeneficiario.Location = new System.Drawing.Point(469, 46);
            this.textApellidoBeneficiario.Name = "textApellidoBeneficiario";
            this.textApellidoBeneficiario.Size = new System.Drawing.Size(58, 18);
            this.textApellidoBeneficiario.TabIndex = 57;
            this.textApellidoBeneficiario.Text = "label33";
            this.textApellidoBeneficiario.Visible = false;
            // 
            // textAB
            // 
            this.textAB.AutoSize = true;
            this.textAB.Location = new System.Drawing.Point(326, 44);
            this.textAB.Name = "textAB";
            this.textAB.Size = new System.Drawing.Size(137, 20);
            this.textAB.TabIndex = 56;
            this.textAB.Text = "Apellido Beneficiario:";
            this.textAB.Visible = false;
            // 
            // grupoEstatusCuenta
            // 
            this.grupoEstatusCuenta.Controls.Add(this.textoTotalAbonadoModificar);
            this.grupoEstatusCuenta.Controls.Add(this.textoTotalAbonado);
            this.grupoEstatusCuenta.Controls.Add(this.gridInformacionPagos);
            this.grupoEstatusCuenta.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.grupoEstatusCuenta.Location = new System.Drawing.Point(9, 148);
            this.grupoEstatusCuenta.Name = "grupoEstatusCuenta";
            this.grupoEstatusCuenta.Size = new System.Drawing.Size(962, 205);
            this.grupoEstatusCuenta.TabIndex = 29;
            this.grupoEstatusCuenta.TabStop = false;
            this.grupoEstatusCuenta.Text = "Estatus de la cuenta del paciente";
            this.grupoEstatusCuenta.Visible = false;
            // 
            // textoTotalAbonadoModificar
            // 
            this.textoTotalAbonadoModificar.AutoSize = true;
            this.textoTotalAbonadoModificar.Location = new System.Drawing.Point(816, 173);
            this.textoTotalAbonadoModificar.Name = "textoTotalAbonadoModificar";
            this.textoTotalAbonadoModificar.Size = new System.Drawing.Size(45, 20);
            this.textoTotalAbonadoModificar.TabIndex = 4;
            this.textoTotalAbonadoModificar.Text = "label6";
            this.textoTotalAbonadoModificar.Visible = false;
            // 
            // textoTotalAbonado
            // 
            this.textoTotalAbonado.AutoSize = true;
            this.textoTotalAbonado.Location = new System.Drawing.Point(684, 173);
            this.textoTotalAbonado.Name = "textoTotalAbonado";
            this.textoTotalAbonado.Size = new System.Drawing.Size(134, 20);
            this.textoTotalAbonado.TabIndex = 1;
            this.textoTotalAbonado.Text = "Total abonado:  BsF.";
            this.textoTotalAbonado.Visible = false;
            // 
            // gridInformacionPagos
            // 
            this.gridInformacionPagos.AllowUserToAddRows = false;
            this.gridInformacionPagos.AllowUserToDeleteRows = false;
            this.gridInformacionPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridInformacionPagos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridInformacionPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridInformacionPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInformacionPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaNumeroFactura,
            this.columnaFecha,
            this.columnaPago});
            this.gridInformacionPagos.Location = new System.Drawing.Point(19, 31);
            this.gridInformacionPagos.Name = "gridInformacionPagos";
            this.gridInformacionPagos.ReadOnly = true;
            this.gridInformacionPagos.Size = new System.Drawing.Size(926, 139);
            this.gridInformacionPagos.TabIndex = 0;
            this.gridInformacionPagos.Visible = false;
            // 
            // columnaNumeroFactura
            // 
            this.columnaNumeroFactura.HeaderText = "Numero Factura";
            this.columnaNumeroFactura.Name = "columnaNumeroFactura";
            this.columnaNumeroFactura.ReadOnly = true;
            // 
            // columnaFecha
            // 
            this.columnaFecha.HeaderText = "Fecha";
            this.columnaFecha.Name = "columnaFecha";
            this.columnaFecha.ReadOnly = true;
            // 
            // columnaPago
            // 
            this.columnaPago.HeaderText = "Pago";
            this.columnaPago.Name = "columnaPago";
            this.columnaPago.ReadOnly = true;
            // 
            // textInformacionPagos
            // 
            this.textInformacionPagos.AutoSize = true;
            this.textInformacionPagos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInformacionPagos.Location = new System.Drawing.Point(205, 9);
            this.textInformacionPagos.Name = "textInformacionPagos";
            this.textInformacionPagos.Size = new System.Drawing.Size(202, 22);
            this.textInformacionPagos.TabIndex = 27;
            this.textInformacionPagos.Text = "Nueva Transferencia";
            // 
            // grupoDatosPaciente1
            // 
            this.grupoDatosPaciente1.Controls.Add(this.botonModificarInformacion);
            this.grupoDatosPaciente1.Controls.Add(this.textoApellidoPacienteIngresado);
            this.grupoDatosPaciente1.Controls.Add(this.label34);
            this.grupoDatosPaciente1.Controls.Add(this.textoTelefonoFijoPacienteIngresado);
            this.grupoDatosPaciente1.Controls.Add(this.label30);
            this.grupoDatosPaciente1.Controls.Add(this.label32);
            this.grupoDatosPaciente1.Controls.Add(this.textoCIPacienteIngresado);
            this.grupoDatosPaciente1.Controls.Add(this.textoNombrePacienteIngresado);
            this.grupoDatosPaciente1.Controls.Add(this.label37);
            this.grupoDatosPaciente1.Controls.Add(this.label33);
            this.grupoDatosPaciente1.Controls.Add(this.textoTelefonoMovilIngresado);
            this.grupoDatosPaciente1.Controls.Add(this.textoCorreoElectronicoPacienteIngresado);
            this.grupoDatosPaciente1.Controls.Add(this.label35);
            this.grupoDatosPaciente1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoDatosPaciente1.Location = new System.Drawing.Point(9, 34);
            this.grupoDatosPaciente1.Name = "grupoDatosPaciente1";
            this.grupoDatosPaciente1.Size = new System.Drawing.Size(964, 114);
            this.grupoDatosPaciente1.TabIndex = 53;
            this.grupoDatosPaciente1.TabStop = false;
            this.grupoDatosPaciente1.Text = "Informacion del Paciente";
            this.grupoDatosPaciente1.Visible = false;
            // 
            // botonModificarInformacion
            // 
            this.botonModificarInformacion.Image = global::CECLIMI.Properties.Resources.iconoModificar;
            this.botonModificarInformacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonModificarInformacion.Location = new System.Drawing.Point(711, 80);
            this.botonModificarInformacion.Name = "botonModificarInformacion";
            this.botonModificarInformacion.Size = new System.Drawing.Size(171, 29);
            this.botonModificarInformacion.TabIndex = 51;
            this.botonModificarInformacion.Text = "Buscar otro paciente";
            this.botonModificarInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonModificarInformacion.UseVisualStyleBackColor = true;
            this.botonModificarInformacion.Visible = false;
            this.botonModificarInformacion.Click += new System.EventHandler(this.BotonModificarInformacionClick);
            // 
            // textoApellidoPacienteIngresado
            // 
            this.textoApellidoPacienteIngresado.AutoSize = true;
            this.textoApellidoPacienteIngresado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoApellidoPacienteIngresado.Location = new System.Drawing.Point(166, 59);
            this.textoApellidoPacienteIngresado.Name = "textoApellidoPacienteIngresado";
            this.textoApellidoPacienteIngresado.Size = new System.Drawing.Size(58, 18);
            this.textoApellidoPacienteIngresado.TabIndex = 11;
            this.textoApellidoPacienteIngresado.Text = "label33";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(45, 57);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(119, 20);
            this.label34.TabIndex = 10;
            this.label34.Text = "Apellido Paciente:";
            // 
            // textoTelefonoFijoPacienteIngresado
            // 
            this.textoTelefonoFijoPacienteIngresado.AutoSize = true;
            this.textoTelefonoFijoPacienteIngresado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoTelefonoFijoPacienteIngresado.Location = new System.Drawing.Point(811, 32);
            this.textoTelefonoFijoPacienteIngresado.Name = "textoTelefonoFijoPacienteIngresado";
            this.textoTelefonoFijoPacienteIngresado.Size = new System.Drawing.Size(58, 18);
            this.textoTelefonoFijoPacienteIngresado.TabIndex = 9;
            this.textoTelefonoFijoPacienteIngresado.Text = "label36";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(704, 55);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(101, 20);
            this.label30.TabIndex = 8;
            this.label30.Text = "Telefono Movil:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(45, 28);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(117, 20);
            this.label32.TabIndex = 0;
            this.label32.Text = "Nombre Paciente:";
            // 
            // textoCIPacienteIngresado
            // 
            this.textoCIPacienteIngresado.AutoSize = true;
            this.textoCIPacienteIngresado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoCIPacienteIngresado.Location = new System.Drawing.Point(482, 30);
            this.textoCIPacienteIngresado.Name = "textoCIPacienteIngresado";
            this.textoCIPacienteIngresado.Size = new System.Drawing.Size(58, 18);
            this.textoCIPacienteIngresado.TabIndex = 7;
            this.textoCIPacienteIngresado.Text = "label38";
            // 
            // textoNombrePacienteIngresado
            // 
            this.textoNombrePacienteIngresado.AutoSize = true;
            this.textoNombrePacienteIngresado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoNombrePacienteIngresado.Location = new System.Drawing.Point(166, 30);
            this.textoNombrePacienteIngresado.Name = "textoNombrePacienteIngresado";
            this.textoNombrePacienteIngresado.Size = new System.Drawing.Size(58, 18);
            this.textoNombrePacienteIngresado.TabIndex = 1;
            this.textoNombrePacienteIngresado.Text = "label33";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(395, 30);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(81, 20);
            this.label37.TabIndex = 6;
            this.label37.Text = "CI Paciente:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(351, 55);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(125, 20);
            this.label33.TabIndex = 2;
            this.label33.Text = "Correo Electronico:";
            // 
            // textoTelefonoMovilIngresado
            // 
            this.textoTelefonoMovilIngresado.AutoSize = true;
            this.textoTelefonoMovilIngresado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoTelefonoMovilIngresado.Location = new System.Drawing.Point(811, 57);
            this.textoTelefonoMovilIngresado.Name = "textoTelefonoMovilIngresado";
            this.textoTelefonoMovilIngresado.Size = new System.Drawing.Size(58, 18);
            this.textoTelefonoMovilIngresado.TabIndex = 5;
            this.textoTelefonoMovilIngresado.Text = "label36";
            // 
            // textoCorreoElectronicoPacienteIngresado
            // 
            this.textoCorreoElectronicoPacienteIngresado.AutoSize = true;
            this.textoCorreoElectronicoPacienteIngresado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.textoCorreoElectronicoPacienteIngresado.Location = new System.Drawing.Point(482, 57);
            this.textoCorreoElectronicoPacienteIngresado.Name = "textoCorreoElectronicoPacienteIngresado";
            this.textoCorreoElectronicoPacienteIngresado.Size = new System.Drawing.Size(58, 18);
            this.textoCorreoElectronicoPacienteIngresado.TabIndex = 3;
            this.textoCorreoElectronicoPacienteIngresado.Text = "label34";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(714, 30);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(91, 20);
            this.label35.TabIndex = 4;
            this.label35.Text = "Telefono Fijo:";
            // 
            // grupoInformacionPaciente
            // 
            this.grupoInformacionPaciente.Controls.Add(this.botonBuscar);
            this.grupoInformacionPaciente.Controls.Add(this.textoCiPaciente);
            this.grupoInformacionPaciente.Controls.Add(this.label2);
            this.grupoInformacionPaciente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoInformacionPaciente.Location = new System.Drawing.Point(11, 34);
            this.grupoInformacionPaciente.Name = "grupoInformacionPaciente";
            this.grupoInformacionPaciente.Size = new System.Drawing.Size(962, 91);
            this.grupoInformacionPaciente.TabIndex = 28;
            this.grupoInformacionPaciente.TabStop = false;
            this.grupoInformacionPaciente.Text = "Informacion del paciente";
            // 
            // botonBuscar
            // 
            this.botonBuscar.Image = global::CECLIMI.Properties.Resources.boton_buscar;
            this.botonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonBuscar.Location = new System.Drawing.Point(394, 34);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(30, 29);
            this.botonBuscar.TabIndex = 52;
            this.botonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.BotonBuscarClick);
            // 
            // textoCiPaciente
            // 
            this.textoCiPaciente.Location = new System.Drawing.Point(168, 37);
            this.textoCiPaciente.Name = "textoCiPaciente";
            this.textoCiPaciente.Size = new System.Drawing.Size(220, 26);
            this.textoCiPaciente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "CI Paciente";
            // 
            // AgregarTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1264, 762);
            this.Controls.Add(this.panel1);
            this.Name = "AgregarTransferencia";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupInformacionTransferencia.ResumeLayout(false);
            this.groupInformacionTransferencia.PerformLayout();
            this.grupoEstatusCuenta.ResumeLayout(false);
            this.grupoEstatusCuenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInformacionPagos)).EndInit();
            this.grupoDatosPaciente1.ResumeLayout(false);
            this.grupoDatosPaciente1.PerformLayout();
            this.grupoInformacionPaciente.ResumeLayout(false);
            this.grupoInformacionPaciente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.GroupBox groupInformacionTransferencia;
        private System.Windows.Forms.TextBox textoCIBeneficiario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label textBsF;
        private System.Windows.Forms.TextBox textoMontoPagar;
        private System.Windows.Forms.Label textMP;
        private System.Windows.Forms.GroupBox grupoEstatusCuenta;
        private System.Windows.Forms.Label textoTotalAbonadoModificar;
        private System.Windows.Forms.Label textoTotalAbonado;
        private System.Windows.Forms.DataGridView gridInformacionPagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaNumeroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPago;
        private System.Windows.Forms.GroupBox grupoInformacionPaciente;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.TextBox textoCiPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label textInformacionPagos;
        private System.Windows.Forms.Button buscarBeneficiario;
        private System.Windows.Forms.GroupBox grupoDatosPaciente1;
        private System.Windows.Forms.Button botonModificarInformacion;
        private System.Windows.Forms.Label textoApellidoPacienteIngresado;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label textoTelefonoFijoPacienteIngresado;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label textoCIPacienteIngresado;
        private System.Windows.Forms.Label textoNombrePacienteIngresado;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label textoTelefonoMovilIngresado;
        private System.Windows.Forms.Label textoCorreoElectronicoPacienteIngresado;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label textApellidoBeneficiario;
        private System.Windows.Forms.Label textAB;
        private System.Windows.Forms.Label textNB;
        private System.Windows.Forms.Label textNombreBeneficiario;

    }
}
