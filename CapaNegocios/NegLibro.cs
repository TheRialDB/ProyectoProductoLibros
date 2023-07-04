using CapaDatos;
using Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class NegLibro
    {
        AdminLibros DatosObjLibros = new AdminLibros();

        public int abmLibros(string accion, Libro objLibro)
        {
            return DatosObjLibros.abmLibros(accion, objLibro);
        }

        public DataSet listadoLibros(string cual)
        {
            return DatosObjLibros.listadoLibros(cual);
        }
    }
}
