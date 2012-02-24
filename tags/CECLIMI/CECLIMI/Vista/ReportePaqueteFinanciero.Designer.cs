namespace CECLIMI.Vista
{
    partial class ReportePaqueteFinanciero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportePaqueteFinanciero));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grupoPaqueteFinanciero = new System.Windows.Forms.GroupBox();
            this.observaciones = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.fechaIntervencion = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gridPagos = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seguro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCirugias = new System.Windows.Forms.DataGridView();
            this.cirugia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cirujano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Honorarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Protesis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientesAlternos = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.correoPaciente = new System.Windows.Forms.Label();
            this.telefonosPaciente = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cedulaPaciente = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nombrePaciente = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fechaElaboracion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.textInformacionPagos = new System.Windows.Forms.Label();
            this.grupoInformacionPaciente = new System.Windows.Forms.GroupBox();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.textoCiPaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grupoPaquetesFinancieros = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboPaquetesFinancieros = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.grupoPaqueteFinanciero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCirugias)).BeginInit();
            this.grupoInformacionPaciente.SuspendLayout();
            this.grupoPaquetesFinancieros.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.grupoPaqueteFinanciero);
            this.panel1.Controls.Add(this.botonAceptar);
            this.panel1.Controls.Add(this.textInformacionPagos);
            this.panel1.Controls.Add(this.grupoInformacionPaciente);
            this.panel1.Controls.Add(this.grupoPaquetesFinancieros);
            this.panel1.Location = new System.Drawing.Point(257, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 646);
            this.panel1.TabIndex = 10;
            // 
            // grupoPaqueteFinanciero
            // 
            this.grupoPaqueteFinanciero.Controls.Add(this.observaciones);
            this.grupoPaqueteFinanciero.Controls.Add(this.label11);
            this.grupoPaqueteFinanciero.Controls.Add(this.fechaIntervencion);
            this.grupoPaqueteFinanciero.Controls.Add(this.label12);
            this.grupoPaqueteFinanciero.Controls.Add(this.gridPagos);
            this.grupoPaqueteFinanciero.Controls.Add(this.gridCirugias);
            this.grupoPaqueteFinanciero.Controls.Add(this.pacientesAlternos);
            this.grupoPaqueteFinanciero.Controls.Add(this.label10);
            this.grupoPaqueteFinanciero.Controls.Add(this.correoPaciente);
            this.grupoPaqueteFinanciero.Controls.Add(this.telefonosPaciente);
            this.grupoPaqueteFinanciero.Controls.Add(this.label9);
            this.grupoPaqueteFinanciero.Controls.Add(this.label8);
            this.grupoPaqueteFinanciero.Controls.Add(this.cedulaPaciente);
            this.grupoPaqueteFinanciero.Controls.Add(this.label7);
            this.grupoPaqueteFinanciero.Controls.Add(this.nombrePaciente);
            this.grupoPaqueteFinanciero.Controls.Add(this.label6);
            this.grupoPaqueteFinanciero.Controls.Add(this.fechaElaboracion);
            this.grupoPaqueteFinanciero.Controls.Add(this.label5);
            this.grupoPaqueteFinanciero.Controls.Add(this.label4);
            this.grupoPaqueteFinanciero.Controls.Add(this.label3);
            this.grupoPaqueteFinanciero.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoPaqueteFinanciero.Location = new System.Drawing.Point(9, 34);
            this.grupoPaqueteFinanciero.Name = "grupoPaqueteFinanciero";
            this.grupoPaqueteFinanciero.Size = new System.Drawing.Size(966, 568);
            this.grupoPaqueteFinanciero.TabIndex = 56;
            this.grupoPaqueteFinanciero.TabStop = false;
            this.grupoPaqueteFinanciero.Text = "Paquete Financiero";
            this.grupoPaqueteFinanciero.Visible = false;
            // 
            // observaciones
            // 
            this.observaciones.AutoSize = true;
            this.observaciones.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Underline);
            this.observaciones.Location = new System.Drawing.Point(158, 512);
            this.observaciones.MaximumSize = new System.Drawing.Size(800, 0);
            this.observaciones.Name = "observaciones";
            this.observaciones.Size = new System.Drawing.Size(799, 40);
            this.observaciones.TabIndex = 19;
            this.observaciones.Text = resources.GetString("observaciones.Text");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 512);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Observaciones:";
            // 
            // fechaIntervencion
            // 
            this.fechaIntervencion.AutoSize = true;
            this.fechaIntervencion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaIntervencion.Location = new System.Drawing.Point(156, 492);
            this.fechaIntervencion.Name = "fechaIntervencion";
            this.fechaIntervencion.Size = new System.Drawing.Size(113, 20);
            this.fechaIntervencion.TabIndex = 17;
            this.fechaIntervencion.Text = "fechaIntervencion";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 492);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Fecha Intervencion:";
            // 
            // gridPagos
            // 
            this.gridPagos.AllowUserToAddRows = false;
            this.gridPagos.AllowUserToDeleteRows = false;
            this.gridPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPagos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.monto,
            this.Fecha,
            this.Seguro,
            this.TipoPago});
            this.gridPagos.Location = new System.Drawing.Point(34, 295);
            this.gridPagos.Name = "gridPagos";
            this.gridPagos.ReadOnly = true;
            this.gridPagos.Size = new System.Drawing.Size(907, 194);
            this.gridPagos.TabIndex = 15;
            // 
            // name
            // 
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // monto
            // 
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Seguro
            // 
            this.Seguro.HeaderText = "Seguro";
            this.Seguro.Name = "Seguro";
            this.Seguro.ReadOnly = true;
            // 
            // TipoPago
            // 
            this.TipoPago.HeaderText = "Tipo Pago";
            this.TipoPago.Name = "TipoPago";
            this.TipoPago.ReadOnly = true;
            // 
            // gridCirugias
            // 
            this.gridCirugias.AllowUserToAddRows = false;
            this.gridCirugias.AllowUserToDeleteRows = false;
            this.gridCirugias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCirugias.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridCirugias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCirugias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCirugias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cirugia,
            this.cirujano,
            this.Honorarios,
            this.Protesis,
            this.Descuento,
            this.Total});
            this.gridCirugias.Location = new System.Drawing.Point(34, 190);
            this.gridCirugias.Name = "gridCirugias";
            this.gridCirugias.ReadOnly = true;
            this.gridCirugias.Size = new System.Drawing.Size(907, 96);
            this.gridCirugias.TabIndex = 14;
            // 
            // cirugia
            // 
            this.cirugia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cirugia.HeaderText = "Cirugia";
            this.cirugia.Name = "cirugia";
            this.cirugia.ReadOnly = true;
            this.cirugia.Width = 75;
            // 
            // cirujano
            // 
            this.cirujano.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cirujano.HeaderText = "Cirujano";
            this.cirujano.Name = "cirujano";
            this.cirujano.ReadOnly = true;
            this.cirujano.Width = 82;
            // 
            // Honorarios
            // 
            this.Honorarios.HeaderText = "Honorarios";
            this.Honorarios.Name = "Honorarios";
            this.Honorarios.ReadOnly = true;
            // 
            // Protesis
            // 
            this.Protesis.HeaderText = "Protesis";
            this.Protesis.Name = "Protesis";
            this.Protesis.ReadOnly = true;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // pacientesAlternos
            // 
            this.pacientesAlternos.AutoSize = true;
            this.pacientesAlternos.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Underline);
            this.pacientesAlternos.Location = new System.Drawing.Point(69, 145);
            this.pacientesAlternos.MaximumSize = new System.Drawing.Size(870, 0);
            this.pacientesAlternos.Name = "pacientesAlternos";
            this.pacientesAlternos.Size = new System.Drawing.Size(869, 40);
            this.pacientesAlternos.TabIndex = 13;
            this.pacientesAlternos.Text = resources.GetString("pacientesAlternos.Text");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.label10.Location = new System.Drawing.Point(36, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "PA:";
            // 
            // correoPaciente
            // 
            this.correoPaciente.AutoSize = true;
            this.correoPaciente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoPaciente.Location = new System.Drawing.Point(698, 120);
            this.correoPaciente.Name = "correoPaciente";
            this.correoPaciente.Size = new System.Drawing.Size(48, 20);
            this.correoPaciente.TabIndex = 11;
            this.correoPaciente.Text = "correo";
            // 
            // telefonosPaciente
            // 
            this.telefonosPaciente.AutoSize = true;
            this.telefonosPaciente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonosPaciente.Location = new System.Drawing.Point(698, 100);
            this.telefonosPaciente.Name = "telefonosPaciente";
            this.telefonosPaciente.Size = new System.Drawing.Size(64, 20);
            this.telefonosPaciente.TabIndex = 10;
            this.telefonosPaciente.Text = "telefonos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(638, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Correo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(620, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Telefonos:";
            // 
            // cedulaPaciente
            // 
            this.cedulaPaciente.AutoSize = true;
            this.cedulaPaciente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedulaPaciente.Location = new System.Drawing.Point(698, 80);
            this.cedulaPaciente.Name = "cedulaPaciente";
            this.cedulaPaciente.Size = new System.Drawing.Size(49, 20);
            this.cedulaPaciente.TabIndex = 7;
            this.cedulaPaciente.Text = "cedula";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(667, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "CI:";
            // 
            // nombrePaciente
            // 
            this.nombrePaciente.AutoSize = true;
            this.nombrePaciente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePaciente.Location = new System.Drawing.Point(101, 80);
            this.nombrePaciente.Name = "nombrePaciente";
            this.nombrePaciente.Size = new System.Drawing.Size(60, 20);
            this.nombrePaciente.TabIndex = 5;
            this.nombrePaciente.Text = "paciente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Paciente:";
            // 
            // fechaElaboracion
            // 
            this.fechaElaboracion.AutoSize = true;
            this.fechaElaboracion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaElaboracion.Location = new System.Drawing.Point(698, 45);
            this.fechaElaboracion.Name = "fechaElaboracion";
            this.fechaElaboracion.Size = new System.Drawing.Size(121, 20);
            this.fechaElaboracion.TabIndex = 3;
            this.fechaElaboracion.Text = "Fecha Elaboración";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(567, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fecha Elaboración:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Centro Clínico Miraflores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "CECLIMI";
            // 
            // botonAceptar
            // 
            this.botonAceptar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAceptar.Image = global::CECLIMI.Properties.Resources.icono_aceptar1;
            this.botonAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonAceptar.Location = new System.Drawing.Point(862, 608);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(111, 29);
            this.botonAceptar.TabIndex = 10;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Visible = false;
            this.botonAceptar.Click += new System.EventHandler(this.BotonAceptarClick);
            // 
            // textInformacionPagos
            // 
            this.textInformacionPagos.AutoSize = true;
            this.textInformacionPagos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInformacionPagos.Location = new System.Drawing.Point(205, 9);
            this.textInformacionPagos.Name = "textInformacionPagos";
            this.textInformacionPagos.Size = new System.Drawing.Size(268, 22);
            this.textInformacionPagos.TabIndex = 27;
            this.textInformacionPagos.Text = "Reporte Paquete Financiero";
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
            this.botonBuscar.Location = new System.Drawing.Point(514, 25);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(30, 29);
            this.botonBuscar.TabIndex = 52;
            this.botonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.BotonBuscarClick);
            // 
            // textoCiPaciente
            // 
            this.textoCiPaciente.Location = new System.Drawing.Point(288, 28);
            this.textoCiPaciente.Name = "textoCiPaciente";
            this.textoCiPaciente.Size = new System.Drawing.Size(220, 26);
            this.textoCiPaciente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "CI Paciente";
            // 
            // grupoPaquetesFinancieros
            // 
            this.grupoPaquetesFinancieros.Controls.Add(this.label13);
            this.grupoPaquetesFinancieros.Controls.Add(this.comboPaquetesFinancieros);
            this.grupoPaquetesFinancieros.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoPaquetesFinancieros.Location = new System.Drawing.Point(11, 107);
            this.grupoPaquetesFinancieros.Name = "grupoPaquetesFinancieros";
            this.grupoPaquetesFinancieros.Size = new System.Drawing.Size(962, 72);
            this.grupoPaquetesFinancieros.TabIndex = 53;
            this.grupoPaquetesFinancieros.TabStop = false;
            this.grupoPaquetesFinancieros.Text = "Paquetes Financieros";
            this.grupoPaquetesFinancieros.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(143, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Paquetes Financieros";
            // 
            // comboPaquetesFinancieros
            // 
            this.comboPaquetesFinancieros.FormattingEnabled = true;
            this.comboPaquetesFinancieros.Location = new System.Drawing.Point(288, 31);
            this.comboPaquetesFinancieros.Name = "comboPaquetesFinancieros";
            this.comboPaquetesFinancieros.Size = new System.Drawing.Size(220, 28);
            this.comboPaquetesFinancieros.TabIndex = 0;
            this.comboPaquetesFinancieros.SelectedIndexChanged += new System.EventHandler(this.ComboPaquetesFinancierosSelectedIndexChanged);
            // 
            // ReportePaqueteFinanciero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.panel1);
            this.Name = "ReportePaqueteFinanciero";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grupoPaqueteFinanciero.ResumeLayout(false);
            this.grupoPaqueteFinanciero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCirugias)).EndInit();
            this.grupoInformacionPaciente.ResumeLayout(false);
            this.grupoInformacionPaciente.PerformLayout();
            this.grupoPaquetesFinancieros.ResumeLayout(false);
            this.grupoPaquetesFinancieros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.GroupBox grupoInformacionPaciente;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.TextBox textoCiPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label textInformacionPagos;
        private System.Windows.Forms.GroupBox grupoPaqueteFinanciero;
        private System.Windows.Forms.Label correoPaciente;
        private System.Windows.Forms.Label telefonosPaciente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label cedulaPaciente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label nombrePaciente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label fechaElaboracion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pacientesAlternos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView gridCirugias;
        private System.Windows.Forms.Label observaciones;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label fechaIntervencion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView gridPagos;
        private System.Windows.Forms.GroupBox grupoPaquetesFinancieros;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboPaquetesFinancieros;
        private System.Windows.Forms.DataGridViewTextBoxColumn cirugia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cirujano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Honorarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protesis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seguro;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPago;
    }
}
