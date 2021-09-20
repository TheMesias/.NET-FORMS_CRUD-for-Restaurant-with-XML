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
    public partial class RegistrarProducto : Form
    {
        ClValidacion validar = new ClValidacion(); 
        public RegistrarProducto()
        {
            InitializeComponent();

            Txt_CodigoProd.Focus();

            
            Txt_NombreProd.Enabled = false;
            Txt_MarcaProd.Enabled = false;
            Txt_PrecioProd.Enabled = false;
            Txt_CategoProd.Enabled = false;
            Txt_CantidadPod.Enabled = false;
            MskTxtBxElaborado.Enabled = false;
            MskTxtBxVence.Enabled = false;
            comboBox1.Enabled = false;
            BtnGuadarProd.Enabled = false; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string CodigProd;
        string NombreProd;
        string MarcaProd;
        string CategoriaProd;
        double Precio;
        int CantProd;
        string FecElabPro;
        string FecVenPro;

        private void Txt_CodigoProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    CodigProd = Txt_CodigoProd.Text;
                    Txt_NombreProd.Enabled = true;
                    Txt_NombreProd.Focus();
                }
                catch
                {
                    MessageBox.Show("Caracter Inválido", "Error Código", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txt_CodigoProd.Clear();
                }
            }
        }

        private void Txt_NombreProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    NombreProd = Txt_NombreProd.Text;
                    Txt_MarcaProd.Enabled = true;
                    Txt_MarcaProd.Focus();
                }
                catch
                {
                    MessageBox.Show("Caracter Inválido", "Error Nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txt_NombreProd.Clear();
                }
            }
          
        }

        private void Txt_MarcaProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    MarcaProd = Txt_MarcaProd.Text;
                    Txt_PrecioProd.Enabled = true;
                    Txt_PrecioProd.Focus();
                }
                catch
                {
                    MessageBox.Show("Caracter Inválido", "Error Marca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txt_MarcaProd.Clear();
                }
            }
        }

        private void Txt_PrecioProd_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    Precio = double.Parse(Txt_PrecioProd.Text);
                    if ((Precio > 0))
                    {
                        Txt_CategoProd.Enabled = true;
                        Txt_CategoProd.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Precio inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Txt_CategoProd.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Caracter Inválido", "Error Precio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txt_PrecioProd.Clear();
                }
            }
        }

        private void RegistrarProducto_Load(object sender, EventArgs e)
        {

        }

        private void Txt_CategoProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    CategoriaProd = Txt_CategoProd.Text;
                    Txt_CantidadPod.Enabled = true;
                    Txt_CantidadPod.Focus();
                }
                catch
                {
                    MessageBox.Show("Caracter Inválido", "Error Categoria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txt_CategoProd.Clear();
                }
            }
        }

        private void Txt_CantidadPod_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    CantProd = int.Parse(Txt_CantidadPod.Text);
                    if (CantProd > 0)
                    {
                        comboBox1.Enabled = true; 
                        MskTxtBxElaborado.Enabled = true;
                        MskTxtBxElaborado.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Cántidad Inválida\nNOTA: Debe ingresar más de uno", "Error Cantidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Txt_CantidadPod.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Caracter Inválido", "Error Cantidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txt_CantidadPod.Clear();
                }
            }
        }

        private void MskTxtBxElaborado_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    FecElabPro = MskTxtBxElaborado.Text;
                    MskTxtBxVence.Enabled = true;
                    MskTxtBxVence.Focus();
                }
                catch
                {
                    MessageBox.Show("Dato Inválido", "Error Fecha de elaboación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MskTxtBxElaborado.Clear();
                }
            }
        }

        private void MskTxtBxVence_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    FecVenPro = MskTxtBxVence.Text;
                    BtnGuadarProd.Enabled = true; 
                    //BtnGuadarProd.PerformClick();
                }
                catch
                {
                    MessageBox.Show("Dato Inválido", "Error Fecha de vencimiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MskTxtBxVence.Clear();
                }
            }
        }

        private void BtnGuadarProd_Click(object sender, EventArgs e)
        {
            dataSetRestaurante1.TblProductos.ReadXml("d:\\Programacion\\Proyectos C#\\PROYECTO ESPOCH\\ArchivosRestauranteProductos.xml");
            object[] vectorP = new object[9];
            vectorP[0] = Txt_CodigoProd.Text;
            vectorP[1] = Txt_NombreProd.Text;
            vectorP[2] = double.Parse(Txt_PrecioProd.Text);
            vectorP[3] = MskTxtBxElaborado.Text;
            vectorP[4] = MskTxtBxVence.Text;
            vectorP[5] = Txt_CategoProd.Text;
            vectorP[6] = int.Parse(Txt_CantidadPod.Text);
            vectorP[7] = Txt_MarcaProd.Text;
            vectorP[8] = comboBox1.SelectedItem;
            dataSetRestaurante1.TblProductos.Rows.Add(vectorP);
            dataSetRestaurante1.TblProductos.WriteXml("d:\\Programacion\\Proyectos C#\\PROYECTO ESPOCH\\ArchivosRestauranteProductos.xml");
            MessageBox.Show("Guardado con Exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Txt_NombreProd_Validated(object sender, EventArgs e)
        {
            if (Txt_NombreProd.Text.Trim() == "")
            {
                errorProvider1.SetError(Txt_NombreProd, "Introduce Nombre");
                Txt_NombreProd.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void Txt_MarcaProd_Validated(object sender, EventArgs e)
        {
            if (Txt_MarcaProd.Text.Trim() == "")
            {
                errorProvider2.SetError(Txt_MarcaProd, "Introduce Marca");
                Txt_MarcaProd.Focus();
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void Txt_PrecioProd_Validated(object sender, EventArgs e)
        {
            if (Txt_PrecioProd.Text.Trim() == "")
            {
                errorProvider3.SetError(Txt_PrecioProd, "Introduce Precio");
                Txt_PrecioProd.Focus();
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void Txt_CategoProd_Validated(object sender, EventArgs e)
        {
           
        }

        private void Txt_CantidadPod_Validated(object sender, EventArgs e)
        {
            
        }

        private void Txt_CategoProd_Validated_1(object sender, EventArgs e)
        {
            if (Txt_CategoProd.Text.Trim() == "")
            {
                errorProvider5.SetError(Txt_CategoProd, "Introduce Categoria");
                Txt_CategoProd.Focus();
            }
            else
            {
                errorProvider5.Clear();
            }

        }

        private void Txt_CantidadPod_Validated_1(object sender, EventArgs e)
        {

        }

        private void MskTxtBxElaborado_Validated(object sender, EventArgs e)
        {
            if (MskTxtBxElaborado.Text.Trim() == "")
            {
                errorProvider6.SetError(MskTxtBxElaborado, "Introduce Fecha");
                MskTxtBxElaborado.Focus();
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void MskTxtBxVence_Validated(object sender, EventArgs e)
        {
            if (MskTxtBxVence.Text.Trim() == "")
            {
                errorProvider7.SetError(MskTxtBxVence, "Introduce Fecha");
                MskTxtBxVence.Focus();
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void Txt_CodigoProd_Validated(object sender, EventArgs e)
        {
            if (Txt_CodigoProd.Text.Trim() == "")
            {
                errorProvider8.SetError(Txt_CodigoProd, "Introduce codigo");
                Txt_CodigoProd.Focus();
            }
            else
            {
                errorProvider8.Clear();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
