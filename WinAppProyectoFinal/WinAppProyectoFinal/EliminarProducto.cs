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
    public partial class EliminarProducto : Form
    {
        public EliminarProducto()
        {
            InitializeComponent();
            txt_CantidadElim.Enabled = false;
            txt_CategoElim.Enabled = false;
            txt_CodigoElim.Enabled = false;
            txt_ElaboracionElim.Enabled = false;
            txt_MarcaElim.Enabled = false;
            txt_NombreElim.Enabled = false;
            txt_PrecioElim.Enabled = false;
            txt_venceElim.Enabled = false;
            txt_MedidaEliminar.Enabled = false; 
        }

        private void btn_GuardarEliminar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btn_CancelarEliminar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
