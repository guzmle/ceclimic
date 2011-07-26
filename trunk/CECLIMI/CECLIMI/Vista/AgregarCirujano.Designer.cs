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
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonRestaurarDatosPaciente = new System.Windows.Forms.Button();
            this.GrupoCirugias = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cirugia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.botonAgregarIntervencionQuirurgica = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grupoDatosCirujano = new System.Windows.Forms.GroupBox();
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
            this.GrupoCirugias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.botonCancelar);
            this.panel1.Controls.Add(this.botonAceptar);
            this.panel1.Controls.Add(this.botonRestaurarDatosPaciente);
            this.panel1.Controls.Add(this.GrupoCirugias);
            this.panel1.Controls.Add(this.grupoDatosCirujano);
            this.panel1.Location = new System.Drawing.Point(257, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 620);
            this.panel1.TabIndex = 9;
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
            // 
            // botonRestaurarDatosPaciente
            // 
            this.botonRestaurarDatosPaciente.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRestaurarDatosPaciente.Location = new System.Drawing.Point(148, 496);
            this.botonRestaurarDatosPaciente.Name = "botonRestaurarDatosPaciente";
            this.botonRestaurarDatosPaciente.Size = new System.Drawing.Size(111, 29);
            this.botonRestaurarDatosPaciente.TabIndex = 36;
            this.botonRestaurarDatosPaciente.Text = "Restaurar";
            this.botonRestaurarDatosPaciente.UseVisualStyleBackColor = true;
            // 
            // GrupoCirugias
            // 
            this.GrupoCirugias.Controls.Add(this.textBox1);
            this.GrupoCirugias.Controls.Add(this.label13);
            this.GrupoCirugias.Controls.Add(this.dataGridView1);
            this.GrupoCirugias.Controls.Add(this.button3);
            this.GrupoCirugias.Controls.Add(this.botonAgregarIntervencionQuirurgica);
            this.GrupoCirugias.Controls.Add(this.label12);
            this.GrupoCirugias.Controls.Add(this.comboBox1);
            this.GrupoCirugias.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoCirugias.Location = new System.Drawing.Point(3, 223);
            this.GrupoCirugias.Name = "GrupoCirugias";
            this.GrupoCirugias.Size = new System.Drawing.Size(985, 247);
            this.GrupoCirugias.TabIndex = 2;
            this.GrupoCirugias.TabStop = false;
            this.GrupoCirugias.Text = "Cirugias";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(607, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 26);
            this.textBox1.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(555, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 20);
            this.label13.TabIndex = 44;
            this.label13.Text = "Monto";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cirugia,
            this.Monto});
            this.dataGridView1.Location = new System.Drawing.Point(110, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(394, 150);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Cirugia
            // 
            this.Cirugia.HeaderText = "Cirugía";
            this.Cirugia.Name = "Cirugia";
            this.Cirugia.Width = 200;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.Width = 150;
            // 
            // button3
            // 
            this.button3.Image = global::CECLIMI.Properties.Resources.menos;
            this.button3.Location = new System.Drawing.Point(801, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 29);
            this.button3.TabIndex = 42;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // botonAgregarIntervencionQuirurgica
            // 
            this.botonAgregarIntervencionQuirurgica.Image = global::CECLIMI.Properties.Resources.mas;
            this.botonAgregarIntervencionQuirurgica.Location = new System.Drawing.Point(742, 87);
            this.botonAgregarIntervencionQuirurgica.Name = "botonAgregarIntervencionQuirurgica";
            this.botonAgregarIntervencionQuirurgica.Size = new System.Drawing.Size(38, 29);
            this.botonAgregarIntervencionQuirurgica.TabIndex = 41;
            this.botonAgregarIntervencionQuirurgica.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(106, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Cirugía";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(163, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // grupoDatosCirujano
            // 
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
            this.grupoDatosCirujano.Controls.Add(this.textIdPaciente);
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
            this.grupoDatosCirujano.Location = new System.Drawing.Point(3, 22);
            this.grupoDatosCirujano.Name = "grupoDatosCirujano";
            this.grupoDatosCirujano.Size = new System.Drawing.Size(985, 189);
            this.grupoDatosCirujano.TabIndex = 1;
            this.grupoDatosCirujano.TabStop = false;
            this.grupoDatosCirujano.Text = "Informacion del Cirujano";
            this.grupoDatosCirujano.Enter += new System.EventHandler(this.grupoDatosPacientes_Enter);
            // 
            // textCorreoElectronico
            // 
            this.textCorreoElectronico.Location = new System.Drawing.Point(610, 138);
            this.textCorreoElectronico.Name = "textCorreoElectronico";
            this.textCorreoElectronico.Size = new System.Drawing.Size(229, 25);
            this.textCorreoElectronico.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(490, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Correo Electronico";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(653, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "-";
            // 
            // textTelefonoMovil
            // 
            this.textTelefonoMovil.Location = new System.Drawing.Point(671, 102);
            this.textTelefonoMovil.Name = "textTelefonoMovil";
            this.textTelefonoMovil.Size = new System.Drawing.Size(168, 25);
            this.textTelefonoMovil.TabIndex = 16;
            // 
            // textCodigoAreaMovil
            // 
            this.textCodigoAreaMovil.Location = new System.Drawing.Point(610, 102);
            this.textCodigoAreaMovil.Name = "textCodigoAreaMovil";
            this.textCodigoAreaMovil.Size = new System.Drawing.Size(42, 25);
            this.textCodigoAreaMovil.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(512, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Telefono Movil";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(653, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "-";
            // 
            // textTelefonoFijo
            // 
            this.textTelefonoFijo.Location = new System.Drawing.Point(671, 69);
            this.textTelefonoFijo.Name = "textTelefonoFijo";
            this.textTelefonoFijo.Size = new System.Drawing.Size(168, 25);
            this.textTelefonoFijo.TabIndex = 12;
            // 
            // textCodigoAreaFijo
            // 
            this.textCodigoAreaFijo.Location = new System.Drawing.Point(610, 69);
            this.textCodigoAreaFijo.Name = "textCodigoAreaFijo";
            this.textCodigoAreaFijo.Size = new System.Drawing.Size(42, 25);
            this.textCodigoAreaFijo.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(520, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Telefono Fijo";
            // 
            // textIdPaciente
            // 
            this.textIdPaciente.Location = new System.Drawing.Point(610, 35);
            this.textIdPaciente.Name = "textIdPaciente";
            this.textIdPaciente.Size = new System.Drawing.Size(229, 25);
            this.textIdPaciente.TabIndex = 9;
            // 
            // textSegundoApellido
            // 
            this.textSegundoApellido.Location = new System.Drawing.Point(163, 138);
            this.textSegundoApellido.Name = "textSegundoApellido";
            this.textSegundoApellido.Size = new System.Drawing.Size(232, 25);
            this.textSegundoApellido.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Segundo Apellido";
            // 
            // textPrimerApellido
            // 
            this.textPrimerApellido.Location = new System.Drawing.Point(163, 102);
            this.textPrimerApellido.Name = "textPrimerApellido";
            this.textPrimerApellido.Size = new System.Drawing.Size(232, 25);
            this.textPrimerApellido.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "* Primer apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "CI Cirujano";
            // 
            // textSegundoNombre
            // 
            this.textSegundoNombre.Location = new System.Drawing.Point(163, 66);
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
            this.label3.Location = new System.Drawing.Point(49, 69);
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
            this.ClientSize = new System.Drawing.Size(1264, 750);
            this.Controls.Add(this.panel1);
            this.Name = "AgregarCirujano";
            this.Load += new System.EventHandler(this.AgregarCirujano_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.GrupoCirugias.ResumeLayout(false);
            this.GrupoCirugias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.GroupBox GrupoCirugias;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonRestaurarDatosPaciente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button botonAgregarIntervencionQuirurgica;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cirugia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.TextBox textBox1;


    }
}
