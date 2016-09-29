namespace AplicacionEscro
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
            this.lstCiudad = new System.Windows.Forms.ListBox();
            this.btnFuente = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFuente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsFuente = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsColor = new System.Windows.Forms.ToolStripButton();
            this.tsSalir = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.tsFuente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCiudad
            // 
            this.lstCiudad.FormattingEnabled = true;
            this.lstCiudad.Items.AddRange(new object[] {
            "Neiva",
            "Bogotá",
            "Pereira",
            "Armenia ",
            "Cali",
            "Medellin",
            "Bucaramanga"});
            this.lstCiudad.Location = new System.Drawing.Point(32, 69);
            this.lstCiudad.Name = "lstCiudad";
            this.lstCiudad.Size = new System.Drawing.Size(120, 108);
            this.lstCiudad.TabIndex = 0;
            this.lstCiudad.SelectedIndexChanged += new System.EventHandler(this.lstCiudad_SelectedIndexChanged);
            // 
            // btnFuente
            // 
            this.btnFuente.Location = new System.Drawing.Point(183, 89);
            this.btnFuente.Name = "btnFuente";
            this.btnFuente.Size = new System.Drawing.Size(117, 23);
            this.btnFuente.TabIndex = 1;
            this.btnFuente.Text = "Cambiar Fuente";
            this.btnFuente.UseVisualStyleBackColor = true;
            this.btnFuente.Click += new System.EventHandler(this.btnFuente_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(183, 141);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(117, 23);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "Cambiar Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchivo,
            this.mnuOpciones});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(333, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuArchivo
            // 
            this.mnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalir});
            this.mnuArchivo.Name = "mnuArchivo";
            this.mnuArchivo.Size = new System.Drawing.Size(60, 20);
            this.mnuArchivo.Text = "&Archivo";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(96, 22);
            this.mnuSalir.Text = "&Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // mnuOpciones
            // 
            this.mnuOpciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFuente,
            this.mnuColor});
            this.mnuOpciones.Name = "mnuOpciones";
            this.mnuOpciones.Size = new System.Drawing.Size(69, 20);
            this.mnuOpciones.Text = "&Opciones";
            // 
            // mnuFuente
            // 
            this.mnuFuente.Name = "mnuFuente";
            this.mnuFuente.Size = new System.Drawing.Size(110, 22);
            this.mnuFuente.Text = "&Fuente";
            this.mnuFuente.Click += new System.EventHandler(this.mnuFuente_Click);
            // 
            // mnuColor
            // 
            this.mnuColor.Name = "mnuColor";
            this.mnuColor.Size = new System.Drawing.Size(110, 22);
            this.mnuColor.Text = "&Color";
            // 
            // tsFuente
            // 
            this.tsFuente.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.tsColor,
            this.tsSalir});
            this.tsFuente.Location = new System.Drawing.Point(0, 24);
            this.tsFuente.Name = "tsFuente";
            this.tsFuente.Size = new System.Drawing.Size(333, 25);
            this.tsFuente.TabIndex = 4;
            this.tsFuente.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsColor
            // 
            this.tsColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsColor.Name = "tsColor";
            this.tsColor.Size = new System.Drawing.Size(23, 22);
            this.tsColor.Text = "toolStripButton2";
            // 
            // tsSalir
            // 
            this.tsSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSalir.Name = "tsSalir";
            this.tsSalir.Size = new System.Drawing.Size(23, 22);
            this.tsSalir.Text = "toolStripButton3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 281);
            this.Controls.Add(this.tsFuente);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnFuente);
            this.Controls.Add(this.lstCiudad);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clases Del FW";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tsFuente.ResumeLayout(false);
            this.tsFuente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void mnuFuente_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ListBox lstCiudad;
        private System.Windows.Forms.Button btnFuente;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuOpciones;
        private System.Windows.Forms.ToolStripMenuItem mnuFuente;
        private System.Windows.Forms.ToolStripMenuItem mnuColor;
        private System.Windows.Forms.ToolStrip tsFuente;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsColor;
        private System.Windows.Forms.ToolStripButton tsSalir;

        public System.EventHandler toolStripButton1_Click { get; set; }
    }
}

