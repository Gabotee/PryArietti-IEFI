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
    public partial class FrmListarClientes : Form
    {
        //Se crea la conexion de la base de datos
        public OleDbConnection ConexionBD;

        // q quiero traer desde la base de datos
        public OleDbCommand QueQuieroTraerDeLaBD;

        // lector de la base de datos
        public OleDbDataReader LectorBD;

        //variable de la ruta de la base de datos
        public string RutaBaseDeDatos = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "BD_Clientes.accdb";
        public FrmListarClientes()
        {
            InitializeComponent();
        }

        private void FrmListarClientes_Load(object sender, EventArgs e)
        {
            try
            {
                //Color Verde = Base de datos Conectada
                SsListarClientes.BackColor = Color.Green;
            }
            catch (Exception)
            {
                //Color Rojo = No se conecto a la base de datos
                SsListarClientes.BackColor = Color.Red;
            }
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            ClaseCliente Clientes = new ClaseCliente();
            Clientes.ListarClientes(dgvMostrar);

            txtTotalClientes.Text = Clientes.Cliente.ToString();
            txtTotalSaldos.Text = Clientes.Mensualidad.ToString();
            txtPromedioSaldos.Text = Clientes.Promedio.ToString();
        }
    }
}
