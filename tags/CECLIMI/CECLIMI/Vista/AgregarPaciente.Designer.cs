namespace CECLIMI.Vista
{
    partial class AgregarPaciente
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
            this.panelInformacionUsuario = new System.Windows.Forms.Panel();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.textInformacionVentana = new System.Windows.Forms.Label();
            this.grupoDatosPacientes = new System.Windows.Forms.GroupBox();
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
            this.textIdPaciente = new System.Windows.Forms.TextBox();
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
            this.panelInformacionUsuario.SuspendLayout();
            this.grupoDatosPacientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelInformacionUsuario);
            this.panel1.Location = new System.Drawing.Point(257, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 646);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1Paint);
            // 
            // panelInformacionUsuario
            // 
            this.panelInformacionUsuario.Controls.Add(this.botonCancelar);
            this.panelInformacionUsuario.Controls.Add(this.botonAceptar);
            this.panelInformacionUsuario.Controls.Add(this.textInformacionVentana);
            this.panelInformacionUsuario.Controls.Add(this.grupoDatosPacientes);
            this.panelInformacionUsuario.Location = new System.Drawing.Point(3, 3);
            this.panelInformacionUsuario.Name = "panelInformacionUsuario";
            this.panelInformacionUsuario.Size = new System.Drawing.Size(983, 321);
            this.panelInformacionUsuario.TabIndex = 1;
            // 
            // botonCancelar
            // 
            this.botonCancelar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.Image = global::CECLIMI.Properties.Resources.icono_cancelar;
            this.botonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonCancelar.Location = new System.Drawing.Point(557, 281);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(111, 29);
            this.botonCancelar.TabIndex = 34;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click_1);
            // 
            // botonAceptar
            // 
            this.botonAceptar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAceptar.Image = global::CECLIMI.Properties.Resources.icono_aceptar1;
            this.botonAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonAceptar.Location = new System.Drawing.Point(852, 281);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(111, 29);
            this.botonAceptar.TabIndex = 33;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.BotonAceptarClick);
            // 
            // textInformacionVentana
            // 
            this.textInformacionVentana.AutoSize = true;
            this.textInformacionVentana.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInformacionVentana.Location = new System.Drawing.Point(417, 16);
            this.textInformacionVentana.Name = "textInformacionVentana";
            this.textInformacionVentana.Size = new System.Drawing.Size(154, 22);
            this.textInformacionVentana.TabIndex = 26;
            this.textInformacionVentana.Text = "Nuevo Paciente";
            // 
            // grupoDatosPacientes
            // 
            this.grupoDatosPacientes.Controls.Add(this.textCorreoElectronico);
            this.grupoDatosPacientes.Controls.Add(this.label11);
            this.grupoDatosPacientes.Controls.Add(this.label9);
            this.grupoDatosPacientes.Controls.Add(this.textTelefonoMovil);
            this.grupoDatosPacientes.Controls.Add(this.textCodigoAreaMovil);
            this.grupoDatosPacientes.Controls.Add(this.label10);
            this.grupoDatosPacientes.Controls.Add(this.label8);
            this.grupoDatosPacientes.Controls.Add(this.textTelefonoFijo);
            this.grupoDatosPacientes.Controls.Add(this.textCodigoAreaFijo);
            this.grupoDatosPacientes.Controls.Add(this.label7);
            this.grupoDatosPacientes.Controls.Add(this.textIdPaciente);
            this.grupoDatosPacientes.Controls.Add(this.textSegundoApellido);
            this.grupoDatosPacientes.Controls.Add(this.label6);
            this.grupoDatosPacientes.Controls.Add(this.textPrimerApellido);
            this.grupoDatosPacientes.Controls.Add(this.label5);
            this.grupoDatosPacientes.Controls.Add(this.label4);
            this.grupoDatosPacientes.Controls.Add(this.textSegundoNombre);
            this.grupoDatosPacientes.Controls.Add(this.textPrimerNombre);
            this.grupoDatosPacientes.Controls.Add(this.label3);
            this.grupoDatosPacientes.Controls.Add(this.label2);
            this.grupoDatosPacientes.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoDatosPacientes.Location = new System.Drawing.Point(10, 53);
            this.grupoDatosPacientes.Name = "grupoDatosPacientes";
            this.grupoDatosPacientes.Size = new System.Drawing.Size(953, 222);
            this.grupoDatosPacientes.TabIndex = 0;
            this.grupoDatosPacientes.TabStop = false;
            this.grupoDatosPacientes.Text = "Información del paciente";
            // 
            // textCorreoElectronico
            // 
            this.textCorreoElectronico.Location = new System.Drawing.Point(640, 158);
            this.textCorreoElectronico.Name = "textCorreoElectronico";
            this.textCorreoElectronico.Size = new System.Drawing.Size(229, 25);
            this.textCorreoElectronico.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(472, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Correo Electronico";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(683, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "-";
            // 
            // textTelefonoMovil
            // 
            this.textTelefonoMovil.Location = new System.Drawing.Point(701, 122);
            this.textTelefonoMovil.Name = "textTelefonoMovil";
            this.textTelefonoMovil.Size = new System.Drawing.Size(168, 25);
            this.textTelefonoMovil.TabIndex = 16;
            // 
            // textCodigoAreaMovil
            // 
            this.textCodigoAreaMovil.Location = new System.Drawing.Point(640, 122);
            this.textCodigoAreaMovil.Name = "textCodigoAreaMovil";
            this.textCodigoAreaMovil.Size = new System.Drawing.Size(42, 25);
            this.textCodigoAreaMovil.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(494, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Telefono Movil";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(683, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "-";
            // 
            // textTelefonoFijo
            // 
            this.textTelefonoFijo.Location = new System.Drawing.Point(701, 89);
            this.textTelefonoFijo.Name = "textTelefonoFijo";
            this.textTelefonoFijo.Size = new System.Drawing.Size(168, 25);
            this.textTelefonoFijo.TabIndex = 12;
            // 
            // textCodigoAreaFijo
            // 
            this.textCodigoAreaFijo.Location = new System.Drawing.Point(640, 89);
            this.textCodigoAreaFijo.Name = "textCodigoAreaFijo";
            this.textCodigoAreaFijo.Size = new System.Drawing.Size(42, 25);
            this.textCodigoAreaFijo.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Telefono Fijo";
            // 
            // textIdPaciente
            // 
            this.textIdPaciente.Location = new System.Drawing.Point(640, 55);
            this.textIdPaciente.MaxLength = 9;
            this.textIdPaciente.Name = "textIdPaciente";
            this.textIdPaciente.Size = new System.Drawing.Size(229, 25);
            this.textIdPaciente.TabIndex = 9;
            // 
            // textSegundoApellido
            // 
            this.textSegundoApellido.Location = new System.Drawing.Point(193, 158);
            this.textSegundoApellido.Name = "textSegundoApellido";
            this.textSegundoApellido.Size = new System.Drawing.Size(232, 25);
            this.textSegundoApellido.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Segundo Apellido";
            // 
            // textPrimerApellido
            // 
            this.textPrimerApellido.Location = new System.Drawing.Point(193, 122);
            this.textPrimerApellido.Name = "textPrimerApellido";
            this.textPrimerApellido.Size = new System.Drawing.Size(232, 25);
            this.textPrimerApellido.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "* Primer apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "* CI Paciente";
            // 
            // textSegundoNombre
            // 
            this.textSegundoNombre.Location = new System.Drawing.Point(193, 86);
            this.textSegundoNombre.Name = "textSegundoNombre";
            this.textSegundoNombre.Size = new System.Drawing.Size(232, 25);
            this.textSegundoNombre.TabIndex = 3;
            // 
            // textPrimerNombre
            // 
            this.textPrimerNombre.Location = new System.Drawing.Point(193, 51);
            this.textPrimerNombre.Name = "textPrimerNombre";
            this.textPrimerNombre.Size = new System.Drawing.Size(232, 25);
            this.textPrimerNombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Segundo Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "* Primer Nombre";
            // 
            // AgregarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.panel1);
            this.Name = "AgregarPaciente";
            this.Text = "SOFTWARE ADMINISTRATIVO CECLIMI - NUEVO PACIENTE";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panelInformacionUsuario.ResumeLayout(false);
            this.panelInformacionUsuario.PerformLayout();
            this.grupoDatosPacientes.ResumeLayout(false);
            this.grupoDatosPacientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelInformacionUsuario;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Label textInformacionVentana;
        private System.Windows.Forms.GroupBox grupoDatosPacientes;
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
        private System.Windows.Forms.TextBox textIdPaciente;
        private System.Windows.Forms.TextBox textSegundoApellido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textPrimerApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSegundoNombre;
        private System.Windows.Forms.TextBox textPrimerNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
