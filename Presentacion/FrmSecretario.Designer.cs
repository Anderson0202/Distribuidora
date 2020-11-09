namespace Presentacion
{
    partial class FrmSecretario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSecretario));
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PnlFormulario = new System.Windows.Forms.Panel();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnVerDetalle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PnlBuscarUnCliente = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TblListaProducto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.PbxCerrarFormulario = new System.Windows.Forms.PictureBox();
            this.PnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PnlFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlBuscarUnCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblListaProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarFormulario)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMenu
            // 
            this.PnlMenu.BackColor = System.Drawing.Color.Silver;
            this.PnlMenu.Controls.Add(this.PbxCerrarFormulario);
            this.PnlMenu.Controls.Add(this.pictureBox18);
            this.PnlMenu.Controls.Add(this.BtnEliminar);
            this.PnlMenu.Controls.Add(this.BtnEditar);
            this.PnlMenu.Controls.Add(this.BtnRegistrar);
            this.PnlMenu.Controls.Add(this.pictureBox17);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(154, 450);
            this.PnlMenu.TabIndex = 10;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
            this.pictureBox18.Location = new System.Drawing.Point(59, 129);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(34, 37);
            this.pictureBox18.TabIndex = 20;
            this.pictureBox18.TabStop = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnEliminar.Location = new System.Drawing.Point(3, 291);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(146, 38);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.TabStop = false;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnEditar.Location = new System.Drawing.Point(3, 235);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(146, 38);
            this.BtnEditar.TabIndex = 2;
            this.BtnEditar.TabStop = false;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnPedido_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.FlatAppearance.BorderSize = 0;
            this.BtnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnRegistrar.Location = new System.Drawing.Point(3, 179);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(146, 38);
            this.BtnRegistrar.TabIndex = 1;
            this.BtnRegistrar.TabStop = false;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
            this.pictureBox17.Location = new System.Drawing.Point(-50, -12);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(202, 135);
            this.pictureBox17.TabIndex = 17;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(211, 317);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 133);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // PnlFormulario
            // 
            this.PnlFormulario.Controls.Add(this.BtnBuscar);
            this.PnlFormulario.Controls.Add(this.BtnVerDetalle);
            this.PnlFormulario.Controls.Add(this.PnlBuscarUnCliente);
            this.PnlFormulario.Controls.Add(this.TblListaProducto);
            this.PnlFormulario.Controls.Add(this.label1);
            this.PnlFormulario.Controls.Add(this.pictureBox2);
            this.PnlFormulario.Controls.Add(this.pictureBox1);
            this.PnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFormulario.Location = new System.Drawing.Point(154, 0);
            this.PnlFormulario.Name = "PnlFormulario";
            this.PnlFormulario.Size = new System.Drawing.Size(646, 450);
            this.PnlFormulario.TabIndex = 106;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.Location = new System.Drawing.Point(95, 348);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(108, 42);
            this.BtnBuscar.TabIndex = 110;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // BtnVerDetalle
            // 
            this.BtnVerDetalle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnVerDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerDetalle.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnVerDetalle.Image = ((System.Drawing.Image)(resources.GetObject("BtnVerDetalle.Image")));
            this.BtnVerDetalle.Location = new System.Drawing.Point(457, 348);
            this.BtnVerDetalle.Name = "BtnVerDetalle";
            this.BtnVerDetalle.Size = new System.Drawing.Size(108, 42);
            this.BtnVerDetalle.TabIndex = 109;
            this.BtnVerDetalle.Text = "Ver Detalle";
            this.BtnVerDetalle.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(646, 450);
            this.pictureBox1.TabIndex = 106;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 96;
            // 
            // PnlBuscarUnCliente
            // 
            this.PnlBuscarUnCliente.Controls.Add(this.textBox1);
            this.PnlBuscarUnCliente.Controls.Add(this.label2);
            this.PnlBuscarUnCliente.Location = new System.Drawing.Point(233, 348);
            this.PnlBuscarUnCliente.Name = "PnlBuscarUnCliente";
            this.PnlBuscarUnCliente.Size = new System.Drawing.Size(208, 74);
            this.PnlBuscarUnCliente.TabIndex = 111;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 95;
            this.label2.Text = "Ingrese la ID del Secretario";
            // 
            // TblListaProducto
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.TblListaProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TblListaProducto.BackgroundColor = System.Drawing.Color.Snow;
            this.TblListaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblListaProducto.Location = new System.Drawing.Point(43, 76);
            this.TblListaProducto.Name = "TblListaProducto";
            this.TblListaProducto.Size = new System.Drawing.Size(571, 266);
            this.TblListaProducto.TabIndex = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(217, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 25);
            this.label1.TabIndex = 107;
            this.label1.Text = "LISTA DE SECRETARIOS";
            // 
            // PbxCerrarFormulario
            // 
            this.PbxCerrarFormulario.Image = ((System.Drawing.Image)(resources.GetObject("PbxCerrarFormulario.Image")));
            this.PbxCerrarFormulario.Location = new System.Drawing.Point(59, 358);
            this.PbxCerrarFormulario.Name = "PbxCerrarFormulario";
            this.PbxCerrarFormulario.Size = new System.Drawing.Size(33, 31);
            this.PbxCerrarFormulario.TabIndex = 106;
            this.PbxCerrarFormulario.TabStop = false;
            this.PbxCerrarFormulario.Click += new System.EventHandler(this.PbxCerrarFormulario_Click);
            // 
            // FrmSecretario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlFormulario);
            this.Controls.Add(this.PnlMenu);
            this.Name = "FrmSecretario";
            this.Text = "FrmSecretario";
            this.PnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PnlFormulario.ResumeLayout(false);
            this.PnlFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlBuscarUnCliente.ResumeLayout(false);
            this.PnlBuscarUnCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblListaProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarFormulario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel PnlFormulario;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnVerDetalle;
        private System.Windows.Forms.Panel PnlBuscarUnCliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView TblListaProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PbxCerrarFormulario;
    }
}