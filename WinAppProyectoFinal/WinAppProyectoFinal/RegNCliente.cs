using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace WinAppProyectoFinal
{
    public partial class RegNCliente : Form
    {
        ClValidacion validaEntrada = new ClValidacion();
        string cedula, nombre, apellido, celular, ocupacion, email, direccion, sexo;

        private void txt_OcupacionUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaEntrada.SoloLetras(e);
            if ((e).KeyChar == (char)Keys.Enter)
            {
                try
                {
                    ocupacion = txt_OcupacionUsuario.Text;
                    txt_emailUsuario.Enabled = true;
                    txt_emailUsuario.Focus();
                }
                catch
                {
                    MessageBox.Show("Caracter Invalido", "Error Ocupacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_OcupacionUsuario.Clear();
                }
            }
        }

        private void txt_emailUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e).KeyChar == (char)Keys.Enter)
            {
                try
                {
                    email = txt_emailUsuario.Text;
                    txt_DireccionUsuario.Enabled = true;
                    txt_DireccionUsuario.Focus(); 
                }
                catch 
                {
                    MessageBox.Show("Caracter Invalido", "Error Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_emailUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_DireccionUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e).KeyChar == (char)Keys.Enter)
            {
                try
                {
                    direccion = txt_DireccionUsuario.Text;
                    CB_Sexo.Enabled = true;
                    CB_Sexo.Focus();
                    btn_guardar.Enabled = true; 
                }
                catch
                {
                    MessageBox.Show("Caracter Invalido", "Error Direccion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        
        private void txt_NombreUsuario_Validated(object sender, EventArgs e)
        {
            if(txt_NombreUsuario.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_NombreUsuario, "Introdusca un nombre!");
                txt_NombreUsuario.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txt_ApellidoUsuario_Validated(object sender, EventArgs e)
        {
            if (txt_ApellidoUsuario.Text.Trim() == "")
            {
                errorProvider2.SetError(txt_ApellidoUsuario, "Introdusca un apellido!");
                txt_ApellidoUsuario.Focus();
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void txt_emailUsuario_Validated(object sender, EventArgs e)
        {
            if (txt_emailUsuario.Text.Trim() == "")
            {
                errorProvider4.SetError(txt_emailUsuario, "Introdusca un email!");
                txt_emailUsuario.Focus();
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void txt_DireccionUsuario_Validated(object sender, EventArgs e)
        {
            if (txt_DireccionUsuario.Text.Trim() == "")
            {
                errorProvider5.SetError(txt_DireccionUsuario, "Introdusca una Direccion!");
                txt_DireccionUsuario.Focus();
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void txt_OcupacionUsuario_Validated(object sender, EventArgs e)
        {
            if (txt_OcupacionUsuario.Text.Trim() == "")
            {
                errorProvider3.SetError(txt_OcupacionUsuario, "Introdusca una Ocupacion!");
                txt_OcupacionUsuario.Focus();
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_CelularUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaEntrada.SoloNumeros(e);
            if ((e).KeyChar == (char)Keys.Enter)
            {
                try
                {
                    if (txt_CelularUsuario.TextLength == 10)
                    {
                        celular = txt_CelularUsuario.Text;
                        txt_OcupacionUsuario.Enabled = true;
                        txt_OcupacionUsuario.Focus();
                    }
                    else
                    {
                        MessageBox.Show("El numero de caracteres es invalido Ejm:0999955555", "Error Cedular", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_CelularUsuario.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Caracter Invalido", "Error Celular", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_CelularUsuario.Clear(); 
                }

                
            }
        }

        private void txt_ApellidoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaEntrada.SoloLetras(e);
            if ((e).KeyChar == (char)Keys.Enter)
            {
                try
                {
                    apellido = txt_ApellidoUsuario.Text;
                    txt_CelularUsuario.Enabled = true;
                    txt_CelularUsuario.Focus();
                }
                catch
                {
                    MessageBox.Show("Caracter Invalido", "Error Apellido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_ApellidoUsuario.Clear(); 
                }
            }
        }

        private void txt_NombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaEntrada.SoloLetras(e); 
            if ((e).KeyChar == (char)Keys.Enter)
            {
                try 
                {
                   
                    nombre = txt_NombreUsuario.Text;
                    if (txt_NombreUsuario.Text != null)
                    {
                        txt_ApellidoUsuario.Enabled = true;
                        txt_ApellidoUsuario.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Caracter Invalido", "Error Nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } 
                catch 
                {
                    MessageBox.Show("Caracter Invalido", "Error Nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_NombreUsuario.Clear(); 
                }  
            }

        }

        public RegNCliente()
        {
            InitializeComponent();

            txt_ApellidoUsuario.Enabled = false;
            txt_DireccionUsuario.Enabled = false;
            txt_emailUsuario.Enabled = false;
            txt_NombreUsuario.Enabled = false;
            txt_OcupacionUsuario.Enabled = false;
            CB_Sexo.Enabled = false;
            txt_CelularUsuario.Enabled = false;
            btn_guardar.Enabled = false;
                
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            dataSetRestaurante1.TblDatosClientes.ReadXml("d:\\Programacion\\Proyectos C#\\PROYECTO ESPOCH\\ArchivosRestaurante.xml");
            //dataSetRestaurante1.ReadXml(Application.StartupPath + "\\ArchivodeDatos.xml");
            Object[] Vector1 = new Object[9];

            Vector1[0] = txt_CedulaUsuario.Text;
            Vector1[1] = txt_NombreUsuario.Text;
            Vector1[2] = txt_ApellidoUsuario.Text;
            Vector1[3] = CB_Sexo.SelectedItem;
            Vector1[4] = txt_emailUsuario.Text;
            Vector1[5] = txt_DireccionUsuario.Text;
            Vector1[6] = txt_OcupacionUsuario.Text;
            Vector1[7] = txt_CelularUsuario.Text;

            ComprasCliente obj1 = new ComprasCliente();
            obj1.ShowDialog();
            Vector1[8] = obj1.lblConsumoTotal.Text;
            
           
           
           

            dataSetRestaurante1.TblDatosClientes.Rows.Add(Vector1);
            dataSetRestaurante1.TblDatosClientes.WriteXml("d:\\Programacion\\Proyectos C#\\PROYECTO ESPOCH\\ArchivosRestaurante.xml");
            //dataSetRestaurante1.WriteXml(Application.StartupPath + "\\ArchivodeDatos.xml");

            MessageBox.Show("Guardado con Exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); 
        }

        private void txt_CedulaUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaEntrada.SoloNumeros(e);
            if ((e).KeyChar == (char)Keys.Enter)
            {
                try 
                {
                    if(txt_CedulaUsuario.TextLength == 10)
                    {
                        cedula = txt_CedulaUsuario.Text;
                        txt_NombreUsuario.Enabled = true;
                        txt_NombreUsuario.Focus();
                    }
                    else
                    {
                        MessageBox.Show("El numero de caracteres es invalido Ejm:1159847645", "Error Cedula", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_CedulaUsuario.Clear(); 
                    }
                } 
                catch 
                {
                    MessageBox.Show("Caracter Invalido", "Error Celular", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
    }
}
