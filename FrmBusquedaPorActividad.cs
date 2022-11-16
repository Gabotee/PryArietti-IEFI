using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PryAriettiIEFI
{
    public partial class FrmBusquedaPorActividad : Form
    {
        //Se crea la conexion de la base de datos
        public OleDbConnection ConexionBD;

        // q quiero traer desde la base de datos
        public OleDbCommand QueQuieroTraerDeLaBD;

        // lector de la base de datos
        public OleDbDataReader LectorBD;

        //variable de la ruta de la base de datos
        public string RutaBaseDeDatos = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "BD_Clientes.accdb";
        public FrmBusquedaPorActividad()
        {
            InitializeComponent();
        }

        private void FrmConcultaPorActividad_Load(object sender, EventArgs e)
        {
            

            try
            {
                //Color Verde = Base de datos Conectada
                SsPorActividad.BackColor = Color.Green;
            }
            catch (Exception)
            {
                //Color Rojo = No se conecto a la base de datos
                SsPorActividad.BackColor = Color.Red;
            }

            // Crea Objeto de la clase Actividad para poder pasarle los datos a los Combo Box

            ClaseActividad Actividad = new ClaseActividad();
            Actividad.ListarActividad(lstActividad);

            lstActividad.SelectedIndex = -1;

        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            
            int NumeroActividad = Convert.ToInt32(lstActividad.SelectedValue);
            ClaseCliente Listar = new ClaseCliente();

            Listar.ListarClienteActividad(dgvMostrar, NumeroActividad);

            txtTotalSaldo.Text = Listar.Saldo.ToString();
            txtMayorPromedio.Text = Listar.Mayor.ToString();
            txtMenorPromedio.Text = Listar.Menor.ToString();

            cmdReporte.Enabled = true;
            cmdImprimir.Enabled = true;


        }

        private void cmdReporte_Click(object sender, EventArgs e)
        {
            ClaseCliente Reporte = new ClaseCliente();
            Reporte.GenerarReporte(dgvMostrar);
            MessageBox.Show("Reporte Generado");
        }

        private void lstActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstActividad.SelectedIndex == -1)
            {
                cmdListar.Enabled = false;
            }
            else
            {
                cmdListar.Enabled = true;
            }
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            ImpVentana.ShowDialog();
            // Le paso La impresora que se selecciono.. 
            ImpDocumento.PrinterSettings = ImpVentana.PrinterSettings;
            // Indico que el documento se debe imprimir 
            ImpDocumento.Print();
            MessageBox.Show("Datos Impresos");
        }

        private void ImpDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            ClaseCliente Listado = new ClaseCliente();
            Listado.Imprimir(e);

        }

        
    }
}
