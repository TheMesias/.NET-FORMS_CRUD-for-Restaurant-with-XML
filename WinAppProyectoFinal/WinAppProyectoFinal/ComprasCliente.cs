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
    public partial class ComprasCliente : Form
    {
        
        public ComprasCliente()
        {
            InitializeComponent();
            cb_PapiPollo.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Hamburguesa.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Salchipapa.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_PolloEntero.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_MedioPollo.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_unoCPollo.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Consome.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_PorcionPapas.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_PapiCarne.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Agua.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Jugos.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_ColaPersonal.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Cola1lt.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Cola2lt.DropDownStyle = ComboBoxStyle.DropDownList; 
            cb_Cola3lt.DropDownStyle = ComboBoxStyle.DropDownList; 
            cb_cerveza.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btn_Listo_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_ListoBebidas_Click(object sender, EventArgs e)
        {
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btn_Sumar_Click(object sender, EventArgs e)
        {
            double TotalComprasCliente = 0;
            double PapiPollo = 0, Hamburguesa = 0, Salchipapa = 0, PolloEntero = 0, MedioPollo = 0, CuartoPollo = 0, Consome = 0, PorcionPapas = 0, PapiCarne = 0;
            double Agua = 0, Jugos = 0, CPersonal = 0, CunLt = 0, CdosLt = 0, Ctreslt = 0, Cerveza = 0;

            PapiPollo = Math.Round(Convert.ToInt32(cb_PapiPollo.SelectedItem) * 2.5, 2);
            Hamburguesa = Math.Round(Convert.ToInt32(cb_Hamburguesa.SelectedItem) * 1.5, 2);
            Salchipapa = Math.Round(Convert.ToInt32(cb_Salchipapa.SelectedItem) * 1.5, 2);
            PolloEntero = Math.Round(Convert.ToInt32(cb_PolloEntero.SelectedItem) * 13.99, 2);
            MedioPollo = Math.Round(Convert.ToInt32(cb_MedioPollo.SelectedItem) * 8.0, 2);
            CuartoPollo = Math.Round(Convert.ToInt32(cb_unoCPollo.SelectedItem) * 2.75, 2);
            Consome = Math.Round(Convert.ToInt32(cb_Consome.SelectedItem) * 1.5, 2);
            PorcionPapas = Math.Round(Convert.ToInt32(cb_PorcionPapas.SelectedItem) * 1.0, 2);
            PapiCarne = Math.Round(Convert.ToInt32(cb_PapiCarne.SelectedItem) * 1.75, 2);

            Agua = Math.Round(Convert.ToInt32(cb_Agua.SelectedItem) * 0.75, 2);
            Jugos = Math.Round(Convert.ToInt32(cb_Jugos.SelectedItem) * 0.75, 2);
            CPersonal = Math.Round(Convert.ToInt32(cb_ColaPersonal.SelectedItem) * 0.75, 2);
            CunLt = Math.Round(Convert.ToInt32(cb_Cola1lt.SelectedItem) * 1.50, 2);
            CdosLt = Math.Round(Convert.ToInt32(cb_Cola2lt.SelectedItem) * 2.25, 2);
            Ctreslt = Math.Round(Convert.ToInt32(cb_Cola3lt.SelectedItem) * 3.00, 2);
            Cerveza = Math.Round(Convert.ToInt32(cb_cerveza.SelectedItem) * 1.35, 2);

            TotalComprasCliente = PapiPollo + Hamburguesa + Salchipapa + PolloEntero + MedioPollo + CuartoPollo + Consome + PorcionPapas + PapiCarne
                + Agua + Jugos + CPersonal + CunLt + CdosLt + Ctreslt + Cerveza;

            lblConsumoTotal.Text = TotalComprasCliente.ToString();
        }
    }
}
