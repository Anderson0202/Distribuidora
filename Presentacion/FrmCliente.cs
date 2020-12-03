using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;

            formulario = PnlFormulario.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PnlFormulario.Controls.Add(formulario);
                PnlFormulario.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {

                formulario.BringToFront();
            }

        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {

           
                

        }



        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRegistrarCliente>();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegistrar_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRegistrarCliente>();
            
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRegistrarCliente>();
           
        }

        private void PbxCerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TblListaProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PnlFormulario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnVerDetalle_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegistrar_Click_2(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRegistrarCliente>();
        }
    }
}
