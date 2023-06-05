using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cliente
    {
        //atributos
        private string nombre;
        private string apellido;
        private string dni;
        private DateTime fechaPrestamo;

        //constructor vacio
        public Cliente()
        {

        }

        //gets sets
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Dni { get; set; }

        public DateTime FechaPrestamo { get; set; }

    }
}
