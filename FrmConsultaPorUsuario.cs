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
    public partial class FrmConsultaPorUsuario : Form
    {
        //Se crea la conexion de la base de datos
        public OleDbConnection ConexionBD;

        // q quiero traer desde la base de datos
        public OleDbCommand QueQuieroTraerDeLaBD;

        // lector de la base de datos
        public OleDbDataReader LectorBD;

        //variable de la ruta de la base de datos
        public string RutaBaseDeDatos = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "BD_Clientes.accdb";
        public FrmConsultaPorUsuario()
        {
            InitializeComponent();
        }

        private void FrmConsultaPorUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                //Color Verde = Base de datos Conectada
                SsConsultaUsuario.BackColor = Color.Green;
            }
            catch (Exception)
            {
                //Color Rojo = No se conecto a la base de datos
                SsConsultaUsuario.BackColor = Color.Red;
            }
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string Nombre = txtNombreCliente.Text;

                if (Nombre == "")
                {
                    MessageBox.Show("El Campo Nombre Debe tener Datos");
                }
                else
                {
                    ClaseCliente Cliente = new ClaseCliente();

                    Cliente.BuscarPorNombre(Nombre);

                    if (Cliente.NombreCliente != Nombre)
                    {
                        MessageBox.Show("Cliente No encontrado");
                    }
                    else
                    {
                        txtDNI.Text = Cliente.DNI;

                        txtDireccion.Text = Cliente.Direccion;

                        ClaseBarrio Barrio = new ClaseBarrio();
                        lstBarrio.Text = Barrio.Buscar(Cliente.Barrio);

                        ClaseActividad Actividad = new ClaseActividad();
                        lstActividad.Text = Actividad.Buscar(Cliente.Actividad);

                        txtSaldo.Text = Convert.ToString(Cliente.Mensualidad);
                    }
                }

            }
            catch (Exception Mensaje)
            {
                MessageBox.Show(Mensaje.Message);
                //throw;
            }
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtNombreCliente.Text = "";
            txtDNI.Text = "";
            txtDireccion.Text = "";
            lstBarrio.SelectedIndex = -1;
            lstActividad.SelectedIndex = -1;
            txtSaldo.Text = "";
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseValidacion Validar = new ClaseValidacion();
            Validar.SoloLetras(e);
        }
    }
}
