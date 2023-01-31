namespace PryAriettiIEFI
{
    partial class FrmModificarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarCliente));
            this.SsBuscar = new System.Windows.Forms.StatusStrip();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.mrcDatosCliente = new System.Windows.Forms.GroupBox();
            this.lstBarrio = new System.Windows.Forms.ComboBox();
            this.lstActividad = new System.Windows.Forms.ComboBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblActividad = new System.Windows.Forms.Label();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpInscipcion = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstSexo = new System.Windows.Forms.ComboBox();
            this.mrcDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // SsBuscar
            // 
            this.SsBuscar.Location = new System.Drawing.Point(0, 394);
            this.SsBuscar.Name = "SsBuscar";
            this.SsBuscar.Size = new System.Drawing.Size(438, 22);
            this.SsBuscar.TabIndex = 14;
            this.SsBuscar.Text = "statusStrip1";
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(175, 35);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 22);
            this.cmdBuscar.TabIndex = 13;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(159, 9);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(109, 20);
            this.txtDniCliente.TabIndex = 12;
            this.txtDniCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDniCliente_KeyPress);
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.Location = new System.Drawing.Point(24, 9);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(99, 13);
            this.lblDniCliente.TabIndex = 11;
            this.lblDniCliente.Text = "Ingrese DNI Cliente";
            // 
            // mrcDatosCliente
            // 
            this.mrcDatosCliente.Controls.Add(this.lstSexo);
            this.mrcDatosCliente.Controls.Add(this.label4);
            this.mrcDatosCliente.Controls.Add(this.label3);
            this.mrcDatosCliente.Controls.Add(this.dtpInscipcion);
            this.mrcDatosCliente.Controls.Add(this.txtEmail);
            this.mrcDatosCliente.Controls.Add(this.label2);
            this.mrcDatosCliente.Controls.Add(this.txtTelefono);
            this.mrcDatosCliente.Controls.Add(this.label1);
            this.mrcDatosCliente.Controls.Add(this.lstBarrio);
            this.mrcDatosCliente.Controls.Add(this.lstActividad);
            this.mrcDatosCliente.Controls.Add(this.txtSaldo);
            this.mrcDatosCliente.Controls.Add(this.lblSaldo);
            this.mrcDatosCliente.Controls.Add(this.lblActividad);
            this.mrcDatosCliente.Controls.Add(this.cmdModificar);
            this.mrcDatosCliente.Controls.Add(this.cmdEliminar);
            this.mrcDatosCliente.Controls.Add(this.cmdGuardar);
            this.mrcDatosCliente.Controls.Add(this.txtDireccion);
            this.mrcDatosCliente.Controls.Add(this.txtNombre);
            this.mrcDatosCliente.Controls.Add(this.lblBarrio);
            this.mrcDatosCliente.Controls.Add(this.lblDireccion);
            this.mrcDatosCliente.Controls.Add(this.lblNombre);
            this.mrcDatosCliente.Location = new System.Drawing.Point(12, 63);
            this.mrcDatosCliente.Name = "mrcDatosCliente";
            this.mrcDatosCliente.Size = new System.Drawing.Size(396, 321);
            this.mrcDatosCliente.TabIndex = 10;
            this.mrcDatosCliente.TabStop = false;
            this.mrcDatosCliente.Text = "Datos";
            // 
            // lstBarrio
            // 
            this.lstBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstBarrio.Enabled = false;
            this.lstBarrio.FormattingEnabled = true;
            this.lstBarrio.Items.AddRange(new object[] {
            "Nueva Cordoba",
            "Alta Cordoba",
            "Barrio Parque ",
            "San Fernando",
            "Nueva Italia",
            "General Paz"});
            this.lstBarrio.Location = new System.Drawing.Point(191, 82);
            this.lstBarrio.Name = "lstBarrio";
            this.lstBarrio.Size = new System.Drawing.Size(107, 21);
            this.lstBarrio.TabIndex = 16;
            // 
            // lstActividad
            // 
            this.lstActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstActividad.Enabled = false;
            this.lstActividad.FormattingEnabled = true;
            this.lstActividad.Items.AddRange(new object[] {
            "Fitnes",
            "Musculacion",
            "Baile",
            "Yoga",
            "Cardio",
            "Funcional"});
            this.lstActividad.Location = new System.Drawing.Point(191, 108);
            this.lstActividad.Name = "lstActividad";
            this.lstActividad.Size = new System.Drawing.Size(107, 21);
            this.lstActividad.TabIndex = 15;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(191, 134);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(107, 20);
            this.txtSaldo.TabIndex = 14;
            this.txtSaldo.TextChanged += new System.EventHandler(this.txtSaldo_TextChanged);
            this.txtSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldo_KeyPress);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(21, 134);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(67, 13);
            this.lblSaldo.TabIndex = 13;
            this.lblSaldo.Text = "Mensualidad";
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(21, 108);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(51, 13);
            this.lblActividad.TabIndex = 11;
            this.lblActividad.Text = "Actividad";
            // 
            // cmdModificar
            // 
            this.cmdModificar.Location = new System.Drawing.Point(165, 283);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(75, 22);
            this.cmdModificar.TabIndex = 10;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(60, 283);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(75, 22);
            this.cmdEliminar.TabIndex = 9;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(270, 283);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(75, 22);
            this.cmdGuardar.TabIndex = 7;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(191, 53);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(107, 20);
            this.txtDireccion.TabIndex = 5;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(191, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(107, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(21, 82);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(34, 13);
            this.lblBarrio.TabIndex = 3;
            this.lblBarrio.Text = "Barrio";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(21, 55);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(191, 160);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(107, 20);
            this.txtTelefono.TabIndex = 18;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Telefono";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(191, 186);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(107, 20);
            this.txtEmail.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Email";
            // 
            // dtpInscipcion
            // 
            this.dtpInscipcion.Enabled = false;
            this.dtpInscipcion.Location = new System.Drawing.Point(191, 212);
            this.dtpInscipcion.Name = "dtpInscipcion";
            this.dtpInscipcion.Size = new System.Drawing.Size(200, 20);
            this.dtpInscipcion.TabIndex = 21;
            this.dtpInscipcion.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Fecha Inscripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Sexo";
            // 
            // lstSexo
            // 
            this.lstSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstSexo.Enabled = false;
            this.lstSexo.FormattingEnabled = true;
            this.lstSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.lstSexo.Location = new System.Drawing.Point(191, 239);
            this.lstSexo.Name = "lstSexo";
            this.lstSexo.Size = new System.Drawing.Size(107, 21);
            this.lstSexo.TabIndex = 24;
            // 
            // FrmModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 416);
            this.Controls.Add(this.SsBuscar);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.txtDniCliente);
            this.Controls.Add(this.lblDniCliente);
            this.Controls.Add(this.mrcDatosCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmModificarCliente";
            this.Text = "Consultar Cliente ";
            this.Load += new System.EventHandler(this.FrmConsultarCliente_Load);
            this.mrcDatosCliente.ResumeLayout(false);
            this.mrcDatosCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip SsBuscar;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.GroupBox mrcDatosCliente;
        private System.Windows.Forms.ComboBox lstBarrio;
        private System.Windows.Forms.ComboBox lstActividad;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DateTimePicker dtpInscipcion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lstSexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}