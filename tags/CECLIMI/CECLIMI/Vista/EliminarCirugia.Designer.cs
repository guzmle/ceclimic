namespace CECLIMI.Vista
{
    partial class EliminarCirugia
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
            this.groupCirugiaEliminar = new System.Windows.Forms.GroupBox();
            this.textIdCirugia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupCirugias = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCirugia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCirugia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cirujano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoCirugia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textInformacionVentana = new System.Windows.Forms.Label();
            this.botonCancelarCirugia = new System.Windows.Forms.Button();
            this.botonAceptarCirugia = new System.Windows.Forms.Button();
            this.grupoInformacionPaciente = new System.Windows.Forms.GroupBox();
            this.botonBuscarPaciente = new System.Windows.Forms.Button();
            this.textoCiPaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            this.groupCirugiaEliminar.SuspendLayout();
            this.groupCirugias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grupoInformacionPaciente.SuspendLayout();
            this.grupoDatosPaciente1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupCirugiaEliminar);
            this.panel1.Controls.Add(this.groupCirugias);
            this.panel1.Controls.Add(this.textInformacionVentana);
            this.panel1.Controls.Add(this.botonCancelarCirugia);
            this.panel1.Controls.Add(this.botonAceptarCirugia);
            this.panel1.Controls.Add(this.grupoInformacionPaciente);
            this.panel1.Controls.Add(this.grupoDatosPaciente1);
            this.panel1.Location = new System.Drawing.Point(261, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 646);
            this.panel1.TabIndex = 11;
            // 
            // groupCirugiaEliminar
            // 
            this.groupCirugiaEliminar.Controls.Add(this.textIdCirugia);
            this.groupCirugiaEliminar.Controls.Add(this.label3);
            this.groupCirugiaEliminar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCirugiaEliminar.Location = new System.Drawing.Point(9, 282);
            this.groupCirugiaEliminar.Name = "groupCirugiaEliminar";
            this.groupCirugiaEliminar.Size = new System.Drawing.Size(966, 129);
            this.groupCirugiaEliminar.TabIndex = 56;
            this.groupCirugiaEliminar.TabStop = false;
            this.groupCirugiaEliminar.Text = "Informacion cirugia a eliminar";
            this.groupCirugiaEliminar.Visible = false;
            // 
            // textIdCirugia
            // 
            this.textIdCirugia.Location = new System.Drawing.Point(169, 50);
            this.textIdCirugia.Name = "textIdCirugia";
            this.textIdCirugia.Size = new System.Drawing.Size(220, 26);
            this.textIdCirugia.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "ID Cirugia";
            // 
            // groupCirugias
            // 
            this.groupCirugias.Controls.Add(this.dataGridView1);
            this.groupCirugias.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCirugias.Location = new System.Drawing.Point(9, 133);
            this.groupCirugias.Name = "groupCirugias";
            this.groupCirugias.Size = new System.Drawing.Size(966, 149);
            this.groupCirugias.TabIndex = 55;
            this.groupCirugias.TabStop = false;
            this.groupCirugias.Text = "Cirugias Paciente";
            this.groupCirugias.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCirugia,
            this.tipoCirugia,
            this.Cirujano,
            this.fechaOperacion,
            this.costoCirugia});
            this.dataGridView1.Location = new System.Drawing.Point(26, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(918, 107);
            this.dataGridView1.TabIndex = 0;
            // 
            // idCirugia
            // 
            this.idCirugia.HeaderText = "ID Cirugia";
            this.idCirugia.Name = "idCirugia";
            this.idCirugia.ReadOnly = true;
            // 
            // tipoCirugia
            // 
            this.tipoCirugia.HeaderText = "Tipo Cirugia";
            this.tipoCirugia.Name = "tipoCirugia";
            this.tipoCirugia.ReadOnly = true;
            // 
            // Cirujano
            // 
            this.Cirujano.HeaderText = "Cirujano";
            this.Cirujano.Name = "Cirujano";
            this.Cirujano.ReadOnly = true;
            // 
            // fechaOperacion
            // 
            this.fechaOperacion.HeaderText = "Fecha Operacion";
            this.fechaOperacion.Name = "fechaOperacion";
            this.fechaOperacion.ReadOnly = true;
            // 
            // costoCirugia
            // 
            this.costoCirugia.HeaderText = "Costo Cirugia BsF";
            this.costoCirugia.Name = "costoCirugia";
            this.costoCirugia.ReadOnly = true;
            // 
            // textInformacionVentana
            // 
            this.textInformacionVentana.AutoSize = true;
            this.textInformacionVentana.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInformacionVentana.Location = new System.Drawing.Point(173, 17);
            this.textInformacionVentana.Name = "textInformacionVentana";
            this.textInformacionVentana.Size = new System.Drawing.Size(298, 22);
            this.textInformacionVentana.TabIndex = 53;
            this.textInformacionVentana.Text = "Eliminar Cirugia a un pacientes";
            // 
            // botonCancelarCirugia
            // 
            this.botonCancelarCirugia.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelarCirugia.Image = global::CECLIMI.Properties.Resources.icono_cancelar;
            this.botonCancelarCirugia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonCancelarCirugia.Location = new System.Drawing.Point(547, 425);
            this.botonCancelarCirugia.Name = "botonCancelarCirugia";
            this.botonCancelarCirugia.Size = new System.Drawing.Size(111, 29);
            this.botonCancelarCirugia.TabIndex = 40;
            this.botonCancelarCirugia.Text = "Cancelar";
            this.botonCancelarCirugia.UseVisualStyleBackColor = true;
            // 
            // botonAceptarCirugia
            // 
            this.botonAceptarCirugia.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAceptarCirugia.Image = global::CECLIMI.Properties.Resources.icono_aceptar1;
            this.botonAceptarCirugia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonAceptarCirugia.Location = new System.Drawing.Point(842, 425);
            this.botonAceptarCirugia.Name = "botonAceptarCirugia";
            this.botonAceptarCirugia.Size = new System.Drawing.Size(111, 29);
            this.botonAceptarCirugia.TabIndex = 39;
            this.botonAceptarCirugia.Text = "Aceptar";
            this.botonAceptarCirugia.UseVisualStyleBackColor = true;
            this.botonAceptarCirugia.Click += new System.EventHandler(this.BotonAceptarCirugiaClick);
            // 
            // grupoInformacionPaciente
            // 
            this.grupoInformacionPaciente.Controls.Add(this.botonBuscarPaciente);
            this.grupoInformacionPaciente.Controls.Add(this.textoCiPaciente);
            this.grupoInformacionPaciente.Controls.Add(this.label2);
            this.grupoInformacionPaciente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoInformacionPaciente.Location = new System.Drawing.Point(9, 42);
            this.grupoInformacionPaciente.Name = "grupoInformacionPaciente";
            this.grupoInformacionPaciente.Size = new System.Drawing.Size(966, 91);
            this.grupoInformacionPaciente.TabIndex = 41;
            this.grupoInformacionPaciente.TabStop = false;
            this.grupoInformacionPaciente.Text = "Informacion del paciente";
            // 
            // botonBuscarPaciente
            // 
            this.botonBuscarPaciente.Image = global::CECLIMI.Properties.Resources.boton_buscar;
            this.botonBuscarPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonBuscarPaciente.Location = new System.Drawing.Point(394, 34);
            this.botonBuscarPaciente.Name = "botonBuscarPaciente";
            this.botonBuscarPaciente.Size = new System.Drawing.Size(30, 29);
            this.botonBuscarPaciente.TabIndex = 52;
            this.botonBuscarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonBuscarPaciente.UseVisualStyleBackColor = true;
            this.botonBuscarPaciente.Click += new System.EventHandler(this.BotonBuscarPacienteClick);
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
            this.label2.Location = new System.Drawing.Point(71, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "CI Paciente";
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
            this.grupoDatosPaciente1.Location = new System.Drawing.Point(9, 41);
            this.grupoDatosPaciente1.Name = "grupoDatosPaciente1";
            this.grupoDatosPaciente1.Size = new System.Drawing.Size(966, 92);
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
            // EliminarCirugia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.panel1);
            this.Name = "EliminarCirugia";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupCirugiaEliminar.ResumeLayout(false);
            this.groupCirugiaEliminar.PerformLayout();
            this.groupCirugias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grupoInformacionPaciente.ResumeLayout(false);
            this.grupoInformacionPaciente.PerformLayout();
            this.grupoDatosPaciente1.ResumeLayout(false);
            this.grupoDatosPaciente1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonCancelarCirugia;
        private System.Windows.Forms.Button botonAceptarCirugia;
        private System.Windows.Forms.GroupBox grupoInformacionPaciente;
        private System.Windows.Forms.Button botonBuscarPaciente;
        private System.Windows.Forms.TextBox textoCiPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label textInformacionVentana;
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
        private System.Windows.Forms.GroupBox groupCirugiaEliminar;
        private System.Windows.Forms.TextBox textIdCirugia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupCirugias;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCirugia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCirugia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cirujano;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoCirugia;
    }
}
