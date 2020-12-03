namespace Presentacion
{
    partial class FrmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlFormulario = new System.Windows.Forms.Panel();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnVerDetalle = new System.Windows.Forms.Button();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.PbxCerrarFormulario = new System.Windows.Forms.PictureBox();
            this.PnlBuscarUnPedido = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TblListaProducto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PnlFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarFormulario)).BeginInit();
            this.PnlBuscarUnPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblListaProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlFormulario
            // 
            this.PnlFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlFormulario.BackColor = System.Drawing.Color.Silver;
            this.PnlFormulario.Controls.Add(this.BtnRegistrar);
            this.PnlFormulario.Controls.Add(this.label2);
            this.PnlFormulario.Controls.Add(this.BtnEditar);
            this.PnlFormulario.Controls.Add(this.BtnEliminar);
            this.PnlFormulario.Controls.Add(this.BtnBuscar);
            this.PnlFormulario.Controls.Add(this.BtnVerDetalle);
            this.PnlFormulario.Controls.Add(this.pictureBox13);
            this.PnlFormulario.Controls.Add(this.PbxCerrarFormulario);
            this.PnlFormulario.Controls.Add(this.PnlBuscarUnPedido);
            this.PnlFormulario.Controls.Add(this.TblListaProducto);
            this.PnlFormulario.Controls.Add(this.label1);
            this.PnlFormulario.Controls.Add(this.pictureBox2);
            this.PnlFormulario.Location = new System.Drawing.Point(0, 0);
            this.PnlFormulario.Name = "PnlFormulario";
            this.PnlFormulario.Size = new System.Drawing.Size(1159, 530);
            this.PnlFormulario.TabIndex = 3;
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
            this.BtnRegistrar.Location = new System.Drawing.Point(28, 148);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(96, 37);
            this.BtnRegistrar.TabIndex = 114;
            this.BtnRegistrar.TabStop = false;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(528, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 14);
            this.label2.TabIndex = 95;
            this.label2.Text = " Ingrese el codigo del Producto ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.BtnEditar.Location = new System.Drawing.Point(28, 209);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(96, 36);
            this.BtnEditar.TabIndex = 115;
            this.BtnEditar.TabStop = false;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
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
            this.BtnEliminar.Location = new System.Drawing.Point(28, 270);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(96, 38);
            this.BtnEliminar.TabIndex = 116;
            this.BtnEliminar.TabStop = false;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnBuscar.BackColor = System.Drawing.Color.Silver;
            this.BtnBuscar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.Location = new System.Drawing.Point(387, 417);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(108, 42);
            this.BtnBuscar.TabIndex = 113;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click_1);
            // 
            // BtnVerDetalle
            // 
            this.BtnVerDetalle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnVerDetalle.BackColor = System.Drawing.Color.Silver;
            this.BtnVerDetalle.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerDetalle.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnVerDetalle.Image = ((System.Drawing.Image)(resources.GetObject("BtnVerDetalle.Image")));
            this.BtnVerDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVerDetalle.Location = new System.Drawing.Point(767, 417);
            this.BtnVerDetalle.Name = "BtnVerDetalle";
            this.BtnVerDetalle.Size = new System.Drawing.Size(115, 42);
            this.BtnVerDetalle.TabIndex = 112;
            this.BtnVerDetalle.Text = "Ver Detalle";
            this.BtnVerDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVerDetalle.UseVisualStyleBackColor = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(469, 27);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(33, 41);
            this.pictureBox13.TabIndex = 13;
            this.pictureBox13.TabStop = false;
            // 
            // PbxCerrarFormulario
            // 
            this.PbxCerrarFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PbxCerrarFormulario.Image = ((System.Drawing.Image)(resources.GetObject("PbxCerrarFormulario.Image")));
            this.PbxCerrarFormulario.Location = new System.Drawing.Point(12, 487);
            this.PbxCerrarFormulario.Name = "PbxCerrarFormulario";
            this.PbxCerrarFormulario.Size = new System.Drawing.Size(33, 31);
            this.PbxCerrarFormulario.TabIndex = 105;
            this.PbxCerrarFormulario.TabStop = false;
            this.PbxCerrarFormulario.Click += new System.EventHandler(this.PbxCerrarFormulario_Click);
            // 
            // PnlBuscarUnPedido
            // 
            this.PnlBuscarUnPedido.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PnlBuscarUnPedido.BackColor = System.Drawing.Color.Silver;
            this.PnlBuscarUnPedido.Controls.Add(this.textBox1);
            this.PnlBuscarUnPedido.Location = new System.Drawing.Point(530, 417);
            this.PnlBuscarUnPedido.Name = "PnlBuscarUnPedido";
            this.PnlBuscarUnPedido.Size = new System.Drawing.Size(208, 71);
            this.PnlBuscarUnPedido.TabIndex = 104;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.Location = new System.Drawing.Point(17, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 96;
            // 
            // TblListaProducto
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.TblListaProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TblListaProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TblListaProducto.BackgroundColor = System.Drawing.Color.Snow;
            this.TblListaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblListaProducto.Location = new System.Drawing.Point(266, 74);
            this.TblListaProducto.Name = "TblListaProducto";
            this.TblListaProducto.Size = new System.Drawing.Size(738, 266);
            this.TblListaProducto.TabIndex = 101;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(508, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 29);
            this.label1.TabIndex = 100;
            this.label1.Text = "LISTA DE PRODUCTOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(513, 382);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(238, 148);
            this.pictureBox2.TabIndex = 99;
            this.pictureBox2.TabStop = false;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 530);
            this.Controls.Add(this.PnlFormulario);
            this.Name = "FrmProductos";
            this.Text = "FrmProductos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.PnlFormulario.ResumeLayout(false);
            this.PnlFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarFormulario)).EndInit();
            this.PnlBuscarUnPedido.ResumeLayout(false);
            this.PnlBuscarUnPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblListaProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlFormulario;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Panel PnlBuscarUnPedido;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView TblListaProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox PbxCerrarFormulario;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnVerDetalle;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
    }
}