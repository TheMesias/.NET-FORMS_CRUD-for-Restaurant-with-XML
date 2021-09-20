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
    public partial class EliminarCliente : Form
    {
        public EliminarCliente()
        {
            InitializeComponent();
            txt_EliminarCedula.Enabled = false;
            txt_EliminarApellido.Enabled = false;
            txt_EliminarCelular.Enabled = false;
            txt_EliminarDireccion.Enabled = false;
            txt_EliminarEmail.Enabled = false;
            txt_EliminarNombre.Enabled = false;
            txt_EliminarOcupacion.Enabled = false;
            Cb_Sexo.Enabled = false; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Elim_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
