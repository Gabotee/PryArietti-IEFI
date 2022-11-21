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
    public partial class FrmBusquedaPorBarrio : Form
    {
        //Se crea la conexion de la base de datos
        public OleDbConnection ConexionBD;

        // q quiero traer desde la base de datos
        public OleDbCommand QueQuieroTraerDeLaBD;

        // lector de la base de datos
        public OleDbDataReader LectorBD;

        //variable de la ruta de la base de datos
        public string RutaBaseDeDatos = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "BD_Clientes.accdb";

        public FrmBusquedaPorBarrio()
        {
            InitializeComponent();
        }

        private void FrmBusquedaPorBarrio_Load(object sender, EventArgs e)
        {
            try
            {
                //Color Verde = Base de datos Conectada
                SsMismoBarrio.BackColor = Color.Green;
            }
            catch (Exception)
            {
                //Color Rojo = No se conecto a la base de datos
                SsMismoBarrio.BackColor = Color.Red;
            }

            // Crea Objeto de la clase Barrio para poder pasarle los datos a los Combo Box

            ClaseBarrio Barrio = new ClaseBarrio();
            Barrio.ListarBarrios(lstBarrio);

            lstBarrio.SelectedIndex = -1;
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            Int32 CodigoBarrio = Convert.ToInt32(lstBarrio.SelectedValue);
            ClaseCliente Listar = new ClaseCliente();
            Listar.ListarClienteBarrio(dgvMostrar,CodigoBarrio);
        }

        private void lstBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBarrio.SelectedIndex == -1)
            {
                cmdListar.Enabled = false;
            }
            else
            {
                cmdListar.Enabled = true;
            }
        }
    }
}
