namespace PryAriettiIEFI
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.SsPrincipal = new System.Windows.Forms.StatusStrip();
            this.PanelSubMenu = new System.Windows.Forms.Panel();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdConsultaPorCliente = new System.Windows.Forms.Button();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.cmdListarClientes = new System.Windows.Forms.Button();
            this.cmdBuscarPorBarrio = new System.Windows.Forms.Button();
            this.cmdConsultaPorActividad = new System.Windows.Forms.Button();
            this.cmdClientes = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelPrincipal.SuspendLayout();
            this.PanelSubMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.PanelPrincipal.Controls.Add(this.SsPrincipal);
            this.PanelPrincipal.Controls.Add(this.PanelSubMenu);
            this.PanelPrincipal.Controls.Add(this.cmdClientes);
            this.PanelPrincipal.Controls.Add(this.PanelLogo);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(200, 487);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // SsPrincipal
            // 
            this.SsPrincipal.Location = new System.Drawing.Point(0, 465);
            this.SsPrincipal.Name = "SsPrincipal";
            this.SsPrincipal.Size = new System.Drawing.Size(200, 22);
            this.SsPrincipal.TabIndex = 2;
            // 
            // PanelSubMenu
            // 
            this.PanelSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PanelSubMenu.Controls.Add(this.cmdModificar);
            this.PanelSubMenu.Controls.Add(this.cmdConsultaPorCliente);
            this.PanelSubMenu.Controls.Add(this.cmdRegistrar);
            this.PanelSubMenu.Controls.Add(this.cmdListarClientes);
            this.PanelSubMenu.Controls.Add(this.cmdBuscarPorBarrio);
            this.PanelSubMenu.Controls.Add(this.cmdConsultaPorActividad);
            this.PanelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenu.Location = new System.Drawing.Point(0, 145);
            this.PanelSubMenu.Name = "PanelSubMenu";
            this.PanelSubMenu.Size = new System.Drawing.Size(200, 307);
            this.PanelSubMenu.TabIndex = 1;
            // 
            // cmdModificar
            // 
            this.cmdModificar.FlatAppearance.BorderSize = 0;
            this.cmdModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdModificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdModificar.Location = new System.Drawing.Point(-3, 51);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.cmdModificar.Size = new System.Drawing.Size(200, 45);
            this.cmdModificar.TabIndex = 2;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdConsultaPorCliente
            // 
            this.cmdConsultaPorCliente.FlatAppearance.BorderSize = 0;
            this.cmdConsultaPorCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdConsultaPorCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdConsultaPorCliente.Location = new System.Drawing.Point(-3, 255);
            this.cmdConsultaPorCliente.Name = "cmdConsultaPorCliente";
            this.cmdConsultaPorCliente.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.cmdConsultaPorCliente.Size = new System.Drawing.Size(200, 45);
            this.cmdConsultaPorCliente.TabIndex = 6;
            this.cmdConsultaPorCliente.Text = "Consulta Por Cliente";
            this.cmdConsultaPorCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdConsultaPorCliente.UseVisualStyleBackColor = true;
            this.cmdConsultaPorCliente.Click += new System.EventHandler(this.cmdConsultaPorCliente_Click);
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.FlatAppearance.BorderSize = 0;
            this.cmdRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRegistrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdRegistrar.Location = new System.Drawing.Point(-3, 0);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.cmdRegistrar.Size = new System.Drawing.Size(200, 45);
            this.cmdRegistrar.TabIndex = 1;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // cmdListarClientes
            // 
            this.cmdListarClientes.FlatAppearance.BorderSize = 0;
            this.cmdListarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdListarClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdListarClientes.Location = new System.Drawing.Point(-3, 102);
            this.cmdListarClientes.Name = "cmdListarClientes";
            this.cmdListarClientes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.cmdListarClientes.Size = new System.Drawing.Size(200, 45);
            this.cmdListarClientes.TabIndex = 4;
            this.cmdListarClientes.Text = "Listado de Clientes ";
            this.cmdListarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdListarClientes.UseVisualStyleBackColor = true;
            this.cmdListarClientes.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // cmdBuscarPorBarrio
            // 
            this.cmdBuscarPorBarrio.FlatAppearance.BorderSize = 0;
            this.cmdBuscarPorBarrio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBuscarPorBarrio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdBuscarPorBarrio.Location = new System.Drawing.Point(-3, 204);
            this.cmdBuscarPorBarrio.Name = "cmdBuscarPorBarrio";
            this.cmdBuscarPorBarrio.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.cmdBuscarPorBarrio.Size = new System.Drawing.Size(200, 45);
            this.cmdBuscarPorBarrio.TabIndex = 3;
            this.cmdBuscarPorBarrio.Text = "Consulta Por Barrio";
            this.cmdBuscarPorBarrio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdBuscarPorBarrio.UseVisualStyleBackColor = true;
            this.cmdBuscarPorBarrio.Click += new System.EventHandler(this.cmdBuscarPorBarrio_Click);
            // 
            // cmdConsultaPorActividad
            // 
            this.cmdConsultaPorActividad.FlatAppearance.BorderSize = 0;
            this.cmdConsultaPorActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdConsultaPorActividad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdConsultaPorActividad.Location = new System.Drawing.Point(-3, 153);
            this.cmdConsultaPorActividad.Name = "cmdConsultaPorActividad";
            this.cmdConsultaPorActividad.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.cmdConsultaPorActividad.Size = new System.Drawing.Size(200, 45);
            this.cmdConsultaPorActividad.TabIndex = 5;
            this.cmdConsultaPorActividad.Text = "Consulta Por Actividad";
            this.cmdConsultaPorActividad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdConsultaPorActividad.UseVisualStyleBackColor = true;
            this.cmdConsultaPorActividad.Click += new System.EventHandler(this.cmdConsultaPorActividad_Click);
            // 
            // cmdClientes
            // 
            this.cmdClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdClientes.FlatAppearance.BorderSize = 0;
            this.cmdClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdClientes.Location = new System.Drawing.Point(0, 100);
            this.cmdClientes.Name = "cmdClientes";
            this.cmdClientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cmdClientes.Size = new System.Drawing.Size(200, 45);
            this.cmdClientes.TabIndex = 1;
            this.cmdClientes.Text = "Clientes";
            this.cmdClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdClientes.UseVisualStyleBackColor = true;
            this.cmdClientes.Click += new System.EventHandler(this.cmdClientes_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.label1);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(200, 100);
            this.PanelLogo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(35, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO !";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(203, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(428, 488);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 487);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PanelPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = " GYM Arietti´s";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelPrincipal.PerformLayout();
            this.PanelSubMenu.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            this.PanelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Panel PanelSubMenu;
        private System.Windows.Forms.Button cmdListarClientes;
        private System.Windows.Forms.Button cmdBuscarPorBarrio;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.Button cmdClientes;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.StatusStrip SsPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdConsultaPorActividad;
        private System.Windows.Forms.Button cmdConsultaPorCliente;
    }
}

