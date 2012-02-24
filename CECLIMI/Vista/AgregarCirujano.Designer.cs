namespace CECLIMI.Vista
{
    partial class AgregarCirujano
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botonCancelarCirugia = new System.Windows.Forms.Button();
            this.botonAceptarCirugia = new System.Windows.Forms.Button();
            this.textInformacionPagos = new System.Windows.Forms.Label();
            this.grupoDatosCirujano = new System.Windows.Forms.GroupBox();
            this.mensajeDeErrorTelefonoMovil = new System.Windows.Forms.Label();
            this.mensajeDeErrorCedula = new System.Windows.Forms.Label();
            this.mensajeDeErrorApellido = new System.Windows.Forms.Label();
            this.mensajeDeErrorNombre = new System.Windows.Forms.Label();
            this.textCorreoElectronico = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textTelefonoMovil = new System.Windows.Forms.TextBox();
            this.textCodigoAreaMovil = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textTelefonoFijo = new System.Windows.Forms.TextBox();
            this.textCodigoAreaFijo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textIdCirujano = new System.Windows.Forms.TextBox();
            this.textSegundoApellido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textPrimerApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textSegundoNombre = new System.Windows.Forms.TextBox();
            this.textPrimerNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grupoDatosCirujano.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.botonCancelarCirugia);
            this.panel1.Controls.Add(this.botonAceptarCirugia);
            this.panel1.Controls.Add(this.textInformacionPagos);
            this.panel1.Controls.Add(this.grupoDatosCirujano);
            this.panel1.Location = new System.Drawing.Point(257, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 646);
            this.panel1.TabIndex = 9;
            // 
            // botonCancelarCirugia
            // 
            this.botonCancelarCirugia.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelarCirugia.Image = global::CECLIMI.Properties.Resources.icono_cancelar;
            this.botonCancelarCirugia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonCancelarCirugia.Location = new System.Drawing.Point(552, 293);
            this.botonCancelarCirugia.Name = "botonCancelarCirugia";
            this.botonCancelarCirugia.Size = new System.Drawing.Size(111, 29);
            this.botonCancelarCirugia.TabIndex = 44;
            this.botonCancelarCirugia.Text = "Cancelar";
            this.botonCancelarCirugia.UseVisualStyleBackColor = true;
            this.botonCancelarCirugia.Click += new System.EventHandler(this.BotonCancelarCirugiaClick);
            // 
            // botonAceptarCirugia
            // 
            this.botonAceptarCirugia.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAceptarCirugia.Image = global::CECLIMI.Properties.Resources.icono_aceptar1;
            this.botonAceptarCirugia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonAceptarCirugia.Location = new System.Drawing.Point(847, 293);
            this.botonAceptarCirugia.Name = "botonAceptarCirugia";
            this.botonAceptarCirugia.Size = new System.Drawing.Size(111, 29);
            this.botonAceptarCirugia.TabIndex = 43;
            this.botonAceptarCirugia.Text = "Aceptar";
            this.botonAceptarCirugia.UseVisualStyleBackColor = true;
            this.botonAceptarCirugia.Click += new System.EventHandler(this.BotonAceptarCirugiaClick);
            // 
            // textInformacionPagos
            // 
            this.textInformacionPagos.AutoSize = true;
            this.textInformacionPagos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInformacionPagos.Location = new System.Drawing.Point(174, 11);
            this.textInformacionPagos.Name = "textInformacionPagos";
            this.textInformacionPagos.Size = new System.Drawing.Size(153, 22);
            this.textInformacionPagos.TabIndex = 42;
            this.textInformacionPagos.Text = "Nuevo Cirujano";
            // 
            // grupoDatosCirujano
            // 
            this.grupoDatosCirujano.Controls.Add(this.mensajeDeErrorTelefonoMovil);
            this.grupoDatosCirujano.Controls.Add(this.mensajeDeErrorCedula);
            this.grupoDatosCirujano.Controls.Add(this.mensajeDeErrorApellido);
            this.grupoDatosCirujano.Controls.Add(this.mensajeDeErrorNombre);
            this.grupoDatosCirujano.Controls.Add(this.textCorreoElectronico);
            this.grupoDatosCirujano.Controls.Add(this.label11);
            this.grupoDatosCirujano.Controls.Add(this.label9);
            this.grupoDatosCirujano.Controls.Add(this.textTelefonoMovil);
            this.grupoDatosCirujano.Controls.Add(this.textCodigoAreaMovil);
            this.grupoDatosCirujano.Controls.Add(this.label10);
            this.grupoDatosCirujano.Controls.Add(this.label8);
            this.grupoDatosCirujano.Controls.Add(this.textTelefonoFijo);
            this.grupoDatosCirujano.Controls.Add(this.textCodigoAreaFijo);
            this.grupoDatosCirujano.Controls.Add(this.label7);
            this.grupoDatosCirujano.Controls.Add(this.textIdCirujano);
            this.grupoDatosCirujano.Controls.Add(this.textSegundoApellido);
            this.grupoDatosCirujano.Controls.Add(this.label6);
            this.grupoDatosCirujano.Controls.Add(this.textPrimerApellido);
            this.grupoDatosCirujano.Controls.Add(this.label5);
            this.grupoDatosCirujano.Controls.Add(this.label4);
            this.grupoDatosCirujano.Controls.Add(this.textSegundoNombre);
            this.grupoDatosCirujano.Controls.Add(this.textPrimerNombre);
            this.grupoDatosCirujano.Controls.Add(this.label3);
            this.grupoDatosCirujano.Controls.Add(this.label2);
            this.grupoDatosCirujano.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoDatosCirujano.Location = new System.Drawing.Point(15, 45);
            this.grupoDatosCirujano.Name = "grupoDatosCirujano";
            this.grupoDatosCirujano.Size = new System.Drawing.Size(964, 218);
            this.grupoDatosCirujano.TabIndex = 1;
            this.grupoDatosCirujano.TabStop = false;
            this.grupoDatosCirujano.Text = "Informacion del Cirujano";
            // 
            // mensajeDeErrorTelefonoMovil
            // 
            this.mensajeDeErrorTelefonoMovil.AutoSize = true;
            this.mensajeDeErrorTelefonoMovil.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensajeDeErrorTelefonoMovil.ForeColor = System.Drawing.Color.Red;
            this.mensajeDeErrorTelefonoMovil.Location = new System.Drawing.Point(607, 149);
            this.mensajeDeErrorTelefonoMovil.Name = "mensajeDeErrorTelefonoMovil";
            this.mensajeDeErrorTelefonoMovil.Size = new System.Drawing.Size(130, 16);
            this.mensajeDeErrorTelefonoMovil.TabIndex = 53;
            this.mensajeDeErrorTelefonoMovil.Text = "Este campo es obligatorio.";
            this.mensajeDeErrorTelefonoMovil.Visible = false;
            // 
            // mensajeDeErrorCedula
            // 
            this.mensajeDeErrorCedula.AutoSize = true;
            this.mensajeDeErrorCedula.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensajeDeErrorCedula.ForeColor = System.Drawing.Color.Red;
            this.mensajeDeErrorCedula.Location = new System.Drawing.Point(607, 60);
            this.mensajeDeErrorCedula.Name = "mensajeDeErrorCedula";
            this.mensajeDeErrorCedula.Size = new System.Drawing.Size(130, 16);
            this.mensajeDeErrorCedula.TabIndex = 51;
            this.mensajeDeErrorCedula.Text = "Este campo es obligatorio.";
            this.mensajeDeErrorCedula.Visible = false;
            // 
            // mensajeDeErrorApellido
            // 
            this.mensajeDeErrorApellido.AutoSize = true;
            this.mensajeDeErrorApellido.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensajeDeErrorApellido.ForeColor = System.Drawing.Color.Red;
            this.mensajeDeErrorApellido.Location = new System.Drawing.Point(163, 150);
            this.mensajeDeErrorApellido.Name = "mensajeDeErrorApellido";
            this.mensajeDeErrorApellido.Size = new System.Drawing.Size(130, 16);
            this.mensajeDeErrorApellido.TabIndex = 49;
            this.mensajeDeErrorApellido.Text = "Este campo es obligatorio.";
            this.mensajeDeErrorApellido.Visible = false;
            // 
            // mensajeDeErrorNombre
            // 
            this.mensajeDeErrorNombre.AutoSize = true;
            this.mensajeDeErrorNombre.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensajeDeErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.mensajeDeErrorNombre.Location = new System.Drawing.Point(163, 57);
            this.mensajeDeErrorNombre.Name = "mensajeDeErrorNombre";
            this.mensajeDeErrorNombre.Size = new System.Drawing.Size(130, 16);
            this.mensajeDeErrorNombre.TabIndex = 47;
            this.mensajeDeErrorNombre.Text = "Este campo es obligatorio.";
            this.mensajeDeErrorNombre.Visible = false;
            // 
            // textCorreoElectronico
            // 
            this.textCorreoElectronico.Location = new System.Drawing.Point(610, 168);
            this.textCorreoElectronico.Name = "textCorreoElectronico";
            this.textCorreoElectronico.Size = new System.Drawing.Size(229, 25);
            this.textCorreoElectronico.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(490, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Correo Electronico";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(653, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "-";
            // 
            // textTelefonoMovil
            // 
            this.textTelefonoMovil.Location = new System.Drawing.Point(671, 122);
            this.textTelefonoMovil.Name = "textTelefonoMovil";
            this.textTelefonoMovil.Size = new System.Drawing.Size(168, 25);
            this.textTelefonoMovil.TabIndex = 16;
            // 
            // textCodigoAreaMovil
            // 
            this.textCodigoAreaMovil.Location = new System.Drawing.Point(610, 122);
            this.textCodigoAreaMovil.Name = "textCodigoAreaMovil";
            this.textCodigoAreaMovil.Size = new System.Drawing.Size(42, 25);
            this.textCodigoAreaMovil.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(507, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "*Telefono Movil";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(653, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "-";
            // 
            // textTelefonoFijo
            // 
            this.textTelefonoFijo.Location = new System.Drawing.Point(671, 79);
            this.textTelefonoFijo.Name = "textTelefonoFijo";
            this.textTelefonoFijo.Size = new System.Drawing.Size(168, 25);
            this.textTelefonoFijo.TabIndex = 12;
            // 
            // textCodigoAreaFijo
            // 
            this.textCodigoAreaFijo.Location = new System.Drawing.Point(610, 79);
            this.textCodigoAreaFijo.Name = "textCodigoAreaFijo";
            this.textCodigoAreaFijo.Size = new System.Drawing.Size(42, 25);
            this.textCodigoAreaFijo.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(520, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Telefono Fijo";
            // 
            // textIdCirujano
            // 
            this.textIdCirujano.Location = new System.Drawing.Point(610, 35);
            this.textIdCirujano.Name = "textIdCirujano";
            this.textIdCirujano.Size = new System.Drawing.Size(229, 25);
            this.textIdCirujano.TabIndex = 9;
            // 
            // textSegundoApellido
            // 
            this.textSegundoApellido.Location = new System.Drawing.Point(163, 168);
            this.textSegundoApellido.Name = "textSegundoApellido";
            this.textSegundoApellido.Size = new System.Drawing.Size(232, 25);
            this.textSegundoApellido.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Segundo Apellido";
            // 
            // textPrimerApellido
            // 
            this.textPrimerApellido.Location = new System.Drawing.Point(163, 122);
            this.textPrimerApellido.Name = "textPrimerApellido";
            this.textPrimerApellido.Size = new System.Drawing.Size(232, 25);
            this.textPrimerApellido.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "* Primer apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "*CI Cirujano";
            // 
            // textSegundoNombre
            // 
            this.textSegundoNombre.Location = new System.Drawing.Point(163, 76);
            this.textSegundoNombre.Name = "textSegundoNombre";
            this.textSegundoNombre.Size = new System.Drawing.Size(232, 25);
            this.textSegundoNombre.TabIndex = 3;
            // 
            // textPrimerNombre
            // 
            this.textPrimerNombre.Location = new System.Drawing.Point(163, 31);
            this.textPrimerNombre.Name = "textPrimerNombre";
            this.textPrimerNombre.Size = new System.Drawing.Size(232, 25);
            this.textPrimerNombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Segundo Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "* Primer Nombre";
            // 
            // AgregarCirujano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.panel1);
            this.Name = "AgregarCirujano";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grupoDatosCirujano.ResumeLayout(false);
            this.grupoDatosCirujano.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grupoDatosCirujano;
        private System.Windows.Forms.TextBox textCorreoElectronico;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textTelefonoMovil;
        private System.Windows.Forms.TextBox textCodigoAreaMovil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textTelefonoFijo;
        private System.Windows.Forms.TextBox textCodigoAreaFijo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textIdCirujano;
        private System.Windows.Forms.TextBox textSegundoApellido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textPrimerApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSegundoNombre;
        private System.Windows.Forms.TextBox textPrimerNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label textInformacionPagos;
        private System.Windows.Forms.Button botonCancelarCirugia;
        private System.Windows.Forms.Button botonAceptarCirugia;
        private System.Windows.Forms.Label mensajeDeErrorTelefonoMovil;
        private System.Windows.Forms.Label mensajeDeErrorCedula;
        private System.Windows.Forms.Label mensajeDeErrorApellido;
        private System.Windows.Forms.Label mensajeDeErrorNombre;


    }
}
