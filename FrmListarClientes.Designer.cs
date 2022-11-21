namespace PryAriettiIEFI
{
    partial class FrmListarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListarClientes));
            this.SsListarClientes = new System.Windows.Forms.StatusStrip();
            this.cmdListar = new System.Windows.Forms.Button();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblTotalClientes = new System.Windows.Forms.Label();
            this.txtTotalClientes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalSaldos = new System.Windows.Forms.TextBox();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.txtPromedioSaldos = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SsListarClientes
            // 
            this.SsListarClientes.Location = new System.Drawing.Point(0, 261);
            this.SsListarClientes.Name = "SsListarClientes";
            this.SsListarClientes.Size = new System.Drawing.Size(893, 22);
            this.SsListarClientes.TabIndex = 21;
            this.SsListarClientes.Text = "statusStrip1";
            // 
            // cmdListar
            // 
            this.cmdListar.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdListar.FlatAppearance.BorderSize = 0;
            this.cmdListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.Location = new System.Drawing.Point(0, 0);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(214, 41);
            this.cmdListar.TabIndex = 20;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.AllowUserToAddRows = false;
            this.dgvMostrar.AllowUserToDeleteRows = false;
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnNombre_Apellido,
            this.Column1,
            this.Column2,
            this.Column3,
            this.ColumnDeuda});
            this.dgvMostrar.Location = new System.Drawing.Point(220, 37);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.ReadOnly = true;
            this.dgvMostrar.Size = new System.Drawing.Size(644, 217);
            this.dgvMostrar.TabIndex = 19;
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
            // Column1
            // 
            this.Column1.HeaderText = "Direccion";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Barrio";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Actividad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // ColumnDeuda
            // 
            this.ColumnDeuda.HeaderText = "Saldo";
            this.ColumnDeuda.Name = "ColumnDeuda";
            this.ColumnDeuda.ReadOnly = true;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(220, 7);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(127, 20);
            this.lblDatos.TabIndex = 18;
            this.lblDatos.Text = "Datos Clientes";
            // 
            // lblTotalClientes
            // 
            this.lblTotalClientes.AutoSize = true;
            this.lblTotalClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalClientes.Location = new System.Drawing.Point(9, 126);
            this.lblTotalClientes.Name = "lblTotalClientes";
            this.lblTotalClientes.Size = new System.Drawing.Size(103, 16);
            this.lblTotalClientes.TabIndex = 29;
            this.lblTotalClientes.Text = "Total Clientes";
            // 
            // txtTotalClientes
            // 
            this.txtTotalClientes.Enabled = false;
            this.txtTotalClientes.Location = new System.Drawing.Point(142, 123);
            this.txtTotalClientes.Name = "txtTotalClientes";
            this.txtTotalClientes.Size = new System.Drawing.Size(69, 20);
            this.txtTotalClientes.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Total Saldos";
            // 
            // txtTotalSaldos
            // 
            this.txtTotalSaldos.Enabled = false;
            this.txtTotalSaldos.Location = new System.Drawing.Point(142, 149);
            this.txtTotalSaldos.Name = "txtTotalSaldos";
            this.txtTotalSaldos.Size = new System.Drawing.Size(69, 20);
            this.txtTotalSaldos.TabIndex = 32;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(9, 177);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(127, 16);
            this.lblPromedio.TabIndex = 33;
            this.lblPromedio.Text = "Promedio Saldos";
            // 
            // txtPromedioSaldos
            // 
            this.txtPromedioSaldos.Enabled = false;
            this.txtPromedioSaldos.Location = new System.Drawing.Point(142, 175);
            this.txtPromedioSaldos.Name = "txtPromedioSaldos";
            this.txtPromedioSaldos.Size = new System.Drawing.Size(69, 20);
            this.txtPromedioSaldos.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblPromedio);
            this.panel1.Controls.Add(this.txtTotalClientes);
            this.panel1.Controls.Add(this.txtPromedioSaldos);
            this.panel1.Controls.Add(this.lblTotalClientes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTotalSaldos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 261);
            this.panel1.TabIndex = 35;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.cmdListar);
            this.panel3.Location = new System.Drawing.Point(0, 213);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 41);
            this.panel3.TabIndex = 36;
            // 
            // FrmListarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 283);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SsListarClientes);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.lblDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListarClientes";
            this.Text = "Listar Clientes ";
            this.Load += new System.EventHandler(this.FrmListarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip SsListarClientes;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label lblTotalClientes;
        private System.Windows.Forms.TextBox txtTotalClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalSaldos;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.TextBox txtPromedioSaldos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDeuda;
        private System.Windows.Forms.Panel panel3;
    }
}