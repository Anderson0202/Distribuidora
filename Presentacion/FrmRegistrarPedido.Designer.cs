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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PnlFormularioRegistrarPedido = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PbxCerrarRegistro = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.PnlFormularioRegistrarPedido.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarRegistro)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(23, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Identificacion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 26);
            this.textBox1.TabIndex = 46;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(149, 90);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(142, 26);
            this.textBox7.TabIndex = 73;
            this.textBox7.Text = "Kg";
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Carne de res",
            "Pollo",
            "Cerdo"});
            this.comboBox2.Location = new System.Drawing.Point(149, 156);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(142, 24);
            this.comboBox2.TabIndex = 71;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(149, 192);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 24);
            this.comboBox1.TabIndex = 70;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Silver;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(107, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 16);
            this.label11.TabIndex = 68;
            this.label11.Text = "Tipo";
            this.label11.Click += new System.EventHandler(this.label11_Click);
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
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(149, 121);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(142, 26);
            this.textBox8.TabIndex = 65;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(149, 49);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(142, 26);
            this.textBox9.TabIndex = 64;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Silver;
            this.label14.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkRed;
            this.label14.Location = new System.Drawing.Point(45, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(291, 25);
            this.label14.TabIndex = 63;
            this.label14.Text = "DATOS DEL PRODUCTOS";
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
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Silver;
            this.label18.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DarkRed;
            this.label18.Location = new System.Drawing.Point(229, 5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(131, 16);
            this.label18.TabIndex = 80;
            this.label18.Text = "Total del descuento";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(232, 26);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(142, 26);
            this.textBox11.TabIndex = 79;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Silver;
            this.label19.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkRed;
            this.label19.Location = new System.Drawing.Point(414, 5);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(135, 16);
            this.label19.TabIndex = 82;
            this.label19.Text = "Total con descuento";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(417, 26);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(142, 26);
            this.textBox12.TabIndex = 81;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Silver;
            this.label20.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DarkRed;
            this.label20.Location = new System.Drawing.Point(8, 5);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(154, 16);
            this.label20.TabIndex = 84;
            this.label20.Text = "Valor neto de producto";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(11, 27);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(142, 24);
            this.comboBox4.TabIndex = 85;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(292, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 26);
            this.pictureBox2.TabIndex = 86;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(267, 49);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 25);
            this.pictureBox3.TabIndex = 87;
            this.pictureBox3.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(217, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 39);
            this.button2.TabIndex = 88;
            this.button2.Text = "Añadir";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox13
            // 
            this.textBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox13.Location = new System.Drawing.Point(11, 59);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(142, 26);
            this.textBox13.TabIndex = 89;
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
            this.PnlFormularioRegistrarPedido.Controls.Add(this.dataGridView1);
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
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBox9);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(448, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 310);
            this.panel2.TabIndex = 112;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(56, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 185);
            this.panel1.TabIndex = 111;
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
            this.panel3.Controls.Add(this.comboBox4);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.textBox12);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.textBox13);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.textBox11);
            this.panel3.Location = new System.Drawing.Point(44, 545);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(741, 117);
            this.panel3.TabIndex = 113;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 350);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 189);
            this.dataGridView1.TabIndex = 114;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(39, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(282, 25);
            this.label7.TabIndex = 88;
            this.label7.Text = "PRODUCTOS AÑADIDOS";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 84);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(378, 97);
            this.dataGridView2.TabIndex = 87;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.PnlFormularioRegistrarPedido.ResumeLayout(false);
            this.PnlFormularioRegistrarPedido.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarRegistro)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PnlFormularioRegistrarPedido;
        private System.Windows.Forms.PictureBox PbxCerrarRegistro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}