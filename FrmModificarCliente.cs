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
    public partial class FrmModificarCliente : Form
    {
        //Se crea la conexion de la base de datos
        public OleDbConnection ConexionBD;

        // q quiero traer desde la base de datos
        public OleDbCommand QueQuieroTraerDeLaBD;

        // lector de la base de datos
        public OleDbDataReader LectorBD;

        //variable de la ruta de la base de datos
        public string RutaBaseDeDatos = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "BD_Clientes.accdb";


        public FrmModificarCliente()
        {
            InitializeComponent();
        }

        private void FrmConsultarCliente_Load(object sender, EventArgs e)
        {
            try
            {
                //Color Verde = Base de datos Conectada
                SsBuscar.BackColor = Color.Green;
            }
            catch (Exception)
            {
                //Color Rojo = No se conecto a la base de datos
                SsBuscar.BackColor = Color.Red;
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            string DNI = txtDniCliente.Text;

            if (txtNombre.Text == "" | txtDireccion.Text == "" | lstBarrio.Text == "" | lstActividad.Text == "" | txtSaldo.Text == "")
            {
                ClaseCliente cliente = new ClaseCliente();

                cliente.NombreCliente = txtNombre.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Barrio = Convert.ToInt32(lstBarrio.SelectedValue);
                cliente.Actividad = Convert.ToInt32(lstActividad.SelectedValue);
                cliente.Saldo = Convert.ToInt32(txtSaldo.Text);

                cliente.ModificarCliente(DNI);

                MessageBox.Show("Datos Modificados");

                Limpiar();
            }
            else
            {
                MessageBox.Show("Asegurese de que todos los campos contengan Datos");
            }


        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtDniCliente.Text = "";
            txtDireccion.Text = "";
            lstBarrio.SelectedIndex = -1;
            lstActividad.SelectedIndex = -1;
            txtSaldo.Text = "";
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                string DNI = txtDniCliente.Text;

                if (DNI == "")
                {
                    MessageBox.Show("Porfavor Ingrese un DNI");
                }
                else
                {
                    ClaseCliente Cliente = new ClaseCliente();

                    Cliente.Buscar(DNI);

                    if (Cliente.DNI != DNI)
                    {
                        MessageBox.Show("Cliente No encontrado");
                    }
                    else
                    {
                        txtNombre.Text = Cliente.NombreCliente;
                        txtDireccion.Text = Cliente.Direccion;

                        ClaseBarrio Barrio = new ClaseBarrio();
                        lstBarrio.Text = Barrio.Buscar(Cliente.Barrio);

                        ClaseActividad Actividad = new ClaseActividad();
                        lstActividad.Text = Actividad.Buscar(Cliente.Actividad);

                        txtSaldo.Text = Convert.ToString(Cliente.Saldo);
                    }
                }
               
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show(Mensaje.Message);
                //throw;
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            string DNI = txtDniCliente.Text;
            //Creo objeto de la clase cliente 
            ClaseCliente Cliente = new ClaseCliente();
            // Le paso el DNI como parametro 
            Cliente.EliminarCliente(DNI);
            MessageBox.Show("Cliente Eliminado Correctamente");
            Limpiar();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtDireccion.Enabled = true;
            lstBarrio.Enabled = true;
            lstActividad.Enabled = true;
            txtSaldo.Enabled = true;

            txtNombre.Focus();
        }

        private void txtDniCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseValidacion Validar = new ClaseValidacion();
            Validar.SoloNumeros(e);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseValidacion Validar = new ClaseValidacion();
            Validar.SoloLetras(e);
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseValidacion Validar = new ClaseValidacion();
            Validar.SoloLetras(e);
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseValidacion Validar = new ClaseValidacion();
            Validar.SoloNumeros(e);
        }
    }
}
