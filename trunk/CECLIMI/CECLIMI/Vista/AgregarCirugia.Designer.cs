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
            this.botonCancelarCirugia = new System.Windows.Forms.Button();
            this.botonAceptarCirugia = new System.Windows.Forms.Button();
            this.GrupoCirugias = new System.Windows.Forms.GroupBox();
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
            this.panel1.Controls.Add(this.botonCancelarCirugia);
            this.panel1.Controls.Add(this.botonAceptarCirugia);
            this.panel1.Controls.Add(this.GrupoCirugias);
            this.panel1.Location = new System.Drawing.Point(261, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 620);
            this.panel1.TabIndex = 10;
            // 
            // botonCancelarCirugia
            // 
            this.botonCancelarCirugia.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelarCirugia.Image = global::CECLIMI.Properties.Resources.icono_cancelar;
            this.botonCancelarCirugia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonCancelarCirugia.Location = new System.Drawing.Point(553, 276);
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
            this.botonAceptarCirugia.Location = new System.Drawing.Point(848, 276);
            this.botonAceptarCirugia.Name = "botonAceptarCirugia";
            this.botonAceptarCirugia.Size = new System.Drawing.Size(111, 29);
            this.botonAceptarCirugia.TabIndex = 39;
            this.botonAceptarCirugia.Text = "Aceptar";
            this.botonAceptarCirugia.UseVisualStyleBackColor = true;
            this.botonAceptarCirugia.Click += new System.EventHandler(this.botonAceptarCirugia_Click);
            // 
            // GrupoCirugias
            // 
            this.GrupoCirugias.Controls.Add(this.textDescripcionCirugia);
            this.GrupoCirugias.Controls.Add(this.textNombreCirugia);
            this.GrupoCirugias.Controls.Add(this.label13);
            this.GrupoCirugias.Controls.Add(this.label12);
            this.GrupoCirugias.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoCirugias.Location = new System.Drawing.Point(18, 14);
            this.GrupoCirugias.Name = "GrupoCirugias";
            this.GrupoCirugias.Size = new System.Drawing.Size(957, 230);
            this.GrupoCirugias.TabIndex = 2;
            this.GrupoCirugias.TabStop = false;
            this.GrupoCirugias.Text = "Cirugia";
            // 
            // textDescripcionCirugia
            // 
            this.textDescripcionCirugia.Location = new System.Drawing.Point(398, 93);
            this.textDescripcionCirugia.Multiline = true;
            this.textDescripcionCirugia.Name = "textDescripcionCirugia";
            this.textDescripcionCirugia.Size = new System.Drawing.Size(278, 105);
            this.textDescripcionCirugia.TabIndex = 45;
            // 
            // textNombreCirugia
            // 
            this.textNombreCirugia.Location = new System.Drawing.Point(398, 35);
            this.textNombreCirugia.Name = "textNombreCirugia";
            this.textNombreCirugia.Size = new System.Drawing.Size(278, 26);
            this.textNombreCirugia.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(279, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 20);
            this.label13.TabIndex = 44;
            this.label13.Text = "Descripcion";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(309, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Cirugía";
            // 
            // AgregarCirugia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1264, 750);
            this.Controls.Add(this.panel1);
            this.Name = "AgregarCirugia";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
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
    }
}
