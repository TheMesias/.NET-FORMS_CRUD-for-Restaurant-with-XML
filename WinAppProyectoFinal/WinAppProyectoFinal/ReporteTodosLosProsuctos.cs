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
    public partial class ReporteTodosLosProductos : Form
    {
        public ReporteTodosLosProductos()
        {
            InitializeComponent();
            DataSetRestaurante.ReadXml("d:\\Programacion\\Proyectos C#\\PROYECTO ESPOCH\\ArchivosRestauranteProductos.xml");
        }

        private void ReporteTodosLosProductos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
