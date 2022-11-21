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
        private int Sal;
        private int Cli;
        private int Prom;
        private int May;
        private int Men;


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
        public int Saldo
        {
            get { return Sal; }
            set { Sal = value; }
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
                            DNI_Cliente = Leer.GetString(0);
                            Nom_Apellido = Leer.GetString(1);
                            Dir = Leer.GetString(2);
                            Barr = Leer.GetInt32(3);
                            Act = Leer.GetInt32(4);
                            Sal = Leer.GetInt32(5);
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
                            Sal = Leer.GetInt32(5);
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
                String AgregarCliente = "INSERT INTO" + " GIMNASIO ([DNI SOCIO], [NOMBRE], [DIRECCION], [COD BARRIO], [ACTIVIDAD], [SALDO])" +
                        " VALUES ('" + DNI + "','" + NombreCliente + "','" + Direccion + "','" + Barrio + "','" + Actividad + "','" + Saldo + "')";

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
            string ModificarCliente = "UPDATE GIMNASIO SET [NOMBRE] = '" + NombreCliente + "',[DIRECCION] = '" + Direccion + "',[Cod Barrio] = '" + Barrio + "',[ACTIVIDAD] ='" + Actividad + "',[SALDO] ='" + Saldo + "' WHERE [Dni Socio] = '" + DNI + "'";

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
            // Ejecuta la instuccion 
            OleDbDataReader Leer = QueQuieroTraerDeLaBD.ExecuteReader();
            DgvListarClientes.Rows.Clear();
            Cliente = 0;
            Saldo = 0;
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
                    Saldo = Saldo + Leer.GetInt32(5);
                    Promedio = Saldo / Cliente;
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

                        Saldo = Saldo + Leer.GetInt32(5);

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
            Reporte.Graphics.DrawString("Saldo", SubTitulo, Brushes.Black, 320, 170);


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
                    Reporte.Graphics.DrawString(Fila["Saldo"].ToString(), TipoLetra, Brushes.Black, 320, Linea);

                    //Incremento la variable Linea para que cuando se impriman los datos Salgan con espacios en la Hoja.
                    Linea = Linea + 25;
                }
            }

            ConexionBD.Close();
        }
    }
}
