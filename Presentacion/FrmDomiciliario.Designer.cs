﻿namespace Presentacion
{
    partial class FrmDomiciliario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDomiciliario));
            this.PnlFormularios = new System.Windows.Forms.Panel();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.TblListaDomiciliarios = new System.Windows.Forms.DataGridView();
            this.PnlBuscarUnCliente = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnVerDetalle = new System.Windows.Forms.Button();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.PbxCerrarFormulario = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TblListaVehiculos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.PnlFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblListaDomiciliarios)).BeginInit();
            this.PnlBuscarUnCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarFormulario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblListaVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlFormularios
            // 
            this.PnlFormularios.BackColor = System.Drawing.Color.Silver;
            this.PnlFormularios.Controls.Add(this.label3);
            this.PnlFormularios.Controls.Add(this.TblListaVehiculos);
            this.PnlFormularios.Controls.Add(this.BtnRegistrar);
            this.PnlFormularios.Controls.Add(this.BtnEditar);
            this.PnlFormularios.Controls.Add(this.BtnEliminar);
            this.PnlFormularios.Controls.Add(this.TblListaDomiciliarios);
            this.PnlFormularios.Controls.Add(this.PnlBuscarUnCliente);
            this.PnlFormularios.Controls.Add(this.BtnBuscar);
            this.PnlFormularios.Controls.Add(this.pictureBox2);
            this.PnlFormularios.Controls.Add(this.BtnVerDetalle);
            this.PnlFormularios.Controls.Add(this.pictureBox16);
            this.PnlFormularios.Controls.Add(this.PbxCerrarFormulario);
            this.PnlFormularios.Controls.Add(this.label1);
            this.PnlFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFormularios.Location = new System.Drawing.Point(0, 0);
            this.PnlFormularios.Name = "PnlFormularios";
            this.PnlFormularios.Size = new System.Drawing.Size(1276, 503);
            this.PnlFormularios.TabIndex = 2;
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
            this.BtnRegistrar.Location = new System.Drawing.Point(25, 144);
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
            this.BtnEditar.Location = new System.Drawing.Point(25, 205);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(96, 36);
            this.BtnEditar.TabIndex = 118;
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
            this.BtnEliminar.Location = new System.Drawing.Point(25, 266);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(96, 38);
            this.BtnEliminar.TabIndex = 119;
            this.BtnEliminar.TabStop = false;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // TblListaDomiciliarios
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.TblListaDomiciliarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TblListaDomiciliarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TblListaDomiciliarios.BackgroundColor = System.Drawing.Color.Snow;
            this.TblListaDomiciliarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblListaDomiciliarios.Location = new System.Drawing.Point(183, 79);
            this.TblListaDomiciliarios.Name = "TblListaDomiciliarios";
            this.TblListaDomiciliarios.Size = new System.Drawing.Size(638, 266);
            this.TblListaDomiciliarios.TabIndex = 20;
            this.TblListaDomiciliarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TblListaProducto_CellContentClick);
            // 
            // PnlBuscarUnCliente
            // 
            this.PnlBuscarUnCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PnlBuscarUnCliente.BackColor = System.Drawing.Color.Silver;
            this.PnlBuscarUnCliente.Controls.Add(this.textBox1);
            this.PnlBuscarUnCliente.Controls.Add(this.label2);
            this.PnlBuscarUnCliente.Location = new System.Drawing.Point(613, 406);
            this.PnlBuscarUnCliente.Name = "PnlBuscarUnCliente";
            this.PnlBuscarUnCliente.Size = new System.Drawing.Size(208, 71);
            this.PnlBuscarUnCliente.TabIndex = 110;
            this.PnlBuscarUnCliente.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlBuscarUnCliente_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.Location = new System.Drawing.Point(25, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 14);
            this.label2.TabIndex = 95;
            this.label2.Text = "Ingrese la ID del domiciliario";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnBuscar.BackColor = System.Drawing.Color.Silver;
            this.BtnBuscar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.Location = new System.Drawing.Point(483, 400);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(103, 42);
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
            this.pictureBox2.Location = new System.Drawing.Point(592, 370);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(248, 133);
            this.pictureBox2.TabIndex = 107;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // BtnVerDetalle
            // 
            this.BtnVerDetalle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnVerDetalle.BackColor = System.Drawing.Color.Silver;
            this.BtnVerDetalle.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerDetalle.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnVerDetalle.Image = ((System.Drawing.Image)(resources.GetObject("BtnVerDetalle.Image")));
            this.BtnVerDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVerDetalle.Location = new System.Drawing.Point(846, 400);
            this.BtnVerDetalle.Name = "BtnVerDetalle";
            this.BtnVerDetalle.Size = new System.Drawing.Size(125, 42);
            this.BtnVerDetalle.TabIndex = 108;
            this.BtnVerDetalle.Text = "Ver Detalle";
            this.BtnVerDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVerDetalle.UseVisualStyleBackColor = false;
            this.BtnVerDetalle.Click += new System.EventHandler(this.BtnVerDetalle_Click);
            // 
            // pictureBox16
            // 
            this.pictureBox16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
            this.pictureBox16.Location = new System.Drawing.Point(325, 33);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(33, 38);
            this.pictureBox16.TabIndex = 16;
            this.pictureBox16.TabStop = false;
            // 
            // PbxCerrarFormulario
            // 
            this.PbxCerrarFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PbxCerrarFormulario.Image = ((System.Drawing.Image)(resources.GetObject("PbxCerrarFormulario.Image")));
            this.PbxCerrarFormulario.Location = new System.Drawing.Point(25, 446);
            this.PbxCerrarFormulario.Name = "PbxCerrarFormulario";
            this.PbxCerrarFormulario.Size = new System.Drawing.Size(33, 31);
            this.PbxCerrarFormulario.TabIndex = 106;
            this.PbxCerrarFormulario.TabStop = false;
            this.PbxCerrarFormulario.Click += new System.EventHandler(this.PbxCerrarFormulario_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(364, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "LISTA DE DOMICILIARIOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TblListaVehiculos
            // 
            this.TblListaVehiculos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TblListaVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblListaVehiculos.Location = new System.Drawing.Point(827, 79);
            this.TblListaVehiculos.Name = "TblListaVehiculos";
            this.TblListaVehiculos.Size = new System.Drawing.Size(364, 265);
            this.TblListaVehiculos.TabIndex = 120;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(841, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 29);
            this.label3.TabIndex = 121;
            this.label3.Text = "LISTA DE VEHICULOS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FrmDomiciliario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 503);
            this.Controls.Add(this.PnlFormularios);
            this.Name = "FrmDomiciliario";
            this.Text = "FrmDomiciliario";
            this.Load += new System.EventHandler(this.FrmDomiciliario_Load);
            this.PnlFormularios.ResumeLayout(false);
            this.PnlFormularios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblListaDomiciliarios)).EndInit();
            this.PnlBuscarUnCliente.ResumeLayout(false);
            this.PnlBuscarUnCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarFormulario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblListaVehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlFormularios;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.DataGridView TblListaDomiciliarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PbxCerrarFormulario;
        private System.Windows.Forms.Panel PnlBuscarUnCliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnVerDetalle;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView TblListaVehiculos;
    }
}