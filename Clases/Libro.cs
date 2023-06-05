using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Libro
    {
        //atributos

        private int codigo;
        private string titulo;
        private string autor;
        private string editorial;
        private string genero;
        private int stock;
        private bool prestado;
        private DateTime fechaPrestamo;
        private DateTime fechaDevolucion;

        //constructor vacio
        public Libro()
        {

        }

        public Libro(int codigo, string titulo, string autor, string editorial, string genero, int cantidad)
        {
            this.codigo = codigo;
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
            this.genero = genero;
            this.stock = cantidad;
            if (stock == 0)
            {
                this.prestado = true;
            }
        }

        //getters y setters
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public string Genero { get; set; }
        public int Stock { get; set; }
        public bool Prestado { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }

    }
}
