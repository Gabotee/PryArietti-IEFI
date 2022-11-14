using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryAriettiIEFI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            Diseño();
        }

        private void Diseño()
        {
            PanelSubMenu.Visible = false;
        }

        private void OcultarSubMenu()
        {
            //Si el panel esta visible lo ocultamos
            if (PanelSubMenu.Visible == true)
            {
                PanelSubMenu.Visible = false;
            }
        }
        private void MostrarSubMenu(Panel SubMenu)
        {

            if (PanelSubMenu.Visible == false)
            {
                //si el panel esta cerrado, lo abre 
                OcultarSubMenu();
                PanelSubMenu.Visible = true;
            }
            else
            {
                //si el panel esta abierto lo esconde
                PanelSubMenu.Visible = false;
            }

        }

        private void cmdClientes_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelSubMenu);
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            FrmRegistrarCliente VentanaRegistrar = new FrmRegistrarCliente();
            VentanaRegistrar.ShowDialog();
            OcultarSubMenu();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            FrmModificarCliente VentanaConsultar = new FrmModificarCliente();
            VentanaConsultar.ShowDialog();
            OcultarSubMenu();
        }

        private void cmdBuscarPorBarrio_Click(object sender, EventArgs e)
        {
            FrmBusquedaPorBarrio VentanaBarrio = new FrmBusquedaPorBarrio();
            VentanaBarrio.ShowDialog();
            OcultarSubMenu();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                //Color Verde = Base de datos Conectada
                SsPrincipal.BackColor = Color.Green;
            }
            catch (Exception)
            {
                //Color Rojo = No se conecto a la base de datos
                SsPrincipal.BackColor = Color.Red;
            }
        }

        private void cmdConsultaPorActividad_Click(object sender, EventArgs e)
        {
            FrmBusquedaPorActividad VentanaConsultaActividad = new FrmBusquedaPorActividad();
            VentanaConsultaActividad.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            FrmListarClientes VentanaListar = new FrmListarClientes();
            VentanaListar.ShowDialog();

        }

        private void cmdConsultaPorCliente_Click(object sender, EventArgs e)
        {
            FrmConsultaPorUsuario VentanaUsuario = new FrmConsultaPorUsuario();
            VentanaUsuario.ShowDialog();

        }
    }
}
