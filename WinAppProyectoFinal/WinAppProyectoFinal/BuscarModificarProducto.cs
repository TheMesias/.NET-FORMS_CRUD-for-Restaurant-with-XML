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
    public partial class BuscarModificarProducto : Form
    {
        public BuscarModificarProducto()
        {
            InitializeComponent();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            dataSetRestaurante1.TblProductos.ReadXml("d:\\Programacion\\Proyectos C#\\PROYECTO ESPOCH\\ArchivosRestauranteProductos.xml");
            System.Data.DataRow[] VectorProBuscar;
            VectorProBuscar = dataSetRestaurante1.TblProductos.Select("Codigo= '" + txt_CodigoProducto.Text + "'");
            if(VectorProBuscar.Length > 0)
            {
                this.Close(); 
                ModificarProducto ObjModificar = new ModificarProducto();
                ObjModificar.txt_CodProducto.Text = VectorProBuscar[0]["Codigo"].ToString();
                ObjModificar.txt_NomProducto.Text = VectorProBuscar[0]["Nombre"].ToString();
                ObjModificar.txt_PrecioProduc.Text = VectorProBuscar[0]["Precio"].ToString();
                ObjModificar.txt_ElaboradProduct.Text = VectorProBuscar[0]["FechaElaboracion"].ToString();
                ObjModificar.txt_VenceProduct.Text = VectorProBuscar[0]["FechaVencimiento"].ToString();
                ObjModificar.txt_CategoriaProduct.Text = VectorProBuscar[0]["Categoria"].ToString();
                ObjModificar.txt_CantidadProduct.Text = VectorProBuscar[0]["Cantidad"].ToString();
                ObjModificar.txt_MarcaProducto.Text = VectorProBuscar[0]["Marca"].ToString();
                ObjModificar.txt_Medida.Text = VectorProBuscar[0]["Medida"].ToString(); 

                if (ObjModificar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    VectorProBuscar[0]["Precio"] = ObjModificar.txt_PrecioProduc.Text;
                    VectorProBuscar[0]["Cantidad"] = ObjModificar.txt_CantidadProduct.Text;
                    VectorProBuscar[0]["FechaElaboracion"] = ObjModificar.txt_ElaboradProduct.Text;
                    VectorProBuscar[0]["FechaVencimiento"] = ObjModificar.txt_VenceProduct.Text;
                    VectorProBuscar[0].AcceptChanges();
                    dataSetRestaurante1.TblProductos.WriteXml("d:\\Programacion\\Proyectos C#\\PROYECTO ESPOCH\\ArchivosRestauranteProductos.xml");
                }
            }
            else
            {
                MessageBox.Show("Producto no Encontrado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_CodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e).KeyChar == (char)Keys.Enter)
            {
                btn_Buscar.Focus(); 
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
