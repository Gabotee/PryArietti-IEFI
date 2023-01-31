namespace PryAriettiIEFI
{
    partial class FrmBusquedaPorActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBusquedaPorActividad));
            this.lblActividad = new System.Windows.Forms.Label();
            this.SsPorActividad = new System.Windows.Forms.StatusStrip();
            this.cmdListar = new System.Windows.Forms.Button();
            this.lstActividad = new System.Windows.Forms.ComboBox();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblMayorPromedio = new System.Windows.Forms.Label();
            this.txtMayorPromedio = new System.Windows.Forms.TextBox();
            this.txtMenorPromedio = new System.Windows.Forms.TextBox();
            this.lblMenorPromedio = new System.Windows.Forms.Label();
            this.txtTotalSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldoTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelBotones = new System.Windows.Forms.Panel();
            this.cmdImprimir = new System.Windows.Forms.Button();
            this.cmdReporte = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.ImpVentana = new System.Windows.Forms.PrintDialog();
            this.ImpDocumento = new System.Drawing.Printing.PrintDocument();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.PanelBotones.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividad.Location = new System.Drawing.Point(3, 163);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(72, 16);
            this.lblActividad.TabIndex = 24;
            this.lblActividad.Text = "Actividad";
            // 
            // SsPorActividad
            // 
            this.SsPorActividad.Location = new System.Drawing.Point(0, 397);
            this.SsPorActividad.Name = "SsPorActividad";
            this.SsPorActividad.Size = new System.Drawing.Size(768, 22);
            this.SsPorActividad.TabIndex = 23;
            this.SsPorActividad.Text = "statusStrip1";
            // 
            // cmdListar
            // 
            this.cmdListar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdListar.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdListar.FlatAppearance.BorderSize = 0;
            this.cmdListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.Location = new System.Drawing.Point(0, 0);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Padding = new System.Windows.Forms.Padding(10, 10, 80, 10);
            this.cmdListar.Size = new System.Drawing.Size(211, 45);
            this.cmdListar.TabIndex = 22;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // lstActividad
            // 
            this.lstActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstActividad.FormattingEnabled = true;
            this.lstActividad.Items.AddRange(new object[] {
            "Nueva Cordoba",
            "Alta Cordoba",
            "Barrio Parque",
            "San Fernando",
            "Nueva Italia ",
            "General Paz "});
            this.lstActividad.Location = new System.Drawing.Point(11, 186);
            this.lstActividad.Name = "lstActividad";
            this.lstActividad.Size = new System.Drawing.Size(198, 21);
            this.lstActividad.TabIndex = 21;
            this.lstActividad.SelectedIndexChanged += new System.EventHandler(this.lstActividad_SelectedIndexChanged);
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.AllowUserToAddRows = false;
            this.dgvMostrar.AllowUserToDeleteRows = false;
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.Nombre_Apellido,
            this.Direccion,
            this.Saldo});
            this.dgvMostrar.Location = new System.Drawing.Point(220, 31);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.ReadOnly = true;
            this.dgvMostrar.Size = new System.Drawing.Size(543, 266);
            this.dgvMostrar.TabIndex = 20;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(232, 8);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(127, 20);
            this.lblDatos.TabIndex = 19;
            this.lblDatos.Text = "Datos Clientes";
            // 
            // lblMayorPromedio
            // 
            this.lblMayorPromedio.AutoSize = true;
            this.lblMayorPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMayorPromedio.Location = new System.Drawing.Point(556, 303);
            this.lblMayorPromedio.Name = "lblMayorPromedio";
            this.lblMayorPromedio.Size = new System.Drawing.Size(54, 16);
            this.lblMayorPromedio.TabIndex = 25;
            this.lblMayorPromedio.Text = "Mayor ";
            // 
            // txtMayorPromedio
            // 
            this.txtMayorPromedio.Enabled = false;
            this.txtMayorPromedio.Location = new System.Drawing.Point(687, 303);
            this.txtMayorPromedio.Name = "txtMayorPromedio";
            this.txtMayorPromedio.Size = new System.Drawing.Size(69, 20);
            this.txtMayorPromedio.TabIndex = 26;
            // 
            // txtMenorPromedio
            // 
            this.txtMenorPromedio.Enabled = false;
            this.txtMenorPromedio.Location = new System.Drawing.Point(687, 336);
            this.txtMenorPromedio.Name = "txtMenorPromedio";
            this.txtMenorPromedio.Size = new System.Drawing.Size(69, 20);
            this.txtMenorPromedio.TabIndex = 28;
            // 
            // lblMenorPromedio
            // 
            this.lblMenorPromedio.AutoSize = true;
            this.lblMenorPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenorPromedio.Location = new System.Drawing.Point(555, 336);
            this.lblMenorPromedio.Name = "lblMenorPromedio";
            this.lblMenorPromedio.Size = new System.Drawing.Size(54, 16);
            this.lblMenorPromedio.TabIndex = 27;
            this.lblMenorPromedio.Text = "Menor ";
            // 
            // txtTotalSaldo
            // 
            this.txtTotalSaldo.Enabled = false;
            this.txtTotalSaldo.Location = new System.Drawing.Point(687, 369);
            this.txtTotalSaldo.Name = "txtTotalSaldo";
            this.txtTotalSaldo.Size = new System.Drawing.Size(69, 20);
            this.txtTotalSaldo.TabIndex = 30;
            // 
            // lblSaldoTotal
            // 
            this.lblSaldoTotal.AutoSize = true;
            this.lblSaldoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoTotal.Location = new System.Drawing.Point(556, 369);
            this.lblSaldoTotal.Name = "lblSaldoTotal";
            this.lblSaldoTotal.Size = new System.Drawing.Size(88, 16);
            this.lblSaldoTotal.TabIndex = 29;
            this.lblSaldoTotal.Text = "Saldo Total";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.PanelBotones);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblActividad);
            this.panel1.Controls.Add(this.lblMensaje);
            this.panel1.Controls.Add(this.lstActividad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 397);
            this.panel1.TabIndex = 31;
            // 
            // PanelBotones
            // 
            this.PanelBotones.Controls.Add(this.cmdImprimir);
            this.PanelBotones.Controls.Add(this.cmdListar);
            this.PanelBotones.Controls.Add(this.cmdReporte);
            this.PanelBotones.Location = new System.Drawing.Point(3, 227);
            this.PanelBotones.Name = "PanelBotones";
            this.PanelBotones.Size = new System.Drawing.Size(211, 220);
            this.PanelBotones.TabIndex = 34;
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.Enabled = false;
            this.cmdImprimir.FlatAppearance.BorderSize = 0;
            this.cmdImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImprimir.Location = new System.Drawing.Point(0, 102);
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.Padding = new System.Windows.Forms.Padding(10, 10, 65, 10);
            this.cmdImprimir.Size = new System.Drawing.Size(211, 50);
            this.cmdImprimir.TabIndex = 33;
            this.cmdImprimir.Text = "Imprimir";
            this.cmdImprimir.UseVisualStyleBackColor = true;
            this.cmdImprimir.Click += new System.EventHandler(this.cmdImprimir_Click);
            // 
            // cmdReporte
            // 
            this.cmdReporte.Enabled = false;
            this.cmdReporte.FlatAppearance.BorderSize = 0;
            this.cmdReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReporte.Location = new System.Drawing.Point(0, 51);
            this.cmdReporte.Name = "cmdReporte";
            this.cmdReporte.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.cmdReporte.Size = new System.Drawing.Size(211, 45);
            this.cmdReporte.TabIndex = 32;
            this.cmdReporte.Text = "Generar Reporte";
            this.cmdReporte.UseVisualStyleBackColor = true;
            this.cmdReporte.Click += new System.EventHandler(this.cmdReporte_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 96);
            this.panel2.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(3, 99);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(206, 40);
            this.lblMensaje.TabIndex = 15;
            this.lblMensaje.Text = "Porfavor seleccione una \r\nActivadad.\r\n";
            // 
            // ImpVentana
            // 
            this.ImpVentana.UseEXDialog = true;
            // 
            // ImpDocumento
            // 
            this.ImpDocumento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ImpDocumento_PrintPage);
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // Nombre_Apellido
            // 
            this.Nombre_Apellido.HeaderText = "Nombre y Apellido";
            this.Nombre_Apellido.Name = "Nombre_Apellido";
            this.Nombre_Apellido.ReadOnly = true;
            this.Nombre_Apellido.Width = 200;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Mensualidad";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            // 
            // FrmBusquedaPorActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 419);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SsPorActividad);
            this.Controls.Add(this.lblMayorPromedio);
            this.Controls.Add(this.txtTotalSaldo);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.txtMayorPromedio);
            this.Controls.Add(this.lblSaldoTotal);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.lblMenorPromedio);
            this.Controls.Add(this.txtMenorPromedio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBusquedaPorActividad";
            this.Text = "Consultar Por Actividad";
            this.Load += new System.EventHandler(this.FrmConcultaPorActividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelBotones.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.StatusStrip SsPorActividad;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.ComboBox lstActividad;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label lblMayorPromedio;
        private System.Windows.Forms.TextBox txtMayorPromedio;
        private System.Windows.Forms.TextBox txtMenorPromedio;
        private System.Windows.Forms.Label lblMenorPromedio;
        private System.Windows.Forms.TextBox txtTotalSaldo;
        private System.Windows.Forms.Label lblSaldoTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button cmdReporte;
        private System.Windows.Forms.Button cmdImprimir;
        private System.Windows.Forms.PrintDialog ImpVentana;
        private System.Drawing.Printing.PrintDocument ImpDocumento;
        private System.Windows.Forms.Panel PanelBotones;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
    }
}