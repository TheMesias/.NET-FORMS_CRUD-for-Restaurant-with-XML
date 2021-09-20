using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppProyectoFinal
{
    public partial class BuscarEliminar : Form
    {
        public BuscarEliminar()
        {
            InitializeComponent();
        }

        private void btn_BuscarEliminar_Click(object sender, EventArgs e)
        {
            dataSetRestaurante1.ReadXml("d:\\Programacion\\Proyectos C#\\PROYECTO ESPOCH\\ArchivosRestaurante.xml");
            System.Data.DataRow[] VectorEliminar;
            VectorEliminar = dataSetRestaurante1.TblDatosClientes.Select("Cedula= '" + txt_buscarCedula.Text + "'");

            if(VectorEliminar.Length > 0)
            {
                this.Close();
                EliminarCliente ObjEliminarCliente = new EliminarCliente();
                ObjEliminarCliente.txt_EliminarCedula.Text = VectorEliminar[0]["Cedula"].ToString();
                ObjEliminarCliente.txt_EliminarNombre.Text = VectorEliminar[0]["Nombre"].ToString();
                ObjEliminarCliente.txt_EliminarApellido.Text = VectorEliminar[0]["Apellido"].ToString();
                ObjEliminarCliente.Cb_Sexo.Text = VectorEliminar[0]["Sexo"].ToString();
                ObjEliminarCliente.txt_EliminarEmail.Text = VectorEliminar[0]["Email"].ToString();
                ObjEliminarCliente.txt_EliminarDireccion.Text = VectorEliminar[0]["Direccion"].ToString();
                ObjEliminarCliente.txt_EliminarOcupacion.Text = VectorEliminar[0]["Ocupacion"].ToString();
                ObjEliminarCliente.txt_EliminarCelular.Text = VectorEliminar[0]["CelularTelefono"].ToString(); 


                if(ObjEliminarCliente.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    VectorEliminar[0].Delete();
                    dataSetRestaurante1.WriteXml("d:\\Programacion\\Proyectos C#\\PROYECTO ESPOCH\\ArchivosRestaurante.xml");
                    MessageBox.Show("Cliente Eliminado", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Cliente no encontrado!", "Error Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_buscarCedula.Clear(); 
            }


        }

        private void txt_buscarCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e).KeyChar == (char)Keys.Enter)
            {

                btn_BuscarEliminar.Focus(); 
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
