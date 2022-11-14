namespace PryAriettiIEFI
{
    partial class FrmRegistrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarCliente));
            this.SsAgregarCliente = new System.Windows.Forms.StatusStrip();
            this.mrcDatosCliente = new System.Windows.Forms.GroupBox();
            this.lstBarrio = new System.Windows.Forms.ComboBox();
            this.lstActividad = new System.Windows.Forms.ComboBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.cmdRegistrarCliente = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.mrcDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // SsAgregarCliente
            // 
            this.SsAgregarCliente.Location = new System.Drawing.Point(0, 314);
            this.SsAgregarCliente.Name = "SsAgregarCliente";
            this.SsAgregarCliente.Size = new System.Drawing.Size(373, 22);
            this.SsAgregarCliente.TabIndex = 3;
            this.SsAgregarCliente.Text = "statusStrip1";
            // 
            // mrcDatosCliente
            // 
            this.mrcDatosCliente.Controls.Add(this.lstBarrio);
            this.mrcDatosCliente.Controls.Add(this.lstActividad);
            this.mrcDatosCliente.Controls.Add(this.txtSaldo);
            this.mrcDatosCliente.Controls.Add(this.lblSaldo);
            this.mrcDatosCliente.Controls.Add(this.lblBarrio);
            this.mrcDatosCliente.Controls.Add(this.txtDireccion);
            this.mrcDatosCliente.Controls.Add(this.lblDireccion);
            this.mrcDatosCliente.Controls.Add(this.txtDNI);
            this.mrcDatosCliente.Controls.Add(this.lblDNI);
            this.mrcDatosCliente.Controls.Add(this.cmdRegistrarCliente);
            this.mrcDatosCliente.Controls.Add(this.txtNombre);
            this.mrcDatosCliente.Controls.Add(this.lblActividad);
            this.mrcDatosCliente.Controls.Add(this.lblNombre);
            this.mrcDatosCliente.Location = new System.Drawing.Point(12, 12);
            this.mrcDatosCliente.Name = "mrcDatosCliente";
            this.mrcDatosCliente.Size = new System.Drawing.Size(337, 287);
            this.mrcDatosCliente.TabIndex = 2;
            this.mrcDatosCliente.TabStop = false;
            this.mrcDatosCliente.Text = "Datos";
            // 
            // lstBarrio
            // 
            this.lstBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstBarrio.FormattingEnabled = true;
            this.lstBarrio.Location = new System.Drawing.Point(115, 133);
            this.lstBarrio.Name = "lstBarrio";
            this.lstBarrio.Size = new System.Drawing.Size(107, 21);
            this.lstBarrio.TabIndex = 17;
            // 
            // lstActividad
            // 
            this.lstActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstActividad.FormattingEnabled = true;
            this.lstActividad.Items.AddRange(new object[] {
            "Fitnes",
            "Musculacion",
            "Baile",
            "Yoga",
            "Cardio",
            "Funcional"});
            this.lstActividad.Location = new System.Drawing.Point(115, 167);
            this.lstActividad.Name = "lstActividad";
            this.lstActividad.Size = new System.Drawing.Size(107, 21);
            this.lstActividad.TabIndex = 16;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(115, 202);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(48, 20);
            this.txtSaldo.TabIndex = 15;
            this.txtSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldo_KeyPress);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(21, 202);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(34, 13);
            this.lblSaldo.TabIndex = 14;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(21, 132);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(34, 13);
            this.lblBarrio.TabIndex = 13;
            this.lblBarrio.Text = "Barrio";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(118, 97);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(107, 20);
            this.txtDireccion.TabIndex = 11;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(21, 97);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 10;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(118, 62);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(107, 20);
            this.txtDNI.TabIndex = 9;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(21, 62);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 8;
            this.lblDNI.Text = "DNI";
            // 
            // cmdRegistrarCliente
            // 
            this.cmdRegistrarCliente.Location = new System.Drawing.Point(223, 251);
            this.cmdRegistrarCliente.Name = "cmdRegistrarCliente";
            this.cmdRegistrarCliente.Size = new System.Drawing.Size(75, 22);
            this.cmdRegistrarCliente.TabIndex = 7;
            this.cmdRegistrarCliente.Text = "Registrar";
            this.cmdRegistrarCliente.UseVisualStyleBackColor = true;
            this.cmdRegistrarCliente.Click += new System.EventHandler(this.cmdRegistrarCliente_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(118, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(21, 167);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(51, 13);
            this.lblActividad.TabIndex = 1;
            this.lblActividad.Text = "Actividad";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(92, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre y Apellido";
            // 
            // FrmRegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 336);
            this.Controls.Add(this.SsAgregarCliente);
            this.Controls.Add(this.mrcDatosCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistrarCliente";
            this.Text = "Registro de Cliente ";
            this.Load += new System.EventHandler(this.FrmRegistrarCliente_Load);
            this.mrcDatosCliente.ResumeLayout(false);
            this.mrcDatosCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip SsAgregarCliente;
        private System.Windows.Forms.GroupBox mrcDatosCliente;
        private System.Windows.Forms.ComboBox lstBarrio;
        private System.Windows.Forms.ComboBox lstActividad;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Button cmdRegistrarCliente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblNombre;
    }
}