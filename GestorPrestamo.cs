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

namespace ProyectoProductoLibros
{
    public partial class GestorPrestamo : Form
    {
        //creacion del datatable para personas
        DataTable dtClientes = new DataTable() { TableName = "clientes" };

        //variables para validaciones
        private string dato;
        private string valor;
        public bool bandera { get; set; }

        //const string DIRECCION_XML = @"C:\Users\Usuario\OneDrive\Escritorio\FACU\PROGRAMACIÓN\vs2023\ProyectoProductoLibros\";
        const string ERROR_CODIGO = "Libro no seleccionado";
        const string LIBRO_PRESTADO = "El libro fue prestado";
        const string ERROR_LIBRO_PRESTADO = "El libro no se haya disponible";
        const string LIBRO_DEVUELTO = "El libro fue devuelto";


        public GestorPrestamo(string codigo, string estado)
        {
            InitializeComponent();
            //variables de validacion
            bandera = false;

            dato = codigo;
            valor = estado;

            //columnas de la tabla
            dtClientes.Columns.Add("Nombres");
            dtClientes.Columns.Add("Apellidos");
            dtClientes.Columns.Add("DNI");
            dtClientes.Columns.Add("Fecha de Devolución");
            dtClientes.Columns.Add("Código");
            

            //lectura y carga de datos
            //Leer_DT();
            dgvPrestamos.DataSource = dtClientes;
        }
        public GestorPrestamo()
        {
            InitializeComponent();

            //columnas de la tabla
            dtClientes.Columns.Add("Nombres");
            dtClientes.Columns.Add("Apellidos");
            dtClientes.Columns.Add("DNI");
            dtClientes.Columns.Add("Fecha de Devolución");
            dtClientes.Columns.Add("Código");

            //lectura y carga de datos
            //Leer_DT();
            dgvPrestamos.DataSource = dtClientes;
        }


        private void btnPrestar_Click(object sender, EventArgs e)
        {
            //creacion de nuevo cliente
            Cliente cliente = new Cliente();

            //devolucion del libro en 2 semanas
            DateTime fechaPrestamo = Convert.ToDateTime(dtpFechaPrestamo.Text);
            fechaPrestamo.AddDays(14);

            //prestamo a 1 cliente
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Dni = txtDni.Text;
            cliente.FechaPrestamo = fechaPrestamo;


            //limpieza de error provider
            epvClientes.Clear();

            //validacion para llenar campos
            if (!Validar())
            {
                if (dato == null)
                {
                    MessageBox.Show(ERROR_CODIGO);
                }
                else
                {
                    if (valor == "Disponible")
                    {
                        //carga de prestamos
                        dtClientes.Rows.Add(new object[] { cliente.Nombre, cliente.Apellido, cliente.Dni, cliente.FechaPrestamo, dato });
                        //dtClientes.WriteXml(DIRECCION_XML + "clientes.xml");

                        dgvPrestamos.DataSource = null;
                        dgvPrestamos.DataSource = dtClientes;

                        MessageBox.Show(LIBRO_PRESTADO);
                        bandera = true;
                        this.Close();
                    }
                }
            }           
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (valor == "Disponible")
            {
                MessageBox.Show(ERROR_LIBRO_PRESTADO);
            }
            else
            {
                int fila = BuscarCodigo(dato);
                if (fila != -1)
                {
                    dtClientes.Rows[fila].Delete();
                    /*dtClientes.WriteXml(DIRECCION_XML + "clientes.xml")*/;

                    MessageBox.Show(LIBRO_DEVUELTO);
                    bandera = true;
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        //Filtros de busqueda
        private void txtFiltrarNombre_TextChanged(object sender, EventArgs e)
        {
            dtClientes.DefaultView.RowFilter = $"Nombres LIKE '{txtFiltrarNombre.Text}%'";
        }

        private void txtFiltrarApellido_TextChanged(object sender, EventArgs e)
        {
            dtClientes.DefaultView.RowFilter = $"Apellidos LIKE '{txtFiltrarNombre.Text}%'";
        }

        private void txtFiltrarDni_TextChanged(object sender, EventArgs e)
        {
            dtClientes.DefaultView.RowFilter = $"DNI LIKE '{txtFiltrarNombre.Text}%'";
        }

        private void txtFiltrarCodigo_TextChanged(object sender, EventArgs e)
        {
            dtClientes.DefaultView.RowFilter = $"Código LIKE '{txtFiltrarNombre.Text}%'";
        }


        private bool Validar()
        {
            bool validar = false;

            if (txtNombre.Text == "")
            {
                epvClientes.SetError(txtNombre, "llenar campo");
                validar = true;
            }
            if (txtApellido.Text == "")
            {
                epvClientes.SetError(txtApellido, "llenar campo");
                validar = true;
            }
            if (txtDni.Text == "")
            {
                epvClientes.SetError(txtDni, "llenar campo");
                validar = true;
            }
            return validar;
        }
        //private void Leer_DT()
        //{
        //    if (System.IO.File.Exists(DIRECCION_XML + "clientes.xml"))
        //    {
        //        dtClientes.ReadXml(DIRECCION_XML + "clientes.xml");
        //    }
        //}
        public int BuscarCodigo(string code)
        {
            int fila = -1;

            for (int i = 0; i < dtClientes.Rows.Count; i++)
            {
                if (dtClientes.Rows[i]["Código"].ToString() == code)
                {
                    fila = i;
                    break;
                }
            }

            return fila;
        }
    }
}
