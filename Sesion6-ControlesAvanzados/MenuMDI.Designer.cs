namespace Sesion6_ControlesAvanzados
{
    partial class MenuMDI
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
            this.registrarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeOpcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarPacienteToolStripMenuItem,
            this.registrarProductoToolStripMenuItem,
            this.calendarioToolStripMenuItem,
            this.listadoDeOpcionesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1102, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarPacienteToolStripMenuItem
            // 
            this.registrarPacienteToolStripMenuItem.Name = "registrarPacienteToolStripMenuItem";
            this.registrarPacienteToolStripMenuItem.Size = new System.Drawing.Size(155, 29);
            this.registrarPacienteToolStripMenuItem.Text = "Registrar Cliente";
            this.registrarPacienteToolStripMenuItem.Click += new System.EventHandler(this.registrarPacienteToolStripMenuItem_Click);
            // 
            // registrarProductoToolStripMenuItem
            // 
            this.registrarProductoToolStripMenuItem.Name = "registrarProductoToolStripMenuItem";
            this.registrarProductoToolStripMenuItem.Size = new System.Drawing.Size(175, 29);
            this.registrarProductoToolStripMenuItem.Text = "Registrar Producto";
            this.registrarProductoToolStripMenuItem.Click += new System.EventHandler(this.registrarProductoToolStripMenuItem_Click_2);
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.calendarioToolStripMenuItem.Text = "Calendario";
            this.calendarioToolStripMenuItem.Click += new System.EventHandler(this.calendarioToolStripMenuItem_Click);
            // 
            // listadoDeOpcionesToolStripMenuItem
            // 
            this.listadoDeOpcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem});
            this.listadoDeOpcionesToolStripMenuItem.Name = "listadoDeOpcionesToolStripMenuItem";
            this.listadoDeOpcionesToolStripMenuItem.Size = new System.Drawing.Size(190, 29);
            this.listadoDeOpcionesToolStripMenuItem.Text = "Listado de Opciones";
            this.listadoDeOpcionesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeOpcionesToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // MenuMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 749);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuMDI";
            this.Text = "MenuMDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem registrarPacienteToolStripMenuItem;
        private ToolStripMenuItem registrarProductoToolStripMenuItem;
        private ToolStripMenuItem calendarioToolStripMenuItem;
        private ToolStripMenuItem listadoDeOpcionesToolStripMenuItem;
        private ToolStripMenuItem calculadoraToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}