namespace Sesion6_ControlesAvanzados
{
    partial class RegistroCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboTipoDocu = new System.Windows.Forms.ComboBox();
            this.txtNumDocu = new System.Windows.Forms.TextBox();
            this.dtFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lstDistrito = new System.Windows.Forms.ListBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre y Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Distrito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha Nacimiento";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(217, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(425, 31);
            this.txtNombre.TabIndex = 5;
            // 
            // cboTipoDocu
            // 
            this.cboTipoDocu.FormattingEnabled = true;
            this.cboTipoDocu.Location = new System.Drawing.Point(217, 79);
            this.cboTipoDocu.Name = "cboTipoDocu";
            this.cboTipoDocu.Size = new System.Drawing.Size(205, 33);
            this.cboTipoDocu.TabIndex = 6;
            // 
            // txtNumDocu
            // 
            this.txtNumDocu.Location = new System.Drawing.Point(448, 82);
            this.txtNumDocu.Name = "txtNumDocu";
            this.txtNumDocu.Size = new System.Drawing.Size(194, 31);
            this.txtNumDocu.TabIndex = 7;
            // 
            // dtFechaNac
            // 
            this.dtFechaNac.Location = new System.Drawing.Point(217, 127);
            this.dtFechaNac.Name = "dtFechaNac";
            this.dtFechaNac.Size = new System.Drawing.Size(425, 31);
            this.dtFechaNac.TabIndex = 8;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(217, 173);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(425, 31);
            this.txtDireccion.TabIndex = 9;
            // 
            // lstDistrito
            // 
            this.lstDistrito.FormattingEnabled = true;
            this.lstDistrito.ItemHeight = 25;
            this.lstDistrito.Location = new System.Drawing.Point(217, 229);
            this.lstDistrito.Name = "lstDistrito";
            this.lstDistrito.Size = new System.Drawing.Size(425, 129);
            this.lstDistrito.TabIndex = 10;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(209, 384);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(104, 35);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(385, 384);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 35);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // RegistroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lstDistrito);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.dtFechaNac);
            this.Controls.Add(this.txtNumDocu);
            this.Controls.Add(this.cboTipoDocu);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroCliente";
            this.Text = "RegistroCliente";
            this.Load += new System.EventHandler(this.RegistroCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private ComboBox cboTipoDocu;
        private TextBox txtNumDocu;
        private DateTimePicker dtFechaNac;
        private TextBox txtDireccion;
        private ListBox lstDistrito;
        private Button btnNuevo;
        private Button btnGuardar;
    }
}