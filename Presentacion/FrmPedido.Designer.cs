namespace Presentacion
{
    partial class FrmPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedido));
            this.PnlFormulario = new System.Windows.Forms.Panel();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.TblListaProducto = new System.Windows.Forms.DataGridView();
            this.PnlBuscarUnPedido = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnVerDetalle = new System.Windows.Forms.Button();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.PbxCerrarFormulario = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblListaProducto)).BeginInit();
            this.PnlBuscarUnPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarFormulario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlFormulario
            // 
            this.PnlFormulario.BackColor = System.Drawing.Color.Silver;
            this.PnlFormulario.Controls.Add(this.PnlBuscarUnPedido);
            this.PnlFormulario.Controls.Add(this.BtnRegistrar);
            this.PnlFormulario.Controls.Add(this.BtnEditar);
            this.PnlFormulario.Controls.Add(this.BtnEliminar);
            this.PnlFormulario.Controls.Add(this.TblListaProducto);
            this.PnlFormulario.Controls.Add(this.BtnBuscar);
            this.PnlFormulario.Controls.Add(this.pictureBox2);
            this.PnlFormulario.Controls.Add(this.BtnVerDetalle);
            this.PnlFormulario.Controls.Add(this.pictureBox15);
            this.PnlFormulario.Controls.Add(this.PbxCerrarFormulario);
            this.PnlFormulario.Controls.Add(this.pictureBox4);
            this.PnlFormulario.Controls.Add(this.pictureBox5);
            this.PnlFormulario.Controls.Add(this.pictureBox3);
            this.PnlFormulario.Controls.Add(this.label1);
            this.PnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFormulario.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlFormulario.Location = new System.Drawing.Point(0, 0);
            this.PnlFormulario.Name = "PnlFormulario";
            this.PnlFormulario.Size = new System.Drawing.Size(925, 537);
            this.PnlFormulario.TabIndex = 2;
            this.PnlFormulario.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlFormulario_Paint);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnRegistrar.FlatAppearance.BorderSize = 0;
            this.BtnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnRegistrar.Location = new System.Drawing.Point(29, 132);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(96, 37);
            this.BtnRegistrar.TabIndex = 117;
            this.BtnRegistrar.TabStop = false;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click_1);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnEditar.Location = new System.Drawing.Point(29, 193);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(96, 36);
            this.BtnEditar.TabIndex = 118;
            this.BtnEditar.TabStop = false;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click_1);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnEliminar.Location = new System.Drawing.Point(29, 254);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(96, 38);
            this.BtnEliminar.TabIndex = 119;
            this.BtnEliminar.TabStop = false;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // TblListaProducto
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.TblListaProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.TblListaProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TblListaProducto.BackgroundColor = System.Drawing.Color.Snow;
            this.TblListaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblListaProducto.Location = new System.Drawing.Point(196, 132);
            this.TblListaProducto.Name = "TblListaProducto";
            this.TblListaProducto.Size = new System.Drawing.Size(619, 266);
            this.TblListaProducto.TabIndex = 16;
            // 
            // PnlBuscarUnPedido
            // 
            this.PnlBuscarUnPedido.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PnlBuscarUnPedido.Controls.Add(this.textBox1);
            this.PnlBuscarUnPedido.Controls.Add(this.label2);
            this.PnlBuscarUnPedido.Location = new System.Drawing.Point(408, 440);
            this.PnlBuscarUnPedido.Name = "PnlBuscarUnPedido";
            this.PnlBuscarUnPedido.Size = new System.Drawing.Size(208, 71);
            this.PnlBuscarUnPedido.TabIndex = 110;
            this.PnlBuscarUnPedido.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlBuscarUnPedido_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.Location = new System.Drawing.Point(14, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 26);
            this.textBox1.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 16);
            this.label2.TabIndex = 95;
            this.label2.Text = "Ingrese la ID del pedido";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnBuscar.BackColor = System.Drawing.Color.Silver;
            this.BtnBuscar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.Location = new System.Drawing.Point(267, 435);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(108, 42);
            this.BtnBuscar.TabIndex = 109;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox2.BackColor = System.Drawing.Color.Silver;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(381, 404);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(248, 133);
            this.pictureBox2.TabIndex = 107;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BtnVerDetalle
            // 
            this.BtnVerDetalle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnVerDetalle.BackColor = System.Drawing.Color.Silver;
            this.BtnVerDetalle.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerDetalle.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnVerDetalle.Image = ((System.Drawing.Image)(resources.GetObject("BtnVerDetalle.Image")));
            this.BtnVerDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVerDetalle.Location = new System.Drawing.Point(635, 435);
            this.BtnVerDetalle.Name = "BtnVerDetalle";
            this.BtnVerDetalle.Size = new System.Drawing.Size(128, 42);
            this.BtnVerDetalle.TabIndex = 108;
            this.BtnVerDetalle.Text = "Ver Detalle";
            this.BtnVerDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVerDetalle.UseVisualStyleBackColor = false;
            this.BtnVerDetalle.Click += new System.EventHandler(this.BtnVerDetalle_Click);
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(363, 28);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(34, 36);
            this.pictureBox15.TabIndex = 18;
            this.pictureBox15.TabStop = false;
            // 
            // PbxCerrarFormulario
            // 
            this.PbxCerrarFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PbxCerrarFormulario.Image = ((System.Drawing.Image)(resources.GetObject("PbxCerrarFormulario.Image")));
            this.PbxCerrarFormulario.Location = new System.Drawing.Point(12, 494);
            this.PbxCerrarFormulario.Name = "PbxCerrarFormulario";
            this.PbxCerrarFormulario.Size = new System.Drawing.Size(33, 31);
            this.PbxCerrarFormulario.TabIndex = 106;
            this.PbxCerrarFormulario.TabStop = false;
            this.PbxCerrarFormulario.Click += new System.EventHandler(this.PbxCerrarFormulario_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox4.BackColor = System.Drawing.Color.Silver;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(231, 101);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 39);
            this.pictureBox4.TabIndex = 96;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox5.BackColor = System.Drawing.Color.Silver;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(265, 101);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(34, 39);
            this.pictureBox5.TabIndex = 97;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.BackColor = System.Drawing.Color.Silver;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(197, 101);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 39);
            this.pictureBox3.TabIndex = 95;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(403, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "LISTA DE PEDIDOS";
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 537);
            this.Controls.Add(this.PnlFormulario);
            this.Name = "FrmPedido";
            this.Text = "FrmPedido";
            this.Load += new System.EventHandler(this.FrmPedido_Load);
            this.PnlFormulario.ResumeLayout(false);
            this.PnlFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblListaProducto)).EndInit();
            this.PnlBuscarUnPedido.ResumeLayout(false);
            this.PnlBuscarUnPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarFormulario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlFormulario;
        private System.Windows.Forms.DataGridView TblListaProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox PbxCerrarFormulario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PnlBuscarUnPedido;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnVerDetalle;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
    }
}