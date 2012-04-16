using System;

namespace CECLIMI.Vista
{
    partial class AgregarCirugiaCirujano
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
            this.textInformacionPagos = new System.Windows.Forms.Label();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.grupoCirugias = new System.Windows.Forms.GroupBox();
            this.uxMonto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.uxGridCirugias = new System.Windows.Forms.DataGridView();
            this.Cirugia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonEliminarIqx = new System.Windows.Forms.Button();
            this.botonAgregarIqx = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.uxComboCirugias = new System.Windows.Forms.ComboBox();
            this.grupoDatosCirujano = new System.Windows.Forms.GroupBox();
            this.uxApellido = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.uxTelefonoFijo = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.uxCedula = new System.Windows.Forms.Label();
            this.uxNombre = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.uxTelefonoMovil = new System.Windows.Forms.Label();
            this.uxCorreo = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.grupoInfoCirujano = new System.Windows.Forms.GroupBox();
            this.botonBuscarCirujano = new System.Windows.Forms.Button();
            this.uxCedulaCirujano = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grupoCirugias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxGridCirugias)).BeginInit();
            this.grupoDatosCirujano.SuspendLayout();
            this.grupoInfoCirujano.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textInformacionPagos);
            this.panel1.Controls.Add(this.botonCancelar);
            this.panel1.Controls.Add(this.botonAceptar);
            this.panel1.Controls.Add(this.grupoCirugias);
            this.panel1.Controls.Add(this.grupoInfoCirujano);
            this.panel1.Controls.Add(this.grupoDatosCirujano);
            this.panel1.Location = new System.Drawing.Point(257, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 646);
            this.panel1.TabIndex = 10;
            // 
            // textInformacionPagos
            // 
            this.textInformacionPagos.AutoSize = true;
            this.textInformacionPagos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInformacionPagos.Location = new System.Drawing.Point(162, 11);
            this.textInformacionPagos.Name = "textInformacionPagos";
            this.textInformacionPagos.Size = new System.Drawing.Size(291, 22);
            this.textInformacionPagos.TabIndex = 42;
            this.textInformacionPagos.Text = "Agregar cirugias a un cirujano";
            // 
            // botonCancelar
            // 
            this.botonCancelar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.Location = new System.Drawing.Point(440, 496);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(111, 29);
            this.botonCancelar.TabIndex = 38;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            // 
            // botonAceptar
            // 
            this.botonAceptar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAceptar.Location = new System.Drawing.Point(735, 496);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(111, 29);
            this.botonAceptar.TabIndex = 37;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.BotonAceptarClick);
            // 
            // grupoCirugias
            // 
            this.grupoCirugias.Controls.Add(this.uxMonto);
            this.grupoCirugias.Controls.Add(this.label13);
            this.grupoCirugias.Controls.Add(this.uxGridCirugias);
            this.grupoCirugias.Controls.Add(this.botonEliminarIqx);
            this.grupoCirugias.Controls.Add(this.botonAgregarIqx);
            this.grupoCirugias.Controls.Add(this.label12);
            this.grupoCirugias.Controls.Add(this.uxComboCirugias);
            this.grupoCirugias.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoCirugias.Location = new System.Drawing.Point(15, 133);
            this.grupoCirugias.Name = "grupoCirugias";
            this.grupoCirugias.Size = new System.Drawing.Size(964, 357);
            this.grupoCirugias.TabIndex = 2;
            this.grupoCirugias.TabStop = false;
            this.grupoCirugias.Text = "Cirugias";
            this.grupoCirugias.Visible = false;
            // 
            // uxMonto
            // 
            this.uxMonto.Location = new System.Drawing.Point(607, 33);
            this.uxMonto.Name = "uxMonto";
            this.uxMonto.Size = new System.Drawing.Size(232, 26);
            this.uxMonto.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(543, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 20);
            this.label13.TabIndex = 44;
            this.label13.Text = "Monto";
            // 
            // uxGridCirugias
            // 
            this.uxGridCirugias.AllowUserToAddRows = false;
            this.uxGridCirugias.AllowUserToDeleteRows = false;
            this.uxGridCirugias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uxGridCirugias.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.uxGridCirugias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uxGridCirugias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxGridCirugias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cirugia,
            this.Monto});
            this.uxGridCirugias.Location = new System.Drawing.Point(18, 87);
            this.uxGridCirugias.Name = "uxGridCirugias";
            this.uxGridCirugias.Size = new System.Drawing.Size(926, 264);
            this.uxGridCirugias.TabIndex = 43;
            // 
            // Cirugia
            // 
            this.Cirugia.HeaderText = "Cirugía";
            this.Cirugia.Name = "Cirugia";
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            // 
            // botonEliminarIqx
            // 
            this.botonEliminarIqx.Image = global::CECLIMI.Properties.Resources.menos;
            this.botonEliminarIqx.Location = new System.Drawing.Point(906, 30);
            this.botonEliminarIqx.Name = "botonEliminarIqx";
            this.botonEliminarIqx.Size = new System.Drawing.Size(38, 29);
            this.botonEliminarIqx.TabIndex = 42;
            this.botonEliminarIqx.UseVisualStyleBackColor = true;
            this.botonEliminarIqx.Click += new System.EventHandler(this.BotonEliminarIqxClick);
            // 
            // botonAgregarIqx
            // 
            this.botonAgregarIqx.Image = global::CECLIMI.Properties.Resources.mas;
            this.botonAgregarIqx.Location = new System.Drawing.Point(862, 30);
            this.botonAgregarIqx.Name = "botonAgregarIqx";
            this.botonAgregarIqx.Size = new System.Drawing.Size(38, 29);
            this.botonAgregarIqx.TabIndex = 41;
            this.botonAgregarIqx.UseVisualStyleBackColor = true;
            this.botonAgregarIqx.Click += new System.EventHandler(this.BotonAgregarIqxClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Cirugía";
            // 
            // uxComboCirugias
            // 
            this.uxComboCirugias.FormattingEnabled = true;
            this.uxComboCirugias.Location = new System.Drawing.Point(70, 33);
            this.uxComboCirugias.Name = "uxComboCirugias";
            this.uxComboCirugias.Size = new System.Drawing.Size(466, 28);
            this.uxComboCirugias.TabIndex = 0;
            // 
            // grupoDatosCirujano
            // 
            this.grupoDatosCirujano.Controls.Add(this.uxApellido);
            this.grupoDatosCirujano.Controls.Add(this.label34);
            this.grupoDatosCirujano.Controls.Add(this.uxTelefonoFijo);
            this.grupoDatosCirujano.Controls.Add(this.label30);
            this.grupoDatosCirujano.Controls.Add(this.label32);
            this.grupoDatosCirujano.Controls.Add(this.uxCedula);
            this.grupoDatosCirujano.Controls.Add(this.uxNombre);
            this.grupoDatosCirujano.Controls.Add(this.label37);
            this.grupoDatosCirujano.Controls.Add(this.label33);
            this.grupoDatosCirujano.Controls.Add(this.uxTelefonoMovil);
            this.grupoDatosCirujano.Controls.Add(this.uxCorreo);
            this.grupoDatosCirujano.Controls.Add(this.label35);
            this.grupoDatosCirujano.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoDatosCirujano.Location = new System.Drawing.Point(15, 36);
            this.grupoDatosCirujano.Name = "grupoDatosCirujano";
            this.grupoDatosCirujano.Size = new System.Drawing.Size(962, 91);
            this.grupoDatosCirujano.TabIndex = 44;
            this.grupoDatosCirujano.TabStop = false;
            this.grupoDatosCirujano.Text = "Informacion del Cirujano";
            this.grupoDatosCirujano.Visible = false;
            // 
            // uxApellido
            // 
            this.uxApellido.AutoSize = true;
            this.uxApellido.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxApellido.Location = new System.Drawing.Point(109, 59);
            this.uxApellido.Name = "uxApellido";
            this.uxApellido.Size = new System.Drawing.Size(58, 18);
            this.uxApellido.TabIndex = 11;
            this.uxApellido.Text = "label33";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(45, 57);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(63, 20);
            this.label34.TabIndex = 10;
            this.label34.Text = "Apellido:";
            // 
            // uxTelefonoFijo
            // 
            this.uxTelefonoFijo.AutoSize = true;
            this.uxTelefonoFijo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTelefonoFijo.Location = new System.Drawing.Point(811, 32);
            this.uxTelefonoFijo.Name = "uxTelefonoFijo";
            this.uxTelefonoFijo.Size = new System.Drawing.Size(58, 18);
            this.uxTelefonoFijo.TabIndex = 9;
            this.uxTelefonoFijo.Text = "label36";
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
            this.label32.Size = new System.Drawing.Size(61, 20);
            this.label32.TabIndex = 0;
            this.label32.Text = "Nombre:";
            // 
            // uxCedula
            // 
            this.uxCedula.AutoSize = true;
            this.uxCedula.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCedula.Location = new System.Drawing.Point(456, 30);
            this.uxCedula.Name = "uxCedula";
            this.uxCedula.Size = new System.Drawing.Size(58, 18);
            this.uxCedula.TabIndex = 7;
            this.uxCedula.Text = "label38";
            // 
            // uxNombre
            // 
            this.uxNombre.AutoSize = true;
            this.uxNombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNombre.Location = new System.Drawing.Point(109, 30);
            this.uxNombre.Name = "uxNombre";
            this.uxNombre.Size = new System.Drawing.Size(58, 18);
            this.uxNombre.TabIndex = 1;
            this.uxNombre.Text = "label33";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(395, 30);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(55, 20);
            this.label37.TabIndex = 6;
            this.label37.Text = "Cedula:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(325, 51);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(125, 20);
            this.label33.TabIndex = 2;
            this.label33.Text = "Correo Electronico:";
            // 
            // uxTelefonoMovil
            // 
            this.uxTelefonoMovil.AutoSize = true;
            this.uxTelefonoMovil.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTelefonoMovil.Location = new System.Drawing.Point(811, 57);
            this.uxTelefonoMovil.Name = "uxTelefonoMovil";
            this.uxTelefonoMovil.Size = new System.Drawing.Size(58, 18);
            this.uxTelefonoMovil.TabIndex = 5;
            this.uxTelefonoMovil.Text = "label36";
            // 
            // uxCorreo
            // 
            this.uxCorreo.AutoSize = true;
            this.uxCorreo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.uxCorreo.Location = new System.Drawing.Point(456, 57);
            this.uxCorreo.Name = "uxCorreo";
            this.uxCorreo.Size = new System.Drawing.Size(58, 18);
            this.uxCorreo.TabIndex = 3;
            this.uxCorreo.Text = "label34";
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
            // grupoInfoCirujano
            // 
            this.grupoInfoCirujano.Controls.Add(this.botonBuscarCirujano);
            this.grupoInfoCirujano.Controls.Add(this.uxCedulaCirujano);
            this.grupoInfoCirujano.Controls.Add(this.label2);
            this.grupoInfoCirujano.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoInfoCirujano.Location = new System.Drawing.Point(15, 36);
            this.grupoInfoCirujano.Name = "grupoInfoCirujano";
            this.grupoInfoCirujano.Size = new System.Drawing.Size(962, 91);
            this.grupoInfoCirujano.TabIndex = 43;
            this.grupoInfoCirujano.TabStop = false;
            this.grupoInfoCirujano.Text = "Cirujano";
            // 
            // botonBuscarCirujano
            // 
            this.botonBuscarCirujano.Image = global::CECLIMI.Properties.Resources.boton_buscar;
            this.botonBuscarCirujano.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonBuscarCirujano.Location = new System.Drawing.Point(463, 42);
            this.botonBuscarCirujano.Name = "botonBuscarCirujano";
            this.botonBuscarCirujano.Size = new System.Drawing.Size(30, 29);
            this.botonBuscarCirujano.TabIndex = 52;
            this.botonBuscarCirujano.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonBuscarCirujano.UseVisualStyleBackColor = true;
            this.botonBuscarCirujano.Click += new System.EventHandler(this.BotonBuscarCirujanoClick);
            // 
            // uxCedulaCirujano
            // 
            this.uxCedulaCirujano.Location = new System.Drawing.Point(237, 45);
            this.uxCedulaCirujano.Name = "uxCedulaCirujano";
            this.uxCedulaCirujano.Size = new System.Drawing.Size(220, 26);
            this.uxCedulaCirujano.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "CI Cirujano";
            // 
            // AgregarCirugiaCirujano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.panel1);
            this.Name = "AgregarCirugiaCirujano";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grupoCirugias.ResumeLayout(false);
            this.grupoCirugias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxGridCirugias)).EndInit();
            this.grupoDatosCirujano.ResumeLayout(false);
            this.grupoDatosCirujano.PerformLayout();
            this.grupoInfoCirujano.ResumeLayout(false);
            this.grupoInfoCirujano.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label textInformacionPagos;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.GroupBox grupoCirugias;
        private System.Windows.Forms.TextBox uxMonto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView uxGridCirugias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cirugia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.Button botonEliminarIqx;
        private System.Windows.Forms.Button botonAgregarIqx;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox uxComboCirugias;
        private System.Windows.Forms.GroupBox grupoInfoCirujano;
        private System.Windows.Forms.Button botonBuscarCirujano;
        private System.Windows.Forms.TextBox uxCedulaCirujano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grupoDatosCirujano;
        private System.Windows.Forms.Label uxApellido;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label uxTelefonoFijo;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label uxCedula;
        private System.Windows.Forms.Label uxNombre;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label uxTelefonoMovil;
        private System.Windows.Forms.Label uxCorreo;
        private System.Windows.Forms.Label label35;
    }
}
