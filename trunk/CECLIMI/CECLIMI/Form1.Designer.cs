namespace CECLIMI
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.papiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.babaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alejandroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.papiToolStripMenuItem,
            this.vamosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(536, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // papiToolStripMenuItem
            // 
            this.papiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kikiToolStripMenuItem,
            this.babaToolStripMenuItem});
            this.papiToolStripMenuItem.Name = "papiToolStripMenuItem";
            this.papiToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.papiToolStripMenuItem.Text = "Papi";
            // 
            // vamosToolStripMenuItem
            // 
            this.vamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alejandroToolStripMenuItem});
            this.vamosToolStripMenuItem.Name = "vamosToolStripMenuItem";
            this.vamosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.vamosToolStripMenuItem.Text = "Vamos";
            // 
            // kikiToolStripMenuItem
            // 
            this.kikiToolStripMenuItem.Name = "kikiToolStripMenuItem";
            this.kikiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kikiToolStripMenuItem.Text = "Kiki";
            // 
            // babaToolStripMenuItem
            // 
            this.babaToolStripMenuItem.Name = "babaToolStripMenuItem";
            this.babaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.babaToolStripMenuItem.Text = "Baba";
            // 
            // alejandroToolStripMenuItem
            // 
            this.alejandroToolStripMenuItem.Name = "alejandroToolStripMenuItem";
            this.alejandroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alejandroToolStripMenuItem.Text = "Alejandro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem papiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem babaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alejandroToolStripMenuItem;

    }
}

