using CapaNegocios;
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
        Libro NuevoLibro;
        Libro LibroExistente;
        NegLibro objNegLibro = new NegLibro();
        bool nuevo = true;
        int fila;

        public GestorLibros()
        {
            InitializeComponent();
            CrearDGV();
            LlenarDGV();         
        }

        private void CrearDGV()
        {
            dgvLibros.Columns.Add("0", "Código");
            dgvLibros.Columns.Add("1", "Título");
            dgvLibros.Columns.Add("2", "Autor");
            dgvLibros.Columns.Add("3", "Editorial");
            dgvLibros.Columns.Add("4", "Género");
            dgvLibros.Columns.Add("5", "Fecha de Emisión");

            dgvLibros.Columns[0].Width = 100;
            dgvLibros.Columns[1].Width = 100;
            dgvLibros.Columns[2].Width = 100;
            dgvLibros.Columns[3].Width = 100;
            dgvLibros.Columns[4].Width = 100;
            dgvLibros.Columns[5].Width = 100;
        }

        private void LlenarDGV()
        {
            dgvLibros.Rows.Clear();

            DataSet ds = new DataSet();
            ds = objNegLibro.listadoLibros("Todos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    //Lo que quieres mostrar esta en dr[0].ToString(), dr[1].ToString(),etc...
                    dgvLibros.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3], dr[4], dr[5].ToString());
                }
            }
            else
                MessageBox.Show("No hay Libros cargados en el sistema");
        }

 
    
        //creacion de listas para libros
        DataTable dtLibros = new DataTable() { TableName = "libros" };

        const string ERROR_CODIGO_EXISTE = "Código existente, ingrese uno nuevo.";
        const string ERROR_CODIGO_BORRADO = "Libro no seleccionado";
        const string ERROR_CODIGO_PRESTADO = "Libro no seleccionado";
        //const string DIRECCION_XML = @"C:\Users\Usuario\OneDrive\Escritorio\FACU\PROGRAMACIÓN\vs2023\ProyectoProductoLibros\";


        private void btnCargar_Click(object sender, EventArgs e)
        {
            #region prg viejo
            //Libro libro = new Libro();

            ////limpieza del error provider
            //epvTextos.Clear();

            ////validacion para llenar los campos
            //if (!Validar())
            //{
            //    int indice = cmbGenero.SelectedIndex;

            //    libro.Codigo = Convert.ToInt32(txtCodigo.Text);
            //    libro.Titulo = txtTitulo.Text;
            //    libro.Autor = txtAutor.Text;
            //    libro.Editorial = txtEditorial.Text;
            //    libro.Genero = cmbGenero.Items[indice].ToString();

            //    //creacion de nuevo libro con sus atributos
            //    //Libro libro = new Libro(codigo, titulo, autor, editorial, genero, cantidad);


            //    //validacion de codigo existente
            //    int fila = BuscarCodigo(Convert.ToString(libro.Codigo));
            //    if (fila != -1)
            //    {
            //        MessageBox.Show(ERROR_CODIGO_EXISTE);
            //    }
            //    else
            //    {

            //        //agregamos el nuevo libro a la lista
            //        dtLibros.Rows.Add(new object[] { libro.Codigo, libro.Titulo, libro.Autor, libro.Editorial, libro.Genero });
            //        //dtLibros.WriteXml(DIRECCION_XML + "librito.xml");

            //        //limpieza de txts y cmb
            //        txtCodigo.Clear();
            //        txtTitulo.Clear();
            //        txtAutor.Clear();
            //        txtEditorial.Clear();
            //        cmbGenero.SelectedIndex = -1;

            //    }
            //}
            #endregion

            int nGrabados = -1;

            Libro NuevoLibro = new Libro();

            nGrabados = objNegLibro.abmLibros("Alta", NuevoLibro);

            if (nGrabados == -1)
            {
                MessageBox.Show("No se pudo grabar el libro en el sistema");
            }
            else
            {
                NuevoLibro.Codigo = int.Parse(txtCodigo.Text);
                NuevoLibro.Titulo = txtTitulo.Text;
                NuevoLibro.Autor = txtAutor.Text;
                NuevoLibro.Editorial = txtEditorial.Text;
                NuevoLibro.Genero = cmbGenero.Text;
                NuevoLibro.FechaEmision = dateTimePicker1.Value;

                LlenarDGV();
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
            if (cmbGenero.SelectedIndex == -1)
            {
                epvTextos.SetError(cmbGenero, "llenar campo");
                validar = true;
            }
            return validar;
        }
    }
}
