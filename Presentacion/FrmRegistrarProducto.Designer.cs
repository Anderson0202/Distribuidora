namespace Presentacion
{
    partial class FrmRegistrarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarProducto));
            this.label1 = new System.Windows.Forms.Label();
            this.txReferencia = new System.Windows.Forms.TextBox();
            this.txPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txPeso = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.PbxCerrarRegistro = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txPesoMinimo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(280, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "INGRESE LOS DATOS DEL PRODUCTO";
            // 
            // txReferencia
            // 
            this.txReferencia.Location = new System.Drawing.Point(376, 97);
            this.txReferencia.Name = "txReferencia";
            this.txReferencia.Size = new System.Drawing.Size(142, 20);
            this.txReferencia.TabIndex = 5;
            // 
            // txPrecio
            // 
            this.txPrecio.Location = new System.Drawing.Point(376, 167);
            this.txPrecio.Name = "txPrecio";
            this.txPrecio.Size = new System.Drawing.Size(142, 20);
            this.txPrecio.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(280, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Referencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(310, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(286, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Categoria";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Carne de res",
            "Pollo",
            "Cerdo"});
            this.cmbCategoria.Location = new System.Drawing.Point(376, 202);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(142, 21);
            this.cmbCategoria.TabIndex = 21;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(235, 157);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(322, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Peso";
            // 
            // txPeso
            // 
            this.txPeso.Location = new System.Drawing.Point(376, 132);
            this.txPeso.Name = "txPeso";
            this.txPeso.Size = new System.Drawing.Size(142, 20);
            this.txPeso.TabIndex = 25;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnGuardar.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(388, 343);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 62);
            this.btnGuardar.TabIndex = 91;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // PbxCerrarRegistro
            // 
            this.PbxCerrarRegistro.Image = ((System.Drawing.Image)(resources.GetObject("PbxCerrarRegistro.Image")));
            this.PbxCerrarRegistro.Location = new System.Drawing.Point(161, 12);
            this.PbxCerrarRegistro.Name = "PbxCerrarRegistro";
            this.PbxCerrarRegistro.Size = new System.Drawing.Size(46, 42);
            this.PbxCerrarRegistro.TabIndex = 110;
            this.PbxCerrarRegistro.TabStop = false;
            this.PbxCerrarRegistro.Click += new System.EventHandler(this.PbxCerrarRegistro_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(296, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 112;
            this.label7.Text = "Nombre";
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(376, 239);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(142, 20);
            this.txNombre.TabIndex = 111;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(255, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 114;
            this.label8.Text = "Peso Minimo";
            // 
            // txPesoMinimo
            // 
            this.txPesoMinimo.Location = new System.Drawing.Point(376, 281);
            this.txPesoMinimo.Name = "txPesoMinimo";
            this.txPesoMinimo.Size = new System.Drawing.Size(142, 20);
            this.txPesoMinimo.TabIndex = 113;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(515, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 115;
            this.label5.Text = "Kg";
            // 
            // FrmRegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txPesoMinimo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.PbxCerrarRegistro);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txPeso);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txPrecio);
            this.Controls.Add(this.txReferencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FrmRegistrarProducto";
            this.Text = "FrmRegistraProducto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txReferencia;
        private System.Windows.Forms.TextBox txPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txPeso;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox PbxCerrarRegistro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txPesoMinimo;
        private System.Windows.Forms.Label label5;
    }
}