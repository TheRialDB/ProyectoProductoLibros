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
        private DateTime fechaEmision;       

        //constructor vacio
        public Libro()
        {

        }

        public Libro(int codigo, string titulo, string autor, string editorial, string genero)
        {
            this.codigo = codigo;
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
            this.genero = genero;
            
        }

        //getters y setters
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public string Genero { get; set; }        
        public DateTime FechaEmision { get; set; }

    }
}
