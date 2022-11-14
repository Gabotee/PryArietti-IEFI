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
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblMayorPromedio = new System.Windows.Forms.Label();
            this.txtMayorPromedio = new System.Windows.Forms.TextBox();
            this.txtMenorPromedio = new System.Windows.Forms.TextBox();
            this.lblMenorPromedio = new System.Windows.Forms.Label();
            this.txtTotalSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldoTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.SsPorActividad.Location = new System.Drawing.Point(0, 336);
            this.SsPorActividad.Name = "SsPorActividad";
            this.SsPorActividad.Size = new System.Drawing.Size(773, 22);
            this.SsPorActividad.TabIndex = 23;
            this.SsPorActividad.Text = "statusStrip1";
            // 
            // cmdListar
            // 
            this.cmdListar.Location = new System.Drawing.Point(668, 303);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(95, 27);
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
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.AllowUserToAddRows = false;
            this.dgvMostrar.AllowUserToDeleteRows = false;
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnNombre_Apellido,
            this.Direccion,
            this.Column1});
            this.dgvMostrar.Location = new System.Drawing.Point(220, 31);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.ReadOnly = true;
            this.dgvMostrar.Size = new System.Drawing.Size(543, 266);
            this.dgvMostrar.TabIndex = 20;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "DNI";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            // 
            // ColumnNombre_Apellido
            // 
            this.ColumnNombre_Apellido.HeaderText = "Nombre y Apellido";
            this.ColumnNombre_Apellido.Name = "ColumnNombre_Apellido";
            this.ColumnNombre_Apellido.ReadOnly = true;
            this.ColumnNombre_Apellido.Width = 200;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Saldo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            this.lblMayorPromedio.Location = new System.Drawing.Point(9, 225);
            this.lblMayorPromedio.Name = "lblMayorPromedio";
            this.lblMayorPromedio.Size = new System.Drawing.Size(125, 16);
            this.lblMayorPromedio.TabIndex = 25;
            this.lblMayorPromedio.Text = "Mayor Promedio ";
            // 
            // txtMayorPromedio
            // 
            this.txtMayorPromedio.Enabled = false;
            this.txtMayorPromedio.Location = new System.Drawing.Point(140, 225);
            this.txtMayorPromedio.Name = "txtMayorPromedio";
            this.txtMayorPromedio.Size = new System.Drawing.Size(69, 20);
            this.txtMayorPromedio.TabIndex = 26;
            // 
            // txtMenorPromedio
            // 
            this.txtMenorPromedio.Enabled = false;
            this.txtMenorPromedio.Location = new System.Drawing.Point(140, 258);
            this.txtMenorPromedio.Name = "txtMenorPromedio";
            this.txtMenorPromedio.Size = new System.Drawing.Size(69, 20);
            this.txtMenorPromedio.TabIndex = 28;
            // 
            // lblMenorPromedio
            // 
            this.lblMenorPromedio.AutoSize = true;
            this.lblMenorPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenorPromedio.Location = new System.Drawing.Point(8, 258);
            this.lblMenorPromedio.Name = "lblMenorPromedio";
            this.lblMenorPromedio.Size = new System.Drawing.Size(121, 16);
            this.lblMenorPromedio.TabIndex = 27;
            this.lblMenorPromedio.Text = "Menor Promedio";
            // 
            // txtTotalSaldo
            // 
            this.txtTotalSaldo.Enabled = false;
            this.txtTotalSaldo.Location = new System.Drawing.Point(140, 291);
            this.txtTotalSaldo.Name = "txtTotalSaldo";
            this.txtTotalSaldo.Size = new System.Drawing.Size(69, 20);
            this.txtTotalSaldo.TabIndex = 30;
            // 
            // lblSaldoTotal
            // 
            this.lblSaldoTotal.AutoSize = true;
            this.lblSaldoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoTotal.Location = new System.Drawing.Point(9, 291);
            this.lblSaldoTotal.Name = "lblSaldoTotal";
            this.lblSaldoTotal.Size = new System.Drawing.Size(88, 16);
            this.lblSaldoTotal.TabIndex = 29;
            this.lblSaldoTotal.Text = "Saldo Total";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblActividad);
            this.panel1.Controls.Add(this.lblMensaje);
            this.panel1.Controls.Add(this.lstActividad);
            this.panel1.Controls.Add(this.lblMayorPromedio);
            this.panel1.Controls.Add(this.txtTotalSaldo);
            this.panel1.Controls.Add(this.txtMayorPromedio);
            this.panel1.Controls.Add(this.lblSaldoTotal);
            this.panel1.Controls.Add(this.lblMenorPromedio);
            this.panel1.Controls.Add(this.txtMenorPromedio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 336);
            this.panel1.TabIndex = 31;
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
            // FrmBusquedaPorActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 358);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SsPorActividad);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.lblDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBusquedaPorActividad";
            this.Text = "Consultar Por Actividad";
            this.Load += new System.EventHandler(this.FrmConcultaPorActividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}