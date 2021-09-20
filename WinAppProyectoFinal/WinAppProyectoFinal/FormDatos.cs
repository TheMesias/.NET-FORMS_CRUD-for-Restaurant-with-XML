using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppProyectoFinal
{
    public partial class FormDatos : Form
    {
        public FormDatos()
        {
            InitializeComponent();
        }

        private void ingresarAlSistema_Click(object sender, EventArgs e)
        {
            Login ObjLogin = new Login();
            ObjLogin.Show(); 
        }

        private void FormDatos_Load(object sender, EventArgs e)
        {
            if(File.Exists("d:\\Programacion\\Proyectos C#\\PROYECTO ESPOCH\\ArchivosRestaurante.xml"))
            {
                dataSetRestaurante1.ReadXml("d:\\Programacion\\Proyectos C#\\PROYECTO ESPOCH\\ArchivosRestaurante.xml");
            }
            else
            {
                dataSetRestaurante1.WriteXml("d:\\Programacion\\Proyectos C#\\PROYECTO ESPOCH\\ArchivosRestaurante.xml");
            }
            if(File.Exists("d:\\Programacion\\Proyectos C#\\PROYECTO ESPOCH\\ArchivosRestauranteProductos.xml"))
            {
                dataSetRestaurante1.ReadXml("d:\\Programacion\\Proyectos C#\\PROYECTO ESPOCH\\ArchivosRestauranteProductos.xml");
            }
            else
            {
                dataSetRestaurante.WriteXml("d:\\Programacion\\Proyectos C#\\PROYECTO ESPOCH\\ArchivosRestauranteProductos.xml"); 
            }
        }

        private void FECHA_Tick(object sender, EventArgs e)
        {
            lbl_fecha.Text = DateTime.Now.ToLongTimeString(); 
        }

        private void ingresarNuevoCliente_Click(object sender, EventArgs e)
        {
            RegNCliente ObjRegistrarCliente = new RegNCliente();
            ObjRegistrarCliente.Show(); 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close(); 
            
        }

        private void actualizarDatosDelClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarCliente ObjBuscar = new BuscarCliente();
            ObjBuscar.Show(); 
        }

        private void clientesDeudores_Click(object sender, EventArgs e)
        {
            ReporteTodosLosClientes ObjReporteClientes = new ReporteTodosLosClientes();
            ObjReporteClientes.Show(); 
        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarEliminar ObjEliminar = new BuscarEliminar();
            ObjEliminar.Show(); 
        }

        private void ingresarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarProducto ObjRegistrar = new RegistrarProducto();
            ObjRegistrar.Show(); 
        }

        private void actualizarDatosDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarModificarProducto ObjModificar = new BuscarModificarProducto();
            ObjModificar.Show(); 
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarEliminarProducto ObjEliminarProducto = new BuscarEliminarProducto();
            ObjEliminarProducto.Show(); 
        }

        private void MostrarclientesDeudores_Click(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MostrarTodoslosProductos_Click(object sender, EventArgs e)
        {
            ReporteTodosLosProductos ObjReporteProductos = new ReporteTodosLosProductos();
            ObjReporteProductos.Show(); 
        }

        private void ingresoDeDatosDelClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
