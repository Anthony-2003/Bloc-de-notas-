namespace WindowsFormsEditorDeTexto
{
    partial class TakoBlock
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakoBlock));
            this.contenidoRtb = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alejarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contenidoRtb
            // 
            resources.ApplyResources(this.contenidoRtb, "contenidoRtb");
            this.contenidoRtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contenidoRtb.Name = "contenidoRtb";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.formatoToolStripMenuItem,
            this.zoomToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            resources.ApplyResources(this.archivoToolStripMenuItem, "archivoToolStripMenuItem");
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            resources.ApplyResources(this.nuevoToolStripMenuItem, "nuevoToolStripMenuItem");
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            resources.ApplyResources(this.abrirToolStripMenuItem, "abrirToolStripMenuItem");
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            resources.ApplyResources(this.guardarToolStripMenuItem, "guardarToolStripMenuItem");
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fuentesToolStripMenuItem});
            this.formatoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            resources.ApplyResources(this.formatoToolStripMenuItem, "formatoToolStripMenuItem");
            // 
            // fuentesToolStripMenuItem
            // 
            this.fuentesToolStripMenuItem.Name = "fuentesToolStripMenuItem";
            resources.ApplyResources(this.fuentesToolStripMenuItem, "fuentesToolStripMenuItem");
            this.fuentesToolStripMenuItem.Click += new System.EventHandler(this.fuentesToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercarToolStripMenuItem,
            this.alejarToolStripMenuItem});
            this.zoomToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            resources.ApplyResources(this.zoomToolStripMenuItem, "zoomToolStripMenuItem");
            // 
            // acercarToolStripMenuItem
            // 
            this.acercarToolStripMenuItem.Name = "acercarToolStripMenuItem";
            resources.ApplyResources(this.acercarToolStripMenuItem, "acercarToolStripMenuItem");
            this.acercarToolStripMenuItem.Click += new System.EventHandler(this.acercarToolStripMenuItem_Click);
            // 
            // alejarToolStripMenuItem
            // 
            this.alejarToolStripMenuItem.Name = "alejarToolStripMenuItem";
            resources.ApplyResources(this.alejarToolStripMenuItem, "alejarToolStripMenuItem");
            this.alejarToolStripMenuItem.Click += new System.EventHandler(this.alejarToolStripMenuItem_Click);
            // 
            // TakoBlock
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.contenidoRtb);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TakoBlock";
            this.Load += new System.EventHandler(this.TakoBlock_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox contenidoRtb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alejarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuentesToolStripMenuItem;
    }
}

