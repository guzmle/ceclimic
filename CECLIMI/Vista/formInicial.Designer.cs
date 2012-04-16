namespace CECLIMI.Vista
{
    partial class formInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInicial));
            this.panelDatos = new System.Windows.Forms.Panel();
            this.usuarioMostrar = new System.Windows.Forms.Label();
            this.rollMostrar = new System.Windows.Forms.Label();
            this.apellidoMostrar = new System.Windows.Forms.Label();
            this.nombreMostrar = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.papiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.babaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alejandroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelDatos.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDatos
            // 
            this.panelDatos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDatos.Controls.Add(this.usuarioMostrar);
            this.panelDatos.Controls.Add(this.rollMostrar);
            this.panelDatos.Controls.Add(this.apellidoMostrar);
            this.panelDatos.Controls.Add(this.nombreMostrar);
            this.panelDatos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDatos.Location = new System.Drawing.Point(12, 277);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(239, 396);
            this.panelDatos.TabIndex = 4;
            this.panelDatos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDatos_Paint);
            // 
            // usuarioMostrar
            // 
            this.usuarioMostrar.AutoSize = true;
            this.usuarioMostrar.Location = new System.Drawing.Point(117, 191);
            this.usuarioMostrar.Name = "usuarioMostrar";
            this.usuarioMostrar.Size = new System.Drawing.Size(0, 20);
            this.usuarioMostrar.TabIndex = 9;
            // 
            // rollMostrar
            // 
            this.rollMostrar.AutoSize = true;
            this.rollMostrar.Location = new System.Drawing.Point(117, 145);
            this.rollMostrar.Name = "rollMostrar";
            this.rollMostrar.Size = new System.Drawing.Size(0, 20);
            this.rollMostrar.TabIndex = 8;
            // 
            // apellidoMostrar
            // 
            this.apellidoMostrar.AutoSize = true;
            this.apellidoMostrar.Location = new System.Drawing.Point(117, 97);
            this.apellidoMostrar.Name = "apellidoMostrar";
            this.apellidoMostrar.Size = new System.Drawing.Size(0, 20);
            this.apellidoMostrar.TabIndex = 7;
            // 
            // nombreMostrar
            // 
            this.nombreMostrar.AutoSize = true;
            this.nombreMostrar.Location = new System.Drawing.Point(117, 54);
            this.nombreMostrar.Name = "nombreMostrar";
            this.nombreMostrar.Size = new System.Drawing.Size(0, 20);
            this.nombreMostrar.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.papiToolStripMenuItem,
            this.vamosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // papiToolStripMenuItem
            // 
            this.papiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kikiToolStripMenuItem,
            this.babaToolStripMenuItem});
            this.papiToolStripMenuItem.Name = "papiToolStripMenuItem";
            this.papiToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.papiToolStripMenuItem.Text = "ceclimi";
            // 
            // kikiToolStripMenuItem
            // 
            this.kikiToolStripMenuItem.Name = "kikiToolStripMenuItem";
            this.kikiToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.kikiToolStripMenuItem.Text = "Kiki";
            // 
            // babaToolStripMenuItem
            // 
            this.babaToolStripMenuItem.Name = "babaToolStripMenuItem";
            this.babaToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.babaToolStripMenuItem.Text = "Baba";
            // 
            // vamosToolStripMenuItem
            // 
            this.vamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alejandroToolStripMenuItem});
            this.vamosToolStripMenuItem.Name = "vamosToolStripMenuItem";
            this.vamosToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.vamosToolStripMenuItem.Text = "Ceclimi";
            this.vamosToolStripMenuItem.Click += new System.EventHandler(this.vamosToolStripMenuItem_Click);
            // 
            // alejandroToolStripMenuItem
            // 
            this.alejandroToolStripMenuItem.Name = "alejandroToolStripMenuItem";
            this.alejandroToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.alejandroToolStripMenuItem.Text = "Alejandro";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.BackgroundImage = global::CECLIMI.Properties.Resources.ceclimi;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(12, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 244);
            this.panel2.TabIndex = 5;
            // 
            // formInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formInicial";
            this.Load += new System.EventHandler(this.formInicial_Load);
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Label usuarioMostrar;
        private System.Windows.Forms.Label rollMostrar;
        private System.Windows.Forms.Label apellidoMostrar;
        private System.Windows.Forms.Label nombreMostrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem papiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem babaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alejandroToolStripMenuItem;
    }
}