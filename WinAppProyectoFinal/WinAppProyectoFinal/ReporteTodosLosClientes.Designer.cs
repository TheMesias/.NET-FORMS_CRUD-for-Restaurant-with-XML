namespace WinAppProyectoFinal
{
    partial class ReporteTodosLosClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TblDatosClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetRestaurante = new WinAppProyectoFinal.DataSetRestaurante();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.TblDatosClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetRestaurante)).BeginInit();
            this.SuspendLayout();
            // 
            // TblDatosClientesBindingSource
            // 
            this.TblDatosClientesBindingSource.DataMember = "TblDatosClientes";
            this.TblDatosClientesBindingSource.DataSource = this.DataSetRestaurante;
            // 
            // DataSetRestaurante
            // 
            this.DataSetRestaurante.DataSetName = "DataSetRestaurante";
            this.DataSetRestaurante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TblDatosClientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WinAppProyectoFinal.Prueba.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(866, 542);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReporteTodosLosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 541);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReporteTodosLosClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteTodosLosClientes";
            this.Load += new System.EventHandler(this.ReporteTodosLosClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TblDatosClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetRestaurante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource TblDatosClientesBindingSource;
        private DataSetRestaurante DataSetRestaurante;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}