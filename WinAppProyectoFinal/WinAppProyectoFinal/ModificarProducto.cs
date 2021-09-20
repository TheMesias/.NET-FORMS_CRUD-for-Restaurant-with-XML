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
    public partial class ModificarProducto : Form
    {
        public ModificarProducto()
        {
            
            InitializeComponent();
            txt_CodProducto.Enabled = false;
            txt_NomProducto.Enabled = false;
            txt_CategoriaProduct.Enabled = false;
            txt_MarcaProducto.Enabled = false;
            txt_Medida.Enabled = false; 
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
