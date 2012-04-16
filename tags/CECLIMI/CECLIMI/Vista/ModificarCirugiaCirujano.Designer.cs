namespace CECLIMI.Vista
{
    partial class ModificarCirugiaCirujano
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
            this.textModificarPaciente = new System.Windows.Forms.Label();
            this.grupoInformacionCirujano = new System.Windows.Forms.GroupBox();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.textoCiCirujano = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupCirugiasCirujano = new System.Windows.Forms.GroupBox();
            this.gridInformacionCirugiasCirujano = new System.Windows.Forms.DataGridView();
            this.nombreCirugia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.honorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.honorarioOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cirugia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cirujano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoDatosCirujano = new System.Windows.Forms.GroupBox();
            this.textCorreoElectronicoModificar = new System.Windows.Forms.Label();
            this.textTelefonoMovilModificar = new System.Windows.Forms.Label();
            this.textTelefonoModificar = new System.Windows.Forms.Label();
            this.textApellidoModificar = new System.Windows.Forms.Label();
            this.textNombreModificar = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.grupoInformacionCirujano.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupCirugiasCirujano.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInformacionCirugiasCirujano)).BeginInit();
            this.grupoDatosCirujano.SuspendLayout();
            this.SuspendLayout();
            // 
            // textModificarPaciente
            // 
            this.textModificarPaciente.AutoSize = true;
            this.textModificarPaciente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textModificarPaciente.Location = new System.Drawing.Point(204, 8);
            this.textModificarPaciente.Name = "textModificarPaciente";
            this.textModificarPaciente.Size = new System.Drawing.Size(279, 22);
            this.textModificarPaciente.TabIndex = 28;
            this.textModificarPaciente.Text = "Modificar Honorario Cirujano";
            // 
            // grupoInformacionCirujano
            // 
            this.grupoInformacionCirujano.Controls.Add(this.botonBuscar);
            this.grupoInformacionCirujano.Controls.Add(this.textoCiCirujano);
            this.grupoInformacionCirujano.Controls.Add(this.label2);
            this.grupoInformacionCirujano.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoInformacionCirujano.Location = new System.Drawing.Point(13, 33);
            this.grupoInformacionCirujano.Name = "grupoInformacionCirujano";
            this.grupoInformacionCirujano.Size = new System.Drawing.Size(962, 91);
            this.grupoInformacionCirujano.TabIndex = 29;
            this.grupoInformacionCirujano.TabStop = false;
            this.grupoInformacionCirujano.Text = "Cirujano";
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
            this.botonBuscar.Click += new System.EventHandler(this.BotonBuscarClick);
            // 
            // textoCiCirujano
            // 
            this.textoCiCirujano.Location = new System.Drawing.Point(237, 45);
            this.textoCiCirujano.Name = "textoCiCirujano";
            this.textoCiCirujano.Size = new System.Drawing.Size(220, 26);
            this.textoCiCirujano.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "CI Cirujano";
            // 
            // botonAceptar
            // 
            this.botonAceptar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAceptar.Image = global::CECLIMI.Properties.Resources.icono_aceptar1;
            this.botonAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonAceptar.Location = new System.Drawing.Point(781, 558);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(111, 29);
            this.botonAceptar.TabIndex = 33;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.BotonAceptarClick);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.Image = global::CECLIMI.Properties.Resources.icono_cancelar;
            this.botonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonCancelar.Location = new System.Drawing.Point(486, 558);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(111, 29);
            this.botonCancelar.TabIndex = 34;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.BotonCancelarClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupCirugiasCirujano);
            this.panel1.Controls.Add(this.botonCancelar);
            this.panel1.Controls.Add(this.botonAceptar);
            this.panel1.Controls.Add(this.textModificarPaciente);
            this.panel1.Controls.Add(this.grupoInformacionCirujano);
            this.panel1.Controls.Add(this.grupoDatosCirujano);
            this.panel1.Location = new System.Drawing.Point(257, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 646);
            this.panel1.TabIndex = 11;
            // 
            // groupCirugiasCirujano
            // 
            this.groupCirugiasCirujano.Controls.Add(this.gridInformacionCirugiasCirujano);
            this.groupCirugiasCirujano.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCirugiasCirujano.Location = new System.Drawing.Point(13, 151);
            this.groupCirugiasCirujano.Name = "groupCirugiasCirujano";
            this.groupCirugiasCirujano.Size = new System.Drawing.Size(962, 401);
            this.groupCirugiasCirujano.TabIndex = 36;
            this.groupCirugiasCirujano.TabStop = false;
            this.groupCirugiasCirujano.Text = "Informacion Cirugias Cirujano";
            this.groupCirugiasCirujano.Visible = false;
            // 
            // gridInformacionCirugiasCirujano
            // 
            this.gridInformacionCirugiasCirujano.AllowUserToAddRows = false;
            this.gridInformacionCirugiasCirujano.AllowUserToDeleteRows = false;
            this.gridInformacionCirugiasCirujano.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridInformacionCirugiasCirujano.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridInformacionCirugiasCirujano.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridInformacionCirugiasCirujano.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInformacionCirugiasCirujano.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreCirugia,
            this.honorario,
            this.honorarioOriginal,
            this.id_cirugia,
            this.id_cirujano});
            this.gridInformacionCirugiasCirujano.Location = new System.Drawing.Point(16, 36);
            this.gridInformacionCirugiasCirujano.Name = "gridInformacionCirugiasCirujano";
            this.gridInformacionCirugiasCirujano.Size = new System.Drawing.Size(925, 359);
            this.gridInformacionCirugiasCirujano.TabIndex = 0;
            // 
            // nombreCirugia
            // 
            this.nombreCirugia.HeaderText = "Cirugia";
            this.nombreCirugia.Name = "nombreCirugia";
            // 
            // honorario
            // 
            this.honorario.HeaderText = "Honorario";
            this.honorario.Name = "honorario";
            // 
            // honorarioOriginal
            // 
            this.honorarioOriginal.HeaderText = "honorarioOriginal";
            this.honorarioOriginal.Name = "honorarioOriginal";
            this.honorarioOriginal.Visible = false;
            // 
            // id_cirugia
            // 
            this.id_cirugia.HeaderText = "id_cirugia";
            this.id_cirugia.Name = "id_cirugia";
            this.id_cirugia.Visible = false;
            // 
            // id_cirujano
            // 
            this.id_cirujano.HeaderText = "id_cirujano";
            this.id_cirujano.Name = "id_cirujano";
            this.id_cirujano.Visible = false;
            // 
            // grupoDatosCirujano
            // 
            this.grupoDatosCirujano.Controls.Add(this.textCorreoElectronicoModificar);
            this.grupoDatosCirujano.Controls.Add(this.textTelefonoMovilModificar);
            this.grupoDatosCirujano.Controls.Add(this.textTelefonoModificar);
            this.grupoDatosCirujano.Controls.Add(this.textApellidoModificar);
            this.grupoDatosCirujano.Controls.Add(this.textNombreModificar);
            this.grupoDatosCirujano.Controls.Add(this.label11);
            this.grupoDatosCirujano.Controls.Add(this.label10);
            this.grupoDatosCirujano.Controls.Add(this.label7);
            this.grupoDatosCirujano.Controls.Add(this.label5);
            this.grupoDatosCirujano.Controls.Add(this.label12);
            this.grupoDatosCirujano.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoDatosCirujano.Location = new System.Drawing.Point(13, 33);
            this.grupoDatosCirujano.Name = "grupoDatosCirujano";
            this.grupoDatosCirujano.Size = new System.Drawing.Size(962, 118);
            this.grupoDatosCirujano.TabIndex = 35;
            this.grupoDatosCirujano.TabStop = false;
            this.grupoDatosCirujano.Text = "Cirujano";
            this.grupoDatosCirujano.Visible = false;
            // 
            // textCorreoElectronicoModificar
            // 
            this.textCorreoElectronicoModificar.AutoSize = true;
            this.textCorreoElectronicoModificar.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCorreoElectronicoModificar.Location = new System.Drawing.Point(743, 34);
            this.textCorreoElectronicoModificar.Name = "textCorreoElectronicoModificar";
            this.textCorreoElectronicoModificar.Size = new System.Drawing.Size(0, 17);
            this.textCorreoElectronicoModificar.TabIndex = 23;
            // 
            // textTelefonoMovilModificar
            // 
            this.textTelefonoMovilModificar.AutoSize = true;
            this.textTelefonoMovilModificar.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelefonoMovilModificar.Location = new System.Drawing.Point(441, 70);
            this.textTelefonoMovilModificar.Name = "textTelefonoMovilModificar";
            this.textTelefonoMovilModificar.Size = new System.Drawing.Size(0, 17);
            this.textTelefonoMovilModificar.TabIndex = 22;
            // 
            // textTelefonoModificar
            // 
            this.textTelefonoModificar.AutoSize = true;
            this.textTelefonoModificar.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelefonoModificar.Location = new System.Drawing.Point(441, 32);
            this.textTelefonoModificar.Name = "textTelefonoModificar";
            this.textTelefonoModificar.Size = new System.Drawing.Size(0, 17);
            this.textTelefonoModificar.TabIndex = 21;
            // 
            // textApellidoModificar
            // 
            this.textApellidoModificar.AutoSize = true;
            this.textApellidoModificar.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellidoModificar.Location = new System.Drawing.Point(114, 72);
            this.textApellidoModificar.Name = "textApellidoModificar";
            this.textApellidoModificar.Size = new System.Drawing.Size(0, 17);
            this.textApellidoModificar.TabIndex = 20;
            // 
            // textNombreModificar
            // 
            this.textNombreModificar.AutoSize = true;
            this.textNombreModificar.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreModificar.Location = new System.Drawing.Point(114, 34);
            this.textNombreModificar.Name = "textNombreModificar";
            this.textNombreModificar.Size = new System.Drawing.Size(0, 17);
            this.textNombreModificar.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(624, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Correo Electronico";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(344, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Telefono Movil";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(352, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Telefono Fijo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Apellido";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Nombre";
            // 
            // ModificarCirugiaCirujano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.panel1);
            this.Name = "ModificarCirugiaCirujano";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.grupoInformacionCirujano.ResumeLayout(false);
            this.grupoInformacionCirujano.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupCirugiasCirujano.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridInformacionCirugiasCirujano)).EndInit();
            this.grupoDatosCirujano.ResumeLayout(false);
            this.grupoDatosCirujano.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textModificarPaciente;
        private System.Windows.Forms.GroupBox grupoInformacionCirujano;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.TextBox textoCiCirujano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grupoDatosCirujano;
        private System.Windows.Forms.Label textCorreoElectronicoModificar;
        private System.Windows.Forms.Label textTelefonoMovilModificar;
        private System.Windows.Forms.Label textTelefonoModificar;
        private System.Windows.Forms.Label textApellidoModificar;
        private System.Windows.Forms.Label textNombreModificar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupCirugiasCirujano;
        private System.Windows.Forms.DataGridView gridInformacionCirugiasCirujano;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCirugia;
        private System.Windows.Forms.DataGridViewTextBoxColumn honorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn honorarioOriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cirugia;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cirujano;

    }
}
