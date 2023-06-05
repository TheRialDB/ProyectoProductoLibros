namespace ProyectoProductoLibros
{
    partial class GestorPrestamo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblFiltroCodigo = new System.Windows.Forms.Label();
            this.txtFiltrarCodigo = new System.Windows.Forms.TextBox();
            this.txtFiltrarDni = new System.Windows.Forms.TextBox();
            this.txtFiltrarApellido = new System.Windows.Forms.TextBox();
            this.txtFiltrarNombre = new System.Windows.Forms.TextBox();
            this.lblFiltroDni = new System.Windows.Forms.Label();
            this.lblFiltroApellido = new System.Windows.Forms.Label();
            this.lblFiltroNombre = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.btnPrestar = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dtpFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.lblFechaPrestamo = new System.Windows.Forms.Label();
            this.epvClientes = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiltroCodigo
            // 
            this.lblFiltroCodigo.AutoSize = true;
            this.lblFiltroCodigo.Location = new System.Drawing.Point(196, 351);
            this.lblFiltroCodigo.Name = "lblFiltroCodigo";
            this.lblFiltroCodigo.Size = new System.Drawing.Size(68, 13);
            this.lblFiltroCodigo.TabIndex = 35;
            this.lblFiltroCodigo.Text = "Filtrar Código";
            // 
            // txtFiltrarCodigo
            // 
            this.txtFiltrarCodigo.Location = new System.Drawing.Point(41, 348);
            this.txtFiltrarCodigo.Name = "txtFiltrarCodigo";
            this.txtFiltrarCodigo.Size = new System.Drawing.Size(147, 20);
            this.txtFiltrarCodigo.TabIndex = 34;
            this.txtFiltrarCodigo.TextChanged += new System.EventHandler(this.txtFiltrarCodigo_TextChanged);
            // 
            // txtFiltrarDni
            // 
            this.txtFiltrarDni.Location = new System.Drawing.Point(41, 322);
            this.txtFiltrarDni.Name = "txtFiltrarDni";
            this.txtFiltrarDni.Size = new System.Drawing.Size(147, 20);
            this.txtFiltrarDni.TabIndex = 33;
            this.txtFiltrarDni.TextChanged += new System.EventHandler(this.txtFiltrarDni_TextChanged);
            // 
            // txtFiltrarApellido
            // 
            this.txtFiltrarApellido.Location = new System.Drawing.Point(41, 296);
            this.txtFiltrarApellido.Name = "txtFiltrarApellido";
            this.txtFiltrarApellido.Size = new System.Drawing.Size(147, 20);
            this.txtFiltrarApellido.TabIndex = 32;
            this.txtFiltrarApellido.TextChanged += new System.EventHandler(this.txtFiltrarApellido_TextChanged);
            // 
            // txtFiltrarNombre
            // 
            this.txtFiltrarNombre.Location = new System.Drawing.Point(41, 270);
            this.txtFiltrarNombre.Name = "txtFiltrarNombre";
            this.txtFiltrarNombre.Size = new System.Drawing.Size(147, 20);
            this.txtFiltrarNombre.TabIndex = 31;
            this.txtFiltrarNombre.TextChanged += new System.EventHandler(this.txtFiltrarNombre_TextChanged);
            // 
            // lblFiltroDni
            // 
            this.lblFiltroDni.AutoSize = true;
            this.lblFiltroDni.Location = new System.Drawing.Point(196, 325);
            this.lblFiltroDni.Name = "lblFiltroDni";
            this.lblFiltroDni.Size = new System.Drawing.Size(54, 13);
            this.lblFiltroDni.TabIndex = 30;
            this.lblFiltroDni.Text = "Filtrar DNI";
            // 
            // lblFiltroApellido
            // 
            this.lblFiltroApellido.AutoSize = true;
            this.lblFiltroApellido.Location = new System.Drawing.Point(196, 299);
            this.lblFiltroApellido.Name = "lblFiltroApellido";
            this.lblFiltroApellido.Size = new System.Drawing.Size(72, 13);
            this.lblFiltroApellido.TabIndex = 29;
            this.lblFiltroApellido.Text = "Filtrar Apellido";
            // 
            // lblFiltroNombre
            // 
            this.lblFiltroNombre.AutoSize = true;
            this.lblFiltroNombre.Location = new System.Drawing.Point(196, 273);
            this.lblFiltroNombre.Name = "lblFiltroNombre";
            this.lblFiltroNombre.Size = new System.Drawing.Size(72, 13);
            this.lblFiltroNombre.TabIndex = 28;
            this.lblFiltroNombre.Text = "Filtrar Nombre";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(797, 275);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolver.Location = new System.Drawing.Point(160, 189);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(75, 23);
            this.btnDevolver.TabIndex = 26;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Location = new System.Drawing.Point(297, 32);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.Size = new System.Drawing.Size(575, 237);
            this.dgvPrestamos.TabIndex = 25;
            // 
            // btnPrestar
            // 
            this.btnPrestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestar.Location = new System.Drawing.Point(41, 189);
            this.btnPrestar.Name = "btnPrestar";
            this.btnPrestar.Size = new System.Drawing.Size(75, 23);
            this.btnPrestar.TabIndex = 24;
            this.btnPrestar.Text = "Prestar";
            this.btnPrestar.UseVisualStyleBackColor = true;
            this.btnPrestar.Click += new System.EventHandler(this.btnPrestar_Click);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(104, 95);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(131, 20);
            this.txtDni.TabIndex = 23;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(104, 69);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(131, 20);
            this.txtApellido.TabIndex = 22;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(38, 98);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 21;
            this.lblDni.Text = "DNI";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(38, 72);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 20;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(131, 20);
            this.txtNombre.TabIndex = 19;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(38, 46);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre";
            // 
            // dtpFechaPrestamo
            // 
            this.dtpFechaPrestamo.Location = new System.Drawing.Point(41, 148);
            this.dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            this.dtpFechaPrestamo.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaPrestamo.TabIndex = 36;
            // 
            // lblFechaPrestamo
            // 
            this.lblFechaPrestamo.AutoSize = true;
            this.lblFechaPrestamo.Location = new System.Drawing.Point(38, 132);
            this.lblFechaPrestamo.Name = "lblFechaPrestamo";
            this.lblFechaPrestamo.Size = new System.Drawing.Size(100, 13);
            this.lblFechaPrestamo.TabIndex = 37;
            this.lblFechaPrestamo.Text = "Fecha del prestamo";
            // 
            // epvClientes
            // 
            this.epvClientes.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epvClientes.ContainerControl = this;
            // 
            // GestorPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(928, 378);
            this.Controls.Add(this.lblFechaPrestamo);
            this.Controls.Add(this.dtpFechaPrestamo);
            this.Controls.Add(this.lblFiltroCodigo);
            this.Controls.Add(this.txtFiltrarCodigo);
            this.Controls.Add(this.txtFiltrarDni);
            this.Controls.Add(this.txtFiltrarApellido);
            this.Controls.Add(this.txtFiltrarNombre);
            this.Controls.Add(this.lblFiltroDni);
            this.Controls.Add(this.lblFiltroApellido);
            this.Controls.Add(this.lblFiltroNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.dgvPrestamos);
            this.Controls.Add(this.btnPrestar);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "GestorPrestamo";
            this.Text = "GestorPrestamo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiltroCodigo;
        private System.Windows.Forms.TextBox txtFiltrarCodigo;
        private System.Windows.Forms.TextBox txtFiltrarDni;
        private System.Windows.Forms.TextBox txtFiltrarApellido;
        private System.Windows.Forms.TextBox txtFiltrarNombre;
        private System.Windows.Forms.Label lblFiltroDni;
        private System.Windows.Forms.Label lblFiltroApellido;
        private System.Windows.Forms.Label lblFiltroNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.Button btnPrestar;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaPrestamo;
        private System.Windows.Forms.ErrorProvider epvClientes;
        private System.Windows.Forms.DateTimePicker dtpFechaPrestamo;
    }
}