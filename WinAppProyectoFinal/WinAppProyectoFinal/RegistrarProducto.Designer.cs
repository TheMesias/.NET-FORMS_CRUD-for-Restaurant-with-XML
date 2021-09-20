namespace WinAppProyectoFinal
{
    partial class RegistrarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarProducto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Txt_CategoProd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Txt_NombreProd = new System.Windows.Forms.TextBox();
            this.Txt_CodigoProd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_CantidadPod = new System.Windows.Forms.TextBox();
            this.Txt_MarcaProd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_PrecioProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCancelarProd = new System.Windows.Forms.Button();
            this.BtnGuadarProd = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MskTxtBxElaborado = new System.Windows.Forms.MaskedTextBox();
            this.MskTxtBxVence = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider8 = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataSetRestaurante1 = new WinAppProyectoFinal.DataSetRestaurante();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRestaurante1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(26)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 64);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "REGISTRAR PRODUCTO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(668, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Txt_CategoProd
            // 
            this.Txt_CategoProd.Location = new System.Drawing.Point(479, 179);
            this.Txt_CategoProd.Name = "Txt_CategoProd";
            this.Txt_CategoProd.Size = new System.Drawing.Size(184, 22);
            this.Txt_CategoProd.TabIndex = 5;
            this.Txt_CategoProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_CategoProd_KeyPress);
            this.Txt_CategoProd.Validated += new System.EventHandler(this.Txt_CategoProd_Validated_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(358, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 20);
            this.label12.TabIndex = 38;
            this.label12.Text = "CATEGORIA: ";
            // 
            // Txt_NombreProd
            // 
            this.Txt_NombreProd.Location = new System.Drawing.Point(128, 222);
            this.Txt_NombreProd.Name = "Txt_NombreProd";
            this.Txt_NombreProd.Size = new System.Drawing.Size(184, 22);
            this.Txt_NombreProd.TabIndex = 2;
            this.Txt_NombreProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_NombreProd_KeyPress);
            this.Txt_NombreProd.Validated += new System.EventHandler(this.Txt_NombreProd_Validated);
            // 
            // Txt_CodigoProd
            // 
            this.Txt_CodigoProd.Location = new System.Drawing.Point(128, 181);
            this.Txt_CodigoProd.Name = "Txt_CodigoProd";
            this.Txt_CodigoProd.Size = new System.Drawing.Size(184, 22);
            this.Txt_CodigoProd.TabIndex = 1;
            this.Txt_CodigoProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_CodigoProd_KeyPress);
            this.Txt_CodigoProd.Validated += new System.EventHandler(this.Txt_CodigoProd_Validated);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "NOMBRE: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "CÓDIGO: ";
            // 
            // Txt_CantidadPod
            // 
            this.Txt_CantidadPod.Location = new System.Drawing.Point(479, 221);
            this.Txt_CantidadPod.Name = "Txt_CantidadPod";
            this.Txt_CantidadPod.Size = new System.Drawing.Size(118, 22);
            this.Txt_CantidadPod.TabIndex = 6;
            this.Txt_CantidadPod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_CantidadPod_KeyPress);
            this.Txt_CantidadPod.Validated += new System.EventHandler(this.Txt_CantidadPod_Validated_1);
            // 
            // Txt_MarcaProd
            // 
            this.Txt_MarcaProd.Location = new System.Drawing.Point(128, 259);
            this.Txt_MarcaProd.Name = "Txt_MarcaProd";
            this.Txt_MarcaProd.Size = new System.Drawing.Size(184, 22);
            this.Txt_MarcaProd.TabIndex = 3;
            this.Txt_MarcaProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_MarcaProd_KeyPress);
            this.Txt_MarcaProd.Validated += new System.EventHandler(this.Txt_MarcaProd_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(353, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "ELABORADO: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(368, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "CANTIDAD: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "MARCA:";
            // 
            // Txt_PrecioProd
            // 
            this.Txt_PrecioProd.Location = new System.Drawing.Point(128, 299);
            this.Txt_PrecioProd.Name = "Txt_PrecioProd";
            this.Txt_PrecioProd.Size = new System.Drawing.Size(184, 22);
            this.Txt_PrecioProd.TabIndex = 4;
            this.Txt_PrecioProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_PrecioProd_KeyPress);
            this.Txt_PrecioProd.Validated += new System.EventHandler(this.Txt_PrecioProd_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "PRECIO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(395, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "VENCE: ";
            // 
            // BtnCancelarProd
            // 
            this.BtnCancelarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(35)))));
            this.BtnCancelarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarProd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarProd.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelarProd.Location = new System.Drawing.Point(536, 362);
            this.BtnCancelarProd.Name = "BtnCancelarProd";
            this.BtnCancelarProd.Size = new System.Drawing.Size(127, 32);
            this.BtnCancelarProd.TabIndex = 10;
            this.BtnCancelarProd.Text = "CANCELAR";
            this.BtnCancelarProd.UseVisualStyleBackColor = false;
            this.BtnCancelarProd.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnGuadarProd
            // 
            this.BtnGuadarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(35)))));
            this.BtnGuadarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuadarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuadarProd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuadarProd.ForeColor = System.Drawing.Color.Black;
            this.BtnGuadarProd.Location = new System.Drawing.Point(399, 362);
            this.BtnGuadarProd.Name = "BtnGuadarProd";
            this.BtnGuadarProd.Size = new System.Drawing.Size(127, 32);
            this.BtnGuadarProd.TabIndex = 9;
            this.BtnGuadarProd.Text = "GUARDAR";
            this.BtnGuadarProd.UseVisualStyleBackColor = false;
            this.BtnGuadarProd.Click += new System.EventHandler(this.BtnGuadarProd_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(318, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // MskTxtBxElaborado
            // 
            this.MskTxtBxElaborado.Location = new System.Drawing.Point(479, 261);
            this.MskTxtBxElaborado.Mask = "00/00/0000";
            this.MskTxtBxElaborado.Name = "MskTxtBxElaborado";
            this.MskTxtBxElaborado.Size = new System.Drawing.Size(184, 22);
            this.MskTxtBxElaborado.TabIndex = 7;
            this.MskTxtBxElaborado.ValidatingType = typeof(System.DateTime);
            this.MskTxtBxElaborado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MskTxtBxElaborado_KeyPress);
            this.MskTxtBxElaborado.Validated += new System.EventHandler(this.MskTxtBxElaborado_Validated);
            // 
            // MskTxtBxVence
            // 
            this.MskTxtBxVence.Location = new System.Drawing.Point(479, 298);
            this.MskTxtBxVence.Mask = "00/00/0000";
            this.MskTxtBxVence.Name = "MskTxtBxVence";
            this.MskTxtBxVence.Size = new System.Drawing.Size(184, 22);
            this.MskTxtBxVence.TabIndex = 8;
            this.MskTxtBxVence.ValidatingType = typeof(System.DateTime);
            this.MskTxtBxVence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MskTxtBxVence_KeyPress);
            this.MskTxtBxVence.Validated += new System.EventHandler(this.MskTxtBxVence_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // errorProvider8
            // 
            this.errorProvider8.ContainerControl = this;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lbs",
            "Kg",
            "Ltr",
            "Ud"});
            this.comboBox1.Location = new System.Drawing.Point(603, 220);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(60, 24);
            this.comboBox1.TabIndex = 52;
            // 
            // dataSetRestaurante1
            // 
            this.dataSetRestaurante1.DataSetName = "DataSetRestaurante";
            this.dataSetRestaurante1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(720, 420);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.MskTxtBxVence);
            this.Controls.Add(this.MskTxtBxElaborado);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnCancelarProd);
            this.Controls.Add(this.BtnGuadarProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_PrecioProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_CategoProd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Txt_NombreProd);
            this.Controls.Add(this.Txt_CodigoProd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Txt_CantidadPod);
            this.Controls.Add(this.Txt_MarcaProd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarProducto";
            this.Load += new System.EventHandler(this.RegistrarProducto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRestaurante1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Txt_CategoProd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Txt_NombreProd;
        private System.Windows.Forms.TextBox Txt_CodigoProd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_CantidadPod;
        private System.Windows.Forms.TextBox Txt_MarcaProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_PrecioProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCancelarProd;
        private System.Windows.Forms.Button BtnGuadarProd;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MaskedTextBox MskTxtBxElaborado;
        private System.Windows.Forms.MaskedTextBox MskTxtBxVence;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
        private DataSetRestaurante dataSetRestaurante1;
        private System.Windows.Forms.ErrorProvider errorProvider8;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}