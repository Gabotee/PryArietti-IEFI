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
    internal class ClaseBarrio
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

        string TablaBarrio = "BARRIO";


        // Lo uso para llenar los combo box 
        public void ListarBarrios(ComboBox Combo)
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
                QueQuieroTraerDeLaBD.CommandText = TablaBarrio;
                // Creo un adaptador y le paso la tabla 
                Adaptador = new OleDbDataAdapter(QueQuieroTraerDeLaBD);
                //
                DataSet DS = new DataSet();
                // Le paso las filas de la base de datos de la tabla Barrio
                Adaptador.Fill(DS, TablaBarrio);
                Combo.DataSource = DS.Tables[TablaBarrio];
                // Le paso el nombre de los Barrios
                Combo.DisplayMember = "Nombre Barrio";
                // Le paso el codigo de los barrios 
                Combo.ValueMember = "Cod Barrio";
                ConexionBD.Close();


            }
            catch (Exception)
            {

                //throw;
            }
        }


        // Funcion de Busqueda.. Secuencial 
        // Retorna el Nombre Segun el codigo de Barrio
        public string Buscar(Int32 CodBarrio)
        {
            try
            {
                ConexionBD = new OleDbConnection();
                ConexionBD.ConnectionString = RutaBaseDeDatos;
                ConexionBD.Open();

                QueQuieroTraerDeLaBD = new OleDbCommand();
                QueQuieroTraerDeLaBD.Connection = ConexionBD;
                QueQuieroTraerDeLaBD.CommandType = System.Data.CommandType.TableDirect;
                QueQuieroTraerDeLaBD.CommandText = TablaBarrio;
                OleDbDataReader Leer = QueQuieroTraerDeLaBD.ExecuteReader();
                string NombreBarrio = "";

                if (Leer.HasRows)
                {
                    while (Leer.Read())
                    {
                        if (Leer.GetInt32(0) == CodBarrio)
                        {
                            NombreBarrio = Leer.GetString(1);
                        }
                    }
                }

                ConexionBD.Close();

                return NombreBarrio;
            }
            catch (Exception e)
            {

                return e.ToString();
            }
        }

        

    }
}
