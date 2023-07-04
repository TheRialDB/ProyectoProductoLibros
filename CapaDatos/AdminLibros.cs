using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Clases;

namespace CapaDatos
{
    public class AdminLibros : DatosConexion
    {
     
        public int abmLibros(string accion, Libro objLibro)
        {
            int resultado = -1; //Controlar que se realice la operacion con exito.
            string orden = string.Empty; //Para guardar consulta sql.

            //Agregar una Mascota nueva.
            if (accion == "Alta")
            {
                orden = "insert into Libro values (" + objLibro.Codigo + ",'" + objLibro.Titulo + ",'" + objLibro.Autor + ",'" + objLibro.Editorial + ",'" + objLibro.Genero + ",'" + objLibro.FechaEmision + "');";
            }


            //Para modificar un existente.
            if (accion == "Modificar")
            {
                orden = "update Libro set Titulo='" + objLibro.Titulo + "', Autor= " + objLibro.Autor + "', Editorial= " + objLibro.Editorial + "', Genero= " + objLibro.Genero + "', FechaEmision= " + objLibro.FechaEmision + " where Codigo = " + objLibro.Codigo + "; ";
            }


            // Para borrar una Mascota.
            if (accion == "Borrar")
            {
                orden = "delete from Libro where Codigo= " + objLibro.Codigo + "; ";
            }

            OleDbCommand cmd = new OleDbCommand(orden, conexion);

            try
            {
                AbrirConexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                //throw new Exception("Errror al tratar de alta,borrar o modificar de Mascota",e);
                throw new Exception($"Error de la accion {accion}", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet listadoLibros(string cual) //Para 1 o todos los datos segun el codigo.
        {
            string orden = string.Empty;

            if (cual != "Todos")
                orden = "select * from Libro where Codigo = " + int.Parse(cual) + ";";
            else
                orden = "select * from Libro;";

            OleDbCommand cmd = new OleDbCommand(orden, conexion);

            DataSet ds = new DataSet();

            OleDbDataAdapter da = new OleDbDataAdapter();

            try
            {
                AbrirConexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar libros", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return ds;
        }
    }
}
