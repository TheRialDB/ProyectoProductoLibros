using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace CapaDatos
{
    public class DatosConexion
    {

        protected OleDbConnection conexion;
        protected string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\Usuario\OneDrive\Escritorio\FACU\PROGRAMACIÓN\BDProyLibros.accdb";


        public DatosConexion()
        {
            conexion = new OleDbConnection(cadenaConexion);
        }

        public void AbrirConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State == ConnectionState.Closed)
                    conexion.Open();
            } 
            catch(Exception e) 
            {
                throw new Exception("Error al tratar de abrir la conexión", e);
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión", e);
            }
        }
    }
}
