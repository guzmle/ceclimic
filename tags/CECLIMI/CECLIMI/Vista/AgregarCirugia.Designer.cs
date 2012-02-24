namespace CECLIMI.Vista
{
    partial class AgregarCirugia
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
            this.botonCancelarCirugia = new System.Windows.Forms.Button();
            this.botonAceptarCirugia = new System.Windows.Forms.Button();
            this.GrupoCirugias = new System.Windows.Forms.GroupBox();
            this.mensajeDeError = new System.Windows.Forms.Label();
            this.textDescripcionCirugia = new System.Windows.Forms.TextBox();
            this.textNombreCirugia = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.GrupoCirugias.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textInformacionPagos);
            this.panel1.Controls.Add(this.botonCancelarCirugia);
            this.panel1.Controls.Add(this.botonAceptarCirugia);
            this.panel1.Controls.Add(this.GrupoCirugias);
            this.panel1.Location = new System.Drawing.Point(261, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 646);
            this.panel1.TabIndex = 10;
            // 
            // textInformacionPagos
            // 
            this.textInformacionPagos.AutoSize = true;
            this.textInformacionPagos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInformacionPagos.Location = new System.Drawing.Point(180, 26);
            this.textInformacionPagos.Name = "textInformacionPagos";
            this.textInformacionPagos.Size = new System.Drawing.Size(157, 22);
            this.textInformacionPagos.TabIndex = 41;
            this.textInformacionPagos.Text = "Agregar Cirugia";
            // 
            // botonCancelarCirugia
            // 
            this.botonCancelarCirugia.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelarCirugia.Image = global::CECLIMI.Properties.Resources.icono_cancelar;
            this.botonCancelarCirugia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonCancelarCirugia.Location = new System.Drawing.Point(566, 282);
            this.botonCancelarCirugia.Name = "botonCancelarCirugia";
            this.botonCancelarCirugia.Size = new System.Drawing.Size(111, 29);
            this.botonCancelarCirugia.TabIndex = 40;
            this.botonCancelarCirugia.Text = "Cancelar";
            this.botonCancelarCirugia.UseVisualStyleBackColor = true;
            this.botonCancelarCirugia.Click += new System.EventHandler(this.BotonCancelarCirugiaClick);
            // 
            // botonAceptarCirugia
            // 
            this.botonAceptarCirugia.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAceptarCirugia.Image = global::CECLIMI.Properties.Resources.icono_aceptar1;
            this.botonAceptarCirugia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonAceptarCirugia.Location = new System.Drawing.Point(861, 282);
            this.botonAceptarCirugia.Name = "botonAceptarCirugia";
            this.botonAceptarCirugia.Size = new System.Drawing.Size(111, 29);
            this.botonAceptarCirugia.TabIndex = 39;
            this.botonAceptarCirugia.Text = "Aceptar";
            this.botonAceptarCirugia.UseVisualStyleBackColor = true;
            this.botonAceptarCirugia.Click += new System.EventHandler(this.BotonAceptarCirugiaClick);
            // 
            // GrupoCirugias
            // 
            this.GrupoCirugias.Controls.Add(this.mensajeDeError);
            this.GrupoCirugias.Controls.Add(this.textDescripcionCirugia);
            this.GrupoCirugias.Controls.Add(this.textNombreCirugia);
            this.GrupoCirugias.Controls.Add(this.label13);
            this.GrupoCirugias.Controls.Add(this.label12);
            this.GrupoCirugias.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoCirugias.Location = new System.Drawing.Point(18, 51);
            this.GrupoCirugias.Name = "GrupoCirugias";
            this.GrupoCirugias.Size = new System.Drawing.Size(957, 205);
            this.GrupoCirugias.TabIndex = 2;
            this.GrupoCirugias.TabStop = false;
            this.GrupoCirugias.Text = "Cirugia";
            // 
            // mensajeDeError
            // 
            this.mensajeDeError.AutoSize = true;
            this.mensajeDeError.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensajeDeError.ForeColor = System.Drawing.Color.Red;
            this.mensajeDeError.Location = new System.Drawing.Point(394, 57);
            this.mensajeDeError.Name = "mensajeDeError";
            this.mensajeDeError.Size = new System.Drawing.Size(130, 16);
            this.mensajeDeError.TabIndex = 46;
            this.mensajeDeError.Text = "Este campo es obligatorio.";
            this.mensajeDeError.Visible = false;
            // 
            // textDescripcionCirugia
            // 
            this.textDescripcionCirugia.Location = new System.Drawing.Point(251, 76);
            this.textDescripcionCirugia.Multiline = true;
            this.textDescripcionCirugia.Name = "textDescripcionCirugia";
            this.textDescripcionCirugia.Size = new System.Drawing.Size(408, 105);
            this.textDescripcionCirugia.TabIndex = 45;
            // 
            // textNombreCirugia
            // 
            this.textNombreCirugia.Location = new System.Drawing.Point(251, 29);
            this.textNombreCirugia.Name = "textNombreCirugia";
            this.textNombreCirugia.Size = new System.Drawing.Size(408, 26);
            this.textNombreCirugia.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(128, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 20);
            this.label13.TabIndex = 44;
            this.label13.Text = "Descripcion:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(153, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Cirugía*:";
            // 
            // AgregarCirugia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.panel1);
            this.Name = "AgregarCirugia";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GrupoCirugias.ResumeLayout(false);
            this.GrupoCirugias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GrupoCirugias;
        private System.Windows.Forms.TextBox textNombreCirugia;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textDescripcionCirugia;
        private System.Windows.Forms.Button botonCancelarCirugia;
        private System.Windows.Forms.Button botonAceptarCirugia;
        private System.Windows.Forms.Label textInformacionPagos;
        private System.Windows.Forms.Label mensajeDeError;
    }
}
