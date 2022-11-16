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
    public partial class FrmRegistrarCliente : Form
    {
        //Se crea la conexion de la base de datos
        public OleDbConnection ConexionBD;

        // q quiero traer desde la base de datos
        public OleDbCommand QueQuieroTraerDeLaBD;

        // lector de la base de datos
        public OleDbDataReader LectorBD;

        //variable de la ruta de la base de datos
        public string RutaBaseDeDatos = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "BD_Clientes.accdb";

        public FrmRegistrarCliente()
        {
            InitializeComponent();
        }

        private void FrmRegistrarCliente_Load(object sender, EventArgs e)
        {
            try
            {
                //Color Verde = Base de datos Conectada
                SsAgregarCliente.BackColor = Color.Green;
            }
            catch (Exception)
            {
                //Color Rojo = No se conecto a la base de datos
                SsAgregarCliente.BackColor = Color.Red;
            }

            //Crea Objeto de la clase Barrio para poder pasarle los datos a los Combo Box 
            ClaseBarrio Barrio = new ClaseBarrio();
            Barrio.ListarBarrios(lstBarrio);

            //Crea Objeto de la clase Actividad para poder pasarle los datos a los Combo Box 
            ClaseActividad Actividad = new ClaseActividad();
            Actividad.ListarActividad(lstActividad);

            // se limpian los combo box para que al cargar no aparezcan con datos 
            lstActividad.SelectedIndex = -1;
            lstBarrio.SelectedIndex = -1;
        }

        private void cmdRegistrarCliente_Click(object sender, EventArgs e)
        {
            string DNI = txtDNI.Text;

            // Crea Objeto de la clase cliente para buscar.. 
            ClaseCliente Cliente = new ClaseCliente();
            Cliente.Buscar(DNI);

            if (txtDNI.Text == "" | txtNombre.Text == "" | txtDireccion.Text == "" | lstBarrio.Text == "" | lstActividad.Text == "" | txtSaldo.Text == "")
            {
                MessageBox.Show("Porfavor Complete todos los datos");
            }
            else
            {
                // Si no lo encuentra, registra los datos 
                if (Cliente.DNI != DNI)
                {
                    // Crea Objeto de la clase cliente para Registrar 
                    ClaseCliente Registrar = new ClaseCliente();

                    Registrar.DNI = txtDNI.Text;
                    Registrar.NombreCliente = txtNombre.Text;
                    Registrar.Direccion = txtDireccion.Text;
                    Registrar.Barrio = Convert.ToInt32(lstBarrio.SelectedValue);
                    Registrar.Actividad = Convert.ToInt32(lstActividad.SelectedValue);
                    Registrar.Saldo = Convert.ToInt32(txtSaldo.Text);
                    Registrar.AgregarCliente();

                    MessageBox.Show("Cliente Registrado con exito");

                    Limpiar();
                }
                else
                {
                    // si lo encuentra, es porque ya esta registrado 
                    MessageBox.Show("El DNI ya se encuentra Registrado, intente con otro");
                }
            }
            
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtDNI.Text = "";
            txtDireccion.Text = "";
            lstBarrio.SelectedIndex = -1;
            lstActividad.SelectedIndex = -1;
            txtSaldo.Text = "";
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseValidacion Validar = new ClaseValidacion();
            Validar.SoloLetras(e);
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseValidacion Validar = new ClaseValidacion();
            Validar.SoloNumeros(e);
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
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
