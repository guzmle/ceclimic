namespace CECLIMI.Vista
{
    partial class BeremoDeOperaciones
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
            this.grupoBeremo = new System.Windows.Forms.GroupBox();
            this.uxGridBeremo = new System.Windows.Forms.DataGridView();
            this.Intervencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.honCirujano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.honPrimerAyudante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anestesiologo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textInformacionPagos = new System.Windows.Forms.Label();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.GrupoCirugias = new System.Windows.Forms.GroupBox();
            this.comboCirujanos = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grupoBeremo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxGridBeremo)).BeginInit();
            this.GrupoCirugias.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.grupoBeremo);
            this.panel1.Controls.Add(this.textInformacionPagos);
            this.panel1.Controls.Add(this.botonAceptar);
            this.panel1.Controls.Add(this.GrupoCirugias);
            this.panel1.Location = new System.Drawing.Point(257, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 646);
            this.panel1.TabIndex = 11;
            // 
            // grupoBeremo
            // 
            this.grupoBeremo.Controls.Add(this.uxGridBeremo);
            this.grupoBeremo.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.grupoBeremo.Location = new System.Drawing.Point(18, 128);
            this.grupoBeremo.Name = "grupoBeremo";
            this.grupoBeremo.Size = new System.Drawing.Size(957, 469);
            this.grupoBeremo.TabIndex = 22;
            this.grupoBeremo.TabStop = false;
            this.grupoBeremo.Text = "Beremo";
            this.grupoBeremo.Visible = false;
            // 
            // uxGridBeremo
            // 
            this.uxGridBeremo.AllowUserToAddRows = false;
            this.uxGridBeremo.AllowUserToDeleteRows = false;
            this.uxGridBeremo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.uxGridBeremo.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.uxGridBeremo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uxGridBeremo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxGridBeremo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Intervencion,
            this.honCirujano,
            this.honPrimerAyudante,
            this.anestesiologo,
            this.ingresos,
            this.subtotal,
            this.clinica,
            this.total});
            this.uxGridBeremo.Location = new System.Drawing.Point(19, 26);
            this.uxGridBeremo.Name = "uxGridBeremo";
            this.uxGridBeremo.ReadOnly = true;
            this.uxGridBeremo.Size = new System.Drawing.Size(921, 437);
            this.uxGridBeremo.TabIndex = 0;
            // 
            // Intervencion
            // 
            this.Intervencion.HeaderText = "Intervencion";
            this.Intervencion.Name = "Intervencion";
            this.Intervencion.ReadOnly = true;
            this.Intervencion.Width = 92;
            // 
            // honCirujano
            // 
            this.honCirujano.HeaderText = "Hon.Cirujano";
            this.honCirujano.Name = "honCirujano";
            this.honCirujano.ReadOnly = true;
            this.honCirujano.Width = 96;
            // 
            // honPrimerAyudante
            // 
            this.honPrimerAyudante.HeaderText = "Hon.1er Ayud";
            this.honPrimerAyudante.Name = "honPrimerAyudante";
            this.honPrimerAyudante.ReadOnly = true;
            this.honPrimerAyudante.Width = 101;
            // 
            // anestesiologo
            // 
            this.anestesiologo.HeaderText = "Anestesiologo";
            this.anestesiologo.Name = "anestesiologo";
            this.anestesiologo.ReadOnly = true;
            this.anestesiologo.Width = 101;
            // 
            // ingresos
            // 
            this.ingresos.HeaderText = "Ingresos";
            this.ingresos.Name = "ingresos";
            this.ingresos.ReadOnly = true;
            this.ingresos.Width = 76;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            this.subtotal.Width = 71;
            // 
            // clinica
            // 
            this.clinica.HeaderText = "Clinica";
            this.clinica.Name = "clinica";
            this.clinica.ReadOnly = true;
            this.clinica.Width = 65;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 56;
            // 
            // textInformacionPagos
            // 
            this.textInformacionPagos.AutoSize = true;
            this.textInformacionPagos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInformacionPagos.Location = new System.Drawing.Point(180, 14);
            this.textInformacionPagos.Name = "textInformacionPagos";
            this.textInformacionPagos.Size = new System.Drawing.Size(232, 22);
            this.textInformacionPagos.TabIndex = 41;
            this.textInformacionPagos.Text = "Beremo de operaciones";
            // 
            // botonAceptar
            // 
            this.botonAceptar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAceptar.Image = global::CECLIMI.Properties.Resources.icono_aceptar1;
            this.botonAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonAceptar.Location = new System.Drawing.Point(864, 603);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(111, 29);
            this.botonAceptar.TabIndex = 39;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.BotonAceptarCirugiaClick);
            // 
            // GrupoCirugias
            // 
            this.GrupoCirugias.Controls.Add(this.comboCirujanos);
            this.GrupoCirugias.Controls.Add(this.label12);
            this.GrupoCirugias.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoCirugias.Location = new System.Drawing.Point(18, 51);
            this.GrupoCirugias.Name = "GrupoCirugias";
            this.GrupoCirugias.Size = new System.Drawing.Size(957, 71);
            this.GrupoCirugias.TabIndex = 2;
            this.GrupoCirugias.TabStop = false;
            this.GrupoCirugias.Text = "Cirujano";
            // 
            // comboCirujanos
            // 
            this.comboCirujanos.FormattingEnabled = true;
            this.comboCirujanos.Location = new System.Drawing.Point(220, 27);
            this.comboCirujanos.Name = "comboCirujanos";
            this.comboCirujanos.Size = new System.Drawing.Size(299, 28);
            this.comboCirujanos.TabIndex = 21;
            this.comboCirujanos.SelectedIndexChanged += new System.EventHandler(this.ComboCirujanosSelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(136, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Cirujano:";
            // 
            // BeremoDeOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.panel1);
            this.Name = "BeremoDeOperaciones";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grupoBeremo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uxGridBeremo)).EndInit();
            this.GrupoCirugias.ResumeLayout(false);
            this.GrupoCirugias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label textInformacionPagos;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.GroupBox GrupoCirugias;
        private System.Windows.Forms.GroupBox grupoBeremo;
        private System.Windows.Forms.ComboBox comboCirujanos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView uxGridBeremo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intervencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn honCirujano;
        private System.Windows.Forms.DataGridViewTextBoxColumn honPrimerAyudante;
        private System.Windows.Forms.DataGridViewTextBoxColumn anestesiologo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinica;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}
