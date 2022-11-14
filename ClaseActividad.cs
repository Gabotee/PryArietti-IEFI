using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PryAriettiIEFI
{
    internal class ClaseActividad
    {
        //Se crea la conexion de la base de datos
        public OleDbConnection ConexionBD;

        // q quiero traer desde la base de datos
        public OleDbCommand QueQuieroTraerDeLaBD;

        // lector de la base de datos
        public OleDbDataReader LectorBD;

        public OleDbDataAdapter Adaptador;

        //variable de la ruta de la base de datos
        public string RutaBaseDeDatos = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "BD_Clientes.accdb";

        string TablaActividad = "ACTIVIDAD";


        // Lo uso para llenar los combo box 
        public void ListarActividad(ComboBox combo)
        {
            try
            {
                //Creo Conexion a la Base de datos 
                ConexionBD = new OleDbConnection();

                ConexionBD.ConnectionString = RutaBaseDeDatos;
                ConexionBD.Open();

                // Creo la variable que me va a permitir Buscar lo que quiero
                QueQuieroTraerDeLaBD = new OleDbCommand();

                // Le paso la conexion 
                QueQuieroTraerDeLaBD.Connection = ConexionBD;
                // Le indico que voy a trabajar con tabla 
                QueQuieroTraerDeLaBD.CommandType = System.Data.CommandType.TableDirect;
                // Le paso la tabla con la que voy a trabajar 
                QueQuieroTraerDeLaBD.CommandText = TablaActividad;
                // Creo un adaptador y le paso la tabla 
                Adaptador = new OleDbDataAdapter(QueQuieroTraerDeLaBD);
                DataSet DS = new DataSet();
                // Le paso las filas de la base de datos de la tabla actividad 
                Adaptador.Fill(DS, TablaActividad);
                //
                combo.DataSource = DS.Tables[TablaActividad];
                // Le paso el nombre de las actividades 
                combo.DisplayMember = "Nombre Actividad";
                // Le paso el Codigo De las actividades 
                combo.ValueMember = "Cod Actividad";

                ConexionBD.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                //throw;
            }
        }

        // Funcion de Busqueda.. Secuencial 
        // Retortna el nombre Segun el codigo de Actividad

        public string Buscar(Int32 CodActividad)
        {
            try
            {
                ConexionBD = new OleDbConnection();
                ConexionBD.ConnectionString = RutaBaseDeDatos;
                ConexionBD.Open();

                QueQuieroTraerDeLaBD = new OleDbCommand();
                QueQuieroTraerDeLaBD.Connection = ConexionBD;
                QueQuieroTraerDeLaBD.CommandType = System.Data.CommandType.TableDirect;
                QueQuieroTraerDeLaBD.CommandText = TablaActividad;
                OleDbDataReader Leer = QueQuieroTraerDeLaBD.ExecuteReader();
                string NombreActividad = "";

                if (Leer.HasRows)
                {
                    while (Leer.Read())
                    {
                        if (Leer.GetInt32(0) == CodActividad)
                        {
                            NombreActividad = Leer.GetString(1);
                        }
                    }
                }

                ConexionBD.Close();

                return NombreActividad;
            }
            catch (Exception e)
            {

                return e.ToString();
            }
        }






    }
}
