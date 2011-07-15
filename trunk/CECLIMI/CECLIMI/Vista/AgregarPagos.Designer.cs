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
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.botonAgregarPago = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textAnoPago = new System.Windows.Forms.TextBox();
            this.textMesPago = new System.Windows.Forms.TextBox();
            this.textDiaPago = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textoNumeroFactura = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textoMontoPagar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textoInformacionEstatusCliente = new System.Windows.Forms.Label();
            this.textoSaldoDeudorModificar = new System.Windows.Forms.Label();
            this.textoSaldoFavorModificar = new System.Windows.Forms.Label();
            this.textoTotalAbonadoModificar = new System.Windows.Forms.Label();
            this.textoSaldoDeudor = new System.Windows.Forms.Label();
            this.textoSaldoFavor = new System.Windows.Forms.Label();
            this.textoTotalAbonado = new System.Windows.Forms.Label();
            this.gridInformacionPagos = new System.Windows.Forms.DataGridView();
            this.columnaNumeroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoInformacionPaciente = new System.Windows.Forms.GroupBox();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.textoCiPaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textInformacionPagos = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInformacionPagos)).BeginInit();
            this.grupoInformacionPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.botonCancelar);
            this.panel1.Controls.Add(this.botonAceptar);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.grupoInformacionPaciente);
            this.panel1.Controls.Add(this.textInformacionPagos);
            this.panel1.Location = new System.Drawing.Point(257, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 620);
            this.panel1.TabIndex = 9;
            // 
            // botonCancelar
            // 
            this.botonCancelar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.Location = new System.Drawing.Point(561, 484);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(111, 29);
            this.botonCancelar.TabIndex = 32;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            // 
            // botonAceptar
            // 
            this.botonAceptar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAceptar.Location = new System.Drawing.Point(856, 484);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(111, 29);
            this.botonAceptar.TabIndex = 31;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.botonAgregarPago);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.textAnoPago);
            this.groupBox2.Controls.Add(this.textMesPago);
            this.groupBox2.Controls.Add(this.textDiaPago);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textoNumeroFactura);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textoMontoPagar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.groupBox2.Location = new System.Drawing.Point(11, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(962, 114);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion del Pago";
            // 
            // botonAgregarPago
            // 
            this.botonAgregarPago.Image = global::CECLIMI.Properties.Resources.mas;
            this.botonAgregarPago.Location = new System.Drawing.Point(907, 79);
            this.botonAgregarPago.Name = "botonAgregarPago";
            this.botonAgregarPago.Size = new System.Drawing.Size(38, 29);
            this.botonAgregarPago.TabIndex = 65;
            this.botonAgregarPago.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(852, 40);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 20);
            this.label20.TabIndex = 64;
            this.label20.Text = "/";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(791, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 20);
            this.label18.TabIndex = 63;
            this.label18.Text = "/";
            // 
            // textAnoPago
            // 
            this.textAnoPago.Location = new System.Drawing.Point(870, 37);
            this.textAnoPago.Name = "textAnoPago";
            this.textAnoPago.Size = new System.Drawing.Size(75, 26);
            this.textAnoPago.TabIndex = 62;
            this.textAnoPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textMesPago
            // 
            this.textMesPago.Location = new System.Drawing.Point(808, 37);
            this.textMesPago.Name = "textMesPago";
            this.textMesPago.Size = new System.Drawing.Size(38, 26);
            this.textMesPago.TabIndex = 61;
            this.textMesPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textDiaPago
            // 
            this.textDiaPago.Location = new System.Drawing.Point(749, 37);
            this.textDiaPago.Name = "textDiaPago";
            this.textDiaPago.Size = new System.Drawing.Size(38, 26);
            this.textDiaPago.TabIndex = 60;
            this.textDiaPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(667, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Fecha Pago";
            // 
            // textoNumeroFactura
            // 
            this.textoNumeroFactura.Location = new System.Drawing.Point(485, 37);
            this.textoNumeroFactura.Name = "textoNumeroFactura";
            this.textoNumeroFactura.Size = new System.Drawing.Size(141, 26);
            this.textoNumeroFactura.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Numero de Factura";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "BsF";
            // 
            // textoMontoPagar
            // 
            this.textoMontoPagar.Location = new System.Drawing.Point(130, 34);
            this.textoMontoPagar.Name = "textoMontoPagar";
            this.textoMontoPagar.Size = new System.Drawing.Size(141, 26);
            this.textoMontoPagar.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Monto a Pagar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textoInformacionEstatusCliente);
            this.groupBox1.Controls.Add(this.textoSaldoDeudorModificar);
            this.groupBox1.Controls.Add(this.textoSaldoFavorModificar);
            this.groupBox1.Controls.Add(this.textoTotalAbonadoModificar);
            this.groupBox1.Controls.Add(this.textoSaldoDeudor);
            this.groupBox1.Controls.Add(this.textoSaldoFavor);
            this.groupBox1.Controls.Add(this.textoTotalAbonado);
            this.groupBox1.Controls.Add(this.gridInformacionPagos);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.groupBox1.Location = new System.Drawing.Point(11, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(962, 223);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estatus de la cuenta del paciente";
            // 
            // textoInformacionEstatusCliente
            // 
            this.textoInformacionEstatusCliente.AutoSize = true;
            this.textoInformacionEstatusCliente.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoInformacionEstatusCliente.Location = new System.Drawing.Point(159, 97);
            this.textoInformacionEstatusCliente.Name = "textoInformacionEstatusCliente";
            this.textoInformacionEstatusCliente.Size = new System.Drawing.Size(673, 29);
            this.textoInformacionEstatusCliente.TabIndex = 7;
            this.textoInformacionEstatusCliente.Text = "Introduzca la informacion del paciente, para obtener el estatus de su cuenta.";
            // 
            // textoSaldoDeudorModificar
            // 
            this.textoSaldoDeudorModificar.AutoSize = true;
            this.textoSaldoDeudorModificar.Location = new System.Drawing.Point(679, 187);
            this.textoSaldoDeudorModificar.Name = "textoSaldoDeudorModificar";
            this.textoSaldoDeudorModificar.Size = new System.Drawing.Size(45, 20);
            this.textoSaldoDeudorModificar.TabIndex = 6;
            this.textoSaldoDeudorModificar.Text = "label6";
            this.textoSaldoDeudorModificar.Visible = false;
            // 
            // textoSaldoFavorModificar
            // 
            this.textoSaldoFavorModificar.AutoSize = true;
            this.textoSaldoFavorModificar.Location = new System.Drawing.Point(679, 162);
            this.textoSaldoFavorModificar.Name = "textoSaldoFavorModificar";
            this.textoSaldoFavorModificar.Size = new System.Drawing.Size(45, 20);
            this.textoSaldoFavorModificar.TabIndex = 5;
            this.textoSaldoFavorModificar.Text = "label6";
            this.textoSaldoFavorModificar.Visible = false;
            // 
            // textoTotalAbonadoModificar
            // 
            this.textoTotalAbonadoModificar.AutoSize = true;
            this.textoTotalAbonadoModificar.Location = new System.Drawing.Point(679, 137);
            this.textoTotalAbonadoModificar.Name = "textoTotalAbonadoModificar";
            this.textoTotalAbonadoModificar.Size = new System.Drawing.Size(45, 20);
            this.textoTotalAbonadoModificar.TabIndex = 4;
            this.textoTotalAbonadoModificar.Text = "label6";
            this.textoTotalAbonadoModificar.Visible = false;
            // 
            // textoSaldoDeudor
            // 
            this.textoSaldoDeudor.AutoSize = true;
            this.textoSaldoDeudor.Location = new System.Drawing.Point(570, 187);
            this.textoSaldoDeudor.Name = "textoSaldoDeudor";
            this.textoSaldoDeudor.Size = new System.Drawing.Size(91, 20);
            this.textoSaldoDeudor.TabIndex = 3;
            this.textoSaldoDeudor.Text = "Saldo deudor";
            this.textoSaldoDeudor.Visible = false;
            // 
            // textoSaldoFavor
            // 
            this.textoSaldoFavor.AutoSize = true;
            this.textoSaldoFavor.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.textoSaldoFavor.Location = new System.Drawing.Point(573, 162);
            this.textoSaldoFavor.Name = "textoSaldoFavor";
            this.textoSaldoFavor.Size = new System.Drawing.Size(88, 20);
            this.textoSaldoFavor.TabIndex = 2;
            this.textoSaldoFavor.Text = "Saldo a favor";
            this.textoSaldoFavor.Visible = false;
            // 
            // textoTotalAbonado
            // 
            this.textoTotalAbonado.AutoSize = true;
            this.textoTotalAbonado.Location = new System.Drawing.Point(567, 137);
            this.textoTotalAbonado.Name = "textoTotalAbonado";
            this.textoTotalAbonado.Size = new System.Drawing.Size(94, 20);
            this.textoTotalAbonado.TabIndex = 1;
            this.textoTotalAbonado.Text = "Total abonado";
            this.textoTotalAbonado.Visible = false;
            // 
            // gridInformacionPagos
            // 
            this.gridInformacionPagos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridInformacionPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridInformacionPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInformacionPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaNumeroFactura,
            this.columnaFecha,
            this.columnaPago});
            this.gridInformacionPagos.Location = new System.Drawing.Point(19, 29);
            this.gridInformacionPagos.Name = "gridInformacionPagos";
            this.gridInformacionPagos.Size = new System.Drawing.Size(926, 105);
            this.gridInformacionPagos.TabIndex = 0;
            this.gridInformacionPagos.Visible = false;
            // 
            // columnaNumeroFactura
            // 
            this.columnaNumeroFactura.HeaderText = "Numero Factura";
            this.columnaNumeroFactura.Name = "columnaNumeroFactura";
            this.columnaNumeroFactura.ReadOnly = true;
            this.columnaNumeroFactura.Width = 300;
            // 
            // columnaFecha
            // 
            this.columnaFecha.HeaderText = "Fecha";
            this.columnaFecha.Name = "columnaFecha";
            this.columnaFecha.ReadOnly = true;
            this.columnaFecha.Width = 300;
            // 
            // columnaPago
            // 
            this.columnaPago.HeaderText = "Pago";
            this.columnaPago.Name = "columnaPago";
            this.columnaPago.ReadOnly = true;
            this.columnaPago.Width = 280;
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
            this.botonBuscar.Location = new System.Drawing.Point(463, 42);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(30, 29);
            this.botonBuscar.TabIndex = 52;
            this.botonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.button6_Click);
            // 
            // textoCiPaciente
            // 
            this.textoCiPaciente.Location = new System.Drawing.Point(237, 45);
            this.textoCiPaciente.Name = "textoCiPaciente";
            this.textoCiPaciente.Size = new System.Drawing.Size(220, 26);
            this.textoCiPaciente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 51);
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
            this.ClientSize = new System.Drawing.Size(1264, 762);
            this.Controls.Add(this.panel1);
            this.Name = "AgregarPagos";
            this.Load += new System.EventHandler(this.AgregarPagos_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInformacionPagos)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridInformacionPagos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label textoSaldoDeudorModificar;
        private System.Windows.Forms.Label textoSaldoFavorModificar;
        private System.Windows.Forms.Label textoTotalAbonadoModificar;
        private System.Windows.Forms.Label textoSaldoDeudor;
        private System.Windows.Forms.Label textoSaldoFavor;
        private System.Windows.Forms.Label textoTotalAbonado;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaNumeroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textoNumeroFactura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textoMontoPagar;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textAnoPago;
        private System.Windows.Forms.TextBox textMesPago;
        private System.Windows.Forms.TextBox textDiaPago;
        private System.Windows.Forms.Button botonAgregarPago;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Label textoInformacionEstatusCliente;
    }
}
