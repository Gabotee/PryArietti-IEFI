using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing.Printing;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Drawing;


namespace PryAriettiIEFI
{
    internal class ClaseCliente
    {
        //Se crea la conexion de la base de datos
        public OleDbConnection ConexionBD;

        // q quiero traer desde la base de datos
        public OleDbCommand QueQuieroTraerDeLaBD;

        // lector de la base de datos
        public OleDbDataReader LectorBD;

        //variable de la ruta de la base de datos
        public string RutaBaseDeDatos = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "BD_Clientes.accdb";

        string TablaGIMNASIO = "GIMNASIO";

        //Declaracion de variables q voy a usar 
        private string Nom_Apellido;
        private string DNI_Cliente;
        private string Dir;
        private int Barr;
        private int Act;
        private int Cli;
        private int Prom;
        private int May;
        private int Men;
        private int Tel;
        private string Em;
        private string FechaInsc;
        private int Mens;
        private string Sex;


        // Toma el Valor de la variable.. y la muestra. 
        public string NombreCliente
        {
            get { return Nom_Apellido; }
            set { Nom_Apellido = value; }
        }
        public string DNI
        {
            get { return DNI_Cliente; }
            set { DNI_Cliente = value; }
        }
        public string Direccion
        {
            get { return Dir; }
            set { Dir = value; }
        }
        public int Barrio
        {
            get { return Barr; }
            set { Barr = value; }
        }
        public int Actividad
        {
            get { return Act; }
            set { Act = value; }
        }
        public int Mensualidad
        {
            get { return Mens; }
            set { Mens = value; }
        }

        public int Cliente
        {
            get { return Cli; }
            set { Cli = value; }
        }
        public int Promedio
        {
            get { return Prom; }
            set { Prom = value; }
        }

        public int Mayor
        {
            get { return May; }
            set { May = value; }
        }

        public int Menor
        {
            get {return Men; }
            set { Men = value; }
        }
        public int Telefono
        {
            get { return Tel; }
            set { Tel = value; }
        }
        public string Email
        {
            get { return Em; }
            set { Em = value; }
        }
        public string FechaInscripcion
        {
            get { return FechaInsc; }
            set { FechaInsc = value; }
        }

        public string Sexo
        {
            get { return Sex; }
            set { Sex = value; }
        }
       

        public void Buscar(string DNI)
        {

            try
            {
                // Me conecto a la base 
                ConexionBD = new OleDbConnection();

                ConexionBD.ConnectionString = RutaBaseDeDatos;
                ConexionBD.Open();

                QueQuieroTraerDeLaBD = new OleDbCommand();
                // Le paso la Conexion 
                QueQuieroTraerDeLaBD.Connection = ConexionBD;
                // Le digo q voy a trabajar con La tabla 
                QueQuieroTraerDeLaBD.CommandType = System.Data.CommandType.TableDirect;
                // Le paso la tabla con la que voy a trabajar 
                QueQuieroTraerDeLaBD.CommandText = TablaGIMNASIO;
                // Creo un data reader para que me lea lo que hay dentro de la tabla 
                OleDbDataReader Leer = QueQuieroTraerDeLaBD.ExecuteReader();
                // Le digo que si hay filas para leer 
                if (Leer.HasRows)
                {
                    // Mientras haya datos para leer 
                    while (Leer.Read())
                    {
                        // Si el dato que lee es igual al dato que le pasaron 
                        if (Leer.GetString(0) == DNI)
                        {
                            // Entonces le asigno los datos que lee a las variables 
                            DNI_Cliente = Leer.GetString(0); // GetString.. Obtiene los valores de una columna 
                            Nom_Apellido = Leer.GetString(1);
                            Dir = Leer.GetString(2);
                            Barr = Leer.GetInt32(3);
                            Act = Leer.GetInt32(4);
                            Mens = Leer.GetInt32(5);
                            Tel = Leer.GetInt32(6);
                            Em = Leer.GetString(7);
                            FechaInsc = Convert.ToString(Leer.GetDateTime(8));
                            Sex = Leer.GetString(9);
                        }
                    }
                }

                ConexionBD.Close();
            }
            catch (Exception)
            {

                //throw;
            }


        }

        public void BuscarPorNombre(string Nombre)
        {

            try
            {
                // Me conecto a la base 
                ConexionBD = new OleDbConnection();

                ConexionBD.ConnectionString = RutaBaseDeDatos;
                ConexionBD.Open();

                QueQuieroTraerDeLaBD = new OleDbCommand();
                // Le paso la Conexion 
                QueQuieroTraerDeLaBD.Connection = ConexionBD;
                // Le digo q voy a trabajar con La tabla 
                QueQuieroTraerDeLaBD.CommandType = System.Data.CommandType.TableDirect;
                // Le paso la tabla con la que voy a trabajar 
                QueQuieroTraerDeLaBD.CommandText = TablaGIMNASIO;
                // Creo un data reader para que me lea lo que hay dentro de la tabla 
                OleDbDataReader Leer = QueQuieroTraerDeLaBD.ExecuteReader();
                // Le digo que si hay filas para leer 
                if (Leer.HasRows)
                {
                    // Mientras haya datos para leer 
                    while (Leer.Read())
                    {
                        // Si el dato que lee es igual al dato que le pasaron 
                        if (Leer.GetString(1) == Nombre)
                        {
                            // Entonces le asigno los datos que lee a las variables 
                            DNI_Cliente = Leer.GetString(0);
                            Nom_Apellido = Leer.GetString(1);
                            Dir = Leer.GetString(2);
                            Barr = Leer.GetInt32(3);
                            Act = Leer.GetInt32(4);
                            Mens = Leer.GetInt32(5);
                        }
                    }
                }

                ConexionBD.Close();
            }
            catch (Exception)
            {

                //throw;
            }


        }

        public void AgregarCliente()
        {
            try
            {
                //Instruccion para agregar datos a la Bade de Datos 
                String AgregarCliente = "INSERT INTO" + " GIMNASIO ([DNI SOCIO], [NOMBRE], [DIRECCION], [COD BARRIO], [ACTIVIDAD], [MENSUALIDAD], [TELEFONO], [EMAIL], [INSCRIPCION], [SEXO])" +
                        " VALUES ('" + DNI + "','" + NombreCliente + "','" + Direccion + "','" + Barrio + "','" + Actividad + "','" + Mensualidad + "','" + Telefono + "','" + Email + "','" + FechaInscripcion + "','" + Sexo + "')";

                //Conectarse a la base de datos
                ConexionBD = new OleDbConnection();

                ConexionBD.ConnectionString = RutaBaseDeDatos;
                ConexionBD.Open();

                // toma la conexion
                QueQuieroTraerDeLaBD = new OleDbCommand();

                QueQuieroTraerDeLaBD.Connection = ConexionBD;

                //Le indico q voy a trabajar con Texto 
                QueQuieroTraerDeLaBD.CommandType = System.Data.CommandType.Text;
                //Le paso la instruccion que quiero que se ejecute 
                QueQuieroTraerDeLaBD.CommandText = AgregarCliente;
                // Ejecuta la instruccion 
                QueQuieroTraerDeLaBD.ExecuteNonQuery();

                ConexionBD.Close();

            }
            catch (Exception)
            {

                //throw;
            }

        }

        public void EliminarCliente(string DNI)
        {
            try
            {
                // Instuccion para elimar los datos de un cliente 
                string EliminarCliente = "DELETE FROM GIMNASIO WHERE ('" + DNI + "'= [Dni Socio])";

                //Me conecto a la base de datos 
                ConexionBD = new OleDbConnection();
                ConexionBD.ConnectionString = RutaBaseDeDatos;
                ConexionBD.Open();

                // Le paso la conexion 
                QueQuieroTraerDeLaBD = new OleDbCommand();
                QueQuieroTraerDeLaBD.Connection = ConexionBD;
                QueQuieroTraerDeLaBD.CommandType = System.Data.CommandType.Text;
                // Le paso la instruccion  
                QueQuieroTraerDeLaBD.CommandText = EliminarCliente;
                // Ejecuta la instuccion 
                QueQuieroTraerDeLaBD.ExecuteNonQuery();


                ConexionBD.Close();



            }
            catch (Exception e)
            {
                e.ToString();
                //throw;
            }
        }

        public void ModificarCliente(string DNI)
        {
            string ModificarCliente = "UPDATE GIMNASIO SET [NOMBRE] = '" + NombreCliente + "',[DIRECCION] = '" + Direccion + "',[Cod Barrio] = '" + Barrio + "',[ACTIVIDAD] ='" + Actividad + "',[MENSUALIDAD] ='" + Mensualidad + 
                "',[TELEFONO] ='" + Telefono + "',[EMAIL] ='" + Email + "',[INSCRIPCION] ='" + FechaInscripcion + "',[SEXO] ='" + Sexo + "' WHERE [Dni Socio] = '" + DNI + "'";

            //Me conecto a la base de datos 
            ConexionBD = new OleDbConnection();
            ConexionBD.ConnectionString = RutaBaseDeDatos;
            ConexionBD.Open();

            // Le paso la conexion 
            QueQuieroTraerDeLaBD = new OleDbCommand();
            QueQuieroTraerDeLaBD.Connection = ConexionBD;
            QueQuieroTraerDeLaBD.CommandType = System.Data.CommandType.Text;
            // Le paso la instruccion 
            QueQuieroTraerDeLaBD.CommandText = ModificarCliente;
            // Ejecuta la instuccion 
            QueQuieroTraerDeLaBD.ExecuteNonQuery();


            ConexionBD.Close();
        }

        public void ListarClientes(DataGridView DgvListarClientes)
        {
            //Me conecto a la base de datos 
            ConexionBD = new OleDbConnection();
            ConexionBD.ConnectionString = RutaBaseDeDatos;
            ConexionBD.Open();

            // Le paso la conexion 
            QueQuieroTraerDeLaBD = new OleDbCommand();
            QueQuieroTraerDeLaBD.Connection = ConexionBD;
            QueQuieroTraerDeLaBD.CommandType = System.Data.CommandType.TableDirect;

            // Le paso la tabla 
            QueQuieroTraerDeLaBD.CommandText = TablaGIMNASIO;

            // Creo objeto del datareader para leer La tabla 
            OleDbDataReader Leer = QueQuieroTraerDeLaBD.ExecuteReader();

            DgvListarClientes.Rows.Clear();
            Cliente = 0;
            Mensualidad = 0;
            Promedio = 0;
            ClaseActividad Actividad = new ClaseActividad();
            ClaseBarrio Barrio = new ClaseBarrio();
            string NombreBarrio = "";
            string NombreActividad = "";

            if (Leer.HasRows)
            {
                while (Leer.Read())
                {
                    NombreBarrio = Barrio.Buscar(Leer.GetInt32(3));
                    NombreActividad = Actividad.Buscar(Leer.GetInt32(4));
                    DgvListarClientes.Rows.Add(Leer.GetString(0), Leer.GetString(1), Leer.GetString(2),NombreBarrio,NombreActividad, Leer.GetInt32(5));
                    Cliente++;
                    Mensualidad = Mensualidad + Leer.GetInt32(5);
                    Promedio = Mensualidad / Cliente;
                }
            }

            ConexionBD.Close();
        }

        public void ListarClienteBarrio(DataGridView DgvListarClientes ,int CodBarrio)
        {
            //Me conecto a la base de datos 
            ConexionBD = new OleDbConnection();
            ConexionBD.ConnectionString = RutaBaseDeDatos;
            ConexionBD.Open();

            // Le paso la conexion 
            QueQuieroTraerDeLaBD = new OleDbCommand();
            QueQuieroTraerDeLaBD.Connection = ConexionBD;
            QueQuieroTraerDeLaBD.CommandType = System.Data.CommandType.TableDirect;
            // Le paso la tabla 
            QueQuieroTraerDeLaBD.CommandText = TablaGIMNASIO;
            // Ejecuta la instuccion 
            OleDbDataReader Leer = QueQuieroTraerDeLaBD.ExecuteReader();
            DgvListarClientes.Rows.Clear();
           

            if (Leer.HasRows)
            {
                while (Leer.Read())
                {
                    if (Leer.GetInt32(3) == CodBarrio)
                    {
                        DgvListarClientes.Rows.Add(Leer.GetString(0), Leer.GetString(1),Leer.GetString(2),Leer.GetInt32(5));
                    }
                    
                }
            }

            ConexionBD.Close();
        }

        public void ListarClienteActividad(DataGridView DgvListarClientes, int CodActividad)
        {
            //Me conecto a la base de datos 
            ConexionBD = new OleDbConnection();
            ConexionBD.ConnectionString = RutaBaseDeDatos;
            ConexionBD.Open();

            // Le paso la conexion 
            QueQuieroTraerDeLaBD = new OleDbCommand();
            QueQuieroTraerDeLaBD.Connection = ConexionBD;
            QueQuieroTraerDeLaBD.CommandType = System.Data.CommandType.TableDirect;
            // Le paso la tabla 
            QueQuieroTraerDeLaBD.CommandText = TablaGIMNASIO;
            // Ejecuta la instuccion 
            OleDbDataReader Leer = QueQuieroTraerDeLaBD.ExecuteReader();
            //Limpia la Grilla
            DgvListarClientes.Rows.Clear();
            
            // Pregunta si Hay filas para leer 
            if (Leer.HasRows)
            {
                while (Leer.Read())
                {
                    if (Leer.GetInt32(4) == CodActividad)
                    {
                        DgvListarClientes.Rows.Add(Leer.GetString(0), Leer.GetString(1), Leer.GetString(2), Leer.GetInt32(5));

                        Mensualidad = Mensualidad + Leer.GetInt32(5);

                        if (Leer.GetInt32(5) > Mayor)
                        {
                            Mayor = Leer.GetInt32(5);
                        }

                        if (Leer.GetInt32(5) < Menor)
                        {
                            Menor = Leer.GetInt32(5);
                        }

                    }

                }
            }

            ConexionBD.Close();
        }

        public void GenerarReporte(DataGridView DgvMostrar)
        {
            // Creo un objeto de tipo Aplicacion de Microsoft Office 
            Microsoft.Office.Interop.Excel.Application ExportarDatos = new Microsoft.Office.Interop.Excel.Application();
            // Creo una hoja de trabajo en excel 
            ExportarDatos.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            // Recorro las columnas de la grilla 
            foreach (DataGridViewColumn columna in DgvMostrar.Columns)
            {
                IndiceColumna++;
                // Le paso el Nombres de las columnas 
                ExportarDatos.Cells[1, IndiceColumna] = columna.Name;
            }

            int IndiceFila = 0;

            //Recorro las filas de la grilla 
            foreach (DataGridViewRow fila in DgvMostrar.Rows)
            {
                IndiceFila++;
                // Una vez que termina de leer las filas.. inicia desde cero, para cambiar de columna 
                IndiceColumna = 0;
                foreach (DataGridViewColumn columna in DgvMostrar.Columns)
                {
                    IndiceColumna++;
                    ExportarDatos.Cells[IndiceFila + 1, IndiceColumna] = fila.Cells[columna.Name].Value;
                }
            }

            //Muestra el Archivo en Excel 
            ExportarDatos.Visible = true;
        }

        public void Imprimir(PrintPageEventArgs Reporte)
        {
            // Creacion de Objeto Font Para poder Elejir el tipo de letra 
            System.Drawing.Font TituloPrincipal = new System.Drawing.Font("Arial", 20);
            System.Drawing.Font SubTitulo = new System.Drawing.Font("Arial", 15);
            System.Drawing.Font TipoLetra = new System.Drawing.Font("Arial", 10);

            // Le pongo los titulos.. 
            Reporte.Graphics.DrawString("Listado de Clientes", TituloPrincipal, Brushes.Black, 100,100);
            Reporte.Graphics.DrawString("DNI", SubTitulo, Brushes.Black, 100, 170);
            Reporte.Graphics.DrawString("Nombres", SubTitulo, Brushes.Black, 200, 170);
            Reporte.Graphics.DrawString("Mensualidad", SubTitulo, Brushes.Black, 320, 170);


            int Linea = 215;

            //Me conecto a la base de datos 
            ConexionBD = new OleDbConnection();
            ConexionBD.ConnectionString = RutaBaseDeDatos;
            ConexionBD.Open();

            // Le paso la conexion 
            QueQuieroTraerDeLaBD = new OleDbCommand();
            QueQuieroTraerDeLaBD.Connection = ConexionBD;
            QueQuieroTraerDeLaBD.CommandType = System.Data.CommandType.TableDirect;
            // Le paso la tabla 
            QueQuieroTraerDeLaBD.CommandText = TablaGIMNASIO;

            OleDbDataAdapter Adaptador = new OleDbDataAdapter(QueQuieroTraerDeLaBD);

            //Creo objeto del dataset 
            DataSet Ds = new DataSet();

            // Agrego Filas 
            Adaptador.Fill(Ds, TablaGIMNASIO);

            //Pregunta si la tabla tiene filas 
            if (Ds.Tables[TablaGIMNASIO].Rows.Count > 0)
            {   
                //Le paso las filas 
                foreach  (DataRow Fila in Ds.Tables[TablaGIMNASIO].Rows)
                {
                    // Imprimo Los campos elegidos de la BD
                    Reporte.Graphics.DrawString(Fila["Dni Socio"].ToString(),TipoLetra,Brushes.Black,100,Linea);
                    Reporte.Graphics.DrawString(Fila["Nombre"].ToString(), TipoLetra, Brushes.Black, 200,Linea);
                    Reporte.Graphics.DrawString(Fila["Mensualidad"].ToString(), TipoLetra, Brushes.Black, 320, Linea);

                    //Incremento la variable Linea para que cuando se impriman los datos Salgan con espacios en la Hoja.
                    Linea = Linea + 50;
                }
            }

            ConexionBD.Close();
        }
    }
}
