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
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
            PnlBuscarUnPedido.Visible = false;
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

        private void FrmPedido_Load(object sender, EventArgs e)
        {

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {

            if (Application.OpenForms["FrmRegistrarPedido"] == null)
                BtnRegistrar.BackColor = Color.FromArgb(224, 224, 224);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRegistrarPedido>();
            BtnRegistrar.BackColor = Color.FromArgb(139, 0, 0);
            BtnRegistrar.ForeColor = Color.FromArgb(244, 244, 244);
        }

        private void BtnBuscarPedido_Click(object sender, EventArgs e)
        {
            PnlBuscarUnPedido.Visible = true;
        }

        private void BtnVerDetallePedido_Click(object sender, EventArgs e)
        {
            PnlBuscarUnPedido.Visible = true;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRegistrarPedido>();
            BtnRegistrar.BackColor = Color.FromArgb(139, 0, 0);
            BtnRegistrar.ForeColor = Color.FromArgb(244, 244, 244);
        }

        private void PbxCerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PnlFormulario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void PnlBuscarUnPedido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BtnVerDetalle_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
