namespace WinAppProyectoFinal
{
    partial class FormDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatos));
            this.dataSetRestauranteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRestaurante = new WinAppProyectoFinal.DataSetRestaurante();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeDatosDelClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarNuevoCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarDatosDelClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarDatosDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDatosDeClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MostrarTodosLosClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MostrarclientesDeudores = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesFrecuentes = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MostrarTodoslosProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.productosCaducados = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FECHA = new System.Windows.Forms.Timer(this.components);
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.dataSetRestaurante1 = new WinAppProyectoFinal.DataSetRestaurante();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRestauranteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRestaurante)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRestaurante1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetRestauranteBindingSource
            // 
            this.dataSetRestauranteBindingSource.DataSource = this.dataSetRestaurante;
            this.dataSetRestauranteBindingSource.Position = 0;
            // 
            // dataSetRestaurante
            // 
            this.dataSetRestaurante.DataSetName = "DataSetRestaurante";
            this.dataSetRestaurante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(26)))), ((int)(((byte)(53)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoDeDatosDelClienteToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // ingresoDeDatosDelClienteToolStripMenuItem
            // 
            this.ingresoDeDatosDelClienteToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ingresoDeDatosDelClienteToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.ingresoDeDatosDelClienteToolStripMenuItem.Name = "ingresoDeDatosDelClienteToolStripMenuItem";
            this.ingresoDeDatosDelClienteToolStripMenuItem.Size = new System.Drawing.Size(300, 26);
            this.ingresoDeDatosDelClienteToolStripMenuItem.Text = "Ingreso de Datos del Cliente";
            this.ingresoDeDatosDelClienteToolStripMenuItem.Click += new System.EventHandler(this.ingresoDeDatosDelClienteToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarNuevoCliente,
            this.actualizarDatosDelClienteToolStripMenuItem,
            this.eliminarClienteToolStripMenuItem});
            this.clienteToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // ingresarNuevoCliente
            // 
            this.ingresarNuevoCliente.Name = "ingresarNuevoCliente";
            this.ingresarNuevoCliente.Size = new System.Drawing.Size(293, 26);
            this.ingresarNuevoCliente.Text = "Ingresar Nuevo Cliente";
            this.ingresarNuevoCliente.Click += new System.EventHandler(this.ingresarNuevoCliente_Click);
            // 
            // actualizarDatosDelClienteToolStripMenuItem
            // 
            this.actualizarDatosDelClienteToolStripMenuItem.Name = "actualizarDatosDelClienteToolStripMenuItem";
            this.actualizarDatosDelClienteToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            this.actualizarDatosDelClienteToolStripMenuItem.Text = "Actualizar Datos del Cliente";
            this.actualizarDatosDelClienteToolStripMenuItem.Click += new System.EventHandler(this.actualizarDatosDelClienteToolStripMenuItem_Click);
            // 
            // eliminarClienteToolStripMenuItem
            // 
            this.eliminarClienteToolStripMenuItem.Name = "eliminarClienteToolStripMenuItem";
            this.eliminarClienteToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            this.eliminarClienteToolStripMenuItem.Text = "Eliminar Cliente";
            this.eliminarClienteToolStripMenuItem.Click += new System.EventHandler(this.eliminarClienteToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarProductoToolStripMenuItem,
            this.actualizarDatosDeProductoToolStripMenuItem,
            this.eliminarProductoToolStripMenuItem});
            this.productosToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // ingresarProductoToolStripMenuItem
            // 
            this.ingresarProductoToolStripMenuItem.Name = "ingresarProductoToolStripMenuItem";
            this.ingresarProductoToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.ingresarProductoToolStripMenuItem.Text = "Ingresar Producto";
            this.ingresarProductoToolStripMenuItem.Click += new System.EventHandler(this.ingresarProductoToolStripMenuItem_Click);
            // 
            // actualizarDatosDeProductoToolStripMenuItem
            // 
            this.actualizarDatosDeProductoToolStripMenuItem.Name = "actualizarDatosDeProductoToolStripMenuItem";
            this.actualizarDatosDeProductoToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.actualizarDatosDeProductoToolStripMenuItem.Text = "Actualizar Datos de Producto";
            this.actualizarDatosDeProductoToolStripMenuItem.Click += new System.EventHandler(this.actualizarDatosDeProductoToolStripMenuItem_Click);
            // 
            // eliminarProductoToolStripMenuItem
            // 
            this.eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            this.eliminarProductoToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.eliminarProductoToolStripMenuItem.Text = "Eliminar Producto";
            this.eliminarProductoToolStripMenuItem.Click += new System.EventHandler(this.eliminarProductoToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesDatosDeClientes,
            this.reportesDeProductosToolStripMenuItem});
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reportesDatosDeClientes
            // 
            this.reportesDatosDeClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MostrarTodosLosClientes,
            this.MostrarclientesDeudores,
            this.clientesFrecuentes});
            this.reportesDatosDeClientes.Name = "reportesDatosDeClientes";
            this.reportesDatosDeClientes.Size = new System.Drawing.Size(283, 26);
            this.reportesDatosDeClientes.Text = "Reporte Datos de Clientes";
            // 
            // MostrarTodosLosClientes
            // 
            this.MostrarTodosLosClientes.Name = "MostrarTodosLosClientes";
            this.MostrarTodosLosClientes.Size = new System.Drawing.Size(278, 26);
            this.MostrarTodosLosClientes.Text = "Mostrar todos los Clientes";
            this.MostrarTodosLosClientes.Click += new System.EventHandler(this.clientesDeudores_Click);
            // 
            // MostrarclientesDeudores
            // 
            this.MostrarclientesDeudores.Name = "MostrarclientesDeudores";
            this.MostrarclientesDeudores.Size = new System.Drawing.Size(278, 26);
            this.MostrarclientesDeudores.Text = "Clientes Deudores";
            this.MostrarclientesDeudores.Click += new System.EventHandler(this.MostrarclientesDeudores_Click);
            // 
            // clientesFrecuentes
            // 
            this.clientesFrecuentes.Name = "clientesFrecuentes";
            this.clientesFrecuentes.Size = new System.Drawing.Size(278, 26);
            this.clientesFrecuentes.Text = "Clientes Frecuentes";
            // 
            // reportesDeProductosToolStripMenuItem
            // 
            this.reportesDeProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MostrarTodoslosProductos,
            this.productosCaducados});
            this.reportesDeProductosToolStripMenuItem.Name = "reportesDeProductosToolStripMenuItem";
            this.reportesDeProductosToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.reportesDeProductosToolStripMenuItem.Text = "Reporte de Productos";
            // 
            // MostrarTodoslosProductos
            // 
            this.MostrarTodoslosProductos.Name = "MostrarTodoslosProductos";
            this.MostrarTodoslosProductos.Size = new System.Drawing.Size(294, 26);
            this.MostrarTodoslosProductos.Text = "Mostrar todos los Productos";
            this.MostrarTodoslosProductos.Click += new System.EventHandler(this.MostrarTodoslosProductos_Click);
            // 
            // productosCaducados
            // 
            this.productosCaducados.Name = "productosCaducados";
            this.productosCaducados.Size = new System.Drawing.Size(294, 26);
            this.productosCaducados.Text = "Productos Caducados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "BIENVENIDO ADMINISTRADOR!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(239, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // FECHA
            // 
            this.FECHA.Enabled = true;
            this.FECHA.Tick += new System.EventHandler(this.FECHA_Tick);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(26)))), ((int)(((byte)(53)))));
            this.lbl_fecha.Location = new System.Drawing.Point(330, 365);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(17, 40);
            this.lbl_fecha.TabIndex = 21;
            this.lbl_fecha.Text = "\r\n";
            // 
            // dataSetRestaurante1
            // 
            this.dataSetRestaurante1.DataSetName = "DataSetRestaurante";
            this.dataSetRestaurante1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(786, 427);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDatos";
            this.Load += new System.EventHandler(this.FormDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRestauranteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRestaurante)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRestaurante1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource dataSetRestauranteBindingSource;
        private DataSetRestaurante dataSetRestaurante;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeDatosDelClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarNuevoCliente;
        private System.Windows.Forms.ToolStripMenuItem actualizarDatosDelClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarDatosDeProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDatosDeClientes;
        private System.Windows.Forms.ToolStripMenuItem MostrarTodosLosClientes;
        private System.Windows.Forms.ToolStripMenuItem MostrarclientesDeudores;
        private System.Windows.Forms.ToolStripMenuItem clientesFrecuentes;
        private System.Windows.Forms.ToolStripMenuItem reportesDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MostrarTodoslosProductos;
        private System.Windows.Forms.ToolStripMenuItem productosCaducados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer FECHA;
        private System.Windows.Forms.Label lbl_fecha;
        private DataSetRestaurante dataSetRestaurante1;
    }
}