using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace ProyectoProductoLibros
{
    public partial class GestorLibros : Form
    {
        //creacion de listas para libros
        DataTable dtLibros = new DataTable() { TableName = "libros" };

        const string ERROR_CODIGO_EXISTE = "Código existente, ingrese uno nuevo.";
        const string ERROR_CODIGO_BORRADO = "Libro no seleccionado";
        const string ERROR_CODIGO_PRESTADO = "Libro no seleccionado";
        //const string DIRECCION_XML = @"C:\Users\Usuario\OneDrive\Escritorio\FACU\PROGRAMACIÓN\vs2023\ProyectoProductoLibros\";


        public GestorLibros()
        {
            InitializeComponent();

            //columnas de mi tabla
            dtLibros.Columns.Add("Código");
            dtLibros.Columns.Add("Título");
            dtLibros.Columns.Add("Autor");
            dtLibros.Columns.Add("Editorial");
            dtLibros.Columns.Add("Género");
            dtLibros.Columns.Add("Estado");

            //Leer_DT();
            dgvLibros.DataSource = dtLibros;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Libro libro = new Libro();

            //limpieza del error provider
            epvTextos.Clear();

            //validacion para llenar los campos
            if (!Validar())
            {
                int indice = cmbGenero.SelectedIndex;

                libro.Codigo = Convert.ToInt32(txtCodigo.Text);
                libro.Titulo = txtTitulo.Text;
                libro.Autor = txtAutor.Text;
                libro.Editorial = txtEditorial.Text;
                libro.Stock = Convert.ToInt32(txtCantidad.Text);
                libro.Genero = cmbGenero.Items[indice].ToString();

                //creacion de nuevo libro con sus atributos
                //Libro libro = new Libro(codigo, titulo, autor, editorial, genero, cantidad);


                //validacion de codigo existente
                int fila = BuscarCodigo(Convert.ToString(libro.Codigo));
                if (fila != -1)
                {
                    MessageBox.Show(ERROR_CODIGO_EXISTE);
                }
                else
                {
                    string estado;
                    if (libro.Stock != 0)
                    {
                        estado = "Disponible";
                    }
                    else
                    {
                        estado = "Prestado";
                    }

                    //agregamos el nuevo libro a la lista
                    dtLibros.Rows.Add(new object[] { libro.Codigo, libro.Titulo, libro.Autor, libro.Editorial, libro.Genero, estado });
                    //dtLibros.WriteXml(DIRECCION_XML + "librito.xml");

                    //limpieza de txts y cmb
                    txtCodigo.Clear();
                    txtTitulo.Clear();
                    txtAutor.Clear();
                    txtEditorial.Clear();
                    txtCantidad.Clear();
                    cmbGenero.SelectedIndex = -1;

                }
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //validacion de codigo no encontrado
            if (dgvLibros.CurrentRow == null)
            {
                MessageBox.Show(ERROR_CODIGO_BORRADO);
            }
            else
            {
                int fila = BuscarCodigo(dgvLibros.CurrentRow.Cells[0].Value.ToString());

                if (fila != -1)
                {
                    dtLibros.Rows[fila].Delete();
                    //dtLibros.WriteXml(DIRECCION_XML + "librito.xml");
                }
            }
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            //validacion de codigo
            if (dgvLibros.CurrentRow == null)
            {
                MessageBox.Show(ERROR_CODIGO_PRESTADO);
            }
            else
            {
                string disponibilidad = dgvLibros.CurrentRow.Cells[5].Value.ToString();

                //abrimos el 2do form con el codigo y la disponibilidad
                GestorPrestamo gestorPrestamos = new GestorPrestamo(dgvLibros.CurrentRow.Cells[0].Value.ToString(), disponibilidad);
                gestorPrestamos.ShowDialog();

                //cambio de la disponibilidad en caso de cambio
                if (gestorPrestamos.bandera)
                {
                    string codigo = dgvLibros.CurrentRow.Cells[0].Value.ToString();
                    string titulo = dgvLibros.CurrentRow.Cells[1].Value.ToString();
                    string autor = dgvLibros.CurrentRow.Cells[2].Value.ToString();
                    string editorial = dgvLibros.CurrentRow.Cells[3].Value.ToString();
                    string genero = dgvLibros.CurrentRow.Cells[4].Value.ToString();
                    dgvLibros.Rows.Remove(dgvLibros.CurrentRow);



                    //-------------------------------------------------------------------------operador ternario
                    dtLibros.Rows.Add(new object[] { codigo, titulo, autor, editorial, genero, disponibilidad == "Disponible" ? "Prestado" : "Disponible" });
                    //dtLibros.WriteXml(DIRECCION_XML + "librito.xml");
                }
            }
        }

        //filtros para buscar libros
        private void txtFiltrarTitulo_TextChanged_1(object sender, EventArgs e)
        {
            dtLibros.DefaultView.RowFilter = $"Título LIKE '{txtFiltrarTitulo.Text}%'";
        }

        private void txtFiltrarAutor_TextChanged_1(object sender, EventArgs e)
        {
            dtLibros.DefaultView.RowFilter = $"Autor LIKE '{txtFiltrarAutor.Text}%'";
        }

        private void txtFiltrarEditorial_TextChanged_1(object sender, EventArgs e)
        {
            dtLibros.DefaultView.RowFilter = $"Editorial LIKE '{txtFiltrarEditorial.Text}%'";
        }

        private void txtFiltrarCodigo_TextChanged_1(object sender, EventArgs e)
        {
            dtLibros.DefaultView.RowFilter = $"Código LIKE '{txtFiltrarCodigo.Text}%'";
        }

        private void txtFiltrarGenero_TextChanged_1(object sender, EventArgs e)
        {
            dtLibros.DefaultView.RowFilter = $"Género LIKE '{txtFiltrarGenero.Text}%'";
        }

        //metodo para buscar codigo
        public int BuscarCodigo(string code)
        {
            int fila = -1;

            for (int i = 0; i < dtLibros.Rows.Count; i++)
            {
                if (dtLibros.Rows[i]["Código"].ToString() == code)
                {
                    fila = i;
                    break;
                }
            }

            return fila;
        }
        //validacion con errorprovider para llenado de campos
        private bool Validar()
        {
            bool validar = false;

            if (txtCodigo.Text == "")
            {
                epvTextos.SetError(txtCodigo, "llenar campo");
                validar = true;
            }
            if (txtTitulo.Text == "")
            {
                epvTextos.SetError(txtTitulo, "llenar campo");
                validar = true;
            }
            if (txtAutor.Text == "")
            {
                epvTextos.SetError(txtAutor, "llenar campo");
                validar = true;
            }
            if (txtEditorial.Text == "")
            {
                epvTextos.SetError(txtEditorial, "llenar campo");
                validar = true;
            }
            if (txtCantidad.Text == "")
            {
                epvTextos.SetError(txtCantidad, "llenar campo");
                validar = true;
            }
            if (cmbGenero.SelectedIndex == -1)
            {
                epvTextos.SetError(cmbGenero, "llenar campo");
                validar = true;
            }
            return validar;
        }
        //metodo para leer DT para saber si existe
        //private void Leer_DT()
        //{
        //    if (System.IO.File.Exists(DIRECCION_XML + "librito.xml"))
        //    {
        //        dtLibros.ReadXml(DIRECCION_XML + "librito.xml");
        //    }
        //}

        
    }
}
