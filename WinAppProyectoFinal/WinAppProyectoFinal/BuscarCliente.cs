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
    public partial class BuscarCliente : Form
    {
        public BuscarCliente()
        {
            InitializeComponent();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            dataSetRestaurante1.ReadXml("d:\\Programacion\\Proyectos C#\\PROYECTO ESPOCH\\ArchivosRestaurante.xml");
            System.Data.DataRow[] Vector_buscar;
            Vector_buscar = dataSetRestaurante1.TblDatosClientes.Select("Cedula= '" + txt_buscarCedula.Text + "'");
            
            if( Vector_buscar.Length >0)
            {
                this.Close();
                ModificarClienteDos Obj1 = new ModificarClienteDos();
                Obj1.txt_modificarCedula.Text = Vector_buscar[0]["Cedula"].ToString();
                Obj1.txt_ModificarNombre.Text = Vector_buscar[0]["Nombre"].ToString();
                Obj1.txt_ModificarApellido.Text = Vector_buscar[0]["Apellido"].ToString();
                Obj1.Cb_Sexo.SelectedItem = Vector_buscar[0]["Sexo"].ToString();
                Obj1.txt_ModificarEmail.Text = Vector_buscar[0]["Email"].ToString();
                Obj1.txt_ModicarDireccion.Text = Vector_buscar[0]["Direccion"].ToString();
                Obj1.txt_ModificarOcupacion.Text = Vector_buscar[0]["Ocupacion"].ToString();
                Obj1.txt_ModificarCelular.Text = Vector_buscar[0]["CelularTelefono"].ToString();


                if (Obj1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Vector_buscar[0]["Nombre"] = Obj1.txt_ModificarNombre.Text;
                    Vector_buscar[0]["Email"] = Obj1.txt_ModificarEmail.Text;
                    Vector_buscar[0]["Direccion"] = Obj1.txt_ModicarDireccion.Text;
                    Vector_buscar[0]["Ocupacion"] = Obj1.txt_ModificarOcupacion.Text;
                    Vector_buscar[0]["CelularTelefono"] = Obj1.txt_ModificarCelular.Text;
             
                    Vector_buscar[0].AcceptChanges();
                    dataSetRestaurante1.WriteXml("d:\\Programacion\\Proyectos C#\\PROYECTO ESPOCH\\ArchivosRestaurante.xml");
                }
            }
            else
            {
                MessageBox.Show("Usuario no Encontrado!","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void txt_buscarCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e).KeyChar == (char)Keys.Enter)
            {
                btn_Buscar.Focus();
            }
        }
    }
}
