namespace PryAriettiIEFI
{
    partial class FrmBusquedaPorBarrio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBusquedaPorBarrio));
            this.SsMismoBarrio = new System.Windows.Forms.StatusStrip();
            this.cmdListar = new System.Windows.Forms.Button();
            this.lstBarrio = new System.Windows.Forms.ComboBox();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBoton = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBarrioo = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelBoton.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SsMismoBarrio
            // 
            this.SsMismoBarrio.Location = new System.Drawing.Point(0, 315);
            this.SsMismoBarrio.Name = "SsMismoBarrio";
            this.SsMismoBarrio.Size = new System.Drawing.Size(696, 22);
            this.SsMismoBarrio.TabIndex = 17;
            this.SsMismoBarrio.Text = "statusStrip1";
            // 
            // cmdListar
            // 
            this.cmdListar.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdListar.Enabled = false;
            this.cmdListar.FlatAppearance.BorderSize = 0;
            this.cmdListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.Location = new System.Drawing.Point(0, 0);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(211, 45);
            this.cmdListar.TabIndex = 16;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // lstBarrio
            // 
            this.lstBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstBarrio.FormattingEnabled = true;
            this.lstBarrio.Items.AddRange(new object[] {
            "Nueva Cordoba",
            "Alta Cordoba",
            "Barrio Parque",
            "San Fernando",
            "Nueva Italia ",
            "General Paz "});
            this.lstBarrio.Location = new System.Drawing.Point(9, 210);
            this.lstBarrio.Name = "lstBarrio";
            this.lstBarrio.Size = new System.Drawing.Size(194, 21);
            this.lstBarrio.TabIndex = 15;
            this.lstBarrio.SelectedIndexChanged += new System.EventHandler(this.lstBarrio_SelectedIndexChanged);
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
            this.ColumnDeuda});
            this.dgvMostrar.Location = new System.Drawing.Point(222, 32);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.ReadOnly = true;
            this.dgvMostrar.Size = new System.Drawing.Size(445, 263);
            this.dgvMostrar.TabIndex = 14;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(220, 9);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(127, 20);
            this.lblDatos.TabIndex = 13;
            this.lblDatos.Text = "Datos Clientes";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(184, 44);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(34, 13);
            this.lblBarrio.TabIndex = 18;
            this.lblBarrio.Text = "Barrio";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.panelBoton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblBarrioo);
            this.panel1.Controls.Add(this.lblMensaje);
            this.panel1.Controls.Add(this.lstBarrio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 315);
            this.panel1.TabIndex = 32;
            // 
            // panelBoton
            // 
            this.panelBoton.Controls.Add(this.cmdListar);
            this.panelBoton.Location = new System.Drawing.Point(3, 256);
            this.panelBoton.Name = "panelBoton";
            this.panelBoton.Size = new System.Drawing.Size(211, 75);
            this.panelBoton.TabIndex = 33;
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
            // lblBarrioo
            // 
            this.lblBarrioo.AutoSize = true;
            this.lblBarrioo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrioo.Location = new System.Drawing.Point(6, 191);
            this.lblBarrioo.Name = "lblBarrioo";
            this.lblBarrioo.Size = new System.Drawing.Size(49, 16);
            this.lblBarrioo.TabIndex = 24;
            this.lblBarrioo.Text = "Barrio";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(12, 111);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(191, 80);
            this.lblMensaje.TabIndex = 15;
            this.lblMensaje.Text = "Porfavor seleccione un\r\nBarrio.\r\n\r\n\r\n";
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
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // ColumnDeuda
            // 
            this.ColumnDeuda.HeaderText = "Mensualidad";
            this.ColumnDeuda.Name = "ColumnDeuda";
            this.ColumnDeuda.ReadOnly = true;
            // 
            // FrmBusquedaPorBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 337);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBarrio);
            this.Controls.Add(this.SsMismoBarrio);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.lblDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBusquedaPorBarrio";
            this.Text = "Buscar Barrio";
            this.Load += new System.EventHandler(this.FrmBusquedaPorBarrio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBoton.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip SsMismoBarrio;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.ComboBox lstBarrio;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBarrioo;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Panel panelBoton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDeuda;
    }
}