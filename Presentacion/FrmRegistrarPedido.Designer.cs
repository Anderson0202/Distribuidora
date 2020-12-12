namespace Presentacion
{
    partial class FrmRegistrarPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarPedido));
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txPeso = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txPrecio = new System.Windows.Forms.TextBox();
            this.TxCodigoProducto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtSubTotal = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PnlFormularioRegistrarPedido = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.DtgDetalle = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PbxCerrarRegistro = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txIdentificacion = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.txTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txCategoria = new System.Windows.Forms.TextBox();
            this.txCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtTotalIva = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.PnlFormularioRegistrarPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetalle)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarRegistro)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(323, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "DATOS DEL PEDIDO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(99, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 74;
            this.label6.Text = "Peso";
            // 
            // txPeso
            // 
            this.txPeso.Enabled = false;
            this.txPeso.Location = new System.Drawing.Point(149, 90);
            this.txPeso.Name = "txPeso";
            this.txPeso.Size = new System.Drawing.Size(142, 26);
            this.txPeso.TabIndex = 73;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(72, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 69;
            this.label10.Text = "Categoria";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Silver;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(91, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 16);
            this.label12.TabIndex = 67;
            this.label12.Text = "Precio";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Silver;
            this.label13.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(86, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 16);
            this.label13.TabIndex = 66;
            this.label13.Text = "Codigo";
            // 
            // txPrecio
            // 
            this.txPrecio.Enabled = false;
            this.txPrecio.Location = new System.Drawing.Point(149, 122);
            this.txPrecio.Name = "txPrecio";
            this.txPrecio.Size = new System.Drawing.Size(142, 26);
            this.txPrecio.TabIndex = 65;
            // 
            // TxCodigoProducto
            // 
            this.TxCodigoProducto.Location = new System.Drawing.Point(149, 49);
            this.TxCodigoProducto.Name = "TxCodigoProducto";
            this.TxCodigoProducto.Size = new System.Drawing.Size(142, 26);
            this.TxCodigoProducto.TabIndex = 64;
            this.TxCodigoProducto.TextChanged += new System.EventHandler(this.TxCodigoProducto_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Silver;
            this.label14.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkRed;
            this.label14.Location = new System.Drawing.Point(45, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(278, 25);
            this.label14.TabIndex = 63;
            this.label14.Text = "DATOS DEL PRODUCTO";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Silver;
            this.label18.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DarkRed;
            this.label18.Location = new System.Drawing.Point(229, 5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 16);
            this.label18.TabIndex = 80;
            this.label18.Text = "Sub total";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // TxtSubTotal
            // 
            this.TxtSubTotal.Enabled = false;
            this.TxtSubTotal.Location = new System.Drawing.Point(232, 26);
            this.TxtSubTotal.Name = "TxtSubTotal";
            this.TxtSubTotal.Size = new System.Drawing.Size(142, 26);
            this.TxtSubTotal.TabIndex = 79;
            this.TxtSubTotal.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Silver;
            this.label19.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkRed;
            this.label19.Location = new System.Drawing.Point(414, 5);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 16);
            this.label19.TabIndex = 82;
            this.label19.Text = "Total ";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Location = new System.Drawing.Point(417, 26);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(142, 26);
            this.TxtTotal.TabIndex = 81;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(270, 49);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 25);
            this.pictureBox3.TabIndex = 87;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(21, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(299, 39);
            this.button2.TabIndex = 88;
            this.button2.Text = "Añadir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(565, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 62);
            this.button1.TabIndex = 90;
            this.button1.Text = "Agregar Pedido";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PnlFormularioRegistrarPedido
            // 
            this.PnlFormularioRegistrarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PnlFormularioRegistrarPedido.BackColor = System.Drawing.Color.Silver;
            this.PnlFormularioRegistrarPedido.Controls.Add(this.label7);
            this.PnlFormularioRegistrarPedido.Controls.Add(this.DtgDetalle);
            this.PnlFormularioRegistrarPedido.Controls.Add(this.panel2);
            this.PnlFormularioRegistrarPedido.Controls.Add(this.panel1);
            this.PnlFormularioRegistrarPedido.Controls.Add(this.PbxCerrarRegistro);
            this.PnlFormularioRegistrarPedido.Controls.Add(this.label1);
            this.PnlFormularioRegistrarPedido.Controls.Add(this.panel3);
            this.PnlFormularioRegistrarPedido.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlFormularioRegistrarPedido.ForeColor = System.Drawing.Color.DarkRed;
            this.PnlFormularioRegistrarPedido.Location = new System.Drawing.Point(0, 0);
            this.PnlFormularioRegistrarPedido.Name = "PnlFormularioRegistrarPedido";
            this.PnlFormularioRegistrarPedido.Size = new System.Drawing.Size(820, 678);
            this.PnlFormularioRegistrarPedido.TabIndex = 91;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(206, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(366, 20);
            this.label7.TabIndex = 88;
            this.label7.Text = "DETALLES DE PRODUCTOS AÑADIDOS";
            // 
            // DtgDetalle
            // 
            this.DtgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDetalle.Location = new System.Drawing.Point(44, 350);
            this.DtgDetalle.Name = "DtgDetalle";
            this.DtgDetalle.Size = new System.Drawing.Size(741, 189);
            this.DtgDetalle.TabIndex = 114;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txCantidad);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txCategoria);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.TxCodigoProducto);
            this.panel2.Controls.Add(this.txPeso);
            this.panel2.Controls.Add(this.txPrecio);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(448, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 271);
            this.panel2.TabIndex = 112;
            // 
            // PbxCerrarRegistro
            // 
            this.PbxCerrarRegistro.BackColor = System.Drawing.Color.Transparent;
            this.PbxCerrarRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PbxCerrarRegistro.Image = ((System.Drawing.Image)(resources.GetObject("PbxCerrarRegistro.Image")));
            this.PbxCerrarRegistro.Location = new System.Drawing.Point(3, 3);
            this.PbxCerrarRegistro.Name = "PbxCerrarRegistro";
            this.PbxCerrarRegistro.Size = new System.Drawing.Size(35, 31);
            this.PbxCerrarRegistro.TabIndex = 110;
            this.PbxCerrarRegistro.TabStop = false;
            this.PbxCerrarRegistro.Click += new System.EventHandler(this.PbxCerrarRegistro_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.TxtTotalIva);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.TxtTotal);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.TxtSubTotal);
            this.panel3.Location = new System.Drawing.Point(44, 545);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(741, 117);
            this.panel3.TabIndex = 113;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Silver;
            this.label15.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkRed;
            this.label15.Location = new System.Drawing.Point(83, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(251, 25);
            this.label15.TabIndex = 75;
            this.label15.Text = "DATOS DEL CLIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(27, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Identificacion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txIdentificacion
            // 
            this.txIdentificacion.Location = new System.Drawing.Point(124, 50);
            this.txIdentificacion.Name = "txIdentificacion";
            this.txIdentificacion.Size = new System.Drawing.Size(210, 26);
            this.txIdentificacion.TabIndex = 46;
            this.txIdentificacion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(313, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 24);
            this.pictureBox2.TabIndex = 86;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txNombre
            // 
            this.txNombre.Enabled = false;
            this.txNombre.Location = new System.Drawing.Point(124, 88);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(210, 26);
            this.txNombre.TabIndex = 108;
            // 
            // txTelefono
            // 
            this.txTelefono.Enabled = false;
            this.txTelefono.Location = new System.Drawing.Point(124, 125);
            this.txTelefono.Name = "txTelefono";
            this.txTelefono.Size = new System.Drawing.Size(210, 26);
            this.txTelefono.TabIndex = 109;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(36, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 110;
            this.label8.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(31, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 111;
            this.label4.Text = "Telefono";
            // 
            // txDireccion
            // 
            this.txDireccion.Enabled = false;
            this.txDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDireccion.Location = new System.Drawing.Point(124, 161);
            this.txDireccion.Name = "txDireccion";
            this.txDireccion.Size = new System.Drawing.Size(210, 26);
            this.txDireccion.TabIndex = 114;
            this.txDireccion.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(31, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 115;
            this.label5.Text = "Direccion";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txDireccion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txTelefono);
            this.panel1.Controls.Add(this.txNombre);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.txIdentificacion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(44, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 271);
            this.panel1.TabIndex = 111;
            // 
            // txCategoria
            // 
            this.txCategoria.Enabled = false;
            this.txCategoria.Location = new System.Drawing.Point(149, 158);
            this.txCategoria.Name = "txCategoria";
            this.txCategoria.Size = new System.Drawing.Size(142, 26);
            this.txCategoria.TabIndex = 90;
            // 
            // txCantidad
            // 
            this.txCantidad.Location = new System.Drawing.Point(149, 190);
            this.txCantidad.Name = "txCantidad";
            this.txCantidad.Size = new System.Drawing.Size(142, 26);
            this.txCantidad.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(72, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 91;
            this.label3.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(44, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 92;
            this.label9.Text = "Total Iva";
            // 
            // TxtTotalIva
            // 
            this.TxtTotalIva.Enabled = false;
            this.TxtTotalIva.Location = new System.Drawing.Point(47, 26);
            this.TxtTotalIva.Name = "TxtTotalIva";
            this.TxtTotalIva.Size = new System.Drawing.Size(142, 26);
            this.TxtTotalIva.TabIndex = 91;
            // 
            // FrmRegistrarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 676);
            this.Controls.Add(this.PnlFormularioRegistrarPedido);
            this.Name = "FrmRegistrarPedido";
            this.Text = "FrmRegistrarPedido";
            this.Load += new System.EventHandler(this.FrmRegistrarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.PnlFormularioRegistrarPedido.ResumeLayout(false);
            this.PnlFormularioRegistrarPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetalle)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarRegistro)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txPeso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txPrecio;
        private System.Windows.Forms.TextBox TxCodigoProducto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TxtSubTotal;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PnlFormularioRegistrarPedido;
        private System.Windows.Forms.PictureBox PbxCerrarRegistro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DtgDetalle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txTelefono;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txIdentificacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txCategoria;
        private System.Windows.Forms.TextBox txCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtTotalIva;
    }
}