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
    public partial class ModificarClienteDos : Form
    {
        public ModificarClienteDos()
        {
            InitializeComponent();
            txt_modificarCedula.Enabled = false;
            txt_ModificarApellido.Enabled = false;
            Cb_Sexo.Enabled = false; 
        }

        private void button1_Click(object sender, EventArgs e)
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
