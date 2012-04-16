namespace CECLIMI.Vista
{
    partial class AgregarPagos
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
            this.grupoPaquetesFinancieros = new System.Windows.Forms.GroupBox();
            this.comboPaquetes = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.grupoDatosPaciente1 = new System.Windows.Forms.GroupBox();
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
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.groupInformacionPago = new System.Windows.Forms.GroupBox();
            this.textTipoPago = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textSeguro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gridPagosNuevos = new System.Windows.Forms.DataGridView();
            this.idFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quienPaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaSeguro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaTipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textNombreQuienPaga = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.botonAgregarPago = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textAnoPago = new System.Windows.Forms.TextBox();
            this.textMesPago = new System.Windows.Forms.TextBox();
            this.textDiaPago = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textoNumeroFactura = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textoMontoPagar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grupoInformacionPaciente = new System.Windows.Forms.GroupBox();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.textoCiPaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textInformacionPagos = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grupoPaquetesFinancieros.SuspendLayout();
            this.grupoDatosPaciente1.SuspendLayout();
            this.groupInformacionPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPagosNuevos)).BeginInit();
            this.grupoInformacionPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.grupoPaquetesFinancieros);
            this.panel1.Controls.Add(this.botonCancelar);
            this.panel1.Controls.Add(this.botonAceptar);
            this.panel1.Controls.Add(this.groupInformacionPago);
            this.panel1.Controls.Add(this.grupoInformacionPaciente);
            this.panel1.Controls.Add(this.textInformacionPagos);
            this.panel1.Controls.Add(this.grupoDatosPaciente1);
            this.panel1.Location = new System.Drawing.Point(257, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 646);
            this.panel1.TabIndex = 9;
            // 
            // grupoPaquetesFinancieros
            // 
            this.grupoPaquetesFinancieros.Controls.Add(this.comboPaquetes);
            this.grupoPaquetesFinancieros.Controls.Add(this.label13);
            this.grupoPaquetesFinancieros.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoPaquetesFinancieros.Location = new System.Drawing.Point(11, 139);
            this.grupoPaquetesFinancieros.Name = "grupoPaquetesFinancieros";
            this.grupoPaquetesFinancieros.Size = new System.Drawing.Size(964, 76);
            this.grupoPaquetesFinancieros.TabIndex = 55;
            this.grupoPaquetesFinancieros.TabStop = false;
            this.grupoPaquetesFinancieros.Text = "Informacion del Paciente";
            this.grupoPaquetesFinancieros.Visible = false;
            // 
            // comboPaquetes
            // 
            this.comboPaquetes.FormattingEnabled = true;
            this.comboPaquetes.Location = new System.Drawing.Point(293, 33);
            this.comboPaquetes.Name = "comboPaquetes";
            this.comboPaquetes.Size = new System.Drawing.Size(247, 28);
            this.comboPaquetes.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(154, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Paquetes financieros";
            // 
            // grupoDatosPaciente1
            // 
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
            this.grupoDatosPaciente1.Location = new System.Drawing.Point(11, 33);
            this.grupoDatosPaciente1.Name = "grupoDatosPaciente1";
            this.grupoDatosPaciente1.Size = new System.Drawing.Size(964, 102);
            this.grupoDatosPaciente1.TabIndex = 54;
            this.grupoDatosPaciente1.TabStop = false;
            this.grupoDatosPaciente1.Text = "Informacion del Paciente";
            this.grupoDatosPaciente1.Visible = false;
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
            // botonCancelar
            // 
            this.botonCancelar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.Image = global::CECLIMI.Properties.Resources.icono_cancelar;
            this.botonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonCancelar.Location = new System.Drawing.Point(562, 553);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(111, 29);
            this.botonCancelar.TabIndex = 11;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Visible = false;
            this.botonCancelar.Click += new System.EventHandler(this.BotonCancelarClick);
            // 
            // botonAceptar
            // 
            this.botonAceptar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAceptar.Image = global::CECLIMI.Properties.Resources.icono_aceptar1;
            this.botonAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonAceptar.Location = new System.Drawing.Point(857, 553);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(111, 29);
            this.botonAceptar.TabIndex = 10;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Visible = false;
            this.botonAceptar.Click += new System.EventHandler(this.BotonAceptarClick);
            // 
            // groupInformacionPago
            // 
            this.groupInformacionPago.Controls.Add(this.textTipoPago);
            this.groupInformacionPago.Controls.Add(this.label5);
            this.groupInformacionPago.Controls.Add(this.textSeguro);
            this.groupInformacionPago.Controls.Add(this.label4);
            this.groupInformacionPago.Controls.Add(this.gridPagosNuevos);
            this.groupInformacionPago.Controls.Add(this.textNombreQuienPaga);
            this.groupInformacionPago.Controls.Add(this.label3);
            this.groupInformacionPago.Controls.Add(this.botonAgregarPago);
            this.groupInformacionPago.Controls.Add(this.label20);
            this.groupInformacionPago.Controls.Add(this.label18);
            this.groupInformacionPago.Controls.Add(this.textAnoPago);
            this.groupInformacionPago.Controls.Add(this.textMesPago);
            this.groupInformacionPago.Controls.Add(this.textDiaPago);
            this.groupInformacionPago.Controls.Add(this.label9);
            this.groupInformacionPago.Controls.Add(this.textoNumeroFactura);
            this.groupInformacionPago.Controls.Add(this.label8);
            this.groupInformacionPago.Controls.Add(this.textoMontoPagar);
            this.groupInformacionPago.Controls.Add(this.label6);
            this.groupInformacionPago.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.groupInformacionPago.Location = new System.Drawing.Point(11, 221);
            this.groupInformacionPago.Name = "groupInformacionPago";
            this.groupInformacionPago.Size = new System.Drawing.Size(962, 326);
            this.groupInformacionPago.TabIndex = 30;
            this.groupInformacionPago.TabStop = false;
            this.groupInformacionPago.Text = "Informacion del Pago";
            this.groupInformacionPago.Visible = false;
            // 
            // textTipoPago
            // 
            this.textTipoPago.Location = new System.Drawing.Point(596, 90);
            this.textTipoPago.Name = "textTipoPago";
            this.textTipoPago.Size = new System.Drawing.Size(287, 26);
            this.textTipoPago.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 71;
            this.label5.Text = "* T-Pago";
            // 
            // textSeguro
            // 
            this.textSeguro.Location = new System.Drawing.Point(596, 58);
            this.textSeguro.Name = "textSeguro";
            this.textSeguro.Size = new System.Drawing.Size(287, 26);
            this.textSeguro.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "* Seguro";
            // 
            // gridPagosNuevos
            // 
            this.gridPagosNuevos.AllowUserToAddRows = false;
            this.gridPagosNuevos.AllowUserToDeleteRows = false;
            this.gridPagosNuevos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPagosNuevos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridPagosNuevos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPagosNuevos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPagosNuevos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFactura,
            this.monto,
            this.fechaPago,
            this.quienPaga,
            this.columnaSeguro,
            this.columnaTipoPago});
            this.gridPagosNuevos.Location = new System.Drawing.Point(13, 135);
            this.gridPagosNuevos.Name = "gridPagosNuevos";
            this.gridPagosNuevos.ReadOnly = true;
            this.gridPagosNuevos.Size = new System.Drawing.Size(887, 183);
            this.gridPagosNuevos.TabIndex = 68;
            // 
            // idFactura
            // 
            this.idFactura.HeaderText = "#Factura";
            this.idFactura.Name = "idFactura";
            this.idFactura.ReadOnly = true;
            // 
            // monto
            // 
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            // 
            // fechaPago
            // 
            this.fechaPago.HeaderText = "Fecha Pago";
            this.fechaPago.Name = "fechaPago";
            this.fechaPago.ReadOnly = true;
            // 
            // quienPaga
            // 
            this.quienPaga.HeaderText = "Quien Paga";
            this.quienPaga.Name = "quienPaga";
            this.quienPaga.ReadOnly = true;
            // 
            // columnaSeguro
            // 
            this.columnaSeguro.HeaderText = "Seguro";
            this.columnaSeguro.Name = "columnaSeguro";
            this.columnaSeguro.ReadOnly = true;
            // 
            // columnaTipoPago
            // 
            this.columnaTipoPago.HeaderText = "T-Pago";
            this.columnaTipoPago.Name = "columnaTipoPago";
            this.columnaTipoPago.ReadOnly = true;
            // 
            // textNombreQuienPaga
            // 
            this.textNombreQuienPaga.Location = new System.Drawing.Point(596, 26);
            this.textNombreQuienPaga.Name = "textNombreQuienPaga";
            this.textNombreQuienPaga.Size = new System.Drawing.Size(287, 26);
            this.textNombreQuienPaga.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 66;
            this.label3.Text = "* Quien Paga?";
            // 
            // botonAgregarPago
            // 
            this.botonAgregarPago.Image = global::CECLIMI.Properties.Resources.mas;
            this.botonAgregarPago.Location = new System.Drawing.Point(906, 135);
            this.botonAgregarPago.Name = "botonAgregarPago";
            this.botonAgregarPago.Size = new System.Drawing.Size(38, 29);
            this.botonAgregarPago.TabIndex = 9;
            this.botonAgregarPago.UseVisualStyleBackColor = true;
            this.botonAgregarPago.Click += new System.EventHandler(this.BotonAgregarPagoClick);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(312, 91);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 20);
            this.label20.TabIndex = 64;
            this.label20.Text = "/";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(258, 90);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 20);
            this.label18.TabIndex = 63;
            this.label18.Text = "/";
            // 
            // textAnoPago
            // 
            this.textAnoPago.Location = new System.Drawing.Point(328, 88);
            this.textAnoPago.Name = "textAnoPago";
            this.textAnoPago.Size = new System.Drawing.Size(75, 26);
            this.textAnoPago.TabIndex = 5;
            this.textAnoPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textMesPago
            // 
            this.textMesPago.Location = new System.Drawing.Point(273, 88);
            this.textMesPago.Name = "textMesPago";
            this.textMesPago.Size = new System.Drawing.Size(38, 26);
            this.textMesPago.TabIndex = 4;
            this.textMesPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textDiaPago
            // 
            this.textDiaPago.Location = new System.Drawing.Point(221, 88);
            this.textDiaPago.Name = "textDiaPago";
            this.textDiaPago.Size = new System.Drawing.Size(38, 26);
            this.textDiaPago.TabIndex = 3;
            this.textDiaPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(107, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "* Fecha Pago";
            // 
            // textoNumeroFactura
            // 
            this.textoNumeroFactura.Location = new System.Drawing.Point(221, 24);
            this.textoNumeroFactura.Name = "textoNumeroFactura";
            this.textoNumeroFactura.Size = new System.Drawing.Size(231, 26);
            this.textoNumeroFactura.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "* Numero de Factura";
            // 
            // textoMontoPagar
            // 
            this.textoMontoPagar.Location = new System.Drawing.Point(221, 56);
            this.textoMontoPagar.Name = "textoMontoPagar";
            this.textoMontoPagar.Size = new System.Drawing.Size(231, 26);
            this.textoMontoPagar.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "* Monto a Pagar BsF";
            // 
            // grupoInformacionPaciente
            // 
            this.grupoInformacionPaciente.Controls.Add(this.botonBuscar);
            this.grupoInformacionPaciente.Controls.Add(this.textoCiPaciente);
            this.grupoInformacionPaciente.Controls.Add(this.label2);
            this.grupoInformacionPaciente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoInformacionPaciente.Location = new System.Drawing.Point(11, 34);
            this.grupoInformacionPaciente.Name = "grupoInformacionPaciente";
            this.grupoInformacionPaciente.Size = new System.Drawing.Size(962, 72);
            this.grupoInformacionPaciente.TabIndex = 28;
            this.grupoInformacionPaciente.TabStop = false;
            this.grupoInformacionPaciente.Text = "Informacion del paciente";
            // 
            // botonBuscar
            // 
            this.botonBuscar.Image = global::CECLIMI.Properties.Resources.boton_buscar;
            this.botonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonBuscar.Location = new System.Drawing.Point(632, 22);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(30, 29);
            this.botonBuscar.TabIndex = 52;
            this.botonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.Button6Click);
            // 
            // textoCiPaciente
            // 
            this.textoCiPaciente.Location = new System.Drawing.Point(406, 25);
            this.textoCiPaciente.Name = "textoCiPaciente";
            this.textoCiPaciente.Size = new System.Drawing.Size(220, 26);
            this.textoCiPaciente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "CI Paciente";
            // 
            // textInformacionPagos
            // 
            this.textInformacionPagos.AutoSize = true;
            this.textInformacionPagos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInformacionPagos.Location = new System.Drawing.Point(205, 9);
            this.textInformacionPagos.Name = "textInformacionPagos";
            this.textInformacionPagos.Size = new System.Drawing.Size(138, 22);
            this.textInformacionPagos.TabIndex = 27;
            this.textInformacionPagos.Text = "Agregar Pago";
            // 
            // AgregarPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.panel1);
            this.Name = "AgregarPagos";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grupoPaquetesFinancieros.ResumeLayout(false);
            this.grupoPaquetesFinancieros.PerformLayout();
            this.grupoDatosPaciente1.ResumeLayout(false);
            this.grupoDatosPaciente1.PerformLayout();
            this.groupInformacionPago.ResumeLayout(false);
            this.groupInformacionPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPagosNuevos)).EndInit();
            this.grupoInformacionPaciente.ResumeLayout(false);
            this.grupoInformacionPaciente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label textInformacionPagos;
        private System.Windows.Forms.GroupBox grupoInformacionPaciente;
        private System.Windows.Forms.TextBox textoCiPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.GroupBox groupInformacionPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textoNumeroFactura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textoMontoPagar;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textAnoPago;
        private System.Windows.Forms.TextBox textMesPago;
        private System.Windows.Forms.TextBox textDiaPago;
        private System.Windows.Forms.Button botonAgregarPago;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.TextBox textNombreQuienPaga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridPagosNuevos;
        private System.Windows.Forms.TextBox textTipoPago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textSeguro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn quienPaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaSeguro;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaTipoPago;
        private System.Windows.Forms.GroupBox grupoDatosPaciente1;
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
        private System.Windows.Forms.GroupBox grupoPaquetesFinancieros;
        private System.Windows.Forms.ComboBox comboPaquetes;
        private System.Windows.Forms.Label label13;
    }
}
