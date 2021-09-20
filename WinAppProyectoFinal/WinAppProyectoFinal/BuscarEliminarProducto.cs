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
    public partial class BuscarEliminarProducto : Form
    {
        public BuscarEliminarProducto()
        {
            InitializeComponent();
        }

        private void btn_BuscarEliminar_Click(object sender, EventArgs e)
        {
            dataSetRestaurante1.ReadXml("d:\\Programacion\\Proyectos C#\\PROYECTO ESPOCH\\ArchivosRestauranteProductos.xml");
            System.Data.DataRow[] Vect_EliminarProducto;
            Vect_EliminarProducto = dataSetRestaurante1.TblProductos.Select("Codigo= '" + txt_ElimBuscarProducto.Text + "'"); 

            if(Vect_EliminarProducto.Length > 0)
            {
                this.Close();
                EliminarProducto ObjEliminarProducto = new EliminarProducto();
                ObjEliminarProducto.txt_CodigoElim.Text = Vect_EliminarProducto[0]["Codigo"].ToString();
                ObjEliminarProducto.txt_NombreElim.Text = Vect_EliminarProducto[0]["Nombre"].ToString();
                ObjEliminarProducto.txt_PrecioElim.Text = Vect_EliminarProducto[0]["Precio"].ToString();
                ObjEliminarProducto.txt_ElaboracionElim.Text = Vect_EliminarProducto[0]["FechaElaboracion"].ToString();
                ObjEliminarProducto.txt_venceElim.Text = Vect_EliminarProducto[0]["FechaVencimiento"].ToString();
                ObjEliminarProducto.txt_CategoElim.Text = Vect_EliminarProducto[0]["Categoria"].ToString();
                ObjEliminarProducto.txt_CantidadElim.Text = Vect_EliminarProducto[0]["Cantidad"].ToString();
                ObjEliminarProducto.txt_MarcaElim.Text = Vect_EliminarProducto[0]["Marca"].ToString();
                ObjEliminarProducto.txt_MedidaEliminar.Text = Vect_EliminarProducto[0]["Medida"].ToString(); 

                //ObjEliminarProducto.ShowDialog();
                
                if(ObjEliminarProducto.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Vect_EliminarProducto[0].Delete();
                    dataSetRestaurante1.WriteXml("d:\\Programacion\\Proyectos C#\\PROYECTO ESPOCH\\ArchivosRestauranteProductos.xml");
                    MessageBox.Show("Producto Eliminado con Éxito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Producto no Encontrado", "Error Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ElimBuscarProducto.Clear(); 
            }


        }

        private void txt_ElimBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e).KeyChar == (char)Keys.Enter)
            {
                btn_BuscarEliminar.Focus(); 
            }
        }
    }
}
