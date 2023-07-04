namespace ProyectoProductoLibros
{
    partial class GestorLibros
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.epvTextos = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtFiltrarGenero = new System.Windows.Forms.TextBox();
            this.lblFiltroGenero = new System.Windows.Forms.Label();
            this.txtFiltrarCodigo = new System.Windows.Forms.TextBox();
            this.lblFiltroCodigo = new System.Windows.Forms.Label();
            this.lblFiltroEditorial = new System.Windows.Forms.Label();
            this.lblFiltroAutor = new System.Windows.Forms.Label();
            this.txtFiltrarEditorial = new System.Windows.Forms.TextBox();
            this.txtFiltrarAutor = new System.Windows.Forms.TextBox();
            this.txtFiltrarTitulo = new System.Windows.Forms.TextBox();
            this.lblFiltroTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epvTextos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(17, 26);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(17, 52);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Título";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(17, 78);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "Autor";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(17, 130);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 3;
            this.lblGenero.Text = "Género";
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditorial.Location = new System.Drawing.Point(17, 104);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(44, 13);
            this.lblEditorial.TabIndex = 4;
            this.lblEditorial.Text = "Editorial";
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Location = new System.Drawing.Point(208, 23);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.Size = new System.Drawing.Size(736, 353);
            this.dgvLibros.TabIndex = 5;
            // 
            // epvTextos
            // 
            this.epvTextos.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epvTextos.ContainerControl = this;
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(20, 203);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(102, 23);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 7;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(102, 49);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 8;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(102, 75);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(100, 20);
            this.txtAutor.TabIndex = 9;
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(102, 101);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(100, 20);
            this.txtEditorial.TabIndex = 10;
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Terror",
            "Policial",
            "Infantil",
            "Ciencia Ficción",
            "Autoayuda",
            "Educativos",
            "Cocina",
            "Otro"});
            this.cmbGenero.Location = new System.Drawing.Point(102, 127);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(100, 21);
            this.cmbGenero.TabIndex = 11;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(127, 203);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtFiltrarGenero
            // 
            this.txtFiltrarGenero.Location = new System.Drawing.Point(12, 418);
            this.txtFiltrarGenero.Name = "txtFiltrarGenero";
            this.txtFiltrarGenero.Size = new System.Drawing.Size(158, 20);
            this.txtFiltrarGenero.TabIndex = 60;
            this.txtFiltrarGenero.TextChanged += new System.EventHandler(this.txtFiltrarGenero_TextChanged_1);
            // 
            // lblFiltroGenero
            // 
            this.lblFiltroGenero.AutoSize = true;
            this.lblFiltroGenero.Location = new System.Drawing.Point(12, 402);
            this.lblFiltroGenero.Name = "lblFiltroGenero";
            this.lblFiltroGenero.Size = new System.Drawing.Size(70, 13);
            this.lblFiltroGenero.TabIndex = 59;
            this.lblFiltroGenero.Text = "Filtrar Género";
            // 
            // txtFiltrarCodigo
            // 
            this.txtFiltrarCodigo.Location = new System.Drawing.Point(12, 379);
            this.txtFiltrarCodigo.Name = "txtFiltrarCodigo";
            this.txtFiltrarCodigo.Size = new System.Drawing.Size(158, 20);
            this.txtFiltrarCodigo.TabIndex = 58;
            this.txtFiltrarCodigo.TextChanged += new System.EventHandler(this.txtFiltrarCodigo_TextChanged_1);
            // 
            // lblFiltroCodigo
            // 
            this.lblFiltroCodigo.AutoSize = true;
            this.lblFiltroCodigo.Location = new System.Drawing.Point(12, 363);
            this.lblFiltroCodigo.Name = "lblFiltroCodigo";
            this.lblFiltroCodigo.Size = new System.Drawing.Size(68, 13);
            this.lblFiltroCodigo.TabIndex = 57;
            this.lblFiltroCodigo.Text = "Filtrar Código";
            // 
            // lblFiltroEditorial
            // 
            this.lblFiltroEditorial.AutoSize = true;
            this.lblFiltroEditorial.Location = new System.Drawing.Point(12, 324);
            this.lblFiltroEditorial.Name = "lblFiltroEditorial";
            this.lblFiltroEditorial.Size = new System.Drawing.Size(72, 13);
            this.lblFiltroEditorial.TabIndex = 56;
            this.lblFiltroEditorial.Text = "Filtrar Editorial";
            // 
            // lblFiltroAutor
            // 
            this.lblFiltroAutor.AutoSize = true;
            this.lblFiltroAutor.Location = new System.Drawing.Point(12, 285);
            this.lblFiltroAutor.Name = "lblFiltroAutor";
            this.lblFiltroAutor.Size = new System.Drawing.Size(60, 13);
            this.lblFiltroAutor.TabIndex = 55;
            this.lblFiltroAutor.Text = "Filtrar Autor";
            // 
            // txtFiltrarEditorial
            // 
            this.txtFiltrarEditorial.Location = new System.Drawing.Point(12, 340);
            this.txtFiltrarEditorial.Name = "txtFiltrarEditorial";
            this.txtFiltrarEditorial.Size = new System.Drawing.Size(158, 20);
            this.txtFiltrarEditorial.TabIndex = 54;
            this.txtFiltrarEditorial.TextChanged += new System.EventHandler(this.txtFiltrarEditorial_TextChanged_1);
            // 
            // txtFiltrarAutor
            // 
            this.txtFiltrarAutor.Location = new System.Drawing.Point(12, 301);
            this.txtFiltrarAutor.Name = "txtFiltrarAutor";
            this.txtFiltrarAutor.Size = new System.Drawing.Size(158, 20);
            this.txtFiltrarAutor.TabIndex = 53;
            this.txtFiltrarAutor.TextChanged += new System.EventHandler(this.txtFiltrarAutor_TextChanged_1);
            // 
            // txtFiltrarTitulo
            // 
            this.txtFiltrarTitulo.Location = new System.Drawing.Point(12, 262);
            this.txtFiltrarTitulo.Name = "txtFiltrarTitulo";
            this.txtFiltrarTitulo.Size = new System.Drawing.Size(158, 20);
            this.txtFiltrarTitulo.TabIndex = 52;
            this.txtFiltrarTitulo.TextChanged += new System.EventHandler(this.txtFiltrarTitulo_TextChanged_1);
            // 
            // lblFiltroTitulo
            // 
            this.lblFiltroTitulo.AutoSize = true;
            this.lblFiltroTitulo.Location = new System.Drawing.Point(12, 246);
            this.lblFiltroTitulo.Name = "lblFiltroTitulo";
            this.lblFiltroTitulo.Size = new System.Drawing.Size(63, 13);
            this.lblFiltroTitulo.TabIndex = 51;
            this.lblFiltroTitulo.Text = "Filtrar Título";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Fecha de Emisión";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 177);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker1.TabIndex = 62;
            // 
            // GestorLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(956, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiltrarGenero);
            this.Controls.Add(this.lblFiltroGenero);
            this.Controls.Add(this.txtFiltrarCodigo);
            this.Controls.Add(this.lblFiltroCodigo);
            this.Controls.Add(this.lblFiltroEditorial);
            this.Controls.Add(this.lblFiltroAutor);
            this.Controls.Add(this.txtFiltrarEditorial);
            this.Controls.Add(this.txtFiltrarAutor);
            this.Controls.Add(this.txtFiltrarTitulo);
            this.Controls.Add(this.lblFiltroTitulo);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.lblEditorial);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "GestorLibros";
            this.Text = "ABM Libros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epvTextos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.ErrorProvider epvTextos;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtFiltrarGenero;
        private System.Windows.Forms.Label lblFiltroGenero;
        private System.Windows.Forms.TextBox txtFiltrarCodigo;
        private System.Windows.Forms.Label lblFiltroCodigo;
        private System.Windows.Forms.Label lblFiltroEditorial;
        private System.Windows.Forms.Label lblFiltroAutor;
        private System.Windows.Forms.TextBox txtFiltrarEditorial;
        private System.Windows.Forms.TextBox txtFiltrarAutor;
        private System.Windows.Forms.TextBox txtFiltrarTitulo;
        private System.Windows.Forms.Label lblFiltroTitulo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
    }
}

