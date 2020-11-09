namespace Presentacion
{
    partial class FrmCliente
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
            this.PnlMenuCliente = new System.Windows.Forms.Panel();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.PnlFormulario = new System.Windows.Forms.Panel();
            this.PnlMenuCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMenuCliente
            // 
            this.PnlMenuCliente.BackColor = System.Drawing.Color.LightGray;
            this.PnlMenuCliente.Controls.Add(this.BtnEliminar);
            this.PnlMenuCliente.Controls.Add(this.BtnEditar);
            this.PnlMenuCliente.Controls.Add(this.BtnRegistrar);
            this.PnlMenuCliente.Controls.Add(this.BtnConsultar);
            this.PnlMenuCliente.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenuCliente.Location = new System.Drawing.Point(0, 0);
            this.PnlMenuCliente.Name = "PnlMenuCliente";
            this.PnlMenuCliente.Size = new System.Drawing.Size(152, 450);
            this.PnlMenuCliente.TabIndex = 0;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(3, 290);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(146, 38);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.TabStop = false;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(3, 231);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(146, 38);
            this.BtnEditar.TabIndex = 6;
            this.BtnEditar.TabStop = false;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(3, 178);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(146, 38);
            this.BtnRegistrar.TabIndex = 5;
            this.BtnRegistrar.TabStop = false;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(3, 120);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(146, 38);
            this.BtnConsultar.TabIndex = 4;
            this.BtnConsultar.TabStop = false;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // PnlFormulario
            // 
            this.PnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFormulario.Location = new System.Drawing.Point(152, 0);
            this.PnlFormulario.Name = "PnlFormulario";
            this.PnlFormulario.Size = new System.Drawing.Size(648, 450);
            this.PnlFormulario.TabIndex = 1;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlFormulario);
            this.Controls.Add(this.PnlMenuCliente);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.PnlMenuCliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenuCliente;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Panel PnlFormulario;
    }
}